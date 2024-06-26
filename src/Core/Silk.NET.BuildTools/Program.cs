// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Silk.NET Build Tools");
            Console.WriteLine("Copyright (C) .NET Foundation and Contributors");
            Console.WriteLine();
            if (args.Length == 1 && args[0] == "jsonex")
            {
                // get a template json file
                Console.WriteLine
                (
                    JsonConvert.SerializeObject
                    (
                        ExampleJsonFile, Formatting.Indented
                    )
                );

                return 0;
            }

            if (args.Length == 0)
            {
                Console.WriteLine
                (
                    "This is an internal tool not meant for general consumption. If you are working on " +
                    "Silk.NET (or a Silk-based project), please let us know in our Discord server and we'll do our " +
                    "best to help you navigate BuildTools."
                );
                return 1;
            }

            //If this is set it will scope the generation to only a single profile, eg only OpenGL or only WebGPU, or multiple comma-separated profiles
            string[] profiles = null;

            var sw = Stopwatch.StartNew();
            var extraCtrls = new List<string>();
            var failedJobs = 0;
            Console.SetOut(ConsoleWriter.GetOrCreate(Console.Out));

            //do one pass over the arguments, picking out the things that start with `--` (eg. control descriptors)
            foreach (var arg in args)
            {
                if (!arg.StartsWith("--"))
                {
                    continue;
                }

                if (arg.StartsWith("--profile="))
                {
                    profiles = arg.Substring("--profile=".Length).Split(',');
                    continue;
                }

                if (string.Equals(arg, "--no-parallel", StringComparison.OrdinalIgnoreCase))
                {
                    // picked up in Generator.cs
                    continue;
                }

                Console.WriteLine($"Control descriptor \"{arg}\" will be applied to every job herein.");
                extraCtrls.Add(arg[2..]);
            }

            //do a second pass over the arguments, picking out the things that dont start with `--` (eg. files)
            foreach (var arg in args)
            {
                if (arg.StartsWith("--"))
                {
                    continue;
                }

                var jobSw = Stopwatch.StartNew();
                var abs = Path.GetFullPath(arg);
                Environment.CurrentDirectory = Path.GetDirectoryName
                    (abs) ?? throw new NullReferenceException("Dir path null.");

                var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(abs));

                //if the profile scope is set, set the tasks to generate to *only* the task that matches the name
                if(profiles != null)
                {
                    config.Tasks = config.Tasks.Where(x => profiles.Any(profile => x.Name.Equals(profile, StringComparison.InvariantCultureIgnoreCase))).ToArray();
                }

                Generator.Run(AddDescriptors(config, extraCtrls));
            
                jobSw.Stop();
                Thread.Sleep(3000); // cooldown to ensure all the threads have reported their results.
                ConsoleWriter.Instance.BeginPlainRegion();
                Console.WriteLine();
                Console.WriteLine("Job Summary");
                Console.WriteLine("===========");
                Console.WriteLine();
                foreach (var kvp in ConsoleWriter.Instance.Timings.Values)
                {
                    if (kvp.Value.Success)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine
                            ($"Task \"{kvp.Key}\" took {kvp.Value.Time.TotalSeconds} second(s) to complete.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine
                            ($"Task \"{kvp.Key}\" failed after {kvp.Value.Time.TotalSeconds} second(s).");
                        failedJobs++;
                    }
                }
                //reset the colour
                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine($"In total, this particular job took {jobSw.Elapsed.TotalSeconds} second(s) to complete.");
                Console.WriteLine();
                ConsoleWriter.Instance.EndPlainRegion();
                ConsoleWriter.Instance.Reset();
            }

            sw.Stop();
            ConsoleWriter.Instance.Wait();
            Console.SetOut(ConsoleWriter.Instance.Base);
            Console.WriteLine($"Complete bind took {sw.Elapsed.TotalSeconds} second(s).");

            static Config AddDescriptors(Config config, IReadOnlyList<string> descriptors)
            {
                for (var i = 0; i < config.Tasks.Length; i++)
                {
                    var task = config.Tasks[i];
                    config.Tasks[i].Controls = task.Controls.Concat(descriptors).ToArray();
                }

                return config;
            }

            if (failedJobs > 0)
            {
                return -2000000000 - failedJobs;
            }

            return 0;
        }

        public class ConsoleWriter : TextWriter
        {
            internal static ConsoleWriter Instance { get; private set; }
            public ThreadLocal<string> CurrentName { get; private set; } = new ThreadLocal<string>();
            public ThreadLocal<KeyValuePair<string, (TimeSpan Time, bool Success)>> Timings { get; private set; } =
                new ThreadLocal<KeyValuePair<string, (TimeSpan Time, bool Success)>>(true);

            private readonly ConcurrentQueue<string> _logs = new();
            private int _exitOnEmpty = 0; // int32 writes are atomic
            private int _plain = 0;
            private Task _logLoop;

            public readonly TextWriter Base;

            private ConsoleWriter(TextWriter @base)
            {
                Base = @base;
                Encoding = Base.Encoding;
                Instance = this;
                _logLoop = Task.Run(LogLoop);
            }
            
            public override Encoding Encoding { get; }
            public static ConsoleWriter GetOrCreate(TextWriter @base) => Instance ??= new ConsoleWriter(@base);

            public void Reset()
            {
                CurrentName = new ThreadLocal<string>();
                Timings = new ThreadLocal<KeyValuePair<string, (TimeSpan Time, bool Success)>>(true);
            }
            public override void WriteLine(string? value)
            {
                _logs.Enqueue(_plain switch
                {
                    1 => value,
                    _ => $"[{DateTime.Now:T}] [{CurrentName.Value}] {Task.CurrentId}> " + value
                });
            }
            
            public override void WriteLine() => _logs.Enqueue("");

            public void BeginPlainRegion() => _plain = 1;
            public void EndPlainRegion() => _plain = 0;

            public void Wait()
            {
                _exitOnEmpty = 1;
                SpinWait.SpinUntil(() => _exitOnEmpty == 0);
            }

            private void LogLoop()
            {
                while (true)
                {
                    if (_logs.IsEmpty && _exitOnEmpty == 1)
                    {
                        _exitOnEmpty = 0;
                        break;
                    }

                    if (_logs.TryDequeue(out var line))
                    {
                        Base.WriteLine(line);
                    }
                }
            }
        }
        
        ///////////////////////////////////////////////////////////////////////////////////////
        // The meaningful part of the file ends here, from here it's just an example structure.
        ///////////////////////////////////////////////////////////////////////////////////////

        private static Config ExampleJsonFile = new Config
        {
            Tasks = new[]
            {
                new BindTask
                {
                    BakeryOpts = new BakeryOptions
                    {
                        Include = new[] {"glcore"}
                    },
                    CacheFolder = "/path/to/cacheFolder",
                    CacheKey = "glcoreCacheKey",
                    ClangOpts = new ClangTaskOptions
                    {
                        ClangArgs = new[] {"--clang-arguments"},
                        ClassMappings = new Dictionary<string, string>
                        {
                            {"sourceHeader.h", "DestinationClass"}
                        }
                    },
                    Controls = new[]
                    {
                        "control-variables-to-define-how-gernation-runs",
                        "convert-windows-only",
                        "convert-macos-only",
                        "convert-linux-only"
                    },
                    ConverterOpts = new ConverterOptions
                    {
                        Reader = "gl",
                        Constructor = "gl"
                    },
                    FunctionPrefix = "gl",
                    ExtensionsNamespace = "MyNamespace.ForExtensions",
                    Namespace = "MyNamespace",
                    Mode = ConverterMode.ConvertConstruct,
                    Name = "Profile Name",
                    Sources = new[] {"/path/to/sourceFile.xml", "/path/to/header.h"},
                    NameContainer = new NameContainer
                    {
                        ClassName = "MyNameContainer",
                        Android = "libapi.so",
                        IOS = "libapi.dylib",
                        Linux = "libapi.so",
                        MacOS = "libapi.dylib",
                        Windows64 = "api.dll",
                        Windows86 = "api.dll"
                    },
                    OutputOpts = new OutputOptions
                    {
                        Folder = "/path/to/outputFolder", License = "/path/to/licenseFile",
                        Props = "/path/to/customMSBuild.props"
                    },
                    TypeMaps = new List<Dictionary<string, string>>
                        {new Dictionary<string, string> {{"HWND", "nint"}}}
                }
            }
        };
    }
}

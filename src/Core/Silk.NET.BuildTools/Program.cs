// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
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
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Silk.NET Build Tools");
            Console.WriteLine("Copyright (C) Ultz Limited");
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

                return;
            }

            var sw = Stopwatch.StartNew();
            var extraCtrls = new List<string>();
            foreach (var arg in args)
            {
                if (arg.StartsWith("--"))
                {
                    Console.WriteLine($"Control descriptor \"{arg}\" will be applied to every job herein.");
                    extraCtrls.Add(arg[2..]);
                    continue;
                }
                
                Console.SetOut(ConsoleWriter.GetOrCreate(Console.Out));
                var jobSw = Stopwatch.StartNew();
                var abs = Path.GetFullPath(arg);
                Environment.CurrentDirectory = Path.GetDirectoryName
                    (abs) ?? throw new NullReferenceException("Dir path null.");
                Generator.Run(AddDescriptors(JsonConvert.DeserializeObject<Config>(File.ReadAllText(abs)), extraCtrls));
            
                jobSw.Stop();
                Console.SetOut(ConsoleWriter.Instance.Base);
                Console.WriteLine();
                Console.WriteLine("Job Summary");
                Console.WriteLine("===========");
                Console.WriteLine();
                foreach (var kvp in ConsoleWriter.Instance.Timings.Values)
                {
                    if (kvp.Value.Success)
                    {
                        Console.WriteLine
                            ($"Task \"{kvp.Key}\" took {kvp.Value.Time.TotalSeconds} second(s) to complete.");
                    }
                    else
                    {
                        Console.WriteLine
                            ($"Task \"{kvp.Key}\" failed after {kvp.Value.Time.TotalSeconds} second(s).");
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"In total, this particular job took {jobSw.Elapsed.TotalSeconds} second(s) to complete.");
                Console.WriteLine();
                ConsoleWriter.Instance.Reset();
            }

            sw.Stop();
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
        }

        internal class ConsoleWriter : TextWriter
        {
            internal static ConsoleWriter Instance { get; private set; }
            public ThreadLocal<string> CurrentName { get; private set; } = new ThreadLocal<string>();
            public ThreadLocal<KeyValuePair<string, (TimeSpan Time, bool Success)>> Timings { get; private set; } =
                new ThreadLocal<KeyValuePair<string, (TimeSpan Time, bool Success)>>(true);

            public readonly TextWriter Base;

            public ConsoleWriter(TextWriter @base)
            {
                Base = @base;
                Encoding = Base.Encoding;
                Instance = this;
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
                Base.WriteLine($"[{DateTime.Now:T}] [{CurrentName.Value}] {Task.CurrentId}> " + value);
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

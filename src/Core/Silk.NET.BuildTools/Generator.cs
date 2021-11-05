// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Humanizer;

using Newtonsoft.Json;
using Silk.NET.BuildTools.Baking;
using Silk.NET.BuildTools.Bind;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Converters;
using Silk.NET.BuildTools.Converters.Constructors;
using Silk.NET.BuildTools.Converters.Readers;
using Silk.NET.BuildTools.Cpp;

namespace Silk.NET.BuildTools
{
    public static class Generator
    {
        public const bool TestMode = false;
        public static void Run(Config config)
        {
            var tasks = new Task[config.Tasks.Length];

            for (var i = 0; i < 10; i++)
            {
                try
                {
                    var dirsToCheckThrough = config.Tasks
                        .Where(x => ShouldBind(x.Controls))
                        .Select(x => x.OutputOpts.Folder)
                        .Distinct();
                    foreach (var s in dirsToCheckThrough)
                    {
                        foreach (var file in Directory.GetFiles(s, "*.gen.cs", SearchOption.AllDirectories))
                        {
                            File.Delete(file);
                        }
                    }

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine
                    (
                        (i + 1).Ordinalize() +
                        $" attempt to remove generated files failed with " +
                        $"{ex.GetType().Name}: {ex.Message}"
                    );

                    Thread.Sleep(1000);
                }
            }

            for (var i = 0; i < config.Tasks.Length; i++)
            {
                var i1 = i;
                if (TestMode)
                {
                    RunTaskUnguarded(config.Tasks[i1]);
                }
                else
                {
                    tasks[i] = Task.Run(() => RunTaskGuarded(config.Tasks[i1]));
                }
            }

            if (!TestMode)
            {
                Task.WaitAll(tasks);
            }
        }

        public static void RunTaskGuarded(BindTask task)
        {
            Stopwatch sw = null;
            if (!(Program.ConsoleWriter.Instance is null))
            {
                Program.ConsoleWriter.Instance.CurrentName.Value = task.Name;
                sw = Stopwatch.StartNew();
            }
            
            try
            {
                RunTask(task, sw);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unhandled exception: {ex}");
                if (sw is not null)
                {
                    Program.ConsoleWriter.Instance.Timings.Value =
                        new KeyValuePair<string, (TimeSpan, bool)>(task.Name, (sw.Elapsed, false));
                    return;
                }
            }
            
            if (sw is not null)
            {
                Program.ConsoleWriter.Instance.Timings.Value =
                    new KeyValuePair<string, (TimeSpan, bool)>(task.Name, (sw.Elapsed, true));
            }
        }

        public static void RunTaskUnguarded(BindTask task)
        {
            Stopwatch sw = null;
            if (!(Program.ConsoleWriter.Instance is null))
            {
                Program.ConsoleWriter.Instance.CurrentName.Value = task.Name;
                sw = Stopwatch.StartNew();
            }
            
            RunTask(task, sw);
            
            if (sw is not null)
            {
                Program.ConsoleWriter.Instance.Timings.Value =
                    new KeyValuePair<string, (TimeSpan, bool)>(task.Name, (sw.Elapsed, true));
            }
        }
        
        public static void RunTask(BindTask task) => RunTask(task, null);
        private static void RunTask(BindTask task, Stopwatch? sw)
        {
            foreach (var typeMap in task.TypeMaps)
            {
                var toAdd = new List<KeyValuePair<string, string>>();
                foreach (var kvp in typeMap)
                {
                    if (kvp.Key.StartsWith("$include"))
                    {
                        toAdd.Add(kvp);
                    }
                }
                
                foreach (var kvp in toAdd)
                {
                    var includedMap = JsonConvert.DeserializeObject<Dictionary<string, string>>
                        (File.ReadAllText(kvp.Value));
                    typeMap.Remove(kvp.Key);
                    foreach (var includedKvp in includedMap)
                    {
                        typeMap.Add(includedKvp.Key, includedKvp.Value);
                    }
                }
            }

            Profile profile;
            if (ShouldConvert(task.Controls))
            {
                Console.WriteLine("Profile conversion started!");
                var tsb4 = sw?.Elapsed.TotalSeconds;
                var profiles = new List<Profile>();
                if (task.Mode == ConverterMode.ConvertConstruct)
                {
                    foreach (var src in task.Sources)
                    {
                        var rawProfiles = ProfileConverter.ReadProfiles
                        (
                            task.ConverterOpts.Reader.ToLower() switch
                            {
                                "gl" => new OpenGLReader(),
                                "cl" => new OpenCLReader(),
                                "vk" => new VulkanReader(),
                                _ => throw new ArgumentException("Couldn't find a reader with that name")
                            }, task.ConverterOpts.Constructor.ToLower() switch
                            {
                                "gl" => new OpenGLConstructor(),
                                "cl" => new OpenCLConstructor(),
                                "vk" => new VulkanConstructor(),
                                _ => throw new ArgumentException("Couldn't find a reader with that name")
                            },
                            OpenPath(src),
                            task
                        ).ToList();

                        Console.WriteLine("Raw profile parsing complete, cloning in memory prior to baking...");
                        profiles.AddRange
                        (
                            // BUG this is an awful fix for a weird bug, but if we don't do this everything falls apart.
                            // feel free to remove the serialize-deserialize and try for yourself would welcome a fix ;)
                            JsonConvert.DeserializeObject<Profile[]>
                            (
                                JsonConvert.SerializeObject
                                (
                                    rawProfiles
                                )
                            )
                        );
                        
                        Console.WriteLine("Profiles are ready.");
                    }
                }
                else if (task.Mode == ConverterMode.Clang)
                {
                    ClangConfig.SubstituteWindowsSdkPath(ref task);
                    foreach (var src in task.Sources)
                    {
                        profiles.Add(Clang.GenerateProfile(Path.GetFileName(src), OpenPath(src), task));
                    }
                }

                profile = ProfileBakery.Bake
                    (task.Name, profiles.Where(x => task.BakeryOpts.Include.Contains(x.Name)).ToList(), in task);
                
                PreprocessorMixin.AddDirectives(profile, task.OutputOpts.ConditionalFunctions);

                var tsaf = sw?.Elapsed.TotalSeconds - tsb4;
                var tsafTxt = sw is null ? null : $", took {tsaf} second(s)";
                Console.WriteLine($"Conversion complete{tsafTxt}.");

                if (!string.IsNullOrWhiteSpace(task.CacheKey) && !string.IsNullOrWhiteSpace(task.CacheFolder))
                {
                    if (!Directory.Exists(task.CacheFolder))
                    {
                        Directory.CreateDirectory(task.CacheFolder);
                    }
                
                    using var fileStream = File.OpenWrite(Path.Combine(task.CacheFolder, task.CacheKey + ".json.gz"));
                    using var gzStream = new GZipStream(fileStream, CompressionLevel.Optimal);
                    gzStream.Write(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(profile)));
                    gzStream.Flush();
                    fileStream.Flush();
                    Console.WriteLine("Written to cache for future use.");
                }
            }
            else if (!ShouldBind(task.Controls))
            {
                // skip
                profile = null;
            }
            else if (!string.IsNullOrWhiteSpace(task.CacheKey) && !string.IsNullOrWhiteSpace(task.CacheFolder))
            {
                Console.WriteLine("Cache hit!");
                var tsb4 = sw?.Elapsed.TotalSeconds;
                var file = Path.Combine(task.CacheFolder, task.CacheKey + ".json.gz");
                if (!File.Exists(file))
                {
                    throw new InvalidOperationException
                    (
                        "Couldn't find a cached profile to fallback on" +
                        "(conversion was skipped as per the control variables)"
                    );
                }
                using var memoryStream = new MemoryStream();
                using var fileStream = File.OpenRead(file);
                using var gzStream = new GZipStream(fileStream, CompressionMode.Decompress);
                gzStream.CopyTo(memoryStream);
                profile = JsonConvert.DeserializeObject<Profile>(Encoding.UTF8.GetString(memoryStream.ToArray()));
                var tsaf = tsb4 - sw?.Elapsed.TotalSeconds;
                var tsafTxt = sw is null ? null : $", took {tsaf} second(s)";
                Console.WriteLine($"Cached profile loaded{tsafTxt}.");
            }
            else
            {
                throw new InvalidOperationException
                (
                    "Couldn't find a cached profile to fallback on" +
                    "(conversion was skipped as per the control variables)"
                );
            }

            if (ShouldBind(task.Controls))
            {
                profile.Flush(task);
            }

            sw?.Stop();
            var af = sw is null ? null : $" after {sw.Elapsed.TotalSeconds} second(s)";
            Console.WriteLine($"Task complete{af}.");
        }

        private static bool ShouldConvert(string[] controls)
        {
            if (controls.Any
                (y => y.ToLower() == "convert-windows-only") && !RuntimeInformation.IsOSPlatform
                (OSPlatform.Windows))
            {
                return false;
            }
                
            if (controls.Any
                (y => y.ToLower() == "convert-macos-only") && !RuntimeInformation.IsOSPlatform
                (OSPlatform.OSX))
            {
                return false;
            }
                
            if (controls.Any
                (y => y.ToLower() == "convert-linux-only") && !RuntimeInformation.IsOSPlatform
                (OSPlatform.Linux))
            {
                return false;
            }

            return controls.All(y => y.ToLower() != "no-convert");
        }

        private static bool ShouldBind(IEnumerable<string> controls) => controls.All
            (x => !string.Equals(x.ToLower(), "no-bind", StringComparison.InvariantCultureIgnoreCase));

        private static Stream OpenPath(string path)
        {
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                // Download from the specified url into a temporary file
                using var wb = new HttpClient();
                return wb.GetStreamAsync(path).GetAwaiter().GetResult();
            }

            return File.OpenRead(path);
        }
    }
}

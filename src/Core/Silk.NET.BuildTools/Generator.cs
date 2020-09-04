// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
        public static void Run(Config config, IReadOnlyList<string> args)
        {
            var tasks = new Task[config.Tasks.Length];
            var dirsToCheckThrough = config.Tasks.Select(x => x.OutputOpts.Folder).Distinct();
            if (!args.Contains("no-clear"))
            {
                foreach (var s in dirsToCheckThrough)
                {
                    foreach (var file in Directory.GetFiles(s, "*.gen.cs", SearchOption.AllDirectories))
                    {
                        File.Delete(file);
                    }
                }
            }

            for (var i = 0; i < config.Tasks.Length; i++)
            {
                var i1 = i;
                if (args.Contains("no-parallel"))
                {
                    RunTask(config.Tasks[i1], args);
                }
                else
                {
                    tasks[i] = Task.Run(() => RunTaskGuarded(config.Tasks[i1], args));
                }
            }

            if (!args.Contains("no-parallel"))
            {
                Task.WaitAll(tasks);
            }
        }

        public static void RunTaskGuarded(BindTask task, IReadOnlyCollection<string> args)
        {
            try
            {
                RunTask(task, args);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled exception: {ex}");
            }
        }

        public static void RunTask(BindTask task, IReadOnlyCollection<string> args)
        {
            Stopwatch sw = null;
            if (!(Program.ConsoleWriter.Instance is null))
            {
                Program.ConsoleWriter.Instance.CurrentName.Value = task.Name;
                sw = Stopwatch.StartNew();
            }

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
            
            Profile profile = null;
            var cacheHit = !ShouldConvert(task.Controls, args);
            if (!cacheHit)
            {
                try
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
                                )
                                .ToList();

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
                        foreach (var src in task.Sources)
                        {
                            profiles.Add(Clang.GenerateProfile(Path.GetFileName(src), OpenPath(src), task));
                        }
                    }

                    profile = ProfileBakery.Bake
                        (task.Name, profiles.Where(x => task.BakeryOpts.Include.Contains(x.Name)).ToList());

                    var tsaf = sw?.Elapsed.TotalSeconds - tsb4;
                    var tsafTxt = sw is null ? null : $", took {tsaf} second(s)";
                    Console.WriteLine($"Conversion complete{tsafTxt}.");

                    try
                    {
                        if (!string.IsNullOrWhiteSpace(task.CacheKey) && !string.IsNullOrWhiteSpace(task.CacheFolder))
                        {
                            if (!Directory.Exists(task.CacheFolder))
                            {
                                Directory.CreateDirectory(task.CacheFolder);
                            }

                            using var fileStream = File.OpenWrite
                                (Path.Combine(task.CacheFolder, task.CacheKey + ".json.gz"));
                            using var gzStream = new GZipStream(fileStream, CompressionLevel.Optimal);
                            gzStream.Write(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(profile)));
                            gzStream.Flush();
                            fileStream.Flush();
                            Console.WriteLine("Written to cache for future use.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Couldn't write to cache, next cache hit may be outdated.");
                        Console.WriteLine(ex);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Profile conversion failed.");
                    Console.WriteLine(ex);
                    Console.WriteLine("Attempting to continue with a cache hit...");
                    cacheHit = true;
                }
            }

            if (cacheHit)
            {
                if (!string.IsNullOrWhiteSpace(task.CacheKey) && !string.IsNullOrWhiteSpace(task.CacheFolder))
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
                        "(conversion was skipped per the control variables)"
                    );
                }
            }

            if (profile is null)
            {
                throw new NullReferenceException
                (
                    "Profile is null. This shouldn't be possible, and indicates a fatal error in both converting " +
                    "and cache hitting."
                );
            }

            profile.Flush(task);
            sw?.Stop();
            var af = sw is null ? null : $" after {sw.Elapsed.TotalSeconds} second(s)";
            Console.WriteLine($"Task complete{af}.");
            if (!(sw is null))
            {
                Program.ConsoleWriter.Instance.Timings.Value =
                    new KeyValuePair<string, TimeSpan>(task.Name, sw.Elapsed);
            }
            
            static bool ShouldConvert(string[] controls, IReadOnlyCollection<string> args)
            {
                if (args.Contains("no-cache-hit"))
                {
                    return true;
                }

                if (args.Contains("always-cache-hit"))
                {
                    return false;
                }
                
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

                return true;
            }
        }

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

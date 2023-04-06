// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.Extensions.FileSystemGlobbing;
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
        public const string VersionsUrl = "https://api.nuget.org/v3-flatcontainer/{0}/index.json";
        public const string DownloadUrl = "https://www.nuget.org/api/v2/package/{0}/{1}";

        private static readonly ConcurrentDictionary<string, string> _downloaded = new();
        public const bool TestMode = false;

        internal static readonly ConcurrentBag<string> TempFolders = new();

        public static void Run(Config config)
        {
            var tasks = new Task[config.Tasks.Length];

            var parallel = !Environment.GetCommandLineArgs().Contains("--no-parallel", StringComparer.OrdinalIgnoreCase);
            for (var i = 0; i < config.Tasks.Length; i++)
            {
                var i1 = i;
                if (TestMode)
                {
                    RunTaskUnguarded(config.Tasks[i1], config);
                }
                else if (!parallel)
                {
                    RunTaskGuarded(config.Tasks[i1], config);
                }
                else
                {
                    tasks[i] = Task.Run(() => RunTaskGuarded(config.Tasks[i1], config));
                }
            }

            if (!TestMode && parallel)
            {
                Task.WaitAll(tasks);
            }
        }

        public static void RunTaskGuarded(BindTask task, Config config)
        {
            Stopwatch sw = null;
            if (!(Program.ConsoleWriter.Instance is null))
            {
                Program.ConsoleWriter.Instance.CurrentName.Value = task.Name;
                sw = Stopwatch.StartNew();
            }

            try
            {
                RunTask(task, config, sw);
            }
            catch (Exception ex)
            {
                if(Debugger.IsAttached)
                    throw;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine($"Unhandled exception when running BuildTools for {task.Name}: {ex}");
                Console.ResetColor();
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

        public static void RunTaskUnguarded(BindTask task, Config config)
        {
            Stopwatch sw = null;
            if (!(Program.ConsoleWriter.Instance is null))
            {
                Program.ConsoleWriter.Instance.CurrentName.Value = task.Name;
                sw = Stopwatch.StartNew();
            }

            RunTask(task, config, sw);

            if (sw is not null)
            {
                Program.ConsoleWriter.Instance.Timings.Value =
                    new KeyValuePair<string, (TimeSpan, bool)>(task.Name, (sw.Elapsed, true));
            }
        }

        public static void RunTask(BindTask task, Config config) => RunTask(task, config, null);

        private static void RunTask(BindTask task, Config config, Stopwatch? sw)
        { 
            foreach (var (glob, dest) in task.CopyFiles ?? Enumerable.Empty<KeyValuePair<string, string>>())
            {
                var sources = Glob(new[]{GetPath(glob)});
                foreach (var source in sources)
                {
                    var destination = Path.Combine(dest, Path.GetFileName(source));
                    if (File.Exists(dest) || Directory.Exists(Path.GetDirectoryName(dest)) && !Directory.Exists(dest))
                    {
                        destination = dest;
                    }

                    Console.WriteLine($"{source} -> {destination}");
                    File.Copy(source, destination, true);
                }
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
                        (File.ReadAllText(GetPath(kvp.Value)));
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
                                File.OpenRead(GetPath(src)),
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
                    for (var i = 0; i < task.Sources.Length; i++)
                    {
                        task.Sources[i] = GetPath(task.Sources[i]);
                    }
                    for (var i = 0; i < task.ClangOpts.Traverse.Length; i++)
                    {
                        task.ClangOpts.Traverse[i] = GetPath(task.ClangOpts.Traverse[i]);
                    }
                    for (var i = 0; i < task.ClangOpts.ClangArgs.Length; i++)
                    {
                        if (task.ClangOpts.ClangArgs[i].StartsWith("-I"))
                        {
                            task.ClangOpts.ClangArgs[i] = $"-I{GetPath(task.ClangOpts.ClangArgs[i][2..])}";
                        }
                    }
                    ClangConfig.SubstituteWindowsSdkPath(ref task);
                    foreach (var src in task.Sources)
                    {
                        profiles.Add(Clang.GenerateProfile(Path.GetFileName(src), File.OpenRead(GetPath(src)), task));
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
                profile.Flush(task, config);
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

        private readonly record struct VersionsPayload([property: JsonPropertyName("versions")] string[] Versions);

        internal static string GetPath(string path)
        {
            // ReSharper disable AccessToDisposedClosure
            using var wb = new HttpClient();
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                // Download from the specified url into a temporary file
                return _downloaded.GetOrAdd
                (
                    path, _ =>
                    {
                        using var file = File.OpenWrite(Path.GetTempFileName());
                        Console.WriteLine($"Downloading {path} into {file.Name}");
                        wb.GetStreamAsync(path).GetAwaiter().GetResult().CopyTo(file);
                        file.Flush();
                        return file.Name;
                    }
                );
            }

            var split = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            // format:
            // $nuget/<name>/<version or *>/<path in package>
            if (split[0].ToLower() == "$nuget" && split.Length >= 3)
            {
                var ogVer = split[2];
                var downloaded = _downloaded.GetOrAdd
                (
                    $"$nuget/{split[1]}/{split[2]}", _ =>
                    {
                        if (split[2].Trim() == "*")
                        {
                            Console.WriteLine($"Getting {split[1]} versions from {VersionsUrl}", split[1].ToLower());
                            split[2] = JsonConvert.DeserializeObject<VersionsPayload>
                                (
                                    wb.GetStringAsync(string.Format(VersionsUrl, split[1].ToLower()))
                                        .GetAwaiter()
                                        .GetResult()
                                )
                                .Versions.Last();
                        }

                        var url = string.Format(DownloadUrl, split[1], split[2].Trim());
                        var tmp = Path.GetRandomFileName();
                        TempFolders.Add(tmp);
                        var dir = Path.Combine(Path.GetTempPath(), tmp);
                        Console.WriteLine($"Downloading & extracting {url} into {dir}");
                        new ZipArchive
                        (
                            wb.GetStreamAsync(url)
                                .GetAwaiter()
                                .GetResult()
                        ).ExtractToDirectory(dir);
                        return dir;
                    }
                );

                var verKey = $"$nuget/{split[1]}/{ogVer}/$version";
                _downloaded.TryAdd(verKey, split[2]);

                if (split.Last().Trim().ToLower() == "$version")
                {
                    var verPath = Path.GetTempFileName();
                    File.WriteAllText(verPath, _downloaded[verKey]);
                    return verPath;
                }

                return Path.Combine(Enumerable.Repeat(downloaded, 1).Concat(split.Skip(3)).ToArray());
            }

            return path;
            // ReSharper restore AccessToDisposedClosure
        }
        
        internal static IEnumerable<string> Glob(IReadOnlyCollection<string> paths, string? cd = null)
        {
            cd ??= Environment.CurrentDirectory;
            var matcher = new Matcher();
            static string PathFixup(string path)
            {
                if (Path.IsPathFullyQualified(path))
                {
                    path = Path.GetRelativePath(Path.GetPathRoot(path)!, path);
                }

                return path.ToLower().Replace('\\', '/');
            }
            
            matcher.AddIncludePatterns
            (
                paths.Where(x => !x.StartsWith("!")).Select(PathFixup)
            );
            matcher.AddExcludePatterns
            (
                paths.Where(x => x.StartsWith("!")).Select(x => x[1..]).Select(PathFixup)
            );

            return matcher.GetResultsInFullPath(cd)
                .Concat
                (
                    paths.Select(x => x.StartsWith('!') ? x[1..] : x)
                        .Where(Path.IsPathFullyQualified)
                        .Select(Path.GetPathRoot)
                        .Distinct()
                        .SelectMany(x => matcher.GetResultsInFullPath(x))
                )
                .Concat(paths.Where(File.Exists))
                .Select(x => Path.GetFullPath(x).ToLower().Replace('\\', '/'))
                .Distinct()
                .ToArray();
        }
    }
}

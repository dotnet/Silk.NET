// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyModel;
using RuntimeEnvironment = Microsoft.DotNet.PlatformAbstractions.RuntimeEnvironment;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    ///     Enumerates possible library load targets. This default implementation returns the following load targets:
    ///     First: The library contained in the applications base folder.
    ///     Second: The simple name, unchanged.
    ///     Third: The library as resolved via the default DependencyContext, in the default nuget package cache folder.
    /// </summary>
    public class DefaultPathResolver : PathResolver
    {
        /// <summary>
        ///     Returns an enumerator which yields possible library load targets, in priority order.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        /// <returns>An enumerator yielding load targets.</returns>
        public override IEnumerable<string> EnumeratePossibleLibraryLoadTargets(string name)
            => CoreEnumeratePossibleLibraryLoadTargets(name);

        private IEnumerable<string> CoreEnumeratePossibleLibraryLoadTargets(string name, bool noLinuxTraverse = false)
        {
            yield return name;
            if (!string.IsNullOrEmpty(AppContext.BaseDirectory))
            {
                yield return Path.Combine(AppContext.BaseDirectory, name);
                if (TryLocateNativeAssetInRuntimesFolder(name, AppContext.BaseDirectory, out var result))
                {
                    yield return result;
                }
            }

            if (TryLocateNativeAssetFromDeps(name, out var appLocalNativePath, out var depsResolvedPath))
            {
                yield return appLocalNativePath;
                yield return depsResolvedPath;
            }
            
            var mainModFname = Process.GetCurrentProcess().MainModule?.FileName;
            if (AppContext.BaseDirectory != Process.GetCurrentProcess().MainModule?.FileName &&
                mainModFname is not null)
            {
                mainModFname = Path.GetDirectoryName(mainModFname);
                if (mainModFname is not null)
                {
                    yield return Path.Combine(mainModFname, name);
                }

                if (TryLocateNativeAssetInRuntimesFolder(name, mainModFname, out var result))
                {
                    yield return result;
                }
            }

            if (!noLinuxTraverse)
            {
                foreach (var linuxName in GetLinuxPossibilities(name))
                {
                    foreach (var possibleLoadTarget in CoreEnumeratePossibleLibraryLoadTargets(linuxName, true))
                    {
                        yield return possibleLoadTarget;
                    }
                }
            }
        }

        private static IEnumerable<string> GetLinuxPossibilities(string name)
        {
            var nameSplit = name.Split('.');
            var indexOfSo = Array.LastIndexOf(nameSplit, "so");
            if (indexOfSo != -1)
            {
                // for libglfw.so.3.3 this should return:
                // libglfw.so
                // libglfw.so.3
                // libglfw.so.3.3
                for (var i = indexOfSo; i < nameSplit.Length; i++)
                {
                    yield return string.Join(".", nameSplit, 0, i + 1);
                }
            }
        }

        private bool TryLocateNativeAssetFromDeps
        (
            string name,
            out string appLocalNativePath,
            out string depsResolvedPath
        )
        {
            try
            {
                var defaultContext = DependencyContext.Default;
                var entAsm = Assembly.GetEntryAssembly();
                if (defaultContext is null && !(entAsm is null))
                {
                    var json = new DependencyContextJsonReader();
                    defaultContext ??= json.Read
                    (
                        File.OpenRead
                        (
                            Path.Combine
                            (
                                Path.GetDirectoryName(entAsm.Location),
                                entAsm.GetName().Name + ".deps.json"
                            )
                        )
                    );
                    defaultContext ??=
                        json.Read
                        (
                            File.OpenRead
                            (
                                Path.Combine(AppContext.BaseDirectory, entAsm.GetName().Name + ".deps.json")
                            )
                        );
                }

                if (defaultContext == null)
                {
                    appLocalNativePath = null;
                    depsResolvedPath = null;
                    return false;
                }

                var currentRid = RuntimeEnvironment.GetRuntimeIdentifier();
                foreach (var rid in GetAllRuntimeIds(currentRid, defaultContext))
                    foreach (var runtimeLib in defaultContext.RuntimeLibraries)
                        foreach (var nativeAsset in runtimeLib.GetRuntimeNativeAssets(defaultContext, rid))
                        {
                            if (Path.GetFileName(nativeAsset) == name || Path.GetFileNameWithoutExtension(nativeAsset) == name)
                            {
                                appLocalNativePath = Path.Combine
                                (
                                    AppContext.BaseDirectory,
                                    nativeAsset
                                );
                                appLocalNativePath = Path.GetFullPath(appLocalNativePath);

                                depsResolvedPath = Path.Combine
                                (
                                    GetNugetPackagesRootDirectory(),
                                    runtimeLib.Name.ToLowerInvariant(),
                                    runtimeLib.Version,
                                    nativeAsset
                                );
                                depsResolvedPath = Path.GetFullPath(depsResolvedPath);

                                return true;
                            }
                        }

                appLocalNativePath = null;
                depsResolvedPath = null;
                return false;
            }
            catch (Exception ex)
            {
                appLocalNativePath = null;
                depsResolvedPath = null;
                return false;
            }
        }

        private bool TryLocateNativeAssetInRuntimesFolder(string name, string baseFolder, out string result)
        {
            static bool Check(string name, string ridFolder, out string result)
            {
                var theoreticalFName = Path.Combine(ridFolder, name);
                if (File.Exists(theoreticalFName))
                {
                    result = theoreticalFName;
                    return true;
                }

                result = null;
                return false;
            }

            foreach (var rid in GetAllRuntimeIds(RuntimeEnvironment.GetRuntimeIdentifier(), DependencyContext.Default))
            {
                if (Check(name, Path.Combine(baseFolder, "runtimes", rid, "native", name), out result))
                {
                    return true;
                }
            }

            result = null;
            return false;
        }

        // from: https://github.com/dotnet/runtime/blob/main/src/libraries/Microsoft.NETCore.Platforms/src/runtime.json
        private static readonly string[] _linuxRiDs =
        {
            "alpine", "android", "arch", "centos", "debian", "exherbo", "fedora", "freebsd", "gentoo", "linux",
            "opensuse", "rhel", "sles", "tizen"
        };

        private string GuessFallbackRid(string actualRuntimeIdentifier)
        {
            if (actualRuntimeIdentifier == "osx.10.13-x64")
            {
                return "osx.10.12-x64";
            }

            var split = actualRuntimeIdentifier.Split('-');
            if (split[0] != "osx" && split[0].StartsWith("osx"))
            {
                return $"osx-{string.Join("-", split.Skip(1))}".TrimEnd('-');
            }

            if (split[0] != "win" && split[0].StartsWith("win"))
            {
                return $"win-{string.Join("-", split.Skip(1))}".TrimEnd('-');
            }

            if (split[0] != "linux" && _linuxRiDs.Any(x => split[0].StartsWith(x)))
            {
                return $"linux-{string.Join("-", split.Skip(1))}".TrimEnd('-');
            }

            return null;
        }

        private bool AddFallbacks(List<string> fallbacks, string rid, IReadOnlyList<RuntimeFallbacks> allFallbacks)
        {
            foreach (var fb in allFallbacks)
            {
                if (fb.Runtime == rid)
                {
                    fallbacks.AddRange(fb.Fallbacks);
                    return true;
                }
            }

            while (rid is not null)
            {
                if (!fallbacks.Contains(rid))
                {
                    fallbacks.Add(rid);
                }

                rid = GuessFallbackRid(rid);
            }

            return false;
        }

        private string GetNugetPackagesRootDirectory()
        {
            // TODO: Handle alternative package directories, if they are configured.
            return Path.Combine(GetUserDirectory(), ".nuget", "packages");
        }

        private string GetUserDirectory()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Environment.GetEnvironmentVariable("USERPROFILE");
            }

            return Environment.GetEnvironmentVariable("HOME");
        }

        private List<string> GetAllRuntimeIds(string currentRid, DependencyContext ctx)
        {
            var allRiDs = new List<string>();

            // prevent null reference exception on net6.0-android where DependencyContext.Default is null
            if (ctx is not null)
            {
                allRiDs.Add(currentRid);
                if (!AddFallbacks(allRiDs, currentRid, ctx.RuntimeGraph))
                {
                    var guessedFallbackRid = GuessFallbackRid(currentRid);
                    if (guessedFallbackRid != null)
                    {
                        allRiDs.Add(guessedFallbackRid);
                        AddFallbacks(allRiDs, guessedFallbackRid, ctx.RuntimeGraph);
                    }
                }
            }

            return allRiDs;
        }
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
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
            }

            if (TryLocateNativeAssetFromDeps(name, out var appLocalNativePath, out var depsResolvedPath))
            {
                yield return appLocalNativePath;
                yield return depsResolvedPath;
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
                var allRiDs = new List<string>();
                allRiDs.Add(currentRid);
                if (!AddFallbacks(allRiDs, currentRid, defaultContext.RuntimeGraph))
                {
                    var guessedFallbackRid = GuessFallbackRid(currentRid);
                    if (guessedFallbackRid != null)
                    {
                        allRiDs.Add(guessedFallbackRid);
                        AddFallbacks(allRiDs, guessedFallbackRid, defaultContext.RuntimeGraph);
                    }
                }

                foreach (var rid in allRiDs)
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

        private string GuessFallbackRid(string actualRuntimeIdentifier)
        {
            if (actualRuntimeIdentifier == "osx.10.13-x64")
            {
                return "osx.10.12-x64";
            }

            if (actualRuntimeIdentifier.StartsWith("osx"))
            {
                return "osx-x64";
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
    }
}

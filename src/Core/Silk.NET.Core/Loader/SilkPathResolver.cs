// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyModel;
using RuntimeEnvironment = Microsoft.DotNet.PlatformAbstractions.RuntimeEnvironment;

namespace Silk.NET.Core.Loader
{
    public class SilkPathResolver
    {
        public static string Resolve(string library)
        {
            var all = EnumeratePossibleLibraryLoadTargets(library);
            var abs = all.FirstOrDefault(File.Exists);
            return abs ?? library;
        }
        
        /// <summary>
        ///     Returns an enumerator which yields possible library load targets, in priority order.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        /// <returns>An enumerator yielding load targets.</returns>
        public static IEnumerable<string> EnumeratePossibleLibraryLoadTargets(string name)
        {
            if (!string.IsNullOrEmpty(AppContext.BaseDirectory))
                yield return Path.Combine(AppContext.BaseDirectory, name);
            yield return name;
            if (TryLocateNativeAssetFromDeps(name, out var appLocalNativePath, out var depsResolvedPath))
            {
                yield return appLocalNativePath;
                yield return depsResolvedPath;
            }
        }

        private static bool TryLocateNativeAssetFromDeps(string name, out string appLocalNativePath,
            out string depsResolvedPath)
        {
            var defaultContext = DependencyContext.Default;
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
                if (Path.GetFileName(nativeAsset) == name || Path.GetFileNameWithoutExtension(nativeAsset) == name)
                {
                    appLocalNativePath = Path.Combine(
                        AppContext.BaseDirectory,
                        nativeAsset);
                    appLocalNativePath = Path.GetFullPath(appLocalNativePath);

                    depsResolvedPath = Path.Combine(
                        GetNugetPackagesRootDirectory(),
                        runtimeLib.Name.ToLowerInvariant(),
                        runtimeLib.Version,
                        nativeAsset);
                    depsResolvedPath = Path.GetFullPath(depsResolvedPath);

                    return true;
                }

            appLocalNativePath = null;
            depsResolvedPath = null;
            return false;
        }

        private static string GuessFallbackRid(string actualRuntimeIdentifier)
        {
            if (actualRuntimeIdentifier == "osx.10.13-x64")
                return "osx.10.12-x64";
            if (actualRuntimeIdentifier.StartsWith("osx")) return "osx-x64";

            return null;
        }

        private static bool AddFallbacks(List<string> fallbacks, string rid, IReadOnlyList<RuntimeFallbacks> allFallbacks)
        {
            foreach (var fb in allFallbacks)
                if (fb.Runtime == rid)
                {
                    fallbacks.AddRange(fb.Fallbacks);
                    return true;
                }

            return false;
        }

        private static string GetNugetPackagesRootDirectory()
        {
            // TODO: Handle alternative package directories, if they are configured.
            return Path.Combine(GetUserDirectory(), ".nuget", "packages");
        }

        private static string GetUserDirectory()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return Environment.GetEnvironmentVariable("USERPROFILE");
            return Environment.GetEnvironmentVariable("HOME");
        }
    }
}

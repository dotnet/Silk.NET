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

#nullable enable

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
        /// Creates a path resolver pre-loaded with the default <see cref="Resolvers"/>, which are the following in the
        /// given order:
        /// - <see cref="PassthroughResolver" />
        /// - <see cref="LinuxVersioningResolver" />
        /// - <see cref="MacVersioningResolver" />
        /// - <see cref="BaseDirectoryResolver" />
        /// - <see cref="MainModuleDirectoryResolver" />
        /// - <see cref="RuntimesFolderResolver" />
        /// - <see cref="NativePackageResolver" />
        /// - <see cref="SilkDirectoryResolver"/>
        /// </summary>
        public DefaultPathResolver() => Resolvers = new()
        {
            PassthroughResolver,
            LinuxVersioningResolver,
            MacVersioningResolver,
            BaseDirectoryResolver,
            MainModuleDirectoryResolver,
            RuntimesFolderResolver,
            NativePackageResolver,
            SilkDirectoryResolver
        };

        /// <summary>
        /// A list of resolvers to use to obtain paths. 
        /// </summary>
        public List<Func<string, IEnumerable<string>>> Resolvers { get; set; }

        /// <summary>
        /// A resolver that returns the given name with no modifications. Note that this resolver is intrinsically
        /// meaningful in that always operates on the originally passed name, rather than what's currently in the
        /// candidate list (as this would be pointless).
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> PassthroughResolver = name
            => Enumerable.Repeat(name, 1);

        /// <summary>
        /// A resolver that returns a path to a file in <see cref="AppContext.BaseDirectory"/> with the given name.
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> BaseDirectoryResolver = name
            // check that name doesn't have a directory name, we only want raw filenames so that the Path.Combine
            // doesn't blow up.
            => string.IsNullOrEmpty(AppContext.BaseDirectory) && string.IsNullOrWhiteSpace(Path.GetDirectoryName(name))
                ? Enumerable.Empty<string>()
                : Enumerable.Repeat(Path.Combine(AppContext.BaseDirectory, name), 1);

        /// <summary>
        /// A resolver that returns a path to a file in <see cref="Process.MainModule"/>'s
        /// <see cref="ProcessModule.FileName"/> directory with the given name.
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> MainModuleDirectoryResolver = name =>
        {
            try
            {
                var mainModFname = Process.GetCurrentProcess().MainModule?.FileName;
                // check that name doesn't have a directory name, we only want raw filenames so that the Path.Combine
                // doesn't blow up.
                if (!string.IsNullOrWhiteSpace(Path.GetDirectoryName(name)) && mainModFname is not null)
                {
                    mainModFname = Path.GetDirectoryName(mainModFname);
                    if (mainModFname is not null)
                    {
                        return Enumerable.Repeat(Path.Combine(mainModFname, name), 1);
                    }
                }
            }
            catch
            {
                // System.Diagnostics.Process is not supported on the WASI-SDK
            }

            return Enumerable.Empty<string>();
        };

        /// <summary>
        /// A resolver that returns a path to a file in Silk.NET's <see cref="Assembly.Location"/> and/or
        /// <see cref="Assembly.CodeBase"/> directory with the given name.
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> SilkDirectoryResolver = name =>
        {
            try
            {
                var asmLocation = typeof(DefaultPathResolver).Assembly.Location;
                // check that name doesn't have a directory name, we only want raw filenames so that the Path.Combine
                // doesn't blow up.
                if (!string.IsNullOrWhiteSpace(Path.GetDirectoryName(name)) && !string.IsNullOrWhiteSpace(asmLocation) && File.Exists(asmLocation))
                {
                    asmLocation = Path.GetDirectoryName(asmLocation);
                    if (asmLocation is not null)
                    {
                        return Enumerable.Repeat(Path.Combine(asmLocation, name), 1);
                    }
                }

                asmLocation = typeof(DefaultPathResolver).Assembly.CodeBase;
                if (!string.IsNullOrWhiteSpace(Path.GetDirectoryName(name)) && !string.IsNullOrWhiteSpace(asmLocation) && File.Exists(asmLocation))
                {
                    asmLocation = Path.GetDirectoryName(asmLocation);
                    if (asmLocation is not null)
                    {
                        return Enumerable.Repeat(Path.Combine(asmLocation, name), 1);
                    }
                }
            }
            catch
            {
                // not supported on the WASI-SDK
            }

            return Enumerable.Empty<string>();
        };

        /// <summary>
        /// A resolver that, given an absolute or relative path, searches for a "runtimes" folder in the directory
        /// represented by the given name for a file matching the given path's file name in one of the applicable
        /// RID-specific runtimes folders applicable to the current dependency context. 
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> RuntimesFolderResolver = name =>
        {
            var dirName = Path.GetDirectoryName(name);
            var fileName = Path.GetFileName(name);
            return string.IsNullOrWhiteSpace(dirName) ||
                   string.IsNullOrWhiteSpace(fileName) ||
                   !TryLocateNativeAssetInRuntimesFolder(fileName, dirName, out var result) ||
                   result is null 
                ? Enumerable.Empty<string>()
                : Enumerable.Repeat(result, 1);
        };

        /// <summary>
        /// A resolver that returns less version-specific Linux shared object names. That is, given a string of
        /// "libglfw.so.3.3.6", this resolver will return "libglfw.so.3.3", "libglfw.so.3", and "libglfw.so" (in that
        /// order).
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> LinuxVersioningResolver = GetLinuxPossibilities;
        
        /// <summary>
        /// A resolver that returns less version-specific macOS dynamic library names. That is, given a string of
        /// "libglfw.3.3.6.dylib", this resolver will return "libglfw.3.3.dylib", "libglfw.3.dylib", and "libglfw.dylib"
        /// (in that order).
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> MacVersioningResolver = GetMacPossibilities;

        /// <summary>
        /// A resolver that searches the restored NuGet packages for the current executable for a file matching the
        /// given file name in one of the applicable RID-specific runtimes folders applicable to the current dependency
        /// context. 
        /// </summary>
        public static readonly Func<string, IEnumerable<string>> NativePackageResolver = name =>
            string.IsNullOrWhiteSpace(Path.GetDirectoryName(name)) &&
            TryLocateNativeAssetFromDeps(name, out var appLocalNativePath, out var depsResolvedPath) &&
            appLocalNativePath is not null &&
            depsResolvedPath is not null
                ? new[] { appLocalNativePath, depsResolvedPath }
                : Enumerable.Empty<string>();

        /// <summary>
        ///     Returns an enumerator which yields possible library load targets, in priority order.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        /// <returns>An enumerator yielding load targets.</returns>
        public override IEnumerable<string> EnumeratePossibleLibraryLoadTargets(string name)
        {
            var candidates = new List<string>();
            foreach (var resolver in Resolvers)
            {
                try
                {
                    if (candidates.Count == 0 || resolver == PassthroughResolver)
                    {
                        candidates.AddRange(resolver.Invoke(name));
                    }
                    else
                    {
                        for (var i = 0; i < candidates.Count; i++)
                        {
                            var oldCnt = candidates.Count;
                            candidates.InsertRange(i + 1, resolver.Invoke(candidates[i]));
                            i += candidates.Count - oldCnt;
                        }
                    }
                }
                catch
                {
                    // Skip failed resolver, to account for unexpected environment. Like NativeAOT for example.
                }
            }

            return candidates.Distinct();
        }

        private static IEnumerable<string> GetLinuxPossibilities(string name)
        {
            var nameSplit = name.Split('.');
            var indexOfSo = Array.LastIndexOf(nameSplit, "so");
            if (indexOfSo != -1)
            {
                // for libglfw.so.3.3 this should return:
                // libglfw.so.3.3
                // libglfw.so.3
                // libglfw.so
                for (var i = nameSplit.Length - 1; i >= indexOfSo; i--)
                {
                    yield return string.Join(".", nameSplit, 0, i + 1);
                }
            }
        }
        
        private static IEnumerable<string> GetMacPossibilities(string name)
        {
            var nameSplit = name.Split('.');
            var indexOfDylib = Array.LastIndexOf(nameSplit, "dylib");
            if (indexOfDylib != -1)
            {
                // for libglfw.3.3.dylib this should return:
                // libglfw.3.3.dylib
                // libglfw.3.dylib
                // libglfw.dylib
                for (var i = indexOfDylib - 1; i >= 0; i--)
                {
                    yield return $"{string.Join(".", nameSplit, 0, i + 1)}.dylib";
                }
            }
        }

        private static bool TryLocateNativeAssetFromDeps
        (
            string name,
            out string? appLocalNativePath,
            out string? depsResolvedPath
        )
        {
            try
            {
                var defaultContext = DependencyContext.Default;
                var entAsm = Assembly.GetEntryAssembly();
                if (defaultContext is null && !(entAsm is null))
                {
                    var json = new DependencyContextJsonReader();
                    var dir = Path.GetDirectoryName(entAsm.Location);
                    if (dir is not null)
                    {
                        defaultContext ??= json.Read
                        (
                            File.OpenRead
                            (
                                Path.Combine
                                (
                                    dir,
                                    entAsm.GetName().Name + ".deps.json"
                                )
                            )
                        );
                    }
                    
                    defaultContext ??= json.Read
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
#if NETSTANDARD2_0
                            if (Path.GetFileName(nativeAsset) == name || Path.GetFileNameWithoutExtension(nativeAsset) == name)
#else
                            var nativeAssetSpan = nativeAsset.AsSpan();
                            if (Path.GetFileName(nativeAssetSpan) == name || Path.GetFileNameWithoutExtension(nativeAssetSpan) == name)
#endif
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
            catch (Exception)
            {
                appLocalNativePath = null;
                depsResolvedPath = null;
                return false;
            }
        }

        private static bool TryLocateNativeAssetInRuntimesFolder(string name, string baseFolder, out string? result)
        {
            static bool Check(string name, string ridFolder, out string? result)
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
                if (Check(name, Path.Combine(baseFolder, "runtimes", rid, "native"), out result))
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

        private static string? GuessFallbackRid(string actualRuntimeIdentifier)
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

            if (split[0] == "osx" && split.Length > 1)
            {
                return "osx"; // fat binaries are fairly commonplace
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

        private static bool AddFallbacks(List<string> fallbacks, string? rid, IReadOnlyList<RuntimeFallbacks> allFallbacks)
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

        private static string GetNugetPackagesRootDirectory()
        {
            // TODO: Handle alternative package directories, if they are configured.
            return Path.Combine(GetUserDirectory(), ".nuget", "packages");
        }

        private static string GetUserDirectory()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Environment.GetEnvironmentVariable("USERPROFILE")!;
            }

            return Environment.GetEnvironmentVariable("HOME")!;
        }

        private static List<string> GetAllRuntimeIds(string currentRid, DependencyContext? ctx)
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

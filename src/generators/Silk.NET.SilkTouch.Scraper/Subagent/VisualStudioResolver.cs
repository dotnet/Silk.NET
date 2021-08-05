// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Microsoft.Build.Locator;
using Ultz.Extensions.Logging;

namespace Silk.NET.SilkTouch.Scraper.Subagent
{
    public record VisualStudioInfo
    (
        string Name,
        string InstallationBaseFolder,
        string UcrtSdkDir,
        string[] UcrtIncludes,
        Version UcrtVersion,
        string MsvcToolsFolder,
        string[] MsvcToolsIncludes,
        Version Version,
        Dictionary<string, string> Variables,
        string MSBuildPath
    );

    public static class VisualStudioResolver
    {
        internal const string MsvcInstallDirVar = "VCToolsInstallDir";
        internal static readonly string[] MsvcIncludeSubDirs = { "include" };

        internal const string WinSdkUcrtSdkDirVar = "UniversalCRTSdkDir";
        internal const string WinSdkUcrtVersionVar = "UCRTVersion";
        internal static readonly string[] WinSdkUcrtIncludeSubDirs =
        {
            "Include/{0}/um",
            "Include/{0}/ucrt",
            "Include/{0}/shared"
        };

        private static VisualStudioInfo? _cachedInfo;
        private static VisualStudioInstance? _cachedInstance;

        public static bool TryGetMSBuildInfo
        (
            [NotNullWhen(true)] out VisualStudioInstance? instance
        )
        {
            if (TryGetVisualStudioInfo(out _))
            {
                instance = _cachedInstance;
                return instance is not null;
            }

            var use = MSBuildLocator.QueryVisualStudioInstances()
                .OrderBy(x => x.DiscoveryType)
                .ThenByDescending(x => x.Version)
                .FirstOrDefault();

            if (use is null)
            {
                instance = null;
                return false;
            }

            Log.Information($"Using MSBuild at \"{use.MSBuildPath}\" (from \"{use.Name}\" v{use.Version.ToString(3)})");
            instance = use;
            return true;
        }

        public static bool TryGetVisualStudioInfo([NotNullWhen(true)] out VisualStudioInfo? info)
        {
            // if we're not on windows, this is never gonna work
            if (!OperatingSystem.IsWindowsVersionAtLeast(10))
            {
                info = null;
                return false;
            }

            // if we've cached some info
            if (_cachedInfo is not null)
            {
                info = _cachedInfo;
                return true;
            }
            
            // use MSBuildLocator to find Visual Studio instances
            var visualStudios = MSBuildLocator
                .QueryVisualStudioInstances()
                .Where(x => (x.DiscoveryType & (DiscoveryType.DeveloperConsole | DiscoveryType.VisualStudioSetup)) != 0)
                .OrderBy(x => x.DiscoveryType)
                .ThenByDescending(x => x.Version);
            
            // cycle through candidate installations, try and find everything we're looking for.
            var hasVs = false;
            foreach (var visualStudio in visualStudios)
            {
                hasVs = true;
                Log.Debug
                (
                    $"Testing \"{visualStudio.Name}\" v{visualStudio.Version.ToString(3)} at " +
                    $"\"{visualStudio.VisualStudioRootPath}\"..."
                );

                if (!VisualStudioVarPrint.TryRun(visualStudio.VisualStudioRootPath, out var vars))
                {
                    Log.Warning("Internal error");
                    info = null;
                    return false;
                }
                
                if (!vars.TryGetValue(MsvcInstallDirVar, out var msvcInstallDir) ||
                    !vars.TryGetValue(WinSdkUcrtSdkDirVar, out var winSdkUcrtSdkDir) ||
                    !vars.TryGetValue(WinSdkUcrtVersionVar, out var winSdkUcrtVersion))
                {
                    Log.Trace($"\"{visualStudio.Name}\" is not a viable candidate.");
                    continue;
                }
                
                Log.Debug($"msvcInstallDir = \"{msvcInstallDir}\"");
                Log.Debug($"winSdkUcrtSdkDir = \"{winSdkUcrtSdkDir}\"");
                Log.Debug($"winSdkUcrtVersion = \"{winSdkUcrtVersion}\"");

                var ucrtDirs = WinSdkUcrtIncludeSubDirs
                    .Select(x => Path.Combine(winSdkUcrtSdkDir, string.Format(x, winSdkUcrtVersion)))
                    .Where(Directory.Exists)
                    .ToArray();

                var msvcDirs = MsvcIncludeSubDirs
                    .Select(x => Path.Combine(msvcInstallDir, x))
                    .Where(Directory.Exists)
                    .ToArray();

                _cachedInstance = visualStudio;
                _cachedInfo = info = new
                (
                    visualStudio.Name,
                    visualStudio.VisualStudioRootPath,
                    winSdkUcrtSdkDir,
                    ucrtDirs,
                    Version.Parse(winSdkUcrtVersion),
                    msvcInstallDir,
                    msvcDirs,
                    visualStudio.Version,
                    vars,
                    visualStudio.MSBuildPath
                );

                Log.Information
                (
                    $"Using \"{visualStudio.Name}\" v{visualStudio.Version.ToString(3)} " +
                    $"(in \"{visualStudio.VisualStudioRootPath}\") with Windows SDK v{info.UcrtVersion.ToString(4)} " +
                    $"({ucrtDirs.Length} include(s)) and MSVC ({msvcDirs.Length} include(s))"
                );

                return true;
            }

            if (!hasVs)
            {
                Log.Trace("No instance of Visual Studio found whatsoever.");
            }
            
            // if any of it's still null, we couldn't find a candidate.
            Log.Warning
            (
                "Couldn't find a viable Visual Studio installation - ensure you have the Windows 10 SDK and C++ " +
                "tools installed. SilkTouch Scraper may not function correctly without Visual Studio or Visual " +
                "Studio Build Tools with these workloads."
            );

            info = null;
            return false;
        }
    }
}

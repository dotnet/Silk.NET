// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Microsoft.Build.Locator;

namespace Silk.NET.SilkTouch.Scraper.Subagent;

/// <summary>
/// Encapsulations information regarding installed versions of Visual Studio.
/// </summary>
/// <param name="Name">The name of this installation.</param>
/// <param name="InstallationBaseFolder">The base folder of this installation.</param>
/// <param name="UcrtSdkDir">The path to the Universal Common Runtime SDK (Windows SDK).</param>
/// <param name="UcrtIncludes">The extra include directories to be added to include the Universal CRT.</param>
/// <param name="UcrtVersion">
/// The version of the Universal Common Runtime. Typically synced with the Windows SDK version.
/// </param>
/// <param name="MsvcToolsFolder">The path to the folder containing the MSVC toolset.</param>
/// <param name="MsvcToolsIncludes">
/// The extra include directories to be added to include the MSVC (standard C++) headers.
/// </param>
/// <param name="Version">The version of this installation.</param>
/// <param name="Variables">
/// The environment variables captured within a Developer Command Prompt for this installation.
/// </param>
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
    Dictionary<string, string> Variables
);

/// <summary>
/// Contains logic for resolving <see cref="VisualStudioInfo"/> for all Visual Studio installations.
/// </summary>
public static class VisualStudioResolver
{
    private const string MsvcInstallDirVar = "VCToolsInstallDir";
    private static readonly string[] _msvcIncludeSubDirs = { "include" };

    private const string WinSdkUcrtSdkDirVar = "UniversalCRTSdkDir";
    private const string WinSdkUcrtVersionVar = "UCRTVersion";
    private static readonly string[] _winSdkUcrtIncludeSubDirs =
    {
        "Include/{0}/um",
        "Include/{0}/ucrt",
        "Include/{0}/shared"
    };
    
    private static VisualStudioInfo? _cachedInfo;
    
    private static bool _vsInfoKnownError;

    /// <summary>
    /// Gets the <see cref="VisualStudioInfo"/> for the most well-equipped installation of Visual Studio on this
    /// system to handle Scraper workloads.
    /// </summary>
    /// <param name="info">The resolved info.</param>
    /// <returns>Whether the operation was successful.</returns>
    public static bool TryGetVisualStudioInfo([NotNullWhen(true)] out VisualStudioInfo? info)
    {
        // if we're not on windows, this is never gonna work
        if (!OperatingSystem.IsWindowsVersionAtLeast(10))
        {
            info = null;
            return false;
        }

        // if we've cached some info
        if (_cachedInfo is not null || _vsInfoKnownError)
        {
            info = _cachedInfo;
            return !_vsInfoKnownError;
        }
        
        // use MSBuildLocator to find Visual Studio instances
        var visualStudios = MSBuildLocator
            .QueryVisualStudioInstances()
            .Where(x => (x.DiscoveryType & (DiscoveryType.DeveloperConsole | DiscoveryType.VisualStudioSetup)) != 0)
            .OrderBy(x => x.DiscoveryType)
            .ThenByDescending(x => x.Version)
            .ToArray();
        
        Debug.WriteLine(visualStudios.Length + " Visual Studio installation(s)");
        
        // cycle through candidate installations, try and find everything we're looking for.
        foreach (var visualStudio in visualStudios)
        {
            Debug.WriteLine
            (
                $"Testing \"{visualStudio.Name}\" v{visualStudio.Version.ToString(3)} at " +
                $"\"{visualStudio.VisualStudioRootPath}\"..."
            );

            if (!VisualStudioVarPrint.TryRun(visualStudio.VisualStudioRootPath, out var vars))
            {
                Console.WriteLine("VS Resolver Internal error");
                info = null;
                return false;
            }
            
            if (!vars.TryGetValue(MsvcInstallDirVar, out var msvcInstallDir) ||
                !vars.TryGetValue(WinSdkUcrtSdkDirVar, out var winSdkUcrtSdkDir) ||
                !vars.TryGetValue(WinSdkUcrtVersionVar, out var winSdkUcrtVersion))
            {
                Debug.WriteLine($"\"{visualStudio.Name}\" is not a viable candidate.");
                continue;
            }
            
            Debug.WriteLine($"msvcInstallDir = \"{msvcInstallDir}\"");
            Debug.WriteLine($"winSdkUcrtSdkDir = \"{winSdkUcrtSdkDir}\"");
            Debug.WriteLine($"winSdkUcrtVersion = \"{winSdkUcrtVersion}\"");

            var ucrtDirs = _winSdkUcrtIncludeSubDirs
                .Select(x => Path.Combine(winSdkUcrtSdkDir, string.Format(x, winSdkUcrtVersion)))
                .Where(Directory.Exists)
                .ToArray();

            var msvcDirs = _msvcIncludeSubDirs
                .Select(x => Path.Combine(msvcInstallDir, x))
                .Where(Directory.Exists)
                .ToArray();

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
                vars
            );

            Console.WriteLine
            (
                $"Using \"{visualStudio.Name}\" v{visualStudio.Version.ToString(3)} " +
                $"(in \"{visualStudio.VisualStudioRootPath}\") with Windows SDK v{info.UcrtVersion.ToString(4)} " +
                $"({ucrtDirs.Length} include(s)) and MSVC ({msvcDirs.Length} include(s))"
            );

            return true;
        }

        info = null;
        _vsInfoKnownError = true;
        return false;
    }
}

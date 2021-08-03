// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.Versioning;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;
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
        string[] MsvcToolsIncludes
    );

    internal record VisualStudioCandidate
    (
        string Name,
        string InstallationPath
    );

    [SupportedOSPlatform("windows")]
    public static class VisualStudioResolver
    {
        internal static readonly string VarPrintScriptNamespace =
            $"{typeof(VisualStudioResolver).Namespace}.VisualStudioVarPrint.bat";
        
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

        public static bool TryGetVisualStudioInfo(bool allowPrerelease, out VisualStudioInfo? info)
        {
            ManagementObjectCollection mcCollection;

            try
            {
                using ManagementClass mc = new("MSFT_VSInstance");
                mcCollection = mc.GetInstances();
            }
            catch (Exception e)
            {
                Log.Debug($"Failed to get \"MSFT_VSInstance\" info with exception {e}");
                info = null;
                return false;
            }

            //We want to buildtools if they have it installec, we'll use VS installs if needed
            var visualStudios = new VisualStudioCandidate[mcCollection.Count];
            var i = 0;
            foreach (var result in mcCollection)
            {
                var name = Convert.ToString(result["Name"]);
                var path = Convert.ToString(result["InstallLocation"]);
                if (name is null || path is null)
                {
                    continue;
                }

                visualStudios[i++] = new(name, path);
            }

            // extract the varprint script
            var varPrint = Path.Combine(Path.GetTempPath(), $"{Path.GetRandomFileName()}.bat");
            using var varPrintRes = typeof(VisualStudioResolver).Assembly
                .GetManifestResourceStream(VarPrintScriptNamespace);
            if (varPrintRes is null)
            {
                Log.Debug($"Couldn't extract \"{VarPrintScriptNamespace}\" from assembly.");
                Log.Warning("Internal error.");
                info = null;
                return false;
            }

            using var varPrintOut = File.OpenWrite(varPrint);
            varPrintRes.CopyTo(varPrintOut);
            
            // cycle through candidate installations, try and find everything we're looking for.
            string? msvcInstallDir = null;
            string? winSdkUcrtSdkDir = null;
            string? winSdkUcrtVersion = null;
            var listening = true;
            foreach (var (name, installationPath) in visualStudios)
            {
                Log.Debug($"Testing \"{name}\" at \"{installationPath}\"...");
                using var varPrintProc = new Process 
                {
                    StartInfo = new()
                    {
                        FileName = "cmd",
                        Arguments = $"/c \"{varPrint}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
            
                varPrintProc.Start();
                while (!varPrintProc.StandardOutput.EndOfStream)
                {
                    var line = varPrintProc.StandardOutput.ReadLine();
                    if (line is null)
                    {
                        break;
                    }

                    Log.Debug(line);

                    if (line == "***VARSTART***")
                    {
                        listening = true;
                        continue;
                    }

                    if (line == "***VAREND***")
                    {
                        listening = false;
                        break;
                    }

                    if (listening)
                    {
                        var split = line.Split('=');
                        var _ = split[0] switch
                        {
                            MsvcInstallDirVar => msvcInstallDir = split[1],
                            WinSdkUcrtSdkDirVar => winSdkUcrtSdkDir = split[1],
                            WinSdkUcrtVersionVar => winSdkUcrtVersion = split[1],
                            _ => string.Empty
                        };
                    }
                }
                
                Log.Debug($"msvcInstallDir = \"{msvcInstallDir}\"");
                Log.Debug($"winSdkUcrtSdkDir = \"{winSdkUcrtSdkDir}\"");
                Log.Debug($"winSdkUcrtVersion = \"{winSdkUcrtVersion}\"");
                if (msvcInstallDir is null || winSdkUcrtSdkDir is null || winSdkUcrtVersion is null)
                {
                    Log.Trace($"\"{name}\" is not a viable candidate.");
                    continue;
                }

                var ucrtDirs = WinSdkUcrtIncludeSubDirs
                    .Select(x => Path.Combine(winSdkUcrtSdkDir, string.Format(x, winSdkUcrtVersion)))
                    .Where(Directory.Exists)
                    .ToArray();

                var msvcDirs = MsvcIncludeSubDirs
                    .Select(x => Path.Combine(msvcInstallDir, x))
                    .Where(Directory.Exists)
                    .ToArray();

                info = new
                (
                    name,
                    installationPath,
                    winSdkUcrtSdkDir,
                    ucrtDirs,
                    Version.Parse(winSdkUcrtVersion),
                    msvcInstallDir,
                    msvcDirs
                );

                Log.Information
                (
                    $"Using \"{name}\" (in \"{installationPath}\") with Windows SDK v{info.UcrtVersion.ToString(4)} " +
                    $"({ucrtDirs.Length} include(s)) and MSVC ({msvcDirs.Length} include(s))"
                );

                return true;
            }
            
            // if any of it's still null, we couldn't find a candidate.
            Log.Warning
            (
                "Couldn't find a viable Visual Studio installation - ensure you have the Windows 10 SDK and C++ " +
                "tools installed."
            );

            info = null;
            return false;
        }
    }
}

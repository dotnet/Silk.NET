// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Nuke.Common;
using Serilog;
using System.IO;
using System;
using System.Linq;
using Nuke.Common.Tooling;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.Git.GitTasks;

partial class Build
{
    [Parameter
    (
        "When enabled, pulls the latest changes for local clone of the 3.0 branch to build the website. Automatically true if the local clone doesn't exist yet."
    )]
    readonly bool PullBaseSite;
    
    [Parameter("Arguments for website generation on the 3.0 branch.")]
    readonly string[]? SiteBuildArgs;

    Target Website => CommonTarget
    (
        x => x.Executes
        (
            () =>
            {
                string? path;
                if (!File.Exists(RootDirectory / "dir.log") || !Directory.Exists(path = File.ReadAllText(RootDirectory / "dir.log")))
                {
                    Log.Information("3.0 clone not found, cloning...");
                    path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    Directory.CreateDirectory(path);
                    Git($"clone \"https://github.com/dotnet/Silk.NET\" --depth 1 --branch develop/3.0 {path}");
                    File.WriteAllText(RootDirectory / "dir.log", path);
                }
                else if (PullBaseSite)
                {
                    if (Directory.Exists($"{path}/eng/submodules/silk.net-2.x/documentation"))
                    {
                        Directory.Delete($"{path}/eng/submodules/silk.net-2.x/documentation", true);
                    }

                    if (File.Exists($"{path}/eng/submodules/silk.net-2.x/documentation/version.txt"))
                    {
                        File.Delete($"{path}/eng/submodules/silk.net-2.x/documentation/version.txt");
                    }

                    Git("pull", path);
                }
                else
                {
                    Directory.Delete($"{path}/eng/submodules/silk.net-2.x/documentation", true);
                }
                CopyDirectoryRecursively(RootDirectory / "documentation", $"{path}/eng/submodules/silk.net-2.x/documentation");
                File.WriteAllText($"{path}/eng/submodules/silk.net-2.x/documentation/version.txt", Git($"describe --tags --abbrev=0").First(x => x.Type == OutputType.Std).Text.Trim());
                InheritedShell($"{(OperatingSystem.IsWindows() ? ".\\build.cmd" : "./build.sh")} website {string.Join(' ', (SiteBuildArgs ?? Enumerable.Empty<string>()).Select(x => $"--{x}"))}", path).AssertZeroExitCode();
                if (Directory.Exists(RootDirectory / "website"))
                {
                    Directory.Delete(RootDirectory / "website", true);
                }

                CopyDirectoryRecursively($"{path}/artifacts/docs", RootDirectory / "website");
            }
        )
    );
}

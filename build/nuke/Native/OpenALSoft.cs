// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Git;
using Octokit;
using Octokit.Internal;
using static Nuke.Common.IO.CompressionTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.HttpTasks;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.GitHub.GitHubTasks;

partial class Build {
    AbsolutePath OpenALSoftPath => RootDirectory / "build" / "submodules" / "openal-soft";

    Target OpenALSoft => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var buildDir = OpenALSoftPath / "build";
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.OpenAL.Soft.Native" / "runtimes";

                    var prepare = "cmake .. -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_NO_CONFIG_UTIL=ON -DALSOFT_EXAMPLES=OFF";
                    var build = $"cmake --build . --config Release{JobsArg}";

                    if (OperatingSystem.IsWindows())
                    {
                        foreach (var (platform, rid) in new[]
                        {
                            ("Win32", "win-x86"),
                            ("x64", "win-x64"),
                            ("ARM64", "win-arm64"),
                        })
                        {
                            EnsureCleanDirectory(buildDir);

                            InheritedShell($"{prepare} -A {platform}", buildDir).AssertZeroExitCode();
                            InheritedShell(build, buildDir).AssertZeroExitCode();

                            CopyFile(buildDir / "Release" / "OpenAL32.dll", runtimes / rid / "native" / "soft_oal.dll", FileExistsPolicy.Overwrite);
                        }
                    }
                    else if (OperatingSystem.IsLinux())
                    {
                        foreach (var (triple, rid) in new[]
                        {
                            ("x86_64-linux-gnu", "linux-x64"),
                            ("arm-linux-gnueabihf", "linux-arm"),
                            ("aarch64-linux-gnu", "linux-arm64"),
                        })
                        {
                            EnsureCleanDirectory(buildDir);

                            InheritedShell($"{prepare} -DALSOFT_BACKEND_SNDIO=OFF {GetCMakeToolchainFlag(triple)}", buildDir).AssertZeroExitCode();
                            InheritedShell(build, buildDir).AssertZeroExitCode();

                            InheritedShell($"{triple}-strip --strip-unneeded libopenal.so", buildDir).AssertZeroExitCode();

                            CopyFile(buildDir / "libopenal.so", runtimes / rid / "native" / "libopenal.so", FileExistsPolicy.Overwrite);
                        }
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        foreach (var (arch, rid) in new[]
                        {
                            ("x86_64", "osx-x64"),
                            ("arm64", "osx-arm64"),
                        })
                        {
                            EnsureCleanDirectory(buildDir);

                            InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES={arch}", buildDir).AssertZeroExitCode();
                            InheritedShell(build, buildDir).AssertZeroExitCode();

                            InheritedShell($"strip -Sx libopenal.dylib", buildDir).AssertZeroExitCode();

                            CopyFile(buildDir / "libopenal.dylib", runtimes / rid / "native" / "libopenal.dylib", FileExistsPolicy.Overwrite);
                        }
                    }

                    Git("checkout HEAD build/", OpenALSoftPath);

                    PrUpdatedNativeBinary("OpenALSoft");
                }
            )
    );
}

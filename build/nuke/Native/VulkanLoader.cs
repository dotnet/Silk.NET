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
    AbsolutePath VulkanLoaderPath => RootDirectory / "build" / "submodules" / "Vulkan-Loader";

    Target VulkanLoader => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var buildDir = VulkanLoaderPath / "build";
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vulkan.Loader.Native" / "runtimes";

                    var prepare = "cmake .. -DCMAKE_BUILD_TYPE=Release -DUPDATE_DEPS=ON";
                    var build = $"cmake --build . --config Release{JobsArg}";

                    if (OperatingSystem.IsWindows())
                    {
                        foreach (var (platform, rid) in new[]
                        {
                            ("Win32", "win-x86"),
                            ("x64", "win-x64"),
                        })
                        {
                            EnsureCleanDirectory(buildDir);

                            InheritedShell($"{prepare} -A {platform}", buildDir).AssertZeroExitCode();
                            InheritedShell(build, buildDir).AssertZeroExitCode();

                            CopyAll((buildDir / "loader" / "Release").GlobFiles("vulkan-1.dll"), runtimes / rid / "native");
                        }
                    }
                    else if (OperatingSystem.IsLinux())
                    {
                        foreach (var (triple, rid) in new[]
                        {
                            ("x86_64-linux-gnu", "linux-x64"),
                            ("aarch64-linux-gnu", "linux-arm64"),
                        })
                        {
                            EnsureCleanDirectory(buildDir);

                            InheritedShell($"{prepare} {GetCMakeToolchainFlag(triple)}", buildDir).AssertZeroExitCode();
                            InheritedShell(build, buildDir).AssertZeroExitCode();

                            InheritedShell($"{triple}-strip --strip-unneeded loader/libvulkan.so", buildDir).AssertZeroExitCode();

                            CopyAll((buildDir / "loader").GlobFiles("libvulkan.so"), runtimes / rid / "native");
                        }

                        // Build for win-arm64 with llvm-mingw.
                        {
                            EnsureCleanDirectory(buildDir);

                            InheritedShell($"{prepare} -DUSE_GAS=ON {GetCMakeToolchainFlag("aarch64-w64-mingw32")}", buildDir).AssertZeroExitCode();
                            InheritedShell(build, buildDir).AssertZeroExitCode();

                            CopyAll((buildDir / "loader").GlobFiles("vulkan-1.dll"), runtimes / "win-arm64" / "native");
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
                            // For some reason, EnsureCleanDirectory(buildDir) fails in CI after performing one
                            // build, so just create a unique directory for each build.
                            var macOsBuildDir = VulkanLoaderPath / ("build-" + arch);

                            EnsureCleanDirectory(macOsBuildDir);

                            InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES={arch}", macOsBuildDir).AssertZeroExitCode();
                            InheritedShell(build, macOsBuildDir).AssertZeroExitCode();

                            InheritedShell($"strip -Sx loader/libvulkan.dylib", macOsBuildDir).AssertZeroExitCode();

                            CopyAll((macOsBuildDir / "loader").GlobFiles("libvulkan.dylib"), runtimes / rid / "native");
                        }
                    }

                    PrUpdatedNativeBinary("Vulkan Loader");
                }
            )
    );
}

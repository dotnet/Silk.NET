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
    AbsolutePath SwiftShaderPath => RootDirectory / "build" / "submodules" / "SwiftShader";

    Target SwiftShader => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var buildDir = SwiftShaderPath / "build";
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vulkan.SwiftShader.Native" / "runtimes";

                    var prepare = "cmake .. -DSWIFTSHADER_WARNINGS_AS_ERRORS=FALSE";
                    var build = $"cmake --build . --config Release{JobsArg}";

                    // Work around SwiftShader's silly Git hook installation logic that fails as a submodule.
                    File.WriteAllText(
                        SwiftShaderPath / "CMakeLists.txt",
                        File.ReadAllText(SwiftShaderPath / "CMakeLists.txt")
                            .Replace("if(NOT EXISTS ${CMAKE_SOURCE_DIR}/.git/hooks/commit-msg)", "if(FALSE)"));

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

                            CopyFile(buildDir / "Windows" / "vk_swiftshader.dll", runtimes / rid / "native" / "vk_swiftshader.dll", FileExistsPolicy.Overwrite);
                            CopyFile(buildDir / "Windows" / "vk_swiftshader_icd.json", runtimes / rid / "native" / "vk_swiftshader_icd.json", FileExistsPolicy.Overwrite);
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

                            InheritedShell($"{prepare} {GetCMakeToolchainFlag(triple)}", buildDir).AssertZeroExitCode();
                            InheritedShell(build, buildDir).AssertZeroExitCode();

                            CopyFile(buildDir / "Linux" / "libvk_swiftshader.so", runtimes / rid / "native" / "libvk_swiftshader.so", FileExistsPolicy.Overwrite);
                            CopyFile(buildDir / "Linux" / "vk_swiftshader_icd.json", runtimes / rid / "native" / "vk_swiftshader_icd.json", FileExistsPolicy.Overwrite);
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

                            CopyFile(buildDir / "Darwin" / "libvk_swiftshader.dylib", runtimes / rid / "native" / "libvk_swiftshader.dylib", FileExistsPolicy.Overwrite);
                            CopyFile(buildDir / "Darwin" / "vk_swiftshader_icd.json", runtimes / rid / "native" / "vk_swiftshader_icd.json", FileExistsPolicy.Overwrite);
                        }
                    }

                    Git("checkout HEAD CMakeLists.txt build/", SwiftShaderPath);

                    PrUpdatedNativeBinary("SwiftShader");
                }
            )
    );
}

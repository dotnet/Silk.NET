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

                    var prepare = "cmake .. -DSWIFTSHADER_WARNINGS_AS_ERRORS=FALSE -DSWIFTSHADER_BUILD_TESTS=FALSE";
                    var build = $"cmake --build . --config Release{JobsArg}";

                    // Work around SwiftShader's silly Git hook installation logic that fails as a submodule
                    // since `.git` is just a file containing a `gitdir` directive.
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
                            ("ARM64", "win-arm64"),
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
                            ("zig-toolchain-x86_64-linux-gnu.2.17", "linux-x64"),
                            ("zig-toolchain-arm-linux-gnueabihf.2.17", "linux-arm"),
                            ("zig-toolchain-aarch64-linux-gnu.2.17", "linux-arm64"),
                        }.Where(x => string.IsNullOrWhiteSpace(MatrixArg) || x.Item2 == MatrixArg))
                        {
                            EnsureCleanDirectory(buildDir);
                            InheritedShell($"{prepare} {GetCMakeToolchainFlag(triple)} -DCMAKE_C_FLAGS_RELEASE=\"-s -Wl,--undefined-version\" -DCMAKE_CXX_FLAGS_RELEASE=\"-s -Wl,--undefined-version\"", buildDir).AssertZeroExitCode();
                            InheritedShell
                            (
                                build,
                                buildDir,
                                new Dictionary<string, string>
                                {
                                    // zig cc doesn't recognise generic as a valid -mtune for some reason
                                    {"SILKDOTNET_ReplaceArchitectureZigCcFlags", "generic="},
                                    // https://issues.chromium.org/issues/40242425#comment3
                                    {"LDFLAGS", "-Wl,--undefined-version"}
                                }
                            ).AssertZeroExitCode();

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

                            InheritedShell($"strip -Sx Darwin/libvk_swiftshader.dylib", buildDir).AssertZeroExitCode();

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

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
    AbsolutePath SwiftShaderBuildPath => RootDirectory / "build" / "submodules" / "SwiftShader" / "build";

    Target SwiftShader => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var sysName = OperatingSystem.IsLinux() ? "Linux" :
                        OperatingSystem.IsWindows() ? "Windows" :
                        OperatingSystem.IsMacOS() ? "Darwin" : throw new PlatformNotSupportedException();
                    DeleteDirectory(SwiftShaderBuildPath);
                    Git("checkout HEAD build/", SwiftShaderBuildPath / "..");
                    StartProcess("cmake", ".. -DCMAKE_BUILD_TYPE=Release", SwiftShaderBuildPath)
                        .AssertZeroExitCode();
                    StartProcess("cmake", $"--build .{JobsArg} --config Release", SwiftShaderBuildPath)
                        .AssertWaitForExit(); // might fail... as long as the output exists we're happy
                    var fname = sysName switch
                    {
                        "Linux" => "libvk_swiftshader.so",
                        "Windows" => "vk_swiftshader.dll",
                        "Darwin" => "libvk_swiftshader.dylib",
                        _ => throw new("what")
                    };

                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vulkan.SwiftShader.Native" / "runtimes";
                    var outputPath = SwiftShaderBuildPath / sysName;
                    const string icd = "vk_swiftshader_icd.json";
                    if (OperatingSystem.IsWindows())
                    {
                        CopyFile
                        (
                            outputPath / fname, runtimes / "win-x64" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        ); // we'll use WOW64
                        CopyFile
                        (
                            outputPath / fname, runtimes / "win-x86" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "win-x64" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "win-x86" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                    }
                    else if (OperatingSystem.IsLinux())
                    {
                        CopyFile
                        (
                            outputPath / fname, runtimes / "linux-x64" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "linux-x64" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        CopyFile
                        (
                            outputPath / fname, runtimes / "osx-x64" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "osx-x64" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                    }

                    PrUpdatedNativeBinary("SwiftShader");
                }
            )
    );
}
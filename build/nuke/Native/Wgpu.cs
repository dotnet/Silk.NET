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
    AbsolutePath WgpuPath => RootDirectory / "build" / "submodules" / "wgpu-native";

    Target Wgpu => CommonTarget
        (
        x => x.Before(Compile)
        .After(Clean)
        .Executes
        (
        () =>
        {
            var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.WebGPU.Native.WGPU" / "runtimes";

            var target = WgpuPath / "target";
            EnsureCleanDirectory(target);

            if(OperatingSystem.IsWindows())
            {
                //Compile Windows libraries
                InheritedShell("cargo build --release --target=i686-pc-windows-msvc", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=x86_64-pc-windows-msvc", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=aarch64-pc-windows-msvc", WgpuPath).AssertZeroExitCode();

                CopyFile(target / "i686-pc-windows-msvc" / "release" / "wgpu_native.dll", runtimes / "win-x86" / "native" / "wgpu_native.dll", FileExistsPolicy.Overwrite);
                CopyFile(target / "x86_64-pc-windows-msvc" / "release" / "wgpu_native.dll", runtimes / "win-x64" / "native" / "wgpu_native.dll", FileExistsPolicy.Overwrite);
                CopyFile(target / "aarch64-pc-windows-msvc" / "release" / "wgpu_native.dll", runtimes / "win-arm64" / "native" / "wgpu_native.dll", FileExistsPolicy.Overwrite);
            }

            if(OperatingSystem.IsLinux())
            {
                //Compile Linux libraries
                InheritedShell("cargo build --release --target=i686-unknown-linux-gnu", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=x86_64-unknown-linux-gnu", WgpuPath).AssertZeroExitCode();

                CopyFile(target / "i686-unknown-linux-gnu" / "release" / "libwgpu_native.so", runtimes / "linux-x86" / "native" / "libwgpu_native.so", FileExistsPolicy.Overwrite);
                CopyFile(target / "x86_64-unknown-linux-gnu" / "release" / "libwgpu_native.so", runtimes / "linux-x64" / "native" / "libwgpu_native.so", FileExistsPolicy.Overwrite);
            }

            if(OperatingSystem.IsMacOS())
            {
                //Compile MacOS libraries
                InheritedShell("cargo build --release --target=aarch64-apple-darwin", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=x86_64-apple-darwin", WgpuPath).AssertZeroExitCode();

                CopyFile(target / "x86_64-apple-darwin" / "release" / "libwgpu_native.dylib", runtimes / "osx-x64" / "native" / "libwgpu_native.dylib", FileExistsPolicy.Overwrite);
                CopyFile(target / "aarch64-apple-darwin" / "release" / "libwgpu_native.dylib", runtimes / "osx-arm64" / "native" / "libwgpu_native.dylib", FileExistsPolicy.Overwrite);
            }

            PrUpdatedNativeBinary("Wgpu");
        }
        )
    );
}
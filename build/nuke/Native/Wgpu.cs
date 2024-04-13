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
            var target = WgpuPath / "target";
            var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.WebGPU.Native.WGPU" / "runtimes";

            EnsureCleanDirectory(target);

            (string Triple, string Rid)[] targets;
            string library;

            if (OperatingSystem.IsWindows())
            {
                targets = new[]
                {
                    ("i686-pc-windows-msvc", "win-x86"),
                    ("x86_64-pc-windows-msvc", "win-x64"),
                    ("aarch64-pc-windows-msvc", "win-arm64"),
                };
                library = "wgpu_native.dll";
            }
            else if (OperatingSystem.IsLinux())
            {
                targets = new[]
                {
                    ("x86_64-unknown-linux-gnu", "linux-x64"),
                    ("arm-unknown-linux-gnueabihf", "linux-arm"),
                    ("aarch64-unknown-linux-gnu", "linux-arm64"),
                };
                library = "libwgpu_native.so";
            }
            else if (OperatingSystem.IsMacOS())
            {
                targets = new[]
                {
                    ("x86_64-apple-darwin", "osx-x64"),
                    ("aarch64-apple-darwin", "osx-arm64"),
                };
                library = "libwgpu_native.dylib";
            }
            else
                throw new Exception("Unsupported OS!");

            foreach (var (triple, rid) in targets)
            {
                // Cross-compiling to these targets on linux-x64 will fail if a proper linker is not set.
                var linker = rid switch
                {
                    "linux-arm" => "arm-linux-gnueabihf-gcc",
                    "linux-arm64" => "aarch64-linux-gnu-gcc",
                    _ => null,
                };

                if (linker != null)
                    linker = $" --config \"target.{triple}.linker = '{linker}'\"";

                InheritedShell($"cargo build --release --target {triple}{linker}", WgpuPath).AssertZeroExitCode();

                CopyFile(target / triple / "release" / library, runtimes / rid / "native" / library, FileExistsPolicy.Overwrite);
            }

            PrUpdatedNativeBinary("Wgpu");
        }
        )
    );
}

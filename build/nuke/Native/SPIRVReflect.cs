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
    AbsolutePath SPIRVReflectPath => RootDirectory / "build" / "submodules" / "SPIRV-Reflect";

    //This is the build script for the SPIRV-Reflect shared library
    const string SPIRVReflectBuildScript = @"const std = @import(""std"");
const fs = std.fs;

pub fn build(b: *std.Build) void {
    const target = b.standardTargetOptions(.{});
    const mode = b.standardOptimizeOption(.{});

    const shared_lib_options: std.build.SharedLibraryOptions = .{
        .name = ""spirv-reflect"",
        .target = target,
        .optimize = mode,
    };

    const lib: *std.build.LibExeObjStep = b.addSharedLibrary(shared_lib_options);
    lib.linkLibC();

    lib.addCSourceFiles(&.{""spirv_reflect.c""}, &.{ ""-std=c99"", ""-fPIC"" });
    b.installArtifact(lib);
}";

    Target SPIRVReflect => CommonTarget
        (
            x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.SPIRV.Reflect.Native" / "runtimes";

                    //Write out the build script to the directory
                    File.WriteAllText(SPIRVReflectPath / "build.zig", SPIRVReflectBuildScript);

                    { //Linux
                        //Build for Linux x86_64 with glibc 2.26 (old version specified for compatibility)
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=x86_64-linux-gnu.2.26 --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "libspirv-reflect.so", runtimes / "linux-x64" / "native" / "libspirv-reflect.so", FileExistsPolicy.Overwrite);

                        //Build for Linux x86 with glibc 2.26 (old version specified for compatibility)
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=x86-linux-gnu.2.26 --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "libspirv-reflect.so", runtimes / "linux-x86" / "native" / "libspirv-reflect.so", FileExistsPolicy.Overwrite);

                        //Build for Linux arm64 with glibc 2.26 (old version specified for compatibility)
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=aarch64-linux-gnu.2.26 --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "libspirv-reflect.so", runtimes / "linux-arm64" / "native" / "libspirv-reflect.so", FileExistsPolicy.Overwrite);
                    }

                    { //Windows
                        //Build for Windows x86_64
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=x86_64-windows --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "spirv-reflect.dll", runtimes / "win-x64" / "native" / "spirv-reflect.dll", FileExistsPolicy.Overwrite);

                        //Build for Windows x86
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=x86-windows --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "spirv-reflect.dll", runtimes / "win-x86" / "native" / "spirv-reflect.dll", FileExistsPolicy.Overwrite);

                        //Build for Windows arm64
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=aarch64-windows --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "spirv-reflect.dll", runtimes / "win-arm64" / "native" / "spirv-reflect.dll", FileExistsPolicy.Overwrite);
                    }

                    { //MacOS
                        //Build for MacOS x86_64
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=x86_64-macos --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "libspirv-reflect.dylib", runtimes / "osx-x64" / "native" / "libspirv-reflect.dylib", FileExistsPolicy.Overwrite);

                        //Build for MacOS arm64
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=aarch64-macos --verbose", SPIRVReflectPath).AssertZeroExitCode();
                        CopyFile(SPIRVReflectPath / "zig-out" / "lib" / "libspirv-reflect.dylib", runtimes / "osx-arm64" / "native" / "libspirv-reflect.dylib", FileExistsPolicy.Overwrite);
                    }

                    var files = (runtimes / "win-x64" / "native").GlobFiles("*.dll")
                        .Concat((runtimes / "win-x86" / "native").GlobFiles("*.dll"))
                        .Concat((runtimes / "win-arm64" / "native").GlobFiles("*.dll"))
                        .Concat((runtimes / "osx-x64" / "native").GlobFiles("*.dylib"))
                        .Concat((runtimes / "osx-arm64" / "native").GlobFiles("*.dylib"))
                        .Concat((runtimes / "linux-x64" / "native").GlobFiles("*.so"))
                        .Concat((runtimes / "linux-x86" / "native").GlobFiles("*.so"))
                        .Concat((runtimes / "linux-arm64" / "native").GlobFiles("*.so"));

                    var glob = string.Empty;
                    glob = files.Aggregate(glob, (current, path) => current + $"\"{path}\" ");

                    PrUpdatedNativeBinary("SPIRV-Reflect", glob);
                }
            )
        );
}
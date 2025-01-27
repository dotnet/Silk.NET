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
    AbsolutePath SPIRVCrossPath => RootDirectory / "build" / "submodules" / "SPIRV-Cross";

    //This is the build script for the SPIRV-Reflect shared library
    const string SPIRVCrossBuildScript = @"const std = @import(""std"");
const fs = std.fs;

pub fn build(b: *std.Build) void {
    const target = b.standardTargetOptions(.{});
    const mode = b.standardOptimizeOption(.{});

    const shared_lib_options: std.Build.SharedLibraryOptions = .{
        .name = ""spirv-cross"",
        .target = target,
        .optimize = mode,
    };

    const lib: *std.Build.Step.Compile = b.addSharedLibrary(shared_lib_options);
    lib.linkLibC();
    lib.linkLibCpp();

    const flags = &.{ ""-std=c++11"", ""-fPIC"" };

    //Enable the GLSL, HLSL, MSL, CPP, and Reflect C APIs
    lib.defineCMacro(""SPIRV_CROSS_C_API_GLSL"", ""1"");
    lib.defineCMacro(""SPIRV_CROSS_C_API_HLSL"", ""1"");
    lib.defineCMacro(""SPIRV_CROSS_C_API_MSL"", ""1"");
    lib.defineCMacro(""SPIRV_CROSS_C_API_CPP"", ""1"");
    lib.defineCMacro(""SPIRV_CROSS_C_API_REFLECT"", ""1"");

    //Export the C API symbols
    lib.defineCMacro(""SPVC_EXPORT_SYMBOLS"", ""1"");

    //On windows, we need to specify `__declspec(dllexport)` ourselves
    //else SPIRV-Cross thinks this is a GNU toolchain and uses the wrong attribute in this case
    if (target.result.os.tag == .windows) {
        lib.defineCMacro(""SPVC_PUBLIC_API"", ""__declspec(dllexport)"");
    }

    //If we arent in debug, defined NDEBUG and strip symbols
    if (mode != .Debug) {
        lib.defineCMacro(""NDEBUG"", ""1"");

        lib.root_module.strip = true;
    }

    lib.addCSourceFiles(.{
        .files = &.{
            ""spirv_cross.cpp"",
            ""spirv_cfg.cpp"",
            ""spirv_cpp.cpp"",
            ""spirv_cross_c.cpp"",
            ""spirv_cross_parsed_ir.cpp"",
            ""spirv_cross_util.cpp"",
            ""spirv_glsl.cpp"",
            ""spirv_hlsl.cpp"",
            ""spirv_msl.cpp"",
            ""spirv_parser.cpp"",
            ""spirv_reflect.cpp"",
        },
        .flags = flags
    });

    b.installArtifact(lib);
}";

    Target SPIRVCross => CommonTarget
        (
            x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.SPIRV.Cross.Native" / "runtimes";

                    //Write out the build script to the directory
                    File.WriteAllText(SPIRVCrossPath / "build.zig", SPIRVCrossBuildScript);

                    string releaseMode = "-Doptimize=ReleaseFast";

                    { //Linux
                        //Build for Linux x86_64 with glibc 2.17 (old version specified for compatibility)
                        InheritedShell($"zig build {releaseMode} -Dtarget=x86_64-linux-gnu.2.17 --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "lib" / "libspirv-cross.so", runtimes / "linux-x64" / "native" / "libspirv-cross.so", FileExistsPolicy.Overwrite);

                        //Build for Linux arm with glibc 2.17 (old version specified for compatibility)
                        InheritedShell($"zig build {releaseMode} -Dtarget=arm-linux-gnueabihf.2.17 --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "lib" / "libspirv-cross.so", runtimes / "linux-arm" / "native" / "libspirv-cross.so", FileExistsPolicy.Overwrite);

                        //Build for Linux arm64 with glibc 2.17 (old version specified for compatibility)
                        InheritedShell($"zig build {releaseMode} -Dtarget=aarch64-linux-gnu.2.17 --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "lib" / "libspirv-cross.so", runtimes / "linux-arm64" / "native" / "libspirv-cross.so", FileExistsPolicy.Overwrite);
                    }

                    { //Windows
                        //Build for Windows x86_64
                        InheritedShell($"zig build {releaseMode} -Dtarget=x86_64-windows --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "bin" / "spirv-cross.dll", runtimes / "win-x64" / "native" / "spirv-cross.dll", FileExistsPolicy.Overwrite);

                        //Build for Windows x86
                        InheritedShell($"zig build {releaseMode} -Dtarget=x86-windows --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "bin" / "spirv-cross.dll", runtimes / "win-x86" / "native" / "spirv-cross.dll", FileExistsPolicy.Overwrite);

                        //Build for Windows arm64
                        InheritedShell($"zig build {releaseMode} -Dtarget=aarch64-windows --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "bin" / "spirv-cross.dll", runtimes / "win-arm64" / "native" / "spirv-cross.dll", FileExistsPolicy.Overwrite);
                    }

                    { //MacOS
                        //Build for MacOS x86_64
                        InheritedShell($"zig build {releaseMode} -Dtarget=x86_64-macos --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "lib" / "libspirv-cross.dylib", runtimes / "osx-x64" / "native" / "libspirv-cross.dylib", FileExistsPolicy.Overwrite);

                        //Build for MacOS arm64
                        InheritedShell($"zig build {releaseMode} -Dtarget=aarch64-macos --verbose", SPIRVCrossPath).AssertZeroExitCode();
                        CopyFile(SPIRVCrossPath / "zig-out" / "lib" / "libspirv-cross.dylib", runtimes / "osx-arm64" / "native" / "libspirv-cross.dylib", FileExistsPolicy.Overwrite);
                    }

                    PrUpdatedNativeBinary("SPIRV-Cross");
                }
            )
        );
}

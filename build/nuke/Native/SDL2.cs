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
    AbsolutePath SDL2Path => RootDirectory / "build" / "submodules" / "SDL";

    Target SDL2 => CommonTarget
        (
        x => x.Before(Compile)
        .After(Clean)
        .Executes
        (
        () =>
        {
            var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.SDL.Native" / "runtimes";

            var x86BuildDir = SDL2Path / "buildx86";
            var x64BuildDir = SDL2Path / "buildx64";
            var ARM64BuildDir = SDL2Path / "buildARM64";
            EnsureCleanDirectory(x86BuildDir);
            EnsureCleanDirectory(x64BuildDir);
            EnsureCleanDirectory(ARM64BuildDir);

            if(OperatingSystem.IsWindows())
            {
                var prepare = "cmake .. -DBUILD_SHARED_LIBS=ON";
                var build = $"cmake --build . --config Release{JobsArg}";

                InheritedShell($"{prepare} -A Win32", x86BuildDir).AssertZeroExitCode();
                InheritedShell(build, x86BuildDir).AssertZeroExitCode();

                InheritedShell($"{prepare} -A X64", x64BuildDir).AssertZeroExitCode();
                InheritedShell(build, x64BuildDir).AssertZeroExitCode();

                InheritedShell($"{prepare} -A arm64", ARM64BuildDir).AssertZeroExitCode();
                InheritedShell(build, ARM64BuildDir).AssertZeroExitCode();

                CopyFile(x86BuildDir / "Release" / "SDL2.dll", runtimes / "win-x86" / "native" / "SDL2.dll", FileExistsPolicy.Overwrite);
                CopyFile(x64BuildDir / "Release" / "SDL2.dll", runtimes / "win-x64" / "native" / "SDL2.dll", FileExistsPolicy.Overwrite);
                CopyFile(ARM64BuildDir / "Release" / "SDL2.dll", runtimes / "win-arm64" / "native" / "SDL2.dll", FileExistsPolicy.Overwrite);
            }

            if(OperatingSystem.IsLinux())
            {
                if(RuntimeInformation.OSArchitecture == Architecture.Arm64) 
                {
                    InheritedShell("cmake ..", x86BuildDir).AssertZeroExitCode();
                    InheritedShell("cmake --build .", x86BuildDir).AssertZeroExitCode();

                    CopyFile(ARM64BuildDir / "libSDL2-2.0.so.0.2600.5", runtimes / "linux-arm64" / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
                } 
                else if (RuntimeInformation.OSArchitecture == Architecture.X64) 
                {
                    var envVars32bit = "CFLAGS='-m32 -O2' CXXFLAGS='-m32 -O2' LDFLAGS=-m32";
                    var envVars64bit = "CFLAGS=-O2 CXXFLAGS=-O2";

                    InheritedShell($"{envVars32bit} ./configure --prefix={x86BuildDir}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"{envVars32bit} make {JobsArg}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"make install", SDL2Path).AssertZeroExitCode();

                    InheritedShell($"{envVars64bit} ./configure --prefix={x64BuildDir}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"{envVars64bit} make {JobsArg}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"make install", SDL2Path).AssertZeroExitCode();

                    //Strip the libraries
                    InheritedShell($"strip {x86BuildDir / "lib" / "libSDL2-2.0.so*"}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"strip {x64BuildDir / "lib" / "libSDL2-2.0.so*"}", SDL2Path).AssertZeroExitCode();

                    CopyFile((x86BuildDir / "lib").GlobFiles("libSDL2-2.0.so*").First(), runtimes / "linux-x86" / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
                    CopyFile((x64BuildDir / "lib").GlobFiles("libSDL2-2.0.so*").First(), runtimes / "linux-x64" / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
                } 
                else 
                {
                    throw new Exception($"Unable to build SDL libs on your architecture ({RuntimeInformation.OSArchitecture}).");
                }
            }

            if(OperatingSystem.IsMacOS())
            {
                var prepare = "cmake .. -DBUILD_SHARED_LIBS=ON";
                var build = $"cmake --build . --config Release{JobsArg}";

                InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=x86_64", x64BuildDir).AssertZeroExitCode();
                InheritedShell(build, x64BuildDir).AssertZeroExitCode();

                InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=arm64", ARM64BuildDir).AssertZeroExitCode();
                InheritedShell(build, ARM64BuildDir).AssertZeroExitCode();

                CopyAs(x64BuildDir, "**/*.dylib", runtimes / "osx-x64" / "native" / "libSDL2-2.0.dylib");
                CopyAs(ARM64BuildDir, "**/*.dylib", runtimes / "osx-arm64" / "native" / "libSDL2-2.0.dylib");
            }

            PrUpdatedNativeBinary("SDL2");
        }
        )
    );
}
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

partial class Build
{
    AbsolutePath SDL2Path => RootDirectory / "build" / "submodules" / "SDL";

    static readonly (string Sdk, string Arch, string Rid, string Args)[] iPhoneConfigs = new[]
    {
        // NB: Xcode has forced us to stop support for i386 archs
        // NB: Xcode has forced us to stop support for iPhone 5 and below (armv7, armv7s)
        ("iphonesimulator", "x86_64", "iossimulator", "-target \"Static Library-iOS\""),
        ("iphonesimulator", "arm64", "iossimulator", "-target \"Static Library-iOS\""),
        ("iphoneos", "arm64", "ios", "-target \"Static Library-iOS\""),
        ("iphoneos", "arm64e", "ios", "-target \"Static Library-iOS\""),
        ("appletvsimulator", "x86_64", "tvossimulator", "-target \"Static Library-tvOS\""),
        ("appletvsimulator", "arm64", "tvossimulator", "-target \"Static Library-tvOS\""),
        ("appletvos", "arm64", "tvos", "-target \"Static Library-tvOS\""),
        ("appletvos", "arm64e", "tvos", "-target \"Static Library-tvOS\""),
        ("macosx", "x86_64", "osx", "-target \"Shared Library\""),
        ("macosx", "arm64", "osx", "-target \"Shared Library\""),
        // TODO figure out how to compile for Mac Catalyst
        //("macosx", "x86_64", "maccatalyst", "-target \"Shared Library-iOS\" -destination \"platform=macOS,variant=Mac Catalyst\""),
        //("macosx", "arm64", "maccatalyst", "-target \"Shared Library-iOS\" -destination \"platform=macOS,variant=Mac Catalyst\""),
    };

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

            if (OperatingSystem.IsWindows())
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

            if (OperatingSystem.IsLinux())
            {
                if (RuntimeInformation.OSArchitecture == Architecture.Arm64)
                {
                    InheritedShell("cmake ..", x86BuildDir).AssertZeroExitCode();
                    InheritedShell("cmake --build .", x86BuildDir).AssertZeroExitCode();

                    CopyFile(ARM64BuildDir.GlobFiles("libSDL2-2.0.so*").First(), runtimes / "linux-arm64" / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
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

            if (OperatingSystem.IsMacOS())
            {
                // iOS build/hackery ported from https://github.com/Ultz/SDL-Xamarin.iOS
                var mainH = File.ReadAllText(SDL2Path / "include" / "SDL_main.h");
                try
                {
                    File.WriteAllText(SDL2Path / "include" / "SDL_main.h", $"#define SDL_MAIN_HANDLED\n{mainH}");
                    EnsureCleanDirectory(SDL2Path / "allbuild");
                    foreach (var (sdk, arch, rid, args) in iPhoneConfigs)
                    {
                        InheritedShell($"xcodebuild -project SDL.xcodeproj {args} -sdk {sdk} -arch {arch} -configuration Release clean build -jobs {Jobs}", SDL2Path / "XCode" / "SDL")
                            .AssertZeroExitCode();
                        var ext = rid is "maccatalyst" or "osx" ? "dylib" : "a";
                        var cfg = rid is "maccatalyst" or "osx" ? "Release" : $"Release-{sdk}";
                        CopyFile(SDL2Path / "XCode" / "SDL" / "build" / cfg / $"libSDL2.{ext}", SDL2Path / "allbuild" / $"libSDL2.{sdk}.{arch}.{rid}.{ext}");
                    }
                    foreach (var rid in iPhoneConfigs.GroupBy(x => x.Rid))
                    {
                        var ext = rid.Key is "maccatalyst" or "osx" ? "dylib" : "a";
                        var @in = string.Join("\" \"", rid.Select(x => SDL2Path / "allbuild" / $"libSDL2.{x.Sdk}.{x.Arch}.{rid.Key}.{ext}"));
                        var @out = runtimes / rid.Key / "native" / (ext is "dylib" ? "libSDL2-2.0.dylib" : "libSDL2.a");
                        EnsureCleanDirectory(Path.GetDirectoryName(@out));
                        InheritedShell($"lipo -create -output \"{@out}\" \"{@in}\"").AssertZeroExitCode();
                    }
                }
                finally
                {
                    File.WriteAllText(SDL2Path / "include" / "SDL_main.h", mainH);
                }
            }

            PrUpdatedNativeBinary("SDL2");
        }
        )
    );
}
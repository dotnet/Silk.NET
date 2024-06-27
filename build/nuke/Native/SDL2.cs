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

            if (OperatingSystem.IsWindows())
            {
                foreach (var (platform, rid) in new[]
                {
                    ("Win32", "win-x86"),
                    ("x64", "win-x64"),
                    ("ARM64", "win-arm64"),
                })
                {
                    var buildDir = SDL2Path / "build";

                    EnsureCleanDirectory(buildDir);

                    InheritedShell($"cmake .. -A {platform} -DCMAKE_BUILD_TYPE=Release -DBUILD_SHARED_LIBS=ON -DSDL_ASSERTIONS=disabled", buildDir).AssertZeroExitCode();
                    InheritedShell($"cmake --build . --config Release{JobsArg}", buildDir).AssertZeroExitCode();

                    CopyFile(buildDir / "Release" / "SDL2.dll", runtimes / rid / "native" / "SDL2.dll", FileExistsPolicy.Overwrite);
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
                    var buildDir = SDL2Path / "build";

                    EnsureCleanDirectory(buildDir);

                    InheritedShell($"./configure --prefix={buildDir} --disable-static --host={triple} --enable-assertions=disabled --enable-wayland-shared --enable-x11-shared", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"make {JobsArg}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"make install", SDL2Path).AssertZeroExitCode();

                    InheritedShell($"{triple}-strip --strip-unneeded lib/libSDL2-2.0.so*", buildDir).AssertZeroExitCode();

                    CopyFile((buildDir / "lib").GlobFiles("libSDL2-2.0.so*").First(), runtimes / rid / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
                }
            }
            else if (OperatingSystem.IsMacOS())
            {
                // iOS build/hackery ported from https://github.com/Ultz/SDL-Xamarin.iOS

                File.WriteAllText(
                    SDL2Path / "include" / "SDL_main.h",
                    $"#define SDL_MAIN_HANDLED\n{File.ReadAllText(SDL2Path / "include" / "SDL_main.h")}");

                EnsureCleanDirectory(SDL2Path / "allbuild");

                foreach (var (sdk, arch, rid, args) in iPhoneConfigs)
                {
                    InheritedShell($"xcodebuild -project SDL.xcodeproj {args} -sdk {sdk} -arch {arch} -configuration Release clean build -jobs {Jobs}", SDL2Path / "XCode" / "SDL").AssertZeroExitCode();

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
                    InheritedShell($"strip -Sx -no_code_signature_warning \"{@out}\"").AssertZeroExitCode();

                    // Re-sign, as lipo and stripping invalidates the signature
                    InheritedShell($"codesign --remove-signature \"{@out}\"").AssertZeroExitCode();
                    InheritedShell($"codesign --sign - \"{@out}\"").AssertZeroExitCode();
                }
            }

            Git("checkout HEAD include/", SDL2Path);

            PrUpdatedNativeBinary("SDL2");
        }
        )
    );
}

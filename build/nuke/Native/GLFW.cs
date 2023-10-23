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
    AbsolutePath GLFWPath => RootDirectory / "build" / "submodules" / "GLFW";

    Target GLFW => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var @out = GLFWPath / "build";
                    var prepare = "cmake -S. -B build -D BUILD_SHARED_LIBS=ON";
                    var build = $"cmake --build build --config Release{JobsArg}";
                    EnsureCleanDirectory(@out);
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.GLFW.Native" / "runtimes";
                    if (OperatingSystem.IsWindows())
                    {
                        InheritedShell($"{prepare} -A X64", GLFWPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, GLFWPath)
                            .AssertZeroExitCode();
                        
                        CopyAll(@out.GlobFiles("src/Release/glfw3.dll"), runtimes / "win-x64" / "native");

                        EnsureCleanDirectory(@out);

                        InheritedShell($"{prepare} -A Win32", GLFWPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, GLFWPath)
                            .AssertZeroExitCode();

                        CopyAll(@out.GlobFiles("src/Release/glfw3.dll"), runtimes / "win-x86" / "native");
                        
                        EnsureCleanDirectory(@out);
                        
                        InheritedShell($"{prepare} -A arm64", GLFWPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, GLFWPath)
                            .AssertZeroExitCode();

                        CopyAll(@out.GlobFiles("src/Release/glfw3.dll"), runtimes / "win-arm64" / "native");
                    }
                    else if (OperatingSystem.IsLinux())
                    {
                        InheritedShell($"{prepare} -DCMAKE_SYSTEM_PROCESSOR=x86_64", GLFWPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, GLFWPath)
                            .AssertZeroExitCode();
                        CopyAll(@out.GlobFiles("src/libglfw.so"), runtimes / "linux-x64" / "native");
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=x86_64", GLFWPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, GLFWPath)
                            .AssertZeroExitCode();
                        CopyAll(@out.GlobFiles("src/libglfw.3.dylib"), runtimes / "osx-x64" / "native");

                        EnsureCleanDirectory(@out);

                        InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=arm64", GLFWPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, GLFWPath)
                            .AssertZeroExitCode();

                        CopyAll(@out.GlobFiles("src/libglfw.3.dylib"), runtimes / "osx-arm64" / "native");
                    }

                    PrUpdatedNativeBinary("GLFW");
                }
            )
    );
}
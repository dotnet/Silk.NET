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
    AbsolutePath AssimpPath => RootDirectory / "build" / "submodules" / "Assimp";

    Target Assimp => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var @out = AssimpPath / "build";
                    var prepare = "cmake -S. -B build -D BUILD_SHARED_LIBS=ON";
                    var build = $"cmake --build build --config Release{JobsArg}";
                    EnsureCleanDirectory(@out);
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Assimp.Native" / "runtimes";
                    if (OperatingSystem.IsWindows())
                    {
                        InheritedShell($"{prepare} -A X64", AssimpPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, AssimpPath)
                            .AssertZeroExitCode();

                        CopyAs(@out, "bin/Release/assimp-*-mt.dll", runtimes / "win-x64" / "native" / "Assimp64.dll");
                        EnsureCleanDirectory(@out);

                        InheritedShell($"{prepare} -A Win32", AssimpPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, AssimpPath)
                            .AssertZeroExitCode();

                        CopyAs(@out, "bin/Release/assimp-*-mt.dll", runtimes / "win-x86" / "native" / "Assimp32.dll");
                    }
                    else if (OperatingSystem.IsLinux())
                    {
                        InheritedShell($"{prepare} -DCMAKE_SYSTEM_PROCESSOR=x86_64", AssimpPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, AssimpPath)
                            .AssertZeroExitCode();

                        CopyAll(@out.GlobFiles("bin/libassimp.so.5"), runtimes / "linux-x64" / "native");
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=x86_64", AssimpPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, AssimpPath)
                            .AssertZeroExitCode();
                        CopyAll(@out.GlobFiles("bin/libassimp.5.dylib"), runtimes / "osx-x64" / "native");

                        EnsureCleanDirectory(@out);

                        InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=arm64", AssimpPath)
                            .AssertZeroExitCode();
                        InheritedShell(build, AssimpPath)
                            .AssertZeroExitCode();

                        CopyAll(@out.GlobFiles("bin/libassimp.5.dylib"), runtimes / "osx-arm64" / "native");
                    }

                    PrUpdatedNativeBinary("Assimp");
                }
            )
    );
}
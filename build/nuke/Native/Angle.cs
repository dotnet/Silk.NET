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
    // NOTE: Disabled until space issues are resolved! If you are a user who needs this please submit a PR!

    // AbsolutePath AnglePath => RootDirectory / "build" / "submodules" / "ANGLE";

    // Target Angle => CommonTarget
    // (
    //     x => x.Before(Compile)
    //         .After(Clean)
    //         .Executes
    //         (
    //             () =>
    //             {
    //                 var @out = AnglePath / "out" / "Release";
    //                 EnsureCleanDirectory(@out);
    //                 var zip = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
    //                 var unzip = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
    //                 HttpDownloadFile("https://storage.googleapis.com/chrome-infra/depot_tools.zip", zip);
    //                 UncompressZip(zip, unzip);
    //                 if (OperatingSystem.IsLinux() || OperatingSystem.IsMacOS())
    //                 {
    //                     InheritedShell($"chmod -R 777 \"{unzip}\"");
    //                 }

    //                 AddToPath(unzip);
    //                 if (OperatingSystem.IsWindows())
    //                 {
    //                     Environment.SetEnvironmentVariable("DEPOT_TOOLS_WIN_TOOLCHAIN", "0");
    //                 }

    //                 InheritedShell("python scripts/bootstrap.py", AnglePath).AssertZeroExitCode();
    //                 InheritedShell("gclient sync", AnglePath).AssertZeroExitCode();
    //                 if (OperatingSystem.IsLinux())
    //                 {
    //                     InheritedShell("sudo ./build/install-build-deps.sh", AnglePath).AssertZeroExitCode();
    //                 }

    //                 var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.OpenGLES.ANGLE.Native" / "runtimes";
    //                 if (OperatingSystem.IsWindows())
    //                 {
    //                     InheritedShell
    //                         (
    //                             "gn gen out/Release " +
    //                             "--args='is_component_build=false target_cpu=\"\"x86\"\" is_debug=false'",
    //                             AnglePath
    //                         )
    //                         .AssertZeroExitCode();
    //                     InheritedShell($"autoninja -C \"{@out}\"", AnglePath).AssertZeroExitCode();
    //                     CopyAll
    //                     (
    //                         // libANGLE might not exist, this is fine
    //                         @out.GlobFiles("libGLESv2.dll", "libEGL.dll", "libANGLE.dll"),
    //                         runtimes / "win-x64" / "native"
    //                     );
    //                     CopyAll
    //                     (
    //                         @out.GlobFiles("libGLESv2.dll", "libEGL.dll", "libANGLE.dll"),
    //                         runtimes / "win-x86" / "native"
    //                     );
    //                 }
    //                 else
    //                 {
    //                     InheritedShell
    //                         (
    //                             $"gn gen \"{@out}\" " +
    //                             "--args=\"is_component_build=false is_debug=false\"",
    //                             AnglePath
    //                         )
    //                         .AssertZeroExitCode();
    //                     InheritedShell($"autoninja -C \"{@out}\"", AnglePath).AssertZeroExitCode();
    //                     CopyAll
    //                     (
    //                         @out.GlobFiles
    //                         (
    //                             "libGLESv2.so", "libEGL.so", "libANGLE.so",
    //                             "libGLESv2.dylib", "libEGL.dylib", "libANGLE.dylib"
    //                         ),
    //                         runtimes / (OperatingSystem.IsMacOS() ? "osx-x64" : "linux-x64") / "native"
    //                     );
    //                 }

    //                 PrUpdatedNativeBinary("ANGLE");
    //             }
    //         )
    // );
}
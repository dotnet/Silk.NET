// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;

partial class Build {
    // NOTE: Enabled only on MacOS until space issues are resolved! If you are a user who needs this please submit a PR!

    Target Angle => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var tempDir = (AbsolutePath)Directory.CreateTempSubdirectory("silkDotNetAngleBuild").FullName;
                    InheritedShell($"git clone --depth 1 --single-branch https://chromium.googlesource.com/chromium/tools/depot_tools.git", tempDir).AssertZeroExitCode();
                    AddToPath(tempDir / "depot_tools");

                    if (OperatingSystem.IsWindows())
                    {
                        Environment.SetEnvironmentVariable("DEPOT_TOOLS_WIN_TOOLCHAIN", "0");
                    }

                    var angleSourceDir = tempDir / "angle_source";
                    EnsureCleanDirectory(angleSourceDir);
                    InheritedShell("fetch --no-history angle", angleSourceDir).AssertZeroExitCode();

                    // save space
                    // DeleteDirectory takes too long (it deletes individual files)
                    Directory.Delete(angleSourceDir / "third_party"/ "VK-GL-CTS", true); // this is only possible because we disable tests below
                    Directory.Delete(angleSourceDir / "third_party"/ "dawn", true); // this is only possible because we disable wgpu below
                    (angleSourceDir / "third_party").GlobDirectories("*.git").ForEach(DeleteDirectory);
                    
                    if (OperatingSystem.IsLinux())
                    {
                        InheritedShell("sudo ./build/install-build-deps.sh", angleSourceDir).AssertZeroExitCode();
                    }

                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.OpenGLES.ANGLE.Native" / "runtimes";
                    // if (OperatingSystem.IsWindows())
                    // {
                    //     var @out = angleSourceDir / "out" / "Release";
                    //     EnsureCleanDirectory(@out);
                    //     InheritedShell
                    //         (
                    //             "gn gen out/Release " +
                    //             "--args='is_component_build=false target_cpu=\"\"x86\"\" is_debug=false'",
                    //             angleSourceDir
                    //         )
                    //         .AssertZeroExitCode();
                    //     InheritedShell($"autoninja -C \"{@out}\"", angleSourceDir).AssertZeroExitCode();
                    //     CopyAll
                    //     (
                    //         // libANGLE might not exist, this is fine
                    //         @out.GlobFiles("libGLESv2.dll", "libEGL.dll", "libANGLE.dll"),
                    //         runtimes / "win-x64" / "native"
                    //     );
                    //     CopyAll
                    //     (
                    //         @out.GlobFiles("libGLESv2.dll", "libEGL.dll", "libANGLE.dll"),
                    //         runtimes / "win-x86" / "native"
                    //     );
                    // }
                    // else
                        if (OperatingSystem.IsMacOS())
                    {
                        foreach (var arch in new [] { "arm64", "x64" })
                        {
                            var @out = angleSourceDir / "out" / $"Release_{arch}";
                            EnsureCleanDirectory(@out);
                            var args = new[]
                            {
                                ("target_cpu", $"\"{arch}\""),
                                ("is_debug", "false"),
                                // ("angle_assert_always_on", "true"),
                                ("angle_build_tests", "false"),
                                ("angle_enable_null", "false"),
                                ("angle_enable_vulkan", "false"),
                                ("angle_enable_wgpu", "false"),
                                // ("angle_enable_abseil", "false"),
                                ("angle_enable_gl", "false"),
                            };
                            InheritedShell
                                (
                                    $"gn gen \"{@out}\" --args='{string.Join(" ", args.Select(arg => $"{arg.Item1} = {arg.Item2}"))}'",
                                    angleSourceDir
                                )
                                .AssertZeroExitCode();
                            InheritedShell($"autoninja -C \"{@out}\"", angleSourceDir).AssertZeroExitCode();
                        }
                        
                        // create universal mac binaries
                        var universalNativeRuntimes = runtimes / "osx" / "native";
                        EnsureCleanDirectory(universalNativeRuntimes);
                        foreach (var lib in new[] { "libGLESv2.dylib", "libEGL.dylib" })
                        {
                            var x64Lib = angleSourceDir / "out" / "Release_x64" / lib;
                            var arm64Lib = angleSourceDir / "out" / "Release_arm64" / lib;
                            InheritedShell
                                (
                                    $"lipo -create \"{arm64Lib}\" \"{x64Lib}\" -output \"{universalNativeRuntimes / lib}\"",
                                    angleSourceDir
                                )
                                .AssertZeroExitCode();
                        }
                    }
                    // else
                    //     if (OperatingSystem.IsLinux())
                    // {
                    //     var @out = angleSourceDir / "out" / "Release";
                    //     EnsureCleanDirectory(@out);
                    //     InheritedShell
                    //         (
                    //             $"gn gen \"{@out}\" " +
                    //             "--args=\"is_component_build=false is_debug=false\"",
                    //             angleSourceDir
                    //         )
                    //         .AssertZeroExitCode();
                    //     InheritedShell($"autoninja -C \"{@out}\"", angleSourceDir).AssertZeroExitCode();
                    //     CopyAll
                    //     (
                    //         @out.GlobFiles
                    //         (
                    //             "libGLESv2.so", "libEGL.so", "libANGLE.so"
                    //         ),
                    //         runtimes / "linux-x64" / "native"
                    //     );
                    // }

                    PrUpdatedNativeBinary("ANGLE");
                }
            )
    );
}

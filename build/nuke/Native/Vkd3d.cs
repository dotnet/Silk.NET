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
    AbsolutePath Vkd3dPath => RootDirectory / "build" / "submodules" / "vkd3d";
    AbsolutePath SPIRVToolsPath => RootDirectory / "build" / "submodules" / "SPIRV-Tools";
    AbsolutePath VulkanHeadersPath => RootDirectory / "build" / "submodules" / "Vulkan-Headers";

    Target Vkd3d => CommonTarget
        (
            x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        throw new PlatformNotSupportedException("This task only runs on Linux!");
                    }

                    InheritedShell($"./git-sync-deps", SPIRVToolsPath / "utils").AssertZeroExitCode();

                    // Get rid of the Vulkan library check since we will not be needing it.
                    File.WriteAllText(
                        Vkd3dPath / "configure.ac",
                        File.ReadAllText(Vkd3dPath / "configure.ac")
                            .Replace("[VKD3D_CHECK_VULKAN]", "[]"));

                    InheritedShell($"./autogen.sh", Vkd3dPath).AssertZeroExitCode();

                    var spirvToolsBuild = SPIRVToolsPath / "build";
                    var vkd3dBuild = Vkd3dPath / "build";
                    var vkd3dShaderCompiler = RootDirectory / "src" / "Microsoft" / "Vkd3dCompiler";
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vkd3d.Native" / "runtimes";

                    foreach (var (triple, rid) in new[]
                    {
                        ("x86_64-linux-gnu", "linux-x64"),
                        ("arm-linux-gnueabihf", "linux-arm"),
                        ("aarch64-linux-gnu", "linux-arm64"),
                    })
                    {
                        // SPIRV-Tools
                        {
                            EnsureCleanDirectory(spirvToolsBuild);

                            InheritedShell($"cmake .. -DCMAKE_BUILD_TYPE=Release -DBUILD_SHARED_LIBS=ON -DSPIRV_SKIP_EXECUTABLES=ON {GetCMakeToolchainFlag(triple)}", spirvToolsBuild).AssertZeroExitCode();
                            InheritedShell($"cmake --build . --config Release{JobsArg}", spirvToolsBuild).AssertZeroExitCode();

                            InheritedShell($"{triple}-strip --strip-unneeded source/libSPIRV-Tools-shared.so", spirvToolsBuild).AssertZeroExitCode();

                            CopyFile(spirvToolsBuild / "source" / "libSPIRV-Tools-shared.so", runtimes / rid / "native" / "libSPIRV-Tools-shared.so", FileExistsPolicy.Overwrite);
                            CopyFile(spirvToolsBuild / "source" / "libSPIRV-Tools-shared.so", vkd3dShaderCompiler / "libSPIRV-Tools-shared.so", FileExistsPolicy.Overwrite);
                        }

                        // Vkd3d
                        {
                            EnsureCleanDirectory(vkd3dBuild);

                            // We only need to configure Vkd3d; we include its sources directly.
                            InheritedShell($"./configure --prefix={vkd3dBuild} --disable-static --host={triple} --disable-tests --disable-doxygen-doc --with-spirv-tools WIDL=x86_64-w64-mingw32-widl CPPFLAGS=\"-I {VulkanHeadersPath / "include"} -I {SPIRVToolsPath / "external" / "spirv-headers" / "include"} -DNDEBUG -DVKD3D_NO_DEBUG_MESSAGES -DVKD3D_NO_TRACE_MESSAGES\" PKG_CONFIG_PATH={spirvToolsBuild}", Vkd3dPath).AssertZeroExitCode();

                            // Invoke widl for some headers that we need.
                            foreach (var name in new[]
                            {
                                "vkd3d_d3d12",
                                "vkd3d_d3d12sdklayers",
                                "vkd3d_d3dcommon",
                                "vkd3d_dxgibase",
                                "vkd3d_dxgiformat",
                            })
                            {
                                InheritedShell($"make include/{name}.h", Vkd3dPath).AssertZeroExitCode();
                            }
                        }

                        // d3dcompile_vkd3d
                        {
                            // Note that the glibc version should match the one used to build SPIRV-Tools. Since we
                            // currently build on Ubuntu 22.04, that's glibc 2.35.
                            InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget={triple}.2.35 --verbose", vkd3dShaderCompiler).AssertZeroExitCode();

                            CopyFile(vkd3dShaderCompiler / "zig-out" / "lib" / "libd3dcompile_vkd3d.so", runtimes / rid / "native" / "libd3dcompile_vkd3d.so", FileExistsPolicy.Overwrite);
                        }
                    }

                    Git("checkout HEAD configure.ac", Vkd3dPath);

                    PrUpdatedNativeBinary("Vkd3d");
                }
            )
        );
}

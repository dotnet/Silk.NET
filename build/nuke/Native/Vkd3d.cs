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

    Target Vkd3d => CommonTarget
        (
            x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    if(!RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        throw new PlatformNotSupportedException("This task only runs on Linux!");
                    }

                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vkd3d.Native" / "runtimes";

                    var vkd3dBuild = SPIRVToolsPath / "build";
                    EnsureCleanDirectory(vkd3dBuild);

                    { //SPIRV-Tools
                        //Sync the external deps
                        InheritedShell($"./git-sync-deps", SPIRVToolsPath / "utils").AssertZeroExitCode();

                        //Make the build scripts, with shared libs enabled, and tests disabled
                        InheritedShell($"cmake .. -DBUILD_SHARED_LIBS=1 -DSPIRV_SKIP_TESTS=ON", vkd3dBuild).AssertZeroExitCode();

                        //Compile SPIRV-Tools
                        InheritedShell($"cmake --build . --config Release {JobsArg}", vkd3dBuild).AssertZeroExitCode();

                        //Run `strip -g` on the shared library file to remove debug info and shrink it from ~30mb down to only ~5.5mb
                        InheritedShell($"strip -g libSPIRV-Tools-shared.so", vkd3dBuild / "source").AssertZeroExitCode();

                        //Copy the resulting SPIRV-Tools shared library to the runtimes folder
                        CopyFile(vkd3dBuild / "source" / "libSPIRV-Tools-shared.so", runtimes / "linux-x64" / "native" / "libSPIRV-Tools-shared.so", FileExistsPolicy.Overwrite);
                    }

                    { //Vkd3d
                        var dest = Vkd3dPath / "dest";
                        var @out = Vkd3dPath / "build";

                        EnsureCleanDirectory(@out);
                        EnsureCleanDirectory(dest);

                        //Run autogen
                        InheritedShell($"./autogen.sh", Vkd3dPath).AssertZeroExitCode();
                        //Run configure to make a non-debug build, with no trace messages, with a prefix of /usr and with spirv-tools
                        InheritedShell($"./configure CPPFLAGS=\"-DNDEBUG -DVKD3D_NO_TRACE_MESSAGES -fPIC\" --prefix=/usr --with-spirv-tools --disable-doxygen-pdf", Vkd3dPath).AssertZeroExitCode();
                        //Build vkd3d
                        InheritedShell($"make {JobsArg}", Vkd3dPath).AssertZeroExitCode();
                        //Install vkd3d to the dest folder
                        InheritedShell($"make DESTDIR=\"{Vkd3dPath.ToString().TrimEnd('/')}/dest\" install", Vkd3dPath).AssertZeroExitCode();

                        var vkd3dShaderCompiler = RootDirectory / "src" / "Microsoft" / "Vkd3dCompiler";

                        //Copy libvkd3d-shader.a
                        CopyFile(@dest / "usr" / "lib" / "libvkd3d-shader.a", vkd3dShaderCompiler / "libvkd3d-shader.a");
                        //Copy libvkd3d-shader.la
                        CopyFile(@dest / "usr" / "lib" / "libvkd3d-shader.la", vkd3dShaderCompiler / "libvkd3d-shader.la");
                        //Copy libSPIRV-Tools-shared.so
                        CopyFile(vkd3dBuild / "source" / "libSPIRV-Tools-shared.so", vkd3dShaderCompiler / "libSPIRV-Tools-shared.so");

                        //Build the shader compiler
                        InheritedShell($"zig build -Doptimize=ReleaseFast -Dtarget=x86_64-linux-gnu --verbose", vkd3dShaderCompiler).AssertZeroExitCode();

                        //Copy the resulting shader compiler to the native output
                        CopyFile(vkd3dShaderCompiler / "zig-out" / "lib" / "libd3dcompile_vkd3d.so", runtimes / "linux-x64" / "native" / "libd3dcompile_vkd3d.so", FileExistsPolicy.Overwrite);
                    }

                    PrUpdatedNativeBinary("Vkd3d");
                }
            )
        );
}

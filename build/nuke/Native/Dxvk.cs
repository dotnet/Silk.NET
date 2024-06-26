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
    AbsolutePath DxvkPath => RootDirectory / "build" / "submodules" / "dxvk";

    Target Dxvk => CommonTarget
    (
        x => x.Before(Compile)
              .After(Clean)
              .Executes
               (
                   () =>
                   {
                       if (!OperatingSystem.IsLinux())
                       {
                           throw new Exception("This task can only run under Linux!");
                       }
                       
                       var @out    = DxvkPath / "output";
                       var glfwOut = DxvkPath / "glfw-output";
                       EnsureCleanDirectory(@out);
                       EnsureCleanDirectory(glfwOut);
                       
                       InheritedShell
                           (
                               $"./package-release.sh master output --no-package",
                               DxvkPath
                           )
                          .AssertZeroExitCode();
                       
                       var win32GlfwLibs = @out.GlobFiles("dxvk-master/x32/*");
                       
                       foreach (var lib in win32GlfwLibs)
                       {
                           var fileName = Path.GetFileName(lib);
                           RenameFile(lib.Parent / fileName, lib.Parent / "dxvk-" + fileName);
                       }
                       
                       var win64GlfwLibs = @out.GlobFiles("dxvk-master/x64/*");
                       
                       foreach (var lib in win64GlfwLibs)
                       {
                           var fileName = Path.GetFileName(lib);
                           RenameFile(lib.Parent / fileName, lib.Parent / "dxvk-" + fileName);
                       }

                       InheritedShell
                           (
                               $"./package-native.sh master output --no-package",
                               DxvkPath
                           )
                          .AssertZeroExitCode();

                       var mesonOptionsPath = Path.Combine(DxvkPath, "meson_options.txt");
                       
                       //Replace `sdl2` with `glfw` in the meson options file, to build with GLFW WSI instead of SDL2 WSI
                       File.WriteAllText(mesonOptionsPath, File.ReadAllText(mesonOptionsPath).Replace("sdl2", "glfw"));
                       InheritedShell
                           (
                               $"./package-native.sh master glfw-output --no-package",
                               DxvkPath
                           )
                          .AssertZeroExitCode();
                       
                       var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.DXVK.Native" / "runtimes";
                       
                       //Copy the windows binaries
                       CopyAll(@out.GlobFiles("dxvk-master/x64/*"), runtimes / "win-x64" / "native");
                       CopyAll(@out.GlobFiles("dxvk-master/x32/*"), runtimes / "win-x86" / "native");

                       var linux64SdlLibs = @out.GlobFiles("dxvk-native-master/usr/lib/*");
                       
                       foreach (var lib in linux64SdlLibs)
                       {
                           var fileName = Path.GetFileName(lib);
                           RenameFile(lib.Parent / fileName, lib.Parent / "sdl2-" + fileName);
                       }
                       
                       var linux64GlfwLibs = glfwOut.GlobFiles("dxvk-native-master/usr/lib/*");
                       
                       foreach (var lib in linux64GlfwLibs)
                       {
                           var fileName = Path.GetFileName(lib);
                           RenameFile(lib.Parent / fileName, lib.Parent / "glfw-" + fileName);
                       }
                       
                       var linux32SdlLibs = @out.GlobFiles("dxvk-native-master/usr/lib32/*");
                       
                       foreach (var lib in linux32SdlLibs)
                       {
                           var fileName = Path.GetFileName(lib);
                           RenameFile(lib.Parent / fileName, lib.Parent / "sdl2-" + fileName);
                       }
                       
                       var linux32GlfwLibs = glfwOut.GlobFiles("dxvk-native-master/usr/lib32/*");
                       
                       foreach (var lib in linux32GlfwLibs)
                       {
                           var fileName = Path.GetFileName(lib);
                           RenameFile(lib.Parent / fileName, lib.Parent / "glfw-" + fileName);
                       }

                       //Copy the linux SDL binaries
                       CopyAll(@out.GlobFiles("dxvk-native-master/usr/lib/*"), runtimes   / "linux-x64" / "native");
                       CopyAll(@out.GlobFiles("dxvk-native-master/usr/lib32/*"), runtimes / "linux-x86" / "native");

                       //Copy the linux GLFW binaries
                       CopyAll(glfwOut.GlobFiles("dxvk-native-master/usr/lib/*"), runtimes   / "linux-x64" / "native");
                       CopyAll(glfwOut.GlobFiles("dxvk-native-master/usr/lib32/*"), runtimes / "linux-x86" / "native");

                       PrUpdatedNativeBinary("DXVK");
                   }
               )
    );
}

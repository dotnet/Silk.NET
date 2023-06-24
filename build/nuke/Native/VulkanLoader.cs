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
    AbsolutePath VulkanLoaderPath => RootDirectory / "build" / "submodules" / "Vulkan-Loader";

    Target VulkanLoader => CommonTarget
    (
        x => x.Before(Compile)
              .After(Clean)
              .Executes
               (
                   () =>
                   {
                       var @out = VulkanLoaderPath / "build";
                       EnsureCleanDirectory(@out);
                       var abi = OperatingSystem.IsWindows() ? " -DCMAKE_GENERATOR_PLATFORM=Win32" : string.Empty;
                       InheritedShell
                           (
                               $"cmake -S. -Bbuild -DUPDATE_DEPS=On -DCMAKE_BUILD_TYPE=Release{abi}",
                               VulkanLoaderPath
                           )
                          .AssertZeroExitCode();
                       InheritedShell($"cmake --build build --config Release{JobsArg}", VulkanLoaderPath)
                          .AssertZeroExitCode();
                       var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vulkan.Loader.Native" / "runtimes";
                       if (OperatingSystem.IsWindows())
                       {
                           CopyAll(@out.GlobFiles("loader/Release/vulkan-1.dll"), runtimes / "win-x64" / "native");
                           CopyAll(@out.GlobFiles("loader/Release/vulkan-1.dll"), runtimes / "win-x86" / "native");
                       }
                       else
                       {
                           CopyAll
                           (
                               @out.GlobFiles("loader/libvulkan.so", "loader/libvulkan.dylib"),
                               runtimes / (OperatingSystem.IsMacOS() ? "osx-x64" : "linux-x64") / "native"
                           );
                       }

                       PrUpdatedNativeBinary("Vulkan Loader");
                   }
               )
    );
}
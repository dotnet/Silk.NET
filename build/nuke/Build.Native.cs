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
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.GitHub.GitHubTasks;

partial class Build
{
    [Nuke.Common.Parameter("Build native code")] readonly bool Native;

    [CanBeNull] string AndroidHomeValue;

    string AndroidHome
    {
        get
        {
            if (AndroidHomeValue is not null)
            {
                return AndroidHomeValue;
            }

            var utils = RootDirectory / "build" / "utilities";
            DotNet($"build \"{utils / "android_probe.proj"}\" /t:GetAndroidJar");
            AndroidHomeValue = (AbsolutePath) File.ReadAllText(utils / "android.jar.gen.txt") / ".." / ".." / "..";
            Logger.Info($"Android Home: {AndroidHomeValue}");
            return AndroidHomeValue;
        }
    }

    Target BuildLibSilkDroid => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    if (!Native)
                    {
                        Logger.Warn("Skipping gradlew build as the --native parameter has not been specified.");
                        return Enumerable.Empty<Output>();
                    }

                    var sdl = RootDirectory / "build" / "submodules" / "SDL";
                    var silkDroid = SourceDirectory / "Windowing" / "SilkDroid";
                    var xcopy = new (string, string)[]
                    {
                        (sdl / "android-project" / "app" / "src" / "main" / "java",
                            silkDroid / "app" / "src" / "main" / "java"),
                        (sdl, silkDroid / "app" / "jni" / "SDL2")
                    };

                    foreach (var (from, to) in xcopy)
                    {
                        if (!Directory.Exists(from))
                        {
                            ControlFlow.Fail
                                ($"\"{from}\" does not exist (did you forget to recursively clone the repo?)");
                        }

                        CopyDirectoryRecursively(from, to, DirectoryExistsPolicy.Merge, FileExistsPolicy.Overwrite);
                    }

                    var envVars = Environment.GetEnvironmentVariables()
                        .Cast<DictionaryEntry>()
                        .ToDictionary(x => (string) x.Key, x => (string) x.Value);
                    envVars["ANDROID_HOME"] = AndroidHome;

                    foreach (var ndk in Directory.GetDirectories((AbsolutePath) AndroidHome / "ndk")
                                 .OrderByDescending(x => Version.Parse(Path.GetFileName(x))))
                    {
                        envVars["ANDROID_NDK_HOME"] = ndk;
                    }

                    using var process = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                        ? StartProcess("bash", "-c \"./gradlew build\"", silkDroid, envVars)
                        : StartProcess("cmd", "/c \".\\gradlew build\"", silkDroid, envVars);
                    process.AssertZeroExitCode();
                    var ret = process.Output;
                    CopyFile
                    (
                        silkDroid / "app" / "build" / "outputs" / "aar" / "app-release.aar",
                        SourceDirectory / "Windowing" / "Silk.NET.Windowing.Sdl" / "Android" / "app-release.aar",
                        FileExistsPolicy.Overwrite
                    );
                    return ret;
                }
            )
    );

    AbsolutePath SwiftShaderBuildPath => RootDirectory / "build" / "submodules" / "SwiftShader" / "build";
    Target SwiftShader => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var sysName = OperatingSystem.IsLinux() ? "Linux" :
                        OperatingSystem.IsWindows() ? "Windows" :
                        OperatingSystem.IsMacOS() ? "Darwin" : throw new PlatformNotSupportedException();
                    DeleteDirectory(SwiftShaderBuildPath);
                    Git("checkout HEAD build/", SwiftShaderBuildPath / "..");
                    StartProcess("cmake", ".. -DCMAKE_BUILD_TYPE=MinSizeRel", SwiftShaderBuildPath)
                        .AssertZeroExitCode();
                    StartProcess("cmake", "--build . --parallel --config Release", SwiftShaderBuildPath)
                        .AssertWaitForExit(); // might fail... as long as the output exists we're happy
                    var fname = sysName switch
                    {
                        "Linux" => "libvk_swiftshader.so",
                        "Windows" => "vk_swiftshader.dll",
                        "Darwin" => "libvk_swiftshader.dylib",
                        _ => throw new("what")
                    };

                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vulkan.SwiftShader.Native" / "runtimes";
                    var outputPath = SwiftShaderBuildPath / sysName;
                    const string icd = "vk_swiftshader_icd.json";
                    if (OperatingSystem.IsWindows())
                    {
                        CopyFile(outputPath / fname, runtimes / "win-x64" / "native" / fname); // we'll use WOW64
                        CopyFile(outputPath / fname, runtimes / "win-x86" / "native" / fname);
                        CopyFile(outputPath / icd, runtimes / "win-x64" / "native" / icd);
                        CopyFile(outputPath / icd, runtimes / "win-x86" / "native" / icd);
                    }
                    else if (OperatingSystem.IsLinux())
                    {
                        CopyFile(outputPath / fname, runtimes / "linux-x64" / "native" / fname);
                        CopyFile(outputPath / icd, runtimes / "linux-x64" / "native" / icd);
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        CopyFile(outputPath / fname, runtimes / "osx-x64" / "native" / fname);
                        CopyFile(outputPath / icd, runtimes / "osx-x64" / "native" / icd);
                    }

                    var pushableToken = EnvironmentInfo.GetVariable<string>("PUSHABLE_GITHUB_TOKEN");
                    var curBranch = GitCurrentBranch(RootDirectory);
                    if (GitHubActions.Instance.GitHubRepository == "dotnet/Silk.NET" &&
                        !string.IsNullOrWhiteSpace(pushableToken) &&
                        curBranch != "HEAD" &&
                        !string.IsNullOrWhiteSpace(curBranch))
                    {
                        Git
                        (
                            $"remote set-url origin https://silkdotnet:{pushableToken}@github.com/dotnet/Silk.NET",
                            RootDirectory
                        );
                        Git("fetch --all", RootDirectory);
                        Git("add src/Native", RootDirectory);
                        Logger.Info("Checking for existing branch...");
                        var newBranch = $"ci/{curBranch}/swiftshader_bins";
                        var exists = StartProcess("git", $"checkout \"{newBranch}\"", RootDirectory)
                            .AssertWaitForExit()
                            .ExitCode == 0;
                        if (!exists)
                        {
                            Git($"checkout -b \"{newBranch}\"");
                        }

                        var curCommit = GitCurrentCommit(RootDirectory);
                        Git($"commit -m \"New binaries for SwiftShader on {sysName}\"");
                        if (GitCurrentCommit(RootDirectory) != curCommit)
                        {
                            Git($"push --set-upstream origin \"{newBranch}\"");
                            if (!exists)
                            {
                                var github = new GitHubClient
                                (
                                    new ProductHeaderValue("Silk.NET-CI"),
                                    new InMemoryCredentialStore(new Credentials(pushableToken))
                                );

                                var pr = github.PullRequest.Create
                                        ("dotnet", "Silk.NET", new("Update SwiftShader binaries", newBranch, curBranch))
                                    .GetAwaiter()
                                    .GetResult();
                            }
                        }
                    }
                }
            )
    );
}

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
    [Nuke.Common.Parameter("Build native code")] readonly bool Native;

    [CanBeNull] string AndroidHomeValue;

    static string JobsArg => string.IsNullOrWhiteSpace(GitHubActions.Instance?.Job)
        ? $" -j{Environment.ProcessorCount}"
        : string.Empty;

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

                    var envVars = CreateEnvVarDictionary();
                    envVars["ANDROID_HOME"] = AndroidHome;

                    foreach (var ndk in Directory.GetDirectories((AbsolutePath) AndroidHome / "ndk")
                                 .OrderByDescending(x => Version.Parse(Path.GetFileName(x))))
                    {
                        envVars["ANDROID_NDK_HOME"] = ndk;
                    }

                    using var process = StartShell($".{Path.PathSeparator}gradlew build", silkDroid, envVars);
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
                    StartProcess("cmake", ".. -DCMAKE_BUILD_TYPE=Release", SwiftShaderBuildPath)
                        .AssertZeroExitCode();
                    StartProcess("cmake", $"--build .{JobsArg} --config Release", SwiftShaderBuildPath)
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
                        CopyFile
                        (
                            outputPath / fname, runtimes / "win-x64" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        ); // we'll use WOW64
                        CopyFile
                        (
                            outputPath / fname, runtimes / "win-x86" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "win-x64" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "win-x86" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                    }
                    else if (OperatingSystem.IsLinux())
                    {
                        CopyFile
                        (
                            outputPath / fname, runtimes / "linux-x64" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "linux-x64" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        CopyFile
                        (
                            outputPath / fname, runtimes / "osx-x64" / "native" / fname,
                            FileExistsPolicy.Overwrite
                        );
                        CopyFile
                        (
                            outputPath / icd, runtimes / "osx-x64" / "native" / icd,
                            FileExistsPolicy.Overwrite
                        );
                    }

                    PrUpdatedNativeBinary("SwiftShader");
                }
            )
    );

    AbsolutePath AnglePath => RootDirectory / "build" / "submodules" / "ANGLE";

    Target Angle => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    var @out = AnglePath / "out" / "Release";
                    EnsureCleanDirectory(@out);
                    var zip = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    var unzip = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    HttpDownloadFile("https://storage.googleapis.com/chrome-infra/depot_tools.zip", zip);
                    UncompressZip(zip, unzip);
                    if (OperatingSystem.IsLinux() || OperatingSystem.IsMacOS())
                    {
                        InheritedShell($"chmod -R 777 \"{unzip}\"");
                    }

                    AddToPath(unzip);
                    if (OperatingSystem.IsWindows())
                    {
                        Environment.SetEnvironmentVariable("DEPOT_TOOLS_WIN_TOOLCHAIN", "0");
                    }

                    InheritedShell("python scripts/bootstrap.py", AnglePath).AssertZeroExitCode();
                    InheritedShell("gclient sync", AnglePath).AssertZeroExitCode();
                    if (OperatingSystem.IsLinux())
                    {
                        InheritedShell("sudo ./build/install-build-deps.sh", AnglePath).AssertZeroExitCode();
                    }

                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.OpenGLES.ANGLE.Native" / "runtimes";
                    if (OperatingSystem.IsWindows())
                    {
                        InheritedShell
                            (
                                "gn gen out/Release " +
                                "--args='is_component_build=false target_cpu=\"\"x86\"\" is_debug=false'",
                                AnglePath
                            )
                            .AssertZeroExitCode();
                        InheritedShell($"autoninja -C \"{@out}\"", AnglePath).AssertZeroExitCode();
                        CopyAll
                        (
                            // libANGLE might not exist, this is fine
                            @out.GlobFiles("libGLESv2.dll", "libEGL.dll", "libANGLE.dll"),
                            runtimes / "win-x64" / "native"
                        );
                        CopyAll
                        (
                            @out.GlobFiles("libGLESv2.dll", "libEGL.dll", "libANGLE.dll"),
                            runtimes / "win-x86" / "native"
                        );
                    }
                    else
                    {
                        InheritedShell
                            (
                                $"gn gen \"{@out}\" " +
                                "--args=\"is_component_build=false is_debug=false\"",
                                AnglePath
                            )
                            .AssertZeroExitCode();
                        InheritedShell($"autoninja -C \"{@out}\"", AnglePath).AssertZeroExitCode();
                        CopyAll
                        (
                            @out.GlobFiles
                            (
                                "libGLESv2.so", "libEGL.so", "libANGLE.so",
                                "libGLESv2.dylib", "libEGL.dylib", "libANGLE.dylib"
                            ),
                            runtimes / (OperatingSystem.IsMacOS() ? "osx-x64" : "linux-x64") / "native"
                        );
                    }

                    PrUpdatedNativeBinary("ANGLE");
                }
            )
    );

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
                    var outW32 = VulkanLoaderPath / "buildW32";
                    var outW64 = VulkanLoaderPath / "buildW64";
                    var outA64 = VulkanLoaderPath / "buildA64";
                    EnsureCleanDirectory(outW32);
                    EnsureCleanDirectory(outW64);
                    EnsureCleanDirectory(outA64);
                    
                    var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.Vulkan.Loader.Native" / "runtimes";
                    
                    if (OperatingSystem.IsWindows())
                    {
                        //Build x86
                        InheritedShell
                            (
                                $"cmake -S. -BbuildW32 -DUPDATE_DEPS=On -DCMAKE_BUILD_TYPE=Release -A Win32",
                                VulkanLoaderPath
                            )
                            .AssertZeroExitCode();
                        
                        InheritedShell($"cmake --build buildW32 --config Release{JobsArg}", VulkanLoaderPath)
                            .AssertZeroExitCode();
                        
                        CopyAll(@outW32.GlobFiles("loader/Release/vulkan-1.dll"), runtimes / "win-x86" / "native");

                        File.Delete(VulkanLoaderPath      / "buildW32" / "CMakeCache.txt");
                        Directory.Delete(VulkanLoaderPath / "buildW32" / "CMakeFiles", true);
                        EnsureCleanDirectory(@outW32);

                        //Build x64
                        InheritedShell
                            (
                                $"cmake -S. -BbuildW64 -DUPDATE_DEPS=On -DCMAKE_BUILD_TYPE=Release -A X64",
                                VulkanLoaderPath
                            )
                            .AssertZeroExitCode();
                        
                        InheritedShell($"cmake --build buildW64 --config Release{JobsArg}", VulkanLoaderPath)
                            .AssertZeroExitCode();
                        
                        CopyAll(@outW64.GlobFiles("loader/Release/vulkan-1.dll"), runtimes / "win-x64" / "native");

                        File.Delete(VulkanLoaderPath      / "buildW64" / "CMakeCache.txt");
                        Directory.Delete(VulkanLoaderPath / "buildW64" / "CMakeFiles", true);
                        EnsureCleanDirectory(@outW64);

                        //Build arm64
                        InheritedShell
                            (
                                $"cmake -S. -BbuildA64 -DUPDATE_DEPS=On -DCMAKE_BUILD_TYPE=Release -A arm64",
                                VulkanLoaderPath
                            )
                            .AssertZeroExitCode();
                        
                        InheritedShell($"cmake --build buildA64 --config Release{JobsArg}", VulkanLoaderPath)
                            .AssertZeroExitCode();
                        
                        CopyAll(@outA64.GlobFiles("loader/Release/vulkan-1.dll"), runtimes / "win-arm64" / "native");
                    }
                    else
                    {
                        //Build 
                        InheritedShell
                            (
                                $"cmake -S. -Bbuild -DUPDATE_DEPS=On -DCMAKE_BUILD_TYPE=Release",
                                VulkanLoaderPath
                            )
                            .AssertZeroExitCode();
                        InheritedShell($"cmake --build build --config Release{JobsArg}", VulkanLoaderPath)
                            .AssertZeroExitCode();
                        
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

    AbsolutePath AssimpPath => RootDirectory / "build" / "submodules" / "Assimp";

    Target Assimp => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    void CopyAs(AbsolutePath @out, string from, string to)
                    {
                        var file = @out.GlobFiles(from).First();
                        CopyFile(file, to, FileExistsPolicy.Overwrite);
                    }

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

    void PrUpdatedNativeBinary(string name)
    {
        var pushableToken = EnvironmentInfo.GetVariable<string>("PUSHABLE_GITHUB_TOKEN");
        var curBranch = GitCurrentBranch(RootDirectory);
        if (!string.IsNullOrWhiteSpace(pushableToken) &&
            GitHubActions.Instance?.Repository == "dotnet/Silk.NET" &&
            curBranch != "HEAD" &&
            !string.IsNullOrWhiteSpace(curBranch) &&
            !curBranch.StartsWith("ci/", StringComparison.OrdinalIgnoreCase) && // ignore other CI branches
            !curBranch.StartsWith("main", StringComparison.OrdinalIgnoreCase) && // submodule updates are done in PRs...
            !curBranch.StartsWith("develop/", StringComparison.OrdinalIgnoreCase))
        {
            // it's assumed that the pushable token was used to checkout the repo
            var suffix = string.Empty;
            if (OperatingSystem.IsWindows())
            {
                suffix = "/**/*.dll";
            }
            else if (OperatingSystem.IsMacOS())
            {
                suffix = "/**/*.dylib";
            }
            else if (OperatingSystem.IsLinux())
            {
                suffix = "/**/*.so*";
            }
            
            Git("fetch --all", RootDirectory);
            Git("pull");
            Git($"add src/Native{suffix}", RootDirectory);
            var newBranch = $"ci/{curBranch}/{name.ToLower().Replace(' ', '_')}_bins";
            var curCommit = GitCurrentCommit(RootDirectory);
            var commitCmd = InheritedShell
                (
                    $"git commit -m \"New binaries for {name} on {RuntimeInformation.OSDescription}\""
                )
                .AssertWaitForExit();
            if (!commitCmd.Output.Any(x => x.Text.Contains("nothing to commit", StringComparison.OrdinalIgnoreCase)))
            {
                commitCmd.AssertZeroExitCode();
            }

            // ensure there are no other changes
            Git("checkout HEAD .nuke/", RootDirectory);
            Git("reset --hard", RootDirectory);
            if (GitCurrentCommit(RootDirectory) != curCommit) // might get "nothing to commit", you never know...
            {
                Logger.Info("Checking for existing branch...");
                var exists = StartProcess("git", $"checkout \"{newBranch}\"", RootDirectory)
                    .AssertWaitForExit()
                    .ExitCode == 0;
                if (!exists)
                {
                    Logger.Info("None found, creating a new one...");
                    Git($"checkout -b \"{newBranch}\"");
                }

                Git($"merge -X theirs \"{curBranch}\" --allow-unrelated-histories");
                Git($"push --set-upstream origin \"{newBranch}\"");
                if (!exists)
                {
                    var github = new GitHubClient
                    (
                        new ProductHeaderValue("Silk.NET-CI"),
                        new InMemoryCredentialStore(new Credentials(pushableToken))
                    );

                    var pr = github.PullRequest.Create
                            ("dotnet", "Silk.NET", new($"Update {name} binaries", newBranch, curBranch))
                        .GetAwaiter()
                        .GetResult();
                }
            }
        }
    }
}

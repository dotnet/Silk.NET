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

    void CopyAs(AbsolutePath @out, string from, string to)
    {
        var file = @out.GlobFiles(from).First();
        CopyFile(file, to, FileExistsPolicy.Overwrite);
    }

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


    AbsolutePath WgpuPath => RootDirectory / "build" / "submodules" / "wgpu-native";

    Target Wgpu => CommonTarget
        (
        x => x.Before(Compile)
        .After(Clean)
        .Executes
        (
        () =>
        {
            var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.WebGPU.Native.WGPU" / "runtimes";

            var target = WgpuPath / "target";
            EnsureCleanDirectory(target);

            if(OperatingSystem.IsWindows())
            {
                //Compile Windows libraries
                InheritedShell("cargo build --release --target=i686-pc-windows-msvc", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=x86_64-pc-windows-msvc", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=aarch64-pc-windows-msvc", WgpuPath).AssertZeroExitCode();

                CopyFile(target / "i686-pc-windows-msvc" / "release" / "wgpu_native.dll", runtimes / "win-x86" / "native" / "wgpu_native.dll", FileExistsPolicy.Overwrite);
                CopyFile(target / "x86_64-pc-windows-msvc" / "release" / "wgpu_native.dll", runtimes / "win-x64" / "native" / "wgpu_native.dll", FileExistsPolicy.Overwrite);
                CopyFile(target / "aarch64-pc-windows-msvc" / "release" / "wgpu_native.dll", runtimes / "win-arm64" / "native" / "wgpu_native.dll", FileExistsPolicy.Overwrite);
            }

            if(OperatingSystem.IsLinux())
            {
                //Compile Linux libraries
                InheritedShell("cargo build --release --target=i686-unknown-linux-gnu", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=x86_64-unknown-linux-gnu", WgpuPath).AssertZeroExitCode();

                CopyFile(target / "i686-unknown-linux-gnu" / "release" / "libwgpu_native.so", runtimes / "linux-x86" / "native" / "libwgpu_native.so", FileExistsPolicy.Overwrite);
                CopyFile(target / "x86_64-unknown-linux-gnu" / "release" / "libwgpu_native.so", runtimes / "linux-x64" / "native" / "libwgpu_native.so", FileExistsPolicy.Overwrite);
            }

            if(OperatingSystem.IsMacOS())
            {
                //Compile MacOS libraries
                InheritedShell("cargo build --release --target=aarch64-apple-darwin", WgpuPath).AssertZeroExitCode();
                InheritedShell("cargo build --release --target=x86_64-apple-darwin", WgpuPath).AssertZeroExitCode();

                CopyFile(target / "x86_64-apple-darwin" / "release" / "libwgpu_native.dylib", runtimes / "osx-x64" / "native" / "libwgpu_native.dylib", FileExistsPolicy.Overwrite);
                CopyFile(target / "aarch64-apple-darwin" / "release" / "libwgpu_native.dylib", runtimes / "osx-arm64" / "native" / "libwgpu_native.dylib", FileExistsPolicy.Overwrite);
            }

            PrUpdatedNativeBinary("Wgpu");
        }
        )
        );

    AbsolutePath SDL2Path => RootDirectory / "build" / "submodules" / "SDL";

    Target SDL2 => CommonTarget
        (
        x => x.Before(Compile)
        .After(Clean)
        .Executes
        (
        () =>
        {
            var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.SDL.Native" / "runtimes";

            var x86BuildDir = SDL2Path / "buildx86";
            var x64BuildDir = SDL2Path / "buildx64";
            var ARM64BuildDir = SDL2Path / "buildARM64";
            EnsureCleanDirectory(x86BuildDir);
            EnsureCleanDirectory(x64BuildDir);
            EnsureCleanDirectory(ARM64BuildDir);

            if(OperatingSystem.IsWindows())
            {
                var prepare = "cmake .. -DBUILD_SHARED_LIBS=ON";
                var build = $"cmake --build . --config Release{JobsArg}";

                InheritedShell($"{prepare} -A Win32", x86BuildDir).AssertZeroExitCode();
                InheritedShell(build, x86BuildDir).AssertZeroExitCode();

                InheritedShell($"{prepare} -A X64", x64BuildDir).AssertZeroExitCode();
                InheritedShell(build, x64BuildDir).AssertZeroExitCode();

                InheritedShell($"{prepare} -A arm64", ARM64BuildDir).AssertZeroExitCode();
                InheritedShell(build, ARM64BuildDir).AssertZeroExitCode();

                CopyFile(x86BuildDir / "Release" / "SDL2.dll", runtimes / "win-x86" / "native" / "SDL2.dll", FileExistsPolicy.Overwrite);
                CopyFile(x64BuildDir / "Release" / "SDL2.dll", runtimes / "win-x64" / "native" / "SDL2.dll", FileExistsPolicy.Overwrite);
                CopyFile(ARM64BuildDir / "Release" / "SDL2.dll", runtimes / "win-arm64" / "native" / "SDL2.dll", FileExistsPolicy.Overwrite);
            }

            if(OperatingSystem.IsLinux())
            {
                if(RuntimeInformation.OSArchitecture == Architecture.Arm64) 
                {
                    InheritedShell("cmake ..", x86BuildDir).AssertZeroExitCode();
                    InheritedShell("cmake --build .", x86BuildDir).AssertZeroExitCode();

                    CopyFile(ARM64BuildDir / "libSDL2-2.0.so.0.2600.5", runtimes / "linux-arm64" / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
                } 
                else if (RuntimeInformation.OSArchitecture == Architecture.X64) 
                {
                    var envVars32bit = "CFLAGS='-m32 -O2' CXXFLAGS='-m32 -O2' LDFLAGS=-m32";
                    var envVars64bit = "CFLAGS=-O2 CXXFLAGS=-O2";

                    InheritedShell($"{envVars32bit} ./configure --prefix={x86BuildDir}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"{envVars32bit} make {JobsArg}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"make install", SDL2Path).AssertZeroExitCode();

                    InheritedShell($"{envVars64bit} ./configure --prefix={x64BuildDir}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"{envVars64bit} make {JobsArg}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"make install", SDL2Path).AssertZeroExitCode();

                    //Strip the libraries
                    InheritedShell($"strip {x86BuildDir / "lib" / "libSDL2-2.0.so.0.2600.5"}", SDL2Path).AssertZeroExitCode();
                    InheritedShell($"strip {x64BuildDir / "lib" / "libSDL2-2.0.so.0.2600.5"}", SDL2Path).AssertZeroExitCode();

                    CopyFile(x86BuildDir / "lib" / "libSDL2-2.0.so.0.2600.5", runtimes / "linux-x86" / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
                    CopyFile(x64BuildDir / "lib" / "libSDL2-2.0.so.0.2600.5", runtimes / "linux-x64" / "native" / "libSDL2-2.0.so", FileExistsPolicy.Overwrite);
                } 
                else 
                {
                    throw new Exception($"Unable to build SDL libs on your architecture ({RuntimeInformation.OSArchitecture}).");
                }
            }

            if(OperatingSystem.IsMacOS())
            {
                var prepare = "cmake .. -DBUILD_SHARED_LIBS=ON";
                var build = $"cmake --build . --config Release{JobsArg}";

                InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=x86_64", x64BuildDir).AssertZeroExitCode();
                InheritedShell(build, x64BuildDir).AssertZeroExitCode();

                InheritedShell($"{prepare} -DCMAKE_OSX_ARCHITECTURES=arm64", ARM64BuildDir).AssertZeroExitCode();
                InheritedShell(build, ARM64BuildDir).AssertZeroExitCode();

                CopyAs(x64BuildDir / "bin" / "Release", "libSDL2*.dylib", runtimes / "osx-x64" / "native" / "libSDL2-2.0.dylib");
                CopyAs(ARM64BuildDir / "bin" / "Release", "libSDL2*.dylib", runtimes / "osx-arm64" / "native" / "libSDL2-2.0.dylib");
            }

            PrUpdatedNativeBinary("SDL2");
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
                        //Clone the SPIRV-Headers external repo
                        InheritedShell($"git clone https://github.com/KhronosGroup/SPIRV-Headers.git external/spirv-headers", SPIRVToolsPath).AssertZeroExitCode();

                        //Make the build scripts, with shared libs enabled
                        InheritedShell($"cmake .. -DBUILD_SHARED_LIBS=1", vkd3dBuild).AssertZeroExitCode();

                        //Compile SPIRV-Tools
                        InheritedShell($"cmake --build . --config Release", vkd3dBuild).AssertZeroExitCode();

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
                        InheritedShell($"./configure CPPFLAGS=\"-DNDEBUG -DVKD3D_NO_TRACE_MESSAGES -fPIC\" --prefix=/usr --with-spirv-tools", Vkd3dPath).AssertZeroExitCode();
                        //Build vkd3d
                        InheritedShell($"make -j4", Vkd3dPath).AssertZeroExitCode();
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
                        InheritedShell($"zig build -Doptimize=ReleaseSmall -Dtarget=x86_64-linux-gnu --verbose", vkd3dShaderCompiler).AssertZeroExitCode();

                        //Copy the resulting shader compiler to the native output
                        CopyFile(vkd3dShaderCompiler / "zig-out" / "lib" / "libd3dcompile_vkd3d.so", runtimes / "linux-x64" / "native" / "libd3dcompile_vkd3d.so", FileExistsPolicy.Overwrite);
                    }

                    PrUpdatedNativeBinary("Vkd3d");
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

                       var winx64 = runtimes / "win-x64" / "native";
                       var winx86 = runtimes / "win-x86" / "native";
                       
                       var linuxx64 = runtimes / "linux-x64" / "native";
                       var linuxx86 = runtimes / "linux-x86" / "native";

                       var glob = string.Empty;
                       var files = winx64.GlobFiles("*.dll")
                                         .Concat(winx86.GlobFiles("*.dll"))
                                         .Concat(linuxx64.GlobFiles("*.so"))
                                         .Concat(linuxx86.GlobFiles("*.so"));

                       glob = files.Aggregate(glob, (current, path) => current + $"\"{path}\" ");

                       PrUpdatedNativeBinary
                       (
                           "DXVK", glob
                       );
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

    void PrUpdatedNativeBinary(string name, [CanBeNull] string glob = null)
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
            if (OperatingSystem.IsWindows())
            {
                glob ??= "src/Native/**/*.dll";
            }
            else if (OperatingSystem.IsMacOS())
            {
                glob ??= "src/Native/**/*.dylib";
            }
            else if (OperatingSystem.IsLinux())
            {
                glob ??= "src/Native/**/*.so*";
            }

            Git("fetch --all", RootDirectory);
            Git("pull");
            Git($"add -f {glob}", RootDirectory);
            var newBranch = $"ci/{curBranch}/{name.ToLower().Replace(' ', '_')}_bins";
            var curCommit = GitCurrentCommit(RootDirectory);
            var commitCmd = InheritedShell
                (
                    $"git commit -m \"New binaries for {name} on {RuntimeInformation.OSDescription}\""
                )
                .AssertWaitForExit();
            if (!commitCmd.Output.Any(x => x.Text.Contains("no changes added to commit", StringComparison.OrdinalIgnoreCase) || x.Text.Contains("nothing to commit", StringComparison.OrdinalIgnoreCase)))
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

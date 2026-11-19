#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

Push-Location $PSScriptRoot
try {
  # Config
  $repoRoot = Join-Path $PSScriptRoot "../../.."
  $submodulePath = Join-Path $repoRoot "eng/submodules/sdl"
  $supportedRuntimes = @(
    "android-arm64",
    "android-arm",
    "android-x64",
    "android-x86",
    "ios",
    "iossimulator",
    "linux-arm64",
    "linux-arm",
    "linux-x64",
    "osx",
    "tvos",
    "tvossimulator",
    "win-arm64",
    "win-x64"
  )

  # Inputs
  Write-Host "Supported runtimes: $supportedRuntimes"

  $runtime = ($args.Count -gt 0 -and $args[0]) ? $args[0] : $env:CHOSEN_RUNTIME
  if (-not $runtime) {
    Write-Host "Please choose a runtime by providing it as the first argument or setting the CHOSEN_RUNTIME env var"
    exit 1
  }

  Write-Host "Chosen runtime: $runtime"
  if (-not ($runtime -in $supportedRuntimes)) {
    Write-Host "Unknown runtime: $runtime"
    exit 1
  }

  # CMake
  function Build-CMake {
    Remove-Item -Recurse -Force build -ErrorAction Ignore
    New-Item -ItemType Directory build
    cmake $submodulePath -B build -G Ninja ($args | ForEach-Object { $_ })
    cmake --build build --parallel
  }

  function Get-CMakeSharedArgs { @("-DCMAKE_BUILD_TYPE=Release", "-DSDL_TEST_LIBRARY=OFF") }
  function Get-CMakeAndroidArgs { @("-DANDROID_PLATFORM=21", "-DSDL_ANDROID_JAR=ON", "-DCMAKE_INSTALL_PREFIX=$PWD/build/install") }

  switch ($true) {
    $IsWindows {
      $vsPath = & "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe" -latest -products "*" -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath

      switch ($runtime) {
        "win-arm64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch arm64 -SkipAutomaticLocation
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake"
          New-Item -ItemType Directory -Force runtimes/win-arm64/native
          Copy-Item build/SDL3.dll runtimes/win-arm64/native
        }

        "win-x64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch amd64 -SkipAutomaticLocation
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake"
          New-Item -ItemType Directory -Force runtimes/win-x64/native
          Copy-Item build/SDL3.dll runtimes/win-x64/native
        }
      }
    }

    $IsLinux {
      # Enter Debian container
      if (-not $env:SILKDOTNET_DOCKER) {
        $docker = "docker"
        if (Get-Command podman -ErrorAction Ignore) {
          $docker = "podman"
        }

        $name = "silk-native-$PID"
        try {
          & $docker build -t silkdotnet-builder:latest --platform=linux/amd64 -f $repoRoot/eng/workflows/native/debian/Dockerfile $repoRoot/eng/workflows
          & $docker run --rm --init --name $name -e SILKDOTNET_DOCKER=1 -e CHOSEN_RUNTIME=$runtime -v "${repoRoot}:/data/repo" silkdotnet-builder:latest bash -c "/data/repo/sources/SDL/Native/build.ps1"
        } finally {
          & $docker rm -f $name
        }

        exit 0
      }

      . $repoRoot/eng/workflows/dependencies/initialize-env.ps1

      if ($runtime -like "linux*") {
        $arch = switch ($runtime) {
          "linux-arm64" { "arm64" }
          "linux-arm" { "armhf" }
          "linux-x64" { "amd64" }
          default {
            Write-Host "Unsupported runtime: $runtime"
            exit 1
          }
        }

        # Dependencies
        # From https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
        dpkg --add-architecture $arch
        apt-get update
        apt-get install -y `
          gnome-desktop-testing `
          libglib2.0-dev-bin `
          libasound2-dev:$arch libpulse-dev:$arch `
          libaudio-dev:$arch libfribidi-dev:$arch libjack-dev:$arch libsndio-dev:$arch libx11-dev:$arch libxext-dev:$arch `
          libxrandr-dev:$arch libxcursor-dev:$arch libxfixes-dev:$arch libxi-dev:$arch libxss-dev:$arch libxtst-dev:$arch `
          libxkbcommon-dev:$arch libdrm-dev:$arch libgbm-dev:$arch libgl1-mesa-dev:$arch libgles2-mesa-dev:$arch `
          libegl1-mesa-dev:$arch libdbus-1-dev:$arch libibus-1.0-dev:$arch libudev-dev:$arch libthai-dev:$arch `
          libpipewire-0.3-dev:$arch libwayland-dev:$arch libdecor-0-dev:$arch liburing-dev:$arch
      }

      switch ($runtime) {
        "android-arm64" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-arm64-v8a.cmake"
          cmake --install build
          New-Item -ItemType Directory -Force runtimes/android-arm64/native
          Copy-Item build/install/lib/libSDL3.so runtimes/android-arm64/native
        }

        "android-arm" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-armeabi-v7a.cmake"
          cmake --install build
          New-Item -ItemType Directory -Force runtimes/android-arm/native
          Copy-Item build/install/lib/libSDL3.so runtimes/android-arm/native
        }

        "android-x64" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-x86_64.cmake"
          cmake --install build
          New-Item -ItemType Directory -Force runtimes/android-x64/native, android
          Copy-Item build/install/lib/libSDL3.so runtimes/android-x64/native

          # The jar and proguard files are the same for all 4 Android jobs
          Copy-Item (Get-ChildItem build/install/share/java/SDL3/SDL3-*.jar -Exclude "*-sources.jar") android/SDL3.jar
          Copy-Item build/install/share/java/SDL3/proguard.txt android/proguard.txt
        }

        "android-x86" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-x86.cmake"
          cmake --install build
          New-Item -ItemType Directory -Force runtimes/android-x86/native
          Copy-Item build/install/lib/libSDL3.so runtimes/android-x86/native
        }

        "linux-arm64" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-aarch64-linux-gnu.2.17.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-arm64/native
          Copy-Item build/libSDL3.so runtimes/linux-arm64/native
        }

        "linux-arm" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-arm/native
          Copy-Item build/libSDL3.so runtimes/linux-arm/native
        }

        "linux-x64" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.17.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-x64/native
          Copy-Item build/libSDL3.so runtimes/linux-x64/native
        }
      }
    }

    $IsMacOS {
      switch ($runtime) {
        "ios" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake" "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphoneos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          New-Item -ItemType Directory -Force runtimes/ios/native
          Copy-Item build/libSDL3.a runtimes/ios/native
        }

        "iossimulator" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake" "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphonesimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          New-Item -ItemType Directory -Force runtimes/iossimulator/native
          Copy-Item build/libSDL3.a runtimes/iossimulator/native
        }

        "osx" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake" "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=10.11"
          New-Item -ItemType Directory -Force runtimes/osx/native
          Copy-Item build/libSDL3.dylib runtimes/osx/native
        }

        "tvos" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake" "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          New-Item -ItemType Directory -Force runtimes/tvos/native
          Copy-Item build/libSDL3.a runtimes/tvos/native
        }

        "tvossimulator" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake" "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvsimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          New-Item -ItemType Directory -Force runtimes/tvossimulator/native
          Copy-Item build/libSDL3.a runtimes/tvossimulator/native
        }
      }
    }
  }
} finally {
  Pop-Location
}

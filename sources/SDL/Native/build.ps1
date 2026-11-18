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
    "android",
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
  function cmakeShared { @("-DCMAKE_BUILD_TYPE=Release", "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.17.cmake", "-DSDL_TEST_LIBRARY=OFF") }

  switch ($true) {
    $IsWindows {
      $vsPath = & "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe" -latest -products "*" -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath

      switch ($runtime) {
        "win-arm64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch arm64 -SkipAutomaticLocation
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build -G Ninja $(cmakeShared)
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/win-arm64/native
          Copy-Item build/SDL3.dll runtimes/win-arm64/native
        }

        "win-x64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch amd64 -SkipAutomaticLocation
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build -G Ninja $(cmakeShared)
          cmake --build build --parallel
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
        "android" {
          # Build
          & python3 $submodulePath/build-scripts/build-release.py --actions android --root $submodulePath
          New-Item -ItemType Directory -Force runtimes/android-x86/native, runtimes/android-x64/native, runtimes/android-arm/native, runtimes/android-arm64/native, android
          Copy-Item $submodulePath/install-android/arm64-v8a-install/lib/libSDL3.so runtimes/android-arm64/native
          Copy-Item $submodulePath/install-android/armeabi-v7a-install/lib/libSDL3.so runtimes/android-arm/native
          Copy-Item $submodulePath/install-android/x86-install/lib/libSDL3.so runtimes/android-x86/native
          Copy-Item $submodulePath/install-android/x86_64-install/lib/libSDL3.so runtimes/android-x64/native
          $jars = @(Get-ChildItem $submodulePath/install-android/armeabi-v7a-install/share/java/SDL3/SDL3-*.jar | Sort-Object FullName)
          Copy-Item $jars[0].FullName android/SDL3.jar
          Copy-Item "$(Split-Path -Parent $jars[1].FullName)/proguard.txt" android/proguard.txt
        }

        "linux-arm64" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-aarch64-linux-gnu.2.17.cmake"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/linux-arm64/native
          Copy-Item build/libSDL3.so runtimes/linux-arm64/native
        }

        "linux-arm" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/linux-arm/native
          Copy-Item build/libSDL3.so runtimes/linux-arm/native
        }

        "linux-x64" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.17.cmake"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/linux-x64/native
          Copy-Item build/libSDL3.so runtimes/linux-x64/native
        }
      }
    }

    $IsMacOS {
      switch ($runtime) {
        "ios" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphoneos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/ios/native
          Copy-Item build/libSDL3.a runtimes/ios/native
        }

        "iossimulator" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphonesimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/iossimulator/native
          Copy-Item build/libSDL3.a runtimes/iossimulator/native
        }

        "osx" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=10.11"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/osx/native
          Copy-Item build/libSDL3.dylib runtimes/osx/native
        }

        "tvos" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/tvos/native
          Copy-Item build/libSDL3.a runtimes/tvos/native
        }

        "tvossimulator" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          cmake $submodulePath -B build $(cmakeShared) "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvsimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DSDL_STATIC=ON"
          cmake --build build --parallel
          New-Item -ItemType Directory -Force runtimes/tvossimulator/native
          Copy-Item build/libSDL3.a runtimes/tvossimulator/native
        }
      }
    }
  }
} finally {
  Pop-Location
}

#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

Push-Location $PSScriptRoot
try {
  # Config
  $repoRoot = Join-Path $PSScriptRoot "../../.."
  $submodulePath = Join-Path $repoRoot "eng/submodules/openal-soft"

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
    $buildConfig = $IsWindows ? @("--config", "Release") : @()

    Remove-Item -Recurse -Force build -ErrorAction Ignore
    New-Item -ItemType Directory build
    cmake $submodulePath -B build ($args | ForEach-Object { $_ })
    cmake --build build --parallel $buildConfig
  }

  function cmakeShared { @("-DCMAKE_BUILD_TYPE=Release", "-DALSOFT_UTILS=OFF", "-DALSOFT_EXAMPLES=OFF") }
  function windowsCmakeShared { @("-DALSOFT_BUILD_ROUTER=ON", "-DALSOFT_REQUIRE_WINMM=ON", "-DALSOFT_REQUIRE_DSOUND=ON", "-DALSOFT_REQUIRE_WASAPI=ON") }
  function androidCmakeShared { @("-DANDROID_PLATFORM=21", "-DCMAKE_TOOLCHAIN_FILE=$env:ANDROID_NDK_HOME/build/cmake/android.toolchain.cmake", "-DALSOFT_EMBED_HRTF_DATA=TRUE", "-DALSOFT_REQUIRE_OPENSL=ON") }
  function linuxCmakeShared { @("-DALSOFT_REQUIRE_RTKIT=ON", "-DALSOFT_REQUIRE_ALSA=ON", "-DALSOFT_REQUIRE_OSS=ON", "-DALSOFT_REQUIRE_PORTAUDIO=ON", "-DALSOFT_REQUIRE_PULSEAUDIO=ON", "-DALSOFT_REQUIRE_JACK=ON", "-DALSOFT_REQUIRE_PIPEWIRE=ON") }
  function appleCmakeShared { @("-DALSOFT_REQUIRE_COREAUDIO=ON") }

  switch ($true) {
    $IsWindows {
      $vsPath = & "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe" -latest -products "*" -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath

      switch ($runtime) {
        "win-arm64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch arm64 -SkipAutomaticLocation
          Build-CMake $(cmakeShared) $(windowsCmakeShared) -A arm64
          New-Item -ItemType Directory -Force runtimes/win-arm64/native
          Copy-Item build/Release/OpenAL32.dll runtimes/win-arm64/native
          Copy-Item build/Release/soft_oal.dll runtimes/win-arm64/native
        }

        "win-x64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch amd64 -SkipAutomaticLocation
          Build-CMake $(cmakeShared) $(windowsCmakeShared) -A x64
          New-Item -ItemType Directory -Force runtimes/win-x64/native
          Copy-Item build/Release/OpenAL32.dll runtimes/win-x64/native
          Copy-Item build/Release/soft_oal.dll runtimes/win-x64/native
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
          & $docker run --rm --init --name $name -e SILKDOTNET_DOCKER=1 -e CHOSEN_RUNTIME=$runtime -v "${repoRoot}:/data/repo" silkdotnet-builder:latest bash -c "/data/repo/sources/OpenAL/Soft.Native/build.ps1"
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
        dpkg --add-architecture $arch
        apt-get update
        apt-get install -y `
          libasound2-dev:$arch libpulse-dev:$arch libsoundio-dev:$arch libsndfile1-dev:$arch `
          libmysofa-dev:$arch qtbase5-dev:$arch libdbus-1-dev:$arch libjack-dev:$arch portaudio19-dev:$arch `
          libpipewire-0.3-dev:$arch qt6-base-dev:$arch pulseaudio:$arch
      }

      switch ($runtime) {
        "android-arm64" {
          # Build
          Build-CMake $(cmakeShared) $(androidCmakeShared) "-DANDROID_ABI=arm64-v8a"
          New-Item -ItemType Directory -Force runtimes/android-arm64/native
          Copy-Item build/libopenal.so runtimes/android-arm64/native
        }

        "android-arm" {
          # Build
          Build-CMake $(cmakeShared) $(androidCmakeShared) "-DANDROID_ABI=armeabi-v7a"
          New-Item -ItemType Directory -Force runtimes/android-arm/native
          Copy-Item build/libopenal.so runtimes/android-arm/native
        }

        "android-x64" {
          # Build
          Build-CMake $(cmakeShared) $(androidCmakeShared) "-DANDROID_ABI=x86_64"
          New-Item -ItemType Directory -Force runtimes/android-x64/native
          Copy-Item build/libopenal.so runtimes/android-x64/native
        }

        "android-x86" {
          # Build
          Build-CMake $(cmakeShared) $(androidCmakeShared) "-DANDROID_ABI=x86"
          New-Item -ItemType Directory -Force runtimes/android-x86/native
          Copy-Item build/libopenal.so runtimes/android-x86/native
        }

        "linux-arm64" {
          # Dependencies
          apt-get install -y gcc-aarch64-linux-gnu g++-aarch64-linux-gnu

          # Build
          Build-CMake $(cmakeShared) $(linuxCmakeShared) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/aarch64-linux-gnu.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-arm64/native
          Copy-Item build/libopenal.so runtimes/linux-arm64/native
        }

        "linux-arm" {
          # Dependencies
          apt-get install -y gcc-arm-linux-gnueabihf g++-arm-linux-gnueabihf

          # Build
          Build-CMake $(cmakeShared) $(linuxCmakeShared) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/arm-linux-gnueabihf.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-arm/native
          Copy-Item build/libopenal.so runtimes/linux-arm/native
        }

        "linux-x64" {
          # Build
          Build-CMake $(cmakeShared) $(linuxCmakeShared) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/x86_64-linux-gnu.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-x64/native
          Copy-Item build/libopenal.so runtimes/linux-x64/native
        }
      }
    }

    $IsMacOS {
      switch ($runtime) {
        "ios" {
          # Build
          Build-CMake $(cmakeShared) $(appleCmakeShared) "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphoneos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/ios/native
          Copy-Item build/libopenal.dylib runtimes/ios/native
        }

        "iossimulator" {
          # Build
          Build-CMake $(cmakeShared) $(appleCmakeShared) "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphonesimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/iossimulator/native
          Copy-Item build/libopenal.dylib runtimes/iossimulator/native
        }

        "osx" {
          # Build
          Build-CMake $(cmakeShared) $(appleCmakeShared) "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=13.3"
          New-Item -ItemType Directory -Force runtimes/osx/native
          Copy-Item build/libopenal.dylib runtimes/osx/native
        }

        "tvos" {
          # Build
          Build-CMake $(cmakeShared) $(appleCmakeShared) "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/tvos/native
          Copy-Item build/libopenal.dylib runtimes/tvos/native
        }

        "tvossimulator" {
          # Build
          Build-CMake $(cmakeShared) $(appleCmakeShared) "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvsimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/tvossimulator/native
          Copy-Item build/libopenal.dylib runtimes/tvossimulator/native
        }
      }
    }
  }
} finally {
  Pop-Location
}

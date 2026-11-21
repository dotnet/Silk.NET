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

  # Imports
  . $repoRoot/eng/workflows/native/build-utils.ps1

  # Inputs
  $runtime = ($args.Count -gt 0 -and $args[0]) ? $args[0] : $env:CHOSEN_RUNTIME
  Validate-ChosenRuntime $supportedRuntimes $runtime

  # CMake
  # C++ modules needs clang-scan-deps, and gets auto-enabled when using Ninja, which leads to the Linux Zig builds failing
  function Get-CMakeSharedArgs { @("-DCMAKE_BUILD_TYPE=Release", "-DALSOFT_UTILS=OFF", "-DALSOFT_EXAMPLES=OFF", "-DALSOFT_ENABLE_MODULES=OFF", "-DCMAKE_CXX_SCAN_FOR_MODULES=OFF") }
  function Get-CMakeWindowsArgs { @("-DALSOFT_BUILD_ROUTER=ON", "-DALSOFT_REQUIRE_WINMM=ON", "-DALSOFT_REQUIRE_DSOUND=ON", "-DALSOFT_REQUIRE_WASAPI=ON") }
  function Get-CMakeAndroidArgs { @("-DANDROID_PLATFORM=21", "-DALSOFT_EMBED_HRTF_DATA=TRUE", "-DALSOFT_REQUIRE_OPENSL=ON") }
  function Get-CMakeLinuxArgs { @("-DALSOFT_REQUIRE_RTKIT=ON", "-DALSOFT_REQUIRE_ALSA=ON", "-DALSOFT_REQUIRE_OSS=ON", "-DALSOFT_REQUIRE_PORTAUDIO=ON", "-DALSOFT_REQUIRE_PULSEAUDIO=ON", "-DALSOFT_REQUIRE_JACK=ON", "-DALSOFT_REQUIRE_PIPEWIRE=ON") }
  function Get-CMakeAppleArgs { @("-DALSOFT_REQUIRE_COREAUDIO=ON") }

  switch ($true) {
    $IsWindows {
      $vsPath = & "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe" -latest -products "*" -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath

      switch ($runtime) {
        "win-arm64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch arm64 -SkipAutomaticLocation
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeWindowsArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake"
          New-Item -ItemType Directory -Force runtimes/win-arm64/native
          Copy-Item build/OpenAL32.dll runtimes/win-arm64/native
          Copy-Item build/soft_oal.dll runtimes/win-arm64/native
        }

        "win-x64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch amd64 -SkipAutomaticLocation
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeWindowsArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/shared-toolchain.cmake"
          New-Item -ItemType Directory -Force runtimes/win-x64/native
          Copy-Item build/OpenAL32.dll runtimes/win-x64/native
          Copy-Item build/soft_oal.dll runtimes/win-x64/native
        }
      }
    }

    $IsLinux {
      # Enter Debian container
      Enter-SilkDebianContainer $runtime "sources/OpenAL/Soft.Native/build.ps1"

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
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-arm64-v8a.cmake"
          New-Item -ItemType Directory -Force runtimes/android-arm64/native
          Copy-Item build/libopenal.so runtimes/android-arm64/native
        }

        "android-arm" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-armeabi-v7a.cmake"
          New-Item -ItemType Directory -Force runtimes/android-arm/native
          Copy-Item build/libopenal.so runtimes/android-arm/native
        }

        "android-x64" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-x86_64.cmake"
          New-Item -ItemType Directory -Force runtimes/android-x64/native
          Copy-Item build/libopenal.so runtimes/android-x64/native
        }

        "android-x86" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAndroidArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/android-toolchain-x86.cmake"
          New-Item -ItemType Directory -Force runtimes/android-x86/native
          Copy-Item build/libopenal.so runtimes/android-x86/native
        }

        "linux-arm64" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeLinuxArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-aarch64-linux-gnu.2.28.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-arm64/native
          Copy-Item build/libopenal.so runtimes/linux-arm64/native
        }

        "linux-arm" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeLinuxArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-arm/native
          Copy-Item build/libopenal.so runtimes/linux-arm/native
        }

        "linux-x64" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeLinuxArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.28.cmake"
          New-Item -ItemType Directory -Force runtimes/linux-x64/native
          Copy-Item build/libopenal.so runtimes/linux-x64/native
        }
      }
    }

    $IsMacOS {
      switch ($runtime) {
        "ios" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAppleArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/apple-toolchain-ios.cmake" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/ios/native
          Copy-Item build/libopenal.dylib runtimes/ios/native
        }

        "iossimulator" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAppleArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/apple-toolchain-ios-simulator.cmake" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/iossimulator/native
          Copy-Item build/libopenal.dylib runtimes/iossimulator/native
        }

        "osx" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAppleArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/apple-toolchain-osx.cmake" "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=13.3"
          New-Item -ItemType Directory -Force runtimes/osx/native
          Copy-Item build/libopenal.dylib runtimes/osx/native
        }

        "tvos" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAppleArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/apple-toolchain-tvos.cmake" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/tvos/native
          Copy-Item build/libopenal.dylib runtimes/tvos/native
        }

        "tvossimulator" {
          # Build
          Build-CMake (Get-CMakeSharedArgs) (Get-CMakeAppleArgs) "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/apple-toolchain-tvos-simulator.cmake" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3"
          New-Item -ItemType Directory -Force runtimes/tvossimulator/native
          Copy-Item build/libopenal.dylib runtimes/tvossimulator/native
        }
      }
    }
  }
} finally {
  Pop-Location
}

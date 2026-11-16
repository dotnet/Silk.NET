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
  $runtime = ($args.Count -gt 0 -and $args[0]) ? $args[0] : $env:CHOSEN_RUNTIME
  if (-not $runtime) {
    Write-Host "Please choose a runtime by providing it as the first argument or setting the CHOSEN_RUNTIME env var"
    exit 1
  }

  Write-Host "Chosen runtime: $runtime"
  if (-not ($runtime -in $supportedRuntimes)) {
    Write-Host "Unknown runtime: $runtime"
    Write-Host "Supported runtimes: $supportedRuntimes"
    exit 1
  }

  switch ($true) {
    $IsWindows {
      $vsPath = & "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe" -latest -products "*" -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath

      switch ($runtime) {
        "win-arm64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch arm64 -SkipAutomaticLocation
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath -G Ninja "-DCMAKE_BUILD_TYPE=Release" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/win-arm64/native
          Copy-Item build/SDL3.dll runtimes/win-arm64/native
        }

        "win-x64" {
          # Build
          & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch amd64 -SkipAutomaticLocation
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath -G Ninja "-DCMAKE_BUILD_TYPE=Release" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
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
          Copy-Item $jars[1].FullName android/SDL3.jar
          Copy-Item "$(Split-Path -Parent $jars[1].FullName)/proguard.txt" android/proguard.txt
        }

        "linux-arm64" {
          # Dependencies
          # From https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
          dpkg --add-architecture arm64
          apt-get update
          apt-get install -y `
            gnome-desktop-testing `
            libglib2.0-dev-bin `
            libasound2-dev:arm64 libpulse-dev:arm64 `
            libaudio-dev:arm64 libfribidi-dev:arm64 libjack-dev:arm64 libsndio-dev:arm64 libx11-dev:arm64 libxext-dev:arm64 `
            libxrandr-dev:arm64 libxcursor-dev:arm64 libxfixes-dev:arm64 libxi-dev:arm64 libxss-dev:arm64 libxtst-dev:arm64 `
            libxkbcommon-dev:arm64 libdrm-dev:arm64 libgbm-dev:arm64 libgl1-mesa-dev:arm64 libgles2-mesa-dev:arm64 `
            libegl1-mesa-dev:arm64 libdbus-1-dev:arm64 libibus-1.0-dev:arm64 libudev-dev:arm64 libthai-dev:arm64 `
            libpipewire-0.3-dev:arm64 libwayland-dev:arm64 libdecor-0-dev:arm64 liburing-dev:arm64

          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_BUILD_TYPE=Release" "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-aarch64-linux-gnu.2.17.cmake" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/linux-arm64/native
          Copy-Item build/libSDL3.so runtimes/linux-arm64/native
        }

        "linux-arm" {
          # Dependencies
          # From https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
          dpkg --add-architecture armhf
          apt-get update
          apt-get install -y `
            gnome-desktop-testing `
            libglib2.0-dev-bin `
            libasound2-dev:armhf libpulse-dev:armhf `
            libaudio-dev:armhf libfribidi-dev:armhf libjack-dev:armhf libsndio-dev:armhf libx11-dev:armhf libxext-dev:armhf `
            libxrandr-dev:armhf libxcursor-dev:armhf libxfixes-dev:armhf libxi-dev:armhf libxss-dev:armhf libxtst-dev:armhf `
            libxkbcommon-dev:armhf libdrm-dev:armhf libgbm-dev:armhf libgl1-mesa-dev:armhf libgles2-mesa-dev:armhf `
            libegl1-mesa-dev:armhf libdbus-1-dev:armhf libibus-1.0-dev:armhf libudev-dev:armhf libthai-dev:armhf `
            libpipewire-0.3-dev:armhf libwayland-dev:armhf libdecor-0-dev:armhf liburing-dev:armhf

          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_BUILD_TYPE=Release" "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/linux-arm/native
          Copy-Item build/libSDL3.so runtimes/linux-arm/native
        }

        "linux-x64" {
          # Dependencies
          # From https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
          dpkg --add-architecture amd64
          apt-get update
          apt-get install -y `
            gnome-desktop-testing `
            libglib2.0-dev-bin `
            libasound2-dev:amd64 libpulse-dev:amd64 `
            libaudio-dev:amd64 libfribidi-dev:amd64 libjack-dev:amd64 libsndio-dev:amd64 libx11-dev:amd64 libxext-dev:amd64 `
            libxrandr-dev:amd64 libxcursor-dev:amd64 libxfixes-dev:amd64 libxi-dev:amd64 libxss-dev:amd64 libxtst-dev:amd64 `
            libxkbcommon-dev:amd64 libdrm-dev:amd64 libgbm-dev:amd64 libgl1-mesa-dev:amd64 libgles2-mesa-dev:amd64 `
            libegl1-mesa-dev:amd64 libdbus-1-dev:amd64 libibus-1.0-dev:amd64 libudev-dev:amd64 libthai-dev:amd64 `
            libpipewire-0.3-dev:amd64 libwayland-dev:amd64 libdecor-0-dev:amd64 liburing-dev:amd64

          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_BUILD_TYPE=Release" "-DCMAKE_TOOLCHAIN_FILE=$repoRoot/eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.17.cmake" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
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
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphoneos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DCMAKE_BUILD_TYPE=Release" "-DSDL_STATIC=ON" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/ios/native
          Copy-Item build/libSDL3.a runtimes/ios/native
        }

        "iossimulator" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphonesimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DCMAKE_BUILD_TYPE=Release" "-DSDL_STATIC=ON" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/iossimulator/native
          Copy-Item build/libSDL3.a runtimes/iossimulator/native
        }

        "osx" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=10.11" "-DCMAKE_BUILD_TYPE=Release" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/osx/native
          Copy-Item build/libSDL3.dylib runtimes/osx/native
        }

        "tvos" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DCMAKE_BUILD_TYPE=Release" "-DSDL_STATIC=ON" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/tvos/native
          Copy-Item build/libSDL3.a runtimes/tvos/native
        }

        "tvossimulator" {
          # Build
          Remove-Item -Recurse -Force build -ErrorAction Ignore
          New-Item -ItemType Directory build
          Push-Location build
          try {
            cmake $submodulePath "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvsimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=9.0" "-DCMAKE_BUILD_TYPE=Release" "-DSDL_STATIC=ON" "-DSDL_TEST_LIBRARY=OFF"
            cmake --build . --parallel
          } finally {
            Pop-Location
          }
          New-Item -ItemType Directory -Force runtimes/tvossimulator/native
          Copy-Item build/libSDL3.a runtimes/tvossimulator/native
        }
      }
    }
  }
} finally {
  Pop-Location
}

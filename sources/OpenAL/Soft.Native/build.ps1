#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

Push-Location $PSScriptRoot
try {
  # Inputs
  $runtime = ($args.Count -gt 0 -and $args[0]) ? $args[0] : $env:CHOSEN_RUNTIME
  if (-not $runtime) {
    Write-Host "Please choose a runtime by providing it as the first argument or setting the CHOSEN_RUNTIME env var"
    exit 1
  }

  Write-Host "Chosen runtime: $runtime"

  switch ($runtime) {
    default {
      Write-Host "Unknown runtime: $runtime"
      exit 1
    }

    "android-arm64" {
      # Dependencies
      if ($env:GITHUB_ACTIONS) {
        # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
        $sdkmanager = @(Get-ChildItem /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager | Sort-Object FullName)
        & $sdkmanager[-1].FullName --install "platforms;android-21"
      }

      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DANDROID_ABI=arm64-v8a" "-DCMAKE_TOOLCHAIN_FILE=$env:ANDROID_NDK_HOME/build/cmake/android.toolchain.cmake" "-DANDROID_PLATFORM=21" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_EMBED_HRTF_DATA=TRUE" "-DALSOFT_REQUIRE_OPENSL=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/android-arm64/native
      Copy-Item build/libopenal.so runtimes/android-arm64/native
    }

    "android-arm" {
      # Dependencies
      if ($env:GITHUB_ACTIONS) {
        # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
        $sdkmanager = @(Get-ChildItem /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager | Sort-Object FullName)
        & $sdkmanager[-1].FullName --install "platforms;android-21"
      }

      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DANDROID_ABI=armeabi-v7a" "-DCMAKE_TOOLCHAIN_FILE=$env:ANDROID_NDK_HOME/build/cmake/android.toolchain.cmake" "-DANDROID_PLATFORM=21" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_EMBED_HRTF_DATA=TRUE" "-DALSOFT_REQUIRE_OPENSL=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/android-arm/native
      Copy-Item build/libopenal.so runtimes/android-arm/native
    }

    "android-x64" {
      # Dependencies
      if ($env:GITHUB_ACTIONS) {
        # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
        $sdkmanager = @(Get-ChildItem /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager | Sort-Object FullName)
        & $sdkmanager[-1].FullName --install "platforms;android-21"
      }

      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DANDROID_ABI=x86_64" "-DCMAKE_TOOLCHAIN_FILE=$env:ANDROID_NDK_HOME/build/cmake/android.toolchain.cmake" "-DANDROID_PLATFORM=21" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_EMBED_HRTF_DATA=TRUE" "-DALSOFT_REQUIRE_OPENSL=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/android-x64/native
      Copy-Item build/libopenal.so runtimes/android-x64/native
    }

    "android-x86" {
      # Dependencies
      if ($env:GITHUB_ACTIONS) {
        # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
        $sdkmanager = @(Get-ChildItem /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager | Sort-Object FullName)
        & $sdkmanager[-1].FullName --install "platforms;android-21"
      }

      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DANDROID_ABI=x86" "-DCMAKE_TOOLCHAIN_FILE=$env:ANDROID_NDK_HOME/build/cmake/android.toolchain.cmake" "-DANDROID_PLATFORM=21" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/android-x86/native
      Copy-Item build/libopenal.so runtimes/android-x86/native
    }

    "ios" {
      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphoneos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_COREAUDIO=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/ios/native
      Copy-Item build/libopenal.dylib runtimes/ios/native
    }

    "iossimulator" {
      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_SYSTEM_NAME=iOS" "-DCMAKE_OSX_SYSROOT=iphonesimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_COREAUDIO=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/iossimulator/native
      Copy-Item build/libopenal.dylib runtimes/iossimulator/native
    }

    "linux-arm64" {
      # Dependencies
      if ($env:GITHUB_ACTIONS) {
        if (-not $env:SILKDOTNET_DOCKER) {
          # Enter Debian container for multiarch packages
          $docker = "docker"
          if (Get-Command podman -ErrorAction Ignore) {
            $docker = "podman"
          }
          & $docker run --platform linux/amd64 -e SILKDOTNET_DOCKER=1 -e GITHUB_ACTIONS=1 -v "$((Resolve-Path ../../../).Path):/data" debian bash -c 'apt-get update && apt-get install -y curl libicu-dev && curl -fsSL https://dot.net/v1/dotnet-install.sh | bash -s -- --channel LTS && export DOTNET_ROOT="$HOME/.dotnet" PATH="$HOME/.dotnet:$HOME/.dotnet/tools:$PATH" && dotnet tool install --global PowerShell && /data/sources/OpenAL/Soft.Native/build.ps1 linux-arm64'
          exit
        } else {
          dpkg --add-architecture arm64
          apt-get update
          apt-get install -y `
            git cmake python3 `
            libasound2-dev:arm64 libpulse-dev:arm64 libsoundio-dev:arm64 libsndfile1-dev:arm64 `
            libmysofa-dev:arm64 qtbase5-dev:arm64 libdbus-1-dev:arm64 libjack-dev:arm64 portaudio19-dev:arm64 `
            libpipewire-0.3-dev:arm64 qt6-base-dev:arm64 pulseaudio:arm64 `
            gcc-aarch64-linux-gnu g++-aarch64-linux-gnu
        }
      }

      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_BUILD_TYPE=Release" "-DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/aarch64-linux-gnu.cmake" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_RTKIT=ON" "-DALSOFT_REQUIRE_ALSA=ON" "-DALSOFT_REQUIRE_OSS=ON" "-DALSOFT_REQUIRE_PORTAUDIO=ON" "-DALSOFT_REQUIRE_PULSEAUDIO=ON" "-DALSOFT_REQUIRE_JACK=ON" "-DALSOFT_REQUIRE_PIPEWIRE=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/linux-arm64/native
      Copy-Item build/libopenal.so runtimes/linux-arm64/native
    }

    "linux-arm" {
      # Dependencies
      if ($env:GITHUB_ACTIONS) {
        if (-not $env:SILKDOTNET_DOCKER) {
          # Enter Debian container for multiarch packages
          $docker = "docker"
          if (Get-Command podman -ErrorAction Ignore) {
            $docker = "podman"
          }
          & $docker run --platform linux/amd64 -e SILKDOTNET_DOCKER=1 -e GITHUB_ACTIONS=1 -v "$((Resolve-Path ../../../).Path):/data" debian bash -c 'apt-get update && apt-get install -y curl libicu-dev && curl -fsSL https://dot.net/v1/dotnet-install.sh | bash -s -- --channel LTS && export DOTNET_ROOT="$HOME/.dotnet" PATH="$HOME/.dotnet:$HOME/.dotnet/tools:$PATH" && dotnet tool install --global PowerShell && /data/sources/OpenAL/Soft.Native/build.ps1 linux-arm'
          exit
        } else {
          dpkg --add-architecture armhf
          apt-get update
          apt-get install -y `
            git cmake python3 `
            libasound2-dev:armhf libpulse-dev:armhf libsoundio-dev:armhf libsndfile1-dev:armhf `
            libmysofa-dev:armhf qtbase5-dev:armhf libdbus-1-dev:armhf libjack-dev:armhf portaudio19-dev:armhf `
            libpipewire-0.3-dev:armhf qt6-base-dev:armhf pulseaudio:armhf `
            gcc-arm-linux-gnueabihf g++-arm-linux-gnueabihf
        }
      }

      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_BUILD_TYPE=Release" "-DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/arm-linux-gnueabihf.cmake" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_RTKIT=ON" "-DALSOFT_REQUIRE_ALSA=ON" "-DALSOFT_REQUIRE_OSS=ON" "-DALSOFT_REQUIRE_PORTAUDIO=ON" "-DALSOFT_REQUIRE_PULSEAUDIO=ON" "-DALSOFT_REQUIRE_JACK=ON" "-DALSOFT_REQUIRE_PIPEWIRE=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/linux-arm/native
      Copy-Item build/libopenal.so runtimes/linux-arm/native
    }

    "linux-x64" {
      # Dependencies
      if ($env:GITHUB_ACTIONS) {
        if (-not $env:SILKDOTNET_DOCKER) {
          # Enter Debian container for multiarch packages
          $docker = "docker"
          if (Get-Command podman -ErrorAction Ignore) {
            $docker = "podman"
          }
          & $docker run --platform linux/amd64 -e SILKDOTNET_DOCKER=1 -e GITHUB_ACTIONS=1 -v "$((Resolve-Path ../../../).Path):/data" debian bash -c 'apt-get update && apt-get install -y curl libicu-dev && curl -fsSL https://dot.net/v1/dotnet-install.sh | bash -s -- --channel LTS && export DOTNET_ROOT="$HOME/.dotnet" PATH="$HOME/.dotnet:$HOME/.dotnet/tools:$PATH" && dotnet tool install --global PowerShell && /data/sources/OpenAL/Soft.Native/build.ps1 linux-x64'
          exit
        } else {
          apt-get update
          apt-get install -y `
            git cmake python3 build-essential `
            libasound2-dev:amd64 libpulse-dev:amd64 libsoundio-dev:amd64 libsndfile1-dev:amd64 `
            libmysofa-dev:amd64 qtbase5-dev:amd64 libdbus-1-dev:amd64 libjack-dev:amd64 portaudio19-dev:amd64 `
            libpipewire-0.3-dev:amd64 qt6-base-dev:amd64 pulseaudio:amd64
        }
      }

      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_BUILD_TYPE=Release" "-DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/x86_64-linux-gnu.cmake" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_RTKIT=ON" "-DALSOFT_REQUIRE_ALSA=ON" "-DALSOFT_REQUIRE_OSS=ON" "-DALSOFT_REQUIRE_PORTAUDIO=ON" "-DALSOFT_REQUIRE_PULSEAUDIO=ON" "-DALSOFT_REQUIRE_JACK=ON" "-DALSOFT_REQUIRE_PIPEWIRE=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/linux-x64/native
      Copy-Item build/libopenal.so runtimes/linux-x64/native
    }

    "osx" {
      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=13.3" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_COREAUDIO=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/osx/native
      Copy-Item build/libopenal.dylib runtimes/osx/native
    }

    "tvos" {
      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvos" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_COREAUDIO=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/tvos/native
      Copy-Item build/libopenal.dylib runtimes/tvos/native
    }

    "tvossimulator" {
      # Build
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_SYSTEM_NAME=tvOS" "-DCMAKE_OSX_SYSROOT=appletvsimulator" "-DCMAKE_OSX_ARCHITECTURES=arm64" "-DCMAKE_OSX_DEPLOYMENT_TARGET=16.3" "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_REQUIRE_COREAUDIO=ON"
        cmake --build . --parallel
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/tvossimulator/native
      Copy-Item build/libopenal.dylib runtimes/tvossimulator/native
    }

    "win-arm64" {
      # Build
      $vsPath = & "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe" -latest -products "*" -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath
      & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch arm64 -SkipAutomaticLocation
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_BUILD_ROUTER=ON" "-DALSOFT_REQUIRE_WINMM=ON" "-DALSOFT_REQUIRE_DSOUND=ON" "-DALSOFT_REQUIRE_WASAPI=ON" -A arm64
        cmake --build . --parallel --config Release
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/win-arm64/native
      Copy-Item build/Release/OpenAL32.dll runtimes/win-arm64/native
      Copy-Item build/Release/soft_oal.dll runtimes/win-arm64/native
    }

    "win-x64" {
      # Build
      $vsPath = & "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe" -latest -products "*" -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath
      & "$vsPath/Common7/Tools/Launch-VsDevShell.ps1" -HostArch amd64 -Arch amd64 -SkipAutomaticLocation
      Remove-Item -Recurse -Force build -ErrorAction Ignore
      New-Item -ItemType Directory build
      Push-Location build
      try {
        cmake ../../../../eng/submodules/openal-soft "-DCMAKE_BUILD_TYPE=Release" "-DALSOFT_UTILS=OFF" "-DALSOFT_EXAMPLES=OFF" "-DALSOFT_BUILD_ROUTER=ON" "-DALSOFT_REQUIRE_WINMM=ON" "-DALSOFT_REQUIRE_DSOUND=ON" "-DALSOFT_REQUIRE_WASAPI=ON" -A x64
        cmake --build . --parallel --config Release
      } finally {
        Pop-Location
      }
      New-Item -ItemType Directory -Force runtimes/win-x64/native
      Copy-Item build/Release/OpenAL32.dll runtimes/win-x64/native
      Copy-Item build/Release/soft_oal.dll runtimes/win-x64/native
    }
  }
} finally {
  Pop-Location
}

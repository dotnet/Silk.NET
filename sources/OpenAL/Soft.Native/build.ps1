#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# TODO
exit 1

# build-android-arm64.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [ ! -z "$GITHUB_ACTIONS" ]; then
    # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
    sdkmanager=( /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager )
    ${sdkmanager[-1]} --install "platforms;android-21"
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DANDROID_ABI=arm64-v8a -DCMAKE_TOOLCHAIN_FILE="${ANDROID_NDK_HOME}/build/cmake/android.toolchain.cmake" -DANDROID_PLATFORM=21 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_EMBED_HRTF_DATA=TRUE -DALSOFT_REQUIRE_OPENSL=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/android-arm64/native
cp build/libopenal.so runtimes/android-arm64/native

# build-android-arm.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [ ! -z "$GITHUB_ACTIONS" ]; then
    # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
    sdkmanager=( /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager )
    ${sdkmanager[-1]} --install "platforms;android-21"
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DANDROID_ABI=armeabi-v7a -DCMAKE_TOOLCHAIN_FILE="${ANDROID_NDK_HOME}/build/cmake/android.toolchain.cmake" -DANDROID_PLATFORM=21 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_EMBED_HRTF_DATA=TRUE -DALSOFT_REQUIRE_OPENSL=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/android-arm/native
cp build/libopenal.so runtimes/android-arm/native

# build-android-x64.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [ ! -z "$GITHUB_ACTIONS" ]; then
    # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
    sdkmanager=( /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager )
    ${sdkmanager[-1]} --install "platforms;android-21"
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DANDROID_ABI=x86_64 -DCMAKE_TOOLCHAIN_FILE="${ANDROID_NDK_HOME}/build/cmake/android.toolchain.cmake" -DANDROID_PLATFORM=21 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_EMBED_HRTF_DATA=TRUE -DALSOFT_REQUIRE_OPENSL=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/android-x64/native
cp build/libopenal.so runtimes/android-x64/native

# build-android-x86.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [ ! -z "$GITHUB_ACTIONS" ]; then
    # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
    sdkmanager=( /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager )
    ${sdkmanager[-1]} --install "platforms;android-21"
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DANDROID_ABI=x86 -DCMAKE_TOOLCHAIN_FILE="${ANDROID_NDK_HOME}/build/cmake/android.toolchain.cmake" -DANDROID_PLATFORM=21 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/android-x86/native
cp build/libopenal.so runtimes/android-x86/native

# build-ios.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_SYSTEM_NAME=iOS -DCMAKE_OSX_SYSROOT=iphoneos "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=16.3 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_COREAUDIO=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/ios/native
cp build/libopenal.dylib runtimes/ios/native

# build-iossimulator.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_SYSTEM_NAME=iOS -DCMAKE_OSX_SYSROOT=iphonesimulator "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=16.3 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_COREAUDIO=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/iossimulator/native
cp build/libopenal.dylib runtimes/iossimulator/native

# build-linux-arm64.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    if [[ -z ${SILKDOTNET_DockerBuild+x} ]]; then
        # Enter Debian container for multiarch packages
        docker="docker"
        if command -v podman >/dev/null 2>&1; then
            docker="podman"
        fi
        $docker run --platform linux/amd64 -e SILKDOTNET_DockerBuild=1 -e GITHUB_ACTIONS=1 -v $(readlink -f ../../../):/data debian bash -c "cd /data/sources/OpenAL/Soft.Native && ./build-linux-arm64.sh"
        exit
    else
        dpkg --add-architecture arm64
        apt-get update
        apt-get install -y \
            git cmake python3 \
            libasound2-dev:arm64 libpulse-dev:arm64 libsoundio-dev:arm64 libsndfile1-dev:arm64 \
            libmysofa-dev:arm64 qtbase5-dev:arm64 libdbus-1-dev:arm64 libjack-dev:arm64 portaudio19-dev:arm64 \
            libpipewire-0.3-dev:arm64 qt6-base-dev:arm64 pulseaudio:arm64 \
            gcc-aarch64-linux-gnu g++-aarch64-linux-gnu
    fi
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/aarch64-linux-gnu.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm64/native
cp build/libopenal.so runtimes/linux-arm64/native

# build-linux-arm.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    if [[ -z ${SILKDOTNET_DockerBuild+x} ]]; then
        # Enter Debian container for multiarch packages
        docker="docker"
        if command -v podman >/dev/null 2>&1; then
            docker="podman"
        fi
        $docker run --platform linux/amd64 -e SILKDOTNET_DockerBuild=1 -e GITHUB_ACTIONS=1 -v $(readlink -f ../../../):/data debian bash -c "cd /data/sources/OpenAL/Soft.Native && ./build-linux-arm.sh"
        exit
    else
        dpkg --add-architecture armhf
        apt-get update
        apt-get install -y \
            git cmake python3 \
            libasound2-dev:armhf libpulse-dev:armhf libsoundio-dev:armhf libsndfile1-dev:armhf \
            libmysofa-dev:armhf qtbase5-dev:armhf libdbus-1-dev:armhf libjack-dev:armhf portaudio19-dev:armhf \
            libpipewire-0.3-dev:armhf qt6-base-dev:armhf pulseaudio:armhf \
            gcc-arm-linux-gnueabihf g++-arm-linux-gnueabihf
    fi
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/arm-linux-gnueabihf.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm/native
cp build/libopenal.so runtimes/linux-arm/native

# build-linux-x64.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    sudo apt-get update
    sudo apt-get install -y \
        git cmake python3 build-essential \
        libasound2-dev:amd64 libpulse-dev:amd64 libsoundio-dev:amd64 libsndfile1-dev:amd64 \
        libmysofa-dev:amd64 qtbase5-dev:amd64 libdbus-1-dev:amd64 libjack-dev:amd64 portaudio19-dev:amd64 \
        libpipewire-0.3-dev:amd64 qt6-base-dev:amd64 pulseaudio:amd64
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/x86_64-linux-gnu.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-x64/native
cp build/libopenal.so runtimes/linux-x64/native

# build-osx.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" -DCMAKE_OSX_DEPLOYMENT_TARGET=13.3 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_COREAUDIO=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/osx/native
cp build/libopenal.dylib runtimes/osx/native

# build-tvos.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_SYSTEM_NAME=tvOS -DCMAKE_OSX_SYSROOT=appletvos "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=16.3 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_COREAUDIO=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/tvos/native
cp build/libopenal.dylib runtimes/tvos/native

# build-tvossimulator.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_SYSTEM_NAME=tvOS -DCMAKE_OSX_SYSROOT=appletvsimulator "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=16.3 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_COREAUDIO=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/tvossimulator/native
cp build/libopenal.dylib runtimes/tvossimulator/native

# build-win-arm64.cmd
@REM Build
call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\VC\Auxiliary\Build\vcvarsall.bat" amd64_arm64
rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\openal-soft -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_BUILD_ROUTER=ON -DALSOFT_REQUIRE_WINMM=ON -DALSOFT_REQUIRE_DSOUND=ON -DALSOFT_REQUIRE_WASAPI=ON -A arm64
cmake --build . --parallel --config Release
cd ..
mkdir runtimes\win-arm64\native
copy build\Release\OpenAL32.dll runtimes\win-arm64\native
copy build\Release\soft_oal.dll runtimes\win-arm64\native

# build-win-x64.cmd
@REM Build
call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\VC\Auxiliary\Build\vcvarsall.bat" x64
rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\openal-soft -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_BUILD_ROUTER=ON -DALSOFT_REQUIRE_WINMM=ON -DALSOFT_REQUIRE_DSOUND=ON -DALSOFT_REQUIRE_WASAPI=ON -A x64
cmake --build . --parallel --config Release
cd ..
mkdir runtimes\win-x64\native
copy build\Release\OpenAL32.dll runtimes\win-x64\native
copy build\Release\soft_oal.dll runtimes\win-x64\native

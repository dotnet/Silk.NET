# build-android.sh
#!/usr/bin/env -S bash -eu

# Dependencies
python="python"
if [ ! -z "$GITHUB_ACTIONS" ]; then
    # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
    sdkmanager=( /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager )
    ${sdkmanager[-1]} --install "platforms;android-19"
    sudo add-apt-repository ppa:deadsnakes/ppa
    sudo apt update
    sudo apt install python3.11 ninja-build
    python="python3.11"
fi

# Build
$python ../../../eng/submodules/sdl/build-scripts/build-release.py --actions android --root ../../../eng/submodules/sdl
mkdir -p runtimes/android-x86/native runtimes/android-x64/native runtimes/android-arm/native runtimes/android-arm64/native android
cp ../../../eng/submodules/sdl/install-android/arm64-v8a-install/lib/libSDL3.so runtimes/android-arm64/native
cp ../../../eng/submodules/sdl/install-android/armeabi-v7a-install/lib/libSDL3.so runtimes/android-arm/native
cp ../../../eng/submodules/sdl/install-android/x86-install/lib/libSDL3.so runtimes/android-x86/native
cp ../../../eng/submodules/sdl/install-android/x86_64-install/lib/libSDL3.so runtimes/android-x64/native
jars=( ../../../eng/submodules/sdl/install-android/armeabi-v7a-install/share/java/SDL3/SDL3-*.jar )
cp "${jars[1]}" android/SDL3.jar
cp "$(dirname "${jars[1]}")/proguard.txt" android/proguard.txt

# build-ios.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_SYSTEM_NAME=iOS -DCMAKE_OSX_SYSROOT=iphoneos "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=9.0 -DCMAKE_BUILD_TYPE=Release -DSDL_STATIC=ON -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/ios/native
cp build/libSDL3.a runtimes/ios/native

# build-iossimulator.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_SYSTEM_NAME=iOS -DCMAKE_OSX_SYSROOT=iphonesimulator "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" -DCMAKE_OSX_DEPLOYMENT_TARGET=9.0 -DCMAKE_BUILD_TYPE=Release -DSDL_STATIC=ON -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/iossimulator/native
cp build/libSDL3.a runtimes/iossimulator/native

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
        $docker run --platform linux/amd64 -e SILKDOTNET_DockerBuild=1 -e GITHUB_ACTIONS=1 -v $(readlink -f ../../../):/data debian bash -c "cd /data/sources/SDL/Native && ./build-linux-arm64.sh"
        exit
    else
        apt-get update
        apt-get install -y python3
        ../../../eng/native/buildsystem/download-zig.py
        export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"

        # Dependency list is from https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
        dpkg --add-architecture arm64
        apt-get update
        apt-get install -y \
            git cmake make build-essential  \
            pkg-config ninja-build gnome-desktop-testing \
            libglib2.0-dev-bin \
            libasound2-dev:arm64 libpulse-dev:arm64 \
            libaudio-dev:arm64 libfribidi-dev:arm64 libjack-dev:arm64 libsndio-dev:arm64 libx11-dev:arm64 libxext-dev:arm64 \
            libxrandr-dev:arm64 libxcursor-dev:arm64 libxfixes-dev:arm64 libxi-dev:arm64 libxss-dev:arm64 libxtst-dev:arm64 \
            libxkbcommon-dev:arm64 libdrm-dev:arm64 libgbm-dev:arm64 libgl1-mesa-dev:arm64 libgles2-mesa-dev:arm64 \
            libegl1-mesa-dev:arm64 libdbus-1-dev:arm64 libibus-1.0-dev:arm64 libudev-dev:arm64 libthai-dev:arm64 \
            libpipewire-0.3-dev:arm64 libwayland-dev:arm64 libdecor-0-dev:arm64 liburing-dev:arm64
    fi
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-aarch64-linux-gnu.2.17.cmake -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm64/native
cp build/libSDL3.so runtimes/linux-arm64/native

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
        $docker run --platform linux/amd64 -e SILKDOTNET_DockerBuild=1 -e GITHUB_ACTIONS=1 -v $(readlink -f ../../../):/data debian bash -c "cd /data/sources/SDL/Native && ./build-linux-arm.sh"
        exit
    else
        apt-get update
        apt-get install -y python3
        ../../../eng/native/buildsystem/download-zig.py
        export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"

        # Dependency list is from https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
        dpkg --add-architecture armhf
        apt-get update
        apt-get install -y \
            git cmake make build-essential  \
            pkg-config ninja-build gnome-desktop-testing \
            libglib2.0-dev-bin \
            libasound2-dev:armhf libpulse-dev:armhf \
            libaudio-dev:armhf libfribidi-dev:armhf libjack-dev:armhf libsndio-dev:armhf libx11-dev:armhf libxext-dev:armhf \
            libxrandr-dev:armhf libxcursor-dev:armhf libxfixes-dev:armhf libxi-dev:armhf libxss-dev:armhf libxtst-dev:armhf \
            libxkbcommon-dev:armhf libdrm-dev:armhf libgbm-dev:armhf libgl1-mesa-dev:armhf libgles2-mesa-dev:armhf \
            libegl1-mesa-dev:armhf libdbus-1-dev:armhf libibus-1.0-dev:armhf libudev-dev:armhf libthai-dev:armhf \
            libpipewire-0.3-dev:armhf libwayland-dev:armhf libdecor-0-dev:armhf liburing-dev:armhf
    fi
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm/native
cp build/libSDL3.so runtimes/linux-arm/native

# build-linux-x64.sh
#!/usr/bin/env -S bash -eu

# Dependencies
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    ../../../eng/native/buildsystem/download-zig.py
    export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"

    # Dependency list is from https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
    sudo dpkg --add-architecture amd64
    sudo apt-get update
    sudo apt-get install -y \
        git cmake make build-essential  \
        pkg-config ninja-build gnome-desktop-testing \
        libglib2.0-dev-bin \
        libasound2-dev:amd64 libpulse-dev:amd64 \
        libaudio-dev:amd64 libfribidi-dev:amd64 libjack-dev:amd64 libsndio-dev:amd64 libx11-dev:amd64 libxext-dev:amd64 \
        libxrandr-dev:amd64 libxcursor-dev:amd64 libxfixes-dev:amd64 libxi-dev:amd64 libxss-dev:amd64 libxtst-dev:amd64 \
        libxkbcommon-dev:amd64 libdrm-dev:amd64 libgbm-dev:amd64 libgl1-mesa-dev:amd64 libgles2-mesa-dev:amd64 \
        libegl1-mesa-dev:amd64 libdbus-1-dev:amd64 libibus-1.0-dev:amd64 libudev-dev:amd64 libthai-dev:amd64 \
        libpipewire-0.3-dev:amd64 libwayland-dev:amd64 libdecor-0-dev:amd64 liburing-dev:amd64
fi

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.17.cmake -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-x64/native
cp build/libSDL3.so runtimes/linux-x64/native

# build-osx.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" -DCMAKE_OSX_DEPLOYMENT_TARGET=10.11 -DCMAKE_BUILD_TYPE=Release -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/osx/native
cp build/libSDL3.dylib runtimes/osx/native

# build-tvos.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_SYSTEM_NAME=tvOS -DCMAKE_OSX_SYSROOT=appletvos "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=9.0 -DCMAKE_BUILD_TYPE=Release -DSDL_STATIC=ON -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/tvos/native
cp build/libSDL3.a runtimes/tvos/native

# build-tvossimulator.sh
#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_SYSTEM_NAME=tvOS -DCMAKE_OSX_SYSROOT=appletvsimulator "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=9.0 -DCMAKE_BUILD_TYPE=Release -DSDL_STATIC=ON -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/tvossimulator/native
cp build/libSDL3.a runtimes/tvossimulator/native

# build-win-arm64.cmd
@REM Build
call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\VC\Auxiliary\Build\vcvarsall.bat" amd64_arm64
rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\sdl -G Ninja -DCMAKE_BUILD_TYPE=Release -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir runtimes\win-arm64\native
copy build\SDL3.dll runtimes\win-arm64\native

# build-win-x64.cmd
@REM Build
call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\VC\Auxiliary\Build\vcvarsall.bat" x64
rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\sdl -G Ninja -DCMAKE_BUILD_TYPE=Release -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir runtimes\win-x64\native
copy build\SDL3.dll runtimes\win-x64\native

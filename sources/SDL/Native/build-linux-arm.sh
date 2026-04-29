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
        apt update
        apt install -y python3
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

# Submodule
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
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

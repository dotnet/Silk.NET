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
        ../../../eng/native/buildsystem/download-zig.py
        export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"

        # Dependency list is from https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
        sudo dpkg --add-architecture arm64
        sudo apt-get update
        sudo apt-get install -y \
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

# Submodule
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
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

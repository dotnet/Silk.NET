#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi

if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    ../../../eng/native/buildsystem/download-zig.py
    export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"
    # Dependency list is from https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
    sudo dpkg --add-architecture amd64
    sudo apt-get update
    sudo apt-get install build-essential git make \
        pkg-config cmake ninja-build gnome-desktop-testing \
        libasound2-dev:amd64 libpulse-dev:amd64 \
        libaudio-dev:amd64 libfribidi-dev:amd64 libjack-dev:amd64 libsndio-dev:amd64 libx11-dev:amd64 libxext-dev:amd64 \
        libxrandr-dev:amd64 libxcursor-dev:amd64 libxfixes-dev:amd64 libxi-dev:amd64 libxss-dev:amd64 libxtst-dev:amd64 \
        libxkbcommon-dev:amd64 libdrm-dev:amd64 libgbm-dev:amd64 libgl1-mesa-dev:amd64 libgles2-mesa-dev:amd64 \
        libegl1-mesa-dev:amd64 libdbus-1-dev:amd64 libibus-1.0-dev:amd64 libudev-dev:amd64 libthai-dev:amd64 \
        libpipewire-0.3-dev:amd64 libwayland-dev:amd64 libdecor-0-dev:amd64 liburing-dev
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.17.cmake -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-x64/native
cp build/libSDL3.so runtimes/linux-x64/native

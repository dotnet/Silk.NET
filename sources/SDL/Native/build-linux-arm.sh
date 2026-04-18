#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi

if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    ../../../eng/native/buildsystem/download-zig.py
    export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"
    # Dependency list is from https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
    sudo dpkg --add-architecture arm
    sudo apt-get update
    sudo apt-get install build-essential git make \
        pkg-config cmake ninja-build gnome-desktop-testing \
        libglib2.0-dev-bin \
        libasound2-dev:arm libpulse-dev:arm \
        libaudio-dev:arm libfribidi-dev:arm libjack-dev:arm libsndio-dev:arm libx11-dev:arm libxext-dev:arm \
        libxrandr-dev:arm libxcursor-dev:arm libxfixes-dev:arm libxi-dev:arm libxss-dev:arm libxtst-dev:arm \
        libxkbcommon-dev:arm libdrm-dev:arm libgbm-dev:arm libgl1-mesa-dev:arm libgles2-mesa-dev:arm \
        libegl1-mesa-dev:arm libdbus-1-dev:arm libibus-1.0-dev:arm libudev-dev:arm libthai-dev:arm \
        libpipewire-0.3-dev:arm libwayland-dev:arm libdecor-0-dev:arm liburing-dev:arm
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm/native
cp build/libSDL3.so runtimes/linux-arm/native

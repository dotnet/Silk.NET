#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi

if [[ "$@" == *"--install-deps"* ]]; then
    ../../../eng/native/buildsystem/download-zig.py
    export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"
    sudo apt-get update
    sudo apt-get install build-essential git make \
        pkg-config cmake ninja-build gnome-desktop-testing libasound2-dev libpulse-dev \
        libaudio-dev libjack-dev libsndio-dev libx11-dev libxext-dev \
        libxrandr-dev libxcursor-dev libxfixes-dev libxi-dev libxss-dev \
        libxkbcommon-dev libdrm-dev libgbm-dev libgl1-mesa-dev libgles2-mesa-dev \
        libegl1-mesa-dev libdbus-1-dev libibus-1.0-dev libudev-dev fcitx-libs-dev \
        libpipewire-0.3-dev libwayland-dev libdecor-0-dev liburing-dev
    exit
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm/native
cp build/libSDL3.so runtimes/linux-arm/native

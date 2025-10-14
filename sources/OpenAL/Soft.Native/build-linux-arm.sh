#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi

if [ -d ../../../eng/native/buildsystem/zig ]; then
    export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"
fi

if [[ "$@" == *"--install-deps"* ]]; then
    ../../../eng/native/buildsystem/download-zig.py
    sudo apt-get update
    sudo apt-get install build-essential git make \
        pkg-config cmake ninja-build libasound2-dev libpulse-dev libsoundio-dev libsndfile1-dev libmysofa-dev \
        qtbase5-dev libdbus-1-dev libjack-dev portaudio19-dev libjack-dev libpipewire-0.3-dev qt6-base-dev
    exit
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft --debug-find -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.28.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm/native
cp build/libopenal.so runtimes/linux-arm/native

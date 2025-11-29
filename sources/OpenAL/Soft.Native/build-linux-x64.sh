#!/usr/bin/env -S bash -eu
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    sudo apt update
    sudo apt install -y libasound2-dev:amd64 libpulse-dev:amd64 libsoundio-dev:amd64 libsndfile1-dev:amd64 \
        libmysofa-dev:amd64 qtbase5-dev:amd64 libdbus-1-dev:amd64 libjack-dev:amd64 portaudio19-dev:amd64 git \
        cmake build-essential python3 libpipewire-0.3-dev:amd64 qt6-base-dev:amd64 pulseaudio:amd64
fi
if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/x86_64-linux-gnu.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-x64/native
cp build/libopenal.so runtimes/linux-x64/native

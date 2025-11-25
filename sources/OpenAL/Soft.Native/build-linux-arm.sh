#!/usr/bin/env -S bash -eu
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    if [[ ! -z ${SILKDOTNET_DockerBuild+x} ]]; then
        dpkg --add-architecture armhf
        apt update
        apt install -y libasound2-dev:armhf libpulse-dev:armhf libsoundio-dev:armhf libsndfile1-dev:armhf \
            libmysofa-dev:armhf qtbase5-dev:armhf libdbus-1-dev:armhf libjack-dev:armhf portaudio19-dev:armhf git \
            cmake python3 libpipewire-0.3-dev:armhf qt6-base-dev:armhf pulseaudio:armhf \
            gcc-arm-linux-gnueabihf g++-arm-linux-gnueabihf
    else
        docker="docker"
        if command -v podman >/dev/null 2>&1; then
            docker="podman"
        fi
        $docker run --platform linux/amd64 -e SILKDOTNET_DockerBuild=1 -e GITHUB_ACTIONS=1 -v $(readlink -f ../../../):/data debian bash -c "cd /data/sources/OpenAL/Soft.Native && ./build-linux-arm.sh"
        exit
    fi
fi
if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/arm-linux-gnueabihf.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm/native
cp build/libopenal.so runtimes/linux-arm/native

#!/usr/bin/env -S bash -eu
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    if [[ ! -z ${SILKDOTNET_DockerBuild+x} ]]; then
        dpkg --add-architecture arm64
        apt update
        apt install -y libasound2-dev:arm64 libpulse-dev:arm64 libsoundio-dev:arm64 libsndfile1-dev:arm64 \
            libmysofa-dev:arm64 qtbase5-dev:arm64 libdbus-1-dev:arm64 libjack-dev:arm64 portaudio19-dev:arm64 git \
            cmake python3 libpipewire-0.3-dev:arm64 qt6-base-dev:arm64 pulseaudio:arm64 \
            gcc-aarch64-linux-gnu g++-aarch64-linux-gnu
    else
        docker="docker"
        if command -v podman >/dev/null 2>&1; then
            docker="podman"
        fi
        $docker run --platform linux/amd64 -e SILKDOTNET_DockerBuild=1 -e GITHUB_ACTIONS=1 -v $(readlink -f ../../../):/data debian bash -c "cd /data/sources/OpenAL/Soft.Native && ./build-linux-arm64.sh"
        exit
    fi
fi
if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/aarch64-linux-gnu.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm64/native
cp build/libopenal.so runtimes/linux-arm64/native

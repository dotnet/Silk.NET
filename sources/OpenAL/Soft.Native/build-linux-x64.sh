#!/usr/bin/env -S bash -eu
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    if [[ ! -z ${SILKDOTNET_DockerBuild+x} ]]; then
        apt update
        apt install -y libasound2-dev:amd64 libpulse-dev:amd64 libsoundio-dev:amd64 libsndfile1-dev:amd64 \
            libmysofa-dev:amd64 qtbase5-dev:amd64 libdbus-1-dev:amd64 libjack-dev:amd64 portaudio19-dev:amd64 git \
            cmake build-essential python3 libpipewire-0.3-dev:amd64 qt6-base-dev:amd64 pulseaudio:amd64
        ../../../eng/native/buildsystem/download-zig.py
        export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"
    else
        docker="docker"
        if command -v podman >/dev/null 2>&1; then
            docker="podman"
        fi
        $docker run --platform linux/amd64 -e SILKDOTNET_DockerBuild=1 -e GITHUB_ACTIONS=1 -v $(readlink -f ../../../):/data debian bash -c "cd /data/sources/OpenAL/Soft.Native && ./build-linux-x64.sh"
        exit
    fi
fi
if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-x86_64-linux-gnu.2.28.cmake -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_RTKIT=ON -DALSOFT_REQUIRE_ALSA=ON -DALSOFT_REQUIRE_OSS=ON -DALSOFT_REQUIRE_PORTAUDIO=ON -DALSOFT_REQUIRE_PULSEAUDIO=ON -DALSOFT_REQUIRE_JACK=ON -DALSOFT_REQUIRE_PIPEWIRE=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-x64/native
cp build/libopenal.so runtimes/linux-x64/native

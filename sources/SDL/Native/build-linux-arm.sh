#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi

if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    ../../../eng/native/buildsystem/download-zig.py
    export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"

    # Enable ports repository
    sudo apt-get update
    sudo apt install lsb-release
    grep -q "^Architectures:" /etc/apt/sources.list.d/ubuntu.sources || sudo sed -i "/^Signed-By: /a Architectures: amd64" /etc/apt/sources.list.d/ubuntu.sources
    sudo tee /etc/apt/sources.list.d/ubuntu-ports.sources <<EOF
Types: deb
URIs: http://ports.ubuntu.com/ubuntu-ports/
Suites: $(lsb_release -sc) $(lsb_release -sc)-updates $(lsb_release -sc)-backports $(lsb_release -sc)-security
Components: main restricted universe multiverse
Architectures: armhf
Signed-By: /usr/share/keyrings/ubuntu-archive-keyring.gpg
EOF

    # Dependency list is from https://github.com/libsdl-org/SDL/blob/main/docs/README-linux.md#build-dependencies
    sudo dpkg --add-architecture armhf
    sudo apt-get update
    sudo apt-get install build-essential git make \
        pkg-config cmake ninja-build gnome-desktop-testing \
        libglib2.0-dev-bin \
        libasound2-dev:armhf libpulse-dev:armhf \
        libaudio-dev:armhf libfribidi-dev:armhf libjack-dev:armhf libsndio-dev:armhf libx11-dev:armhf libxext-dev:armhf \
        libxrandr-dev:armhf libxcursor-dev:armhf libxfixes-dev:armhf libxi-dev:armhf libxss-dev:armhf libxtst-dev:armhf \
        libxkbcommon-dev:armhf libdrm-dev:armhf libgbm-dev:armhf libgl1-mesa-dev:armhf libgles2-mesa-dev:armhf \
        libegl1-mesa-dev:armhf libdbus-1-dev:armhf libibus-1.0-dev:armhf libudev-dev:armhf libthai-dev:armhf \
        libpipewire-0.3-dev:armhf libwayland-dev:armhf libdecor-0-dev:armhf liburing-dev:armhf
fi
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_BUILD_TYPE=Release -DCMAKE_TOOLCHAIN_FILE=../../../../eng/native/cmake/zig-toolchain-arm-linux-gnueabihf.2.34.cmake -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/linux-arm/native
cp build/libSDL3.so runtimes/linux-arm/native

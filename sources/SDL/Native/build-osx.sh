#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi

if [[ "$@" == *"--install-deps"* ]]; then
    exit
fi

rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" -DCMAKE_OSX_DEPLOYMENT_TARGET=10.11 -DCMAKE_BUILD_TYPE=Release
cmake --build . --parallel
cd ..
mkdir -p runtimes/osx/native
cp build/libSDL3.dylib runtimes/osx/native

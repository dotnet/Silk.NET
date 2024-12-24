#!/usr/bin/env -S bash -eu

if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi

rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl -DCMAKE_SYSTEM_NAME=tvOS -DCMAKE_OSX_SYSROOT=appletvos "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=9.0 -DCMAKE_BUILD_TYPE=Release -DSDL_STATIC=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/tvos/native
cp build/libSDL3.a runtimes/tvos/native

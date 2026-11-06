#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/sdl "-DCMAKE_OSX_ARCHITECTURES=arm64;x86_64" -DCMAKE_OSX_DEPLOYMENT_TARGET=10.11 -DCMAKE_BUILD_TYPE=Release -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/osx/native
cp build/libSDL3.dylib runtimes/osx/native

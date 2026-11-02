#!/usr/bin/env -S bash -eu

# Build
rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_SYSTEM_NAME=iOS -DCMAKE_OSX_SYSROOT=iphoneos "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=16.3 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_COREAUDIO=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/ios/native
cp build/libopenal.dylib runtimes/ios/native

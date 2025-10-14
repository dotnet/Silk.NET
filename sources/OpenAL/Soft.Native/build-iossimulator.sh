#!/usr/bin/env -S bash -eu
if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi

if [[ "$@" == *"--install-deps"* ]]; then
  exit
fi

rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DCMAKE_SYSTEM_NAME=iOS -DCMAKE_OSX_SYSROOT=iphonesimulator "-DCMAKE_OSX_ARCHITECTURES=arm64" -DCMAKE_OSX_DEPLOYMENT_TARGET=16.3 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_REQUIRE_COREAUDIO=ON
cmake --build . --parallel
cd ..
mkdir -p runtimes/iossimulator/native
cp build/libopenal.dylib runtimes/iossimulator/native

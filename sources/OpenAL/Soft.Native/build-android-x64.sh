#!/usr/bin/env -S bash -eu

if [ ! -e ../../../eng/submodules/openal-soft/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/openal-soft
fi

if [ ! -z "$GITHUB_ACTIONS" ]; then
  # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
  sdkmanager=( /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager )
  ${sdkmanager[-1]} --install "platforms;android-21"
fi

rm -rf build
mkdir build
cd build
cmake ../../../../eng/submodules/openal-soft -DANDROID_ABI=x86_64 -DCMAKE_TOOLCHAIN_FILE="${ANDROID_NDK_HOME}/build/cmake/android.toolchain.cmake" -DANDROID_PLATFORM=21 -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF
cmake --build . --parallel
cd ..
mkdir -p runtimes/android-x64/native
cp build/libopenal.so runtimes/android-x64/native

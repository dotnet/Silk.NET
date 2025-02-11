#!/usr/bin/env -S bash -eu

if [ ! -e ../../../eng/submodules/sdl/CMakeLists.txt ]; then
    git submodule update --init --recursive --depth 1 ../../../eng/submodules/sdl
fi

python="python"
if [ ! -z "$GITHUB_ACTIONS" ]; then
  # NDK already installed: https://github.com/actions/runner-images/blob/main/images/ubuntu/Ubuntu2404-Readme.md
  sdkmanager=( /usr/local/lib/android/sdk/cmdline-tools/*/bin/sdkmanager )
  ${sdkmanager[-1]} --install "platforms;android-19"
  sudo add-apt-repository ppa:deadsnakes/ppa
  sudo apt update
  sudo apt install python3.11 ninja-build
  python="python3.11"
fi

$python ../../../eng/submodules/sdl/build-scripts/build-release.py --actions android --root ../../../eng/submodules/sdl
mkdir -p runtimes/android-x86/native runtimes/android-x64/native runtimes/android-arm/native runtimes/android-arm64/native android
cp ../../../eng/submodules/sdl/install-android/arm64-v8a-install/lib/libSDL3.so runtimes/android-arm64/native
cp ../../../eng/submodules/sdl/install-android/armeabi-v7a-install/lib/libSDL3.so runtimes/android-arm/native
cp ../../../eng/submodules/sdl/install-android/x86-install/lib/libSDL3.so runtimes/android-x86/native
cp ../../../eng/submodules/sdl/install-android/x86_64-install/lib/libSDL3.so runtimes/android-x64/native
jars=( ../../../eng/submodules/sdl/install-android/armeabi-v7a-install/share/java/SDL3/SDL3-*.jar )
cp "${jars[1]}" android/SDL3.jar
cp "$(dirname "${jars[1]}")/proguard.txt" android/proguard.txt

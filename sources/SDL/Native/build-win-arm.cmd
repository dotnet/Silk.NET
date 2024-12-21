if not exist "../../../eng/submodules/sdl/CMakeLists.txt" (
    git submodule update --init --recursive --depth 1 ..\..\..\eng\submodules\sdl
)

rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\sdl -A arm -DCMAKE_BUILD_TYPE=Release
cmake --build . --parallel
cd ..
mkdir runtimes\win-arm\native
copy build\SDL3.dll runtimes\win-arm\native

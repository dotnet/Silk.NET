if not exist "../../../eng/submodules/sdl/CMakeLists.txt" (
    git submodule update --init --recursive --depth 1 ..\..\..\eng\submodules\sdl
)

rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\sdl -DCMAKE_BUILD_TYPE=Release
cmake --build . --parallel
cd ..
mkdir runtimes\win-x64\native
copy build\Release\SDL3.dll runtimes\win-x64\native

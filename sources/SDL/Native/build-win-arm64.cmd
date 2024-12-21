if not exist "../../../eng/submodules/sdl/CMakeLists.txt" (
    git submodule update --init --recursive --depth 1 ..\..\..\eng\submodules\sdl
)

call "C:\Program Files (x86)\Microsoft Visual Studio 17.0\VC\vcvarsall.bat" arm64
rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\sdl -A arm64 -DCMAKE_BUILD_TYPE=Release
cmake --build . --parallel
cd ..
mkdir runtimes\win-arm64\native
copy build\Release\SDL3.dll runtimes\win-arm64\native

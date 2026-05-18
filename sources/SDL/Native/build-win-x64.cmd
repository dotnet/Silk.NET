@REM Submodule
if not exist "../../../eng/submodules/sdl/CMakeLists.txt" (
    git submodule update --init --recursive --depth 1 ..\..\..\eng\submodules\sdl
)

@REM Build
call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\VC\Auxiliary\Build\vcvarsall.bat" x64
rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\sdl -G Ninja -DCMAKE_BUILD_TYPE=Release -DSDL_TEST_LIBRARY=OFF
cmake --build . --parallel
cd ..
mkdir runtimes\win-x64\native
copy build\SDL3.dll runtimes\win-x64\native

if not exist "../../../eng/submodules/sdl/CMakeLists.txt" (
    git submodule update --init --recursive --depth 1 ..\..\..\eng\submodules\sdl
)

call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\VC\Auxiliary\Build\vcvarsall.bat" x64
rd /s /q build
mkdir build
cd build
cmake ..\..\..\..\eng\submodules\sdl -DCMAKE_BUILD_TYPE=Release -DALSOFT_UTILS=OFF -DALSOFT_EXAMPLES=OFF -DALSOFT_BUILD_ROUTER=ON -A x64
cmake --build . --parallel --config Release
cd ..
mkdir runtimes\win-x64\native
copy build\Release\OpenAL32.dll runtimes\win-x64\native
copy build\Release\soft_oal.dll runtimes\win-x64\native

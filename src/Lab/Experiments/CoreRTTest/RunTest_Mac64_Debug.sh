#!/bin/sh
dotnet publish -r osx-x64 -c Debug
cp ./bin/Debug/net5.0/osx-x64/libglfw.3.dylib ./bin/Debug/net5.0/osx-x64/native/libglfw.3.dylib
cp ./bin/Debug/net5.0/osx-x64/lighting.frag ./bin/Debug/net5.0/osx-x64/native/lighting.frag
cp ./bin/Debug/net5.0/osx-x64/shader.frag ./bin/Debug/net5.0/osx-x64/native/shader.frag
cp ./bin/Debug/net5.0/osx-x64/shader.vert ./bin/Debug/net5.0/osx-x64/native/shader.vert
cp ./bin/Debug/net5.0/osx-x64/silkBoxed.png ./bin/Debug/net5.0/osx-x64/native/silkBoxed.png
cp ./bin/Debug/net5.0/osx-x64/silkSpecular.png ./bin/Debug/net5.0/osx-x64/native/silkSpecular.png
cd ./bin/Debug/net5.0/osx-x64/native/
./CoreRTTest
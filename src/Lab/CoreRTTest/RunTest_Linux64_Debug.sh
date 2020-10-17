#!/bin/sh
dotnet publish -r linux-x64 -c Debug
cp ./bin/Debug/net5.0/linux-x64/libglfw.so.3 ./bin/Debug/net5.0/linux-x64/native/libglfw.so.3
cp ./bin/Debug/net5.0/linux-x64/lighting.frag ./bin/Debug/net5.0/linux-x64/native/lighting.frag
cp ./bin/Debug/net5.0/linux-x64/shader.frag ./bin/Debug/net5.0/linux-x64/native/shader.frag
cp ./bin/Debug/net5.0/linux-x64/shader.vert ./bin/Debug/net5.0/linux-x64/native/shader.vert
cp ./bin/Debug/net5.0/linux-x64/silkBoxed.png ./bin/Debug/net5.0/linux-x64/native/silkBoxed.png
cp ./bin/Debug/net5.0/linux-x64/silkSpecular.png ./bin/Debug/net5.0/linux-x64/native/silkSpecular.png
cd ./bin/Debug/net5.0/linux-x64/native/
./CoreRTTest
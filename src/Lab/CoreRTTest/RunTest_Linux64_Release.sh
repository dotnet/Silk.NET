#!/bin/sh
dotnet publish -r linux-x64 -c Release
cp ./bin/Release/net5.0/linux-x64/libglfw.so.3 ./bin/Release/net5.0/linux-x64/native/libglfw.so.3
cp ./bin/Release/net5.0/linux-x64/lighting.frag ./bin/Release/net5.0/linux-x64/native/lighting.frag
cp ./bin/Release/net5.0/linux-x64/shader.frag ./bin/Release/net5.0/linux-x64/native/shader.frag
cp ./bin/Release/net5.0/linux-x64/shader.vert ./bin/Release/net5.0/linux-x64/native/shader.vert
cp ./bin/Release/net5.0/linux-x64/silkBoxed.png ./bin/Release/net5.0/linux-x64/native/silkBoxed.png
cp ./bin/Release/net5.0/linux-x64/silkSpecular.png ./bin/Release/net5.0/linux-x64/native/silkSpecular.png
cd ./bin/Release/net5.0/linux-x64/native/
./CoreRTTest
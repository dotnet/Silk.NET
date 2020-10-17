#!/bin/sh
dotnet publish -r osx-x64 -c Release
cp ./bin/Release/net5.0/osx-x64/libglfw.3.dylib ./bin/Release/net5.0/osx-x64/native/libglfw.3.dylib
cp ./bin/Release/net5.0/osx-x64/lighting.frag ./bin/Release/net5.0/osx-x64/native/lighting.frag
cp ./bin/Release/net5.0/osx-x64/shader.frag ./bin/Release/net5.0/osx-x64/native/shader.frag
cp ./bin/Release/net5.0/osx-x64/shader.vert ./bin/Release/net5.0/osx-x64/native/shader.vert
cp ./bin/Release/net5.0/osx-x64/silkBoxed.png ./bin/Release/net5.0/osx-x64/native/silkBoxed.png
cp ./bin/Release/net5.0/osx-x64/silkSpecular.png ./bin/Release/net5.0/osx-x64/native/silkSpecular.png
cd ./bin/Release/net5.0/osx-x64/native/
./CoreRTTest
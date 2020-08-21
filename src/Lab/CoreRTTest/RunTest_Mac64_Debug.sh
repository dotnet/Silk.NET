#!/bin/sh
dotnet publish -r osx-x64 -c Debug
cp ./bin/Debug/netcoreapp3.0/osx-x64/libglfw.3.dylib ./bin/Debug/netcoreapp3.0/osx-x64/native/libglfw.3.dylib
cd ./bin/Debug/netcoreapp3.0/osx-x64/native/
./CoreRTTest
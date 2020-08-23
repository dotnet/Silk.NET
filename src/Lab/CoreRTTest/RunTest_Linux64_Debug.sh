#!/bin/sh
dotnet publish -r linux-x64 -c Debug
cp ./bin/Debug/netcoreapp3.0/linux-x64/libglfw.so.3 ./bin/Debug/netcoreapp3.0/linux-x64/native/libglfw.so.3
cd ./bin/Debug/netcoreapp3.0/linux-x64/native/
./CoreRTTest
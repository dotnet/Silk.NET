echo off
cd ..\..\SilkDroid
call build
echo off
copy bin\org.libsdl.app.jar ..\Silk.NET.Windowing.Sdl.Android\Jars
echo on
echo off
cd ..\..\SilkDroid
call gradlew build
copy app\build\outputs\aar\app-release.aar ..\Silk.NET.Windowing.Sdl.Android\Jars
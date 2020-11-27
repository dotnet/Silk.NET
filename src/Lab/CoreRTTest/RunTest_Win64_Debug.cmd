dotnet publish -r win-x64 -c Debug
copy .\bin\Debug\net5.0\win-x64\glfw3.dll .\bin\Debug\net5.0\win-x64\native\glfw3.dll
copy .\bin\Release\net5.0\win-x64\sdl2.dll .\bin\Release\net5.0\win-x64\native\sdl2.dll
copy .\bin\Debug\net5.0\win-x64\lighting.frag .\bin\Debug\net5.0\win-x64\native\lighting.frag
copy .\bin\Debug\net5.0\win-x64\shader.frag .\bin\Debug\net5.0\win-x64\native\shader.frag
copy .\bin\Debug\net5.0\win-x64\shader.vert .\bin\Debug\net5.0\win-x64\native\shader.vert
copy .\bin\Debug\net5.0\win-x64\silkBoxed.png .\bin\Debug\net5.0\win-x64\native\silkBoxed.png
copy .\bin\Debug\net5.0\win-x64\silkSpecular.png .\bin\Debug\net5.0\win-x64\native\silkSpecular.png
cd .\bin\Debug\net5.0\win-x64\native\
.\CoreRTTest
pause
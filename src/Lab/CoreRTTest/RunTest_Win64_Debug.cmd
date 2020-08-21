dotnet publish -r win-x64 -c Debug
copy .\bin\Debug\netcoreapp3.0\win-x64\glfw3.dll .\bin\Debug\netcoreapp3.0\win-x64\native\glfw3.dll
cd .\bin\Debug\netcoreapp3.0\win-x64\native\
.\CoreRTTest
pause
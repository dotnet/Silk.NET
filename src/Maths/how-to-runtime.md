For a user named "HurricanKai" and a runtime commit "commit", having added `jitutils\bin` to PATH already
```
git clone https://github.com/HurricanKai/runtime
git clone https://github.com/dotnet/runtime runtime_base
cd runtime
git remote add dotnet https://github.com/dotnet/runtime
git fetch --all
git reset --hard dotnet/master
.\build.cmd -subset clr -configuration Checked; .\build.cmd -subset clr -configuration Release; .\build.cmd -subset libs -configuration Release; .\src\coreclr\build-test.cmd x64 Release
cd ..\runtime_base
git checkout 'commit'
.\build.cmd -subset clr -configuration Checked; .\build.cmd -subset clr -configuration Release; .\build.cmd -subset libs -configuration Release; .\src\coreclr\build-test.cmd x64 Release
cd ..\runtime
jit-diff diff --pmi --diff --base --base_root ..\runtime_base
```
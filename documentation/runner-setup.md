# Windows Runner Setup

This contains the details of the environment in which bindings regeneration jobs run. If you would like to run BuildTools on your PC, this may contain useful information.

Windows Server 2022 Core was used in this guide, specifically an Azure F8s v2 VM.

## Silk.NET Hosting Resource Naming Convention

- Two letter country code.
- Three letter location name.
- Location number.
- Hyphen.
- Name of the machine.
- Number of the machine.
- `p` for physical or `v` for virtual. Omit this entirely for other types of resources.

For Azure locations, the last two letters of the three letter location name are `az`.

For example, `useaz1-githubrunner2v` is the second GitHub runner (`githubrunner2`) running in a VM (`v`) at the U.S. East 1 Azure (`useaz1`) datacenter.

## Commands executed following VM creation

### Runner setup
Commands:
```powershell
cd C:\
Invoke-WebRequest -Uri https://github.com/actions/runner/releases/download/v2.316.1/actions-runner-win-x64-2.316.1.zip -OutFile actions-runner-win-x64-2.316.1.zip
Add-Type -AssemblyName System.IO.Compression.FileSystem ; [System.IO.Compression.ZipFile]::ExtractToDirectory("$PWD/actions-runner-win-x64-2.316.1.zip", "$PWD")
./config.cmd --url https://github.com/dotnet/Silk.NET --token [redacted]
```

Terminal Window View:
```
--------------------------------------------------------------------------------
|        ____ _ _   _   _       _          _        _   _                      |
|       / ___(_) |_| | | |_   _| |__      / \   ___| |_(_) ___  _ __  ___      |
|      | |  _| | __| |_| | | | | '_ \    / _ \ / __| __| |/ _ \| '_ \/ __|     |
|      | |_| | | |_|  _  | |_| | |_) |  / ___ \ (__| |_| | (_) | | | \__ \     |
|       \____|_|\__|_| |_|\__,_|_.__/  /_/   \_\___|\__|_|\___/|_| |_|___/     |
|                                                                              |
|                       Self-hosted runner registration                        |
|                                                                              |
--------------------------------------------------------------------------------

# Authentication


√ Connected to GitHub

# Runner Registration

Enter the name of the runner group to add this runner to: [press Enter for Default]

Enter the name of runner: [press Enter for useaz1-githubru] useaz1-githubrunner2v

This runner will have the following labels: 'self-hosted', 'Windows', 'X64'
Enter any additional labels (ex. label-1,label-2): [press Enter to skip] windows-2022,windows-quick

√ Runner successfully added
√ Runner connection is good

# Runner settings

Enter name of work folder: [press Enter for _work] _

√ Settings Saved.

Would you like to run the runner as service? (Y/N) [press Enter for N] y
User account to use for the service [press Enter for NT AUTHORITY\NETWORK SERVICE]
Granting file permissions to 'NT AUTHORITY\NETWORK SERVICE'.
Service actions.runner.dotnet-Silk.NET.useaz1-githubrunner2v successfully installed
Service actions.runner.dotnet-Silk.NET.useaz1-githubrunner2v successfully set recovery option
Service actions.runner.dotnet-Silk.NET.useaz1-githubrunner2v successfully set to delayed auto start
Service actions.runner.dotnet-Silk.NET.useaz1-githubrunner2v successfully configured
Waiting for service to start...
Service actions.runner.dotnet-Silk.NET.useaz1-githubrunner2v started successfully
```

### Installing Visual Studio Build Tools

In 2.X we need to force Visual Studio Build Tools to a specific version due to newer versions containing newer MSVC versions with newer headers that aren't compatible with the older version of libclang/ClangSharp that we're currently locked to due to breaking changes in libclang Silk.NET.BuildTools can't readily recover from.

Commands:
```powershell
Invoke-WebRequest -Uri https://download.visualstudio.microsoft.com/download/pr/4bc0c2da-4e6d-4a88-9eaa-0748022737fb/71f8452bdc7437780b80979d84138e9f31fda34e1b28fa523be775a7b82a2a8c/vs_BuildTools.exe -OutFile vs_BuildTools.exe
Invoke-WebRequest -Uri https://catalog.s.download.windowsupdate.com/d/msdownload/update/software/secu/2022/12/visualstudioupdate-17.0.0to17.4.3-online_5831821151ec3845e4f2f27894871d69cacf6565.exe -OutFile vs17.4.3.exe
.\vs17.4.3.exe; Start-Sleep -Seconds 2; $source = "C:\Users\silkdotnet\AppData\Local\Temp\"; $bin = Get-ChildItem -Recurse -Path $source | Where-Object {$_.Name -match "ChannelManifest.json"}; foreach ($item in $bin) { Copy-Item -Path $item.FullName -Destination . };
.\vs_BuildTools.exe --channelURI "file:///C:\a\ChannelManifest.json" --quiet --norestart `
--add Microsoft.VisualStudio.Product.BuildTools `
--add Microsoft.VisualStudio.Component.Roslyn.Compiler `
--add Microsoft.Component.MSBuild `
--add Microsoft.VisualStudio.Component.CoreBuildTools `
--add Microsoft.VisualStudio.Workload.MSBuildTools `
--add Microsoft.VisualStudio.Component.Windows10SDK `
--add Microsoft.VisualStudio.Component.VC.CoreBuildTools `
--add Microsoft.VisualStudio.Component.VC.Tools.x86.x64 `
--add Microsoft.VisualStudio.Component.VC.Redist.14.Latest `
--add Microsoft.VisualStudio.Component.Windows11SDK.22000 `
--add Microsoft.VisualStudio.Component.VC.CMake.Project `
--add Microsoft.VisualStudio.Component.TestTools.BuildTools `
--add Microsoft.Net.Component.4.8.SDK `
--add Microsoft.Net.Component.4.7.2.TargetingPack `
--add Microsoft.VisualStudio.Component.VC.ASAN `
--add Microsoft.VisualStudio.Component.TextTemplating `
--add Microsoft.VisualStudio.Component.VC.CoreIde `
--add Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core `
--add Microsoft.VisualStudio.Component.VC.Llvm.ClangToolset `
--add Microsoft.VisualStudio.Component.VC.Llvm.Clang `
--add Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Llvm.Clang `
--add Microsoft.VisualStudio.ComponentGroup.VC.Tools.142.x86.x64 `
--add Microsoft.VisualStudio.Workload.VCTools `
--add Microsoft.VisualStudio.Component.NuGet.BuildTools `
--add Microsoft.Net.ComponentGroup.DevelopmentPrerequisites `
--add Microsoft.Net.Component.4.8.TargetingPack `
--add Microsoft.Net.ComponentGroup.4.8.DeveloperTools `
--add Microsoft.NetCore.Component.Runtime.6.0 `
--add Microsoft.NetCore.Component.Runtime.7.0 `
--add Microsoft.NetCore.Component.SDK `
--add Microsoft.Component.ClickOnce.MSBuild `
--add Microsoft.VisualStudio.Wcf.BuildTools.ComponentGroup `
--add Microsoft.Net.Component.3.5.DeveloperTools `
--add Microsoft.Net.Component.4.6.2.TargetingPack `
--add Microsoft.Net.Component.4.7.TargetingPack `
--add Microsoft.Net.Component.4.7.1.TargetingPack `
--add Microsoft.Net.ComponentGroup.4.6.2-4.7.1.DeveloperTools `
--add Microsoft.Net.Component.4.8.1.SDK `
--add Microsoft.Net.Component.4.8.1.TargetingPack `
--add Microsoft.Net.ComponentGroup.4.8.1.DeveloperTools `
--add microsoft.net.runtime.mono.tooling `
--add microsoft.net.sdk.emscripten.net7 `
--add wasm.tools `
--add microsoft.net.runtime.mono.tooling.net6 `
--add microsoft.net.sdk.emscripten.net6 `
--add wasm.tools.net6 `
--add Component.Android.SDK.MAUI `
--add Component.OpenJDK `
--add Microsoft.Component.NetFX.Native `
--add Microsoft.VisualStudio.ComponentGroup.UWP.BuildTools `
--add Microsoft.Net.Component.4.6.1.TargetingPack `
--add maui.core `
--add maui.blazor `
--add microsoft.net.runtime.android.net6 `
--add microsoft.net.runtime.android.aot.net6 `
--add microsoft.net.runtime.android `
--add microsoft.net.runtime.android.aot `
--add android `
--add maui.android `
--add runtimes.ios `
--add microsoft.net.runtime.ios `
--add runtimes.ios.net6 `
--add microsoft.net.runtime.ios.net6 `
--add ios `
--add maui.ios `
--add runtimes.maccatalyst `
--add microsoft.net.runtime.maccatalyst `
--add runtimes.maccatalyst.net6 `
--add microsoft.net.runtime.maccatalyst.net6 `
--add maccatalyst `
--add maui.maccatalyst `
--add maui.windows `
--add Microsoft.VisualStudio.Workload.XamarinBuildTools `
--add Microsoft.VisualStudio.Component.FSharp.MSBuild `
--add Microsoft.VisualStudio.Workload.ManagedDesktopBuildTools `
--add Microsoft.Net.Component.4.6.TargetingPack `
--add Microsoft.Net.Component.4.7.2.SDK `
--add Microsoft.VisualStudio.Component.VC.14.29.16.11.ARM64 `
--add Microsoft.VisualStudio.ComponentGroup.UWP.VC.v142.BuildTools `
--add Microsoft.VisualStudio.Workload.UniversalBuildTools `
--add Microsoft.Net.Core.Component.SDK.2.1 `
--add Microsoft.NetCore.Component.Runtime.3.1 `
--add Microsoft.NetCore.Component.Runtime.5.0
```

### Installing Windows SDK

Shouldn't be installed using the VS Installer as we'll miss out on the extra features available from using the Windows SDK installer directly.

```powershell
Invoke-WebRequest -Uri https://go.microsoft.com/fwlink/?linkid=2250105 -OutFile winsdk22621.exe
Invoke-WebRequest -Uri https://go.microsoft.com/fwlink/?linkid=2272610 -OutFile winsdk26100.exe
.\winsdk22621.exe /features + /q /norestart
.\winsdk26100.exe /features + /q /norestart
```

### Installing .NET 8

Our Visual Studio version doesn't come with .NET 8 so we'll install it separately.

```powershell
Invoke-WebRequest -Uri https://download.visualstudio.microsoft.com/download/pr/90486d8a-fb5a-41be-bfe4-ad292c06153f/6673965085e00f5b305bbaa0b931cc96/dotnet-sdk-8.0.300-win-x64.exe -OutFile dotnet8.exe
.\dotnet8.exe /install /quiet /norestart
dotnet workload install android ios maccatalyst ios tvos wasm-tools wasm-experimental wasi-experimental maui
```

### Installing Git

Totally didn't forget about this one.

```powershell
Invoke-WebRequest -Uri https://github.com/git-for-windows/git/releases/download/v2.45.1.windows.1/Git-2.45.1-64-bit.exe -OutFile gitinstall.exe
.\gitinstall.exe /install /verysilent /norestart
```

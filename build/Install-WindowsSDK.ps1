
$WinSdkTempDir = "C:\WinSdkTemp\"
$WinSdkSetupExe = "C:\WinSdkTemp\" + "WinSdkSetup.exe"

mkdir $WinSdkTempDir

$client = [System.Net.WebClient]::new()
$client.DownloadFile("https://go.microsoft.com/fwlink/p/?linkid=2120843", $WinSdkSetupExe)

Start-Process -Wait $WinSdkSetupExe "/features+ /q"
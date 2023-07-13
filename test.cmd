@ECHO OFF
powershell.exe -NoLogo -NoProfile -ExecutionPolicy ByPass -Command "& """%~dp0scripts\build.ps1""" -test %*"
EXIT /B %ERRORLEVEL%

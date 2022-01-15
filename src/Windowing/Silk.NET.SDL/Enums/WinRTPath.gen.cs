// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_system_L353_C9")]
    [NativeName("Name", "SDL_WinRT_Path")]
    public enum WinRTPath : int
    {
        [NativeName("Name", "SDL_WINRT_PATH_INSTALLED_LOCATION")]
        WinrtPathInstalledLocation = 0x0,
        [NativeName("Name", "SDL_WINRT_PATH_LOCAL_FOLDER")]
        WinrtPathLocalFolder = 0x1,
        [NativeName("Name", "SDL_WINRT_PATH_ROAMING_FOLDER")]
        WinrtPathRoamingFolder = 0x2,
        [NativeName("Name", "SDL_WINRT_PATH_TEMP_FOLDER")]
        WinrtPathTempFolder = 0x3,
    }
}

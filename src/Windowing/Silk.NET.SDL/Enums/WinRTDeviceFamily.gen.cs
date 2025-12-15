// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_system_L499_C9")]
    [NativeName("Name", "SDL_WinRT_DeviceFamily")]
    public enum WinRTDeviceFamily : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_UNKNOWN")]
        WinrtDevicefamilyUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Desktop\"")]
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_DESKTOP")]
        WinrtDevicefamilyDesktop = 0x1,
        [Obsolete("Deprecated in favour of \"Mobile\"")]
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_MOBILE")]
        WinrtDevicefamilyMobile = 0x2,
        [Obsolete("Deprecated in favour of \"Xbox\"")]
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_XBOX")]
        WinrtDevicefamilyXbox = 0x3,
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_DESKTOP")]
        Desktop = 0x1,
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_MOBILE")]
        Mobile = 0x2,
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_XBOX")]
        Xbox = 0x3,
    }
}

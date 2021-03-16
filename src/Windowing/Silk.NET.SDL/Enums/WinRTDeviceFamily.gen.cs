// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_system_L233_C9")]
    [NativeName("Name", "SDL_WinRT_DeviceFamily")]
    public enum WinRTDeviceFamily : int
    {
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_UNKNOWN")]
        WinrtDevicefamilyUnknown = 0x0,
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_DESKTOP")]
        WinrtDevicefamilyDesktop = 0x1,
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_MOBILE")]
        WinrtDevicefamilyMobile = 0x2,
        [NativeName("Name", "SDL_WINRT_DEVICEFAMILY_XBOX")]
        WinrtDevicefamilyXbox = 0x3,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_touch_L44_C9")]
    [NativeName("Name", "SDL_TouchDeviceType")]
    public enum TouchDeviceType : int
    {
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "SDL_TOUCH_DEVICE_INVALID")]
        TouchDeviceInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Direct\"")]
        [NativeName("Name", "SDL_TOUCH_DEVICE_DIRECT")]
        TouchDeviceDirect = 0x0,
        [Obsolete("Deprecated in favour of \"IndirectAbsolute\"")]
        [NativeName("Name", "SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE")]
        TouchDeviceIndirectAbsolute = 0x1,
        [Obsolete("Deprecated in favour of \"IndirectRelative\"")]
        [NativeName("Name", "SDL_TOUCH_DEVICE_INDIRECT_RELATIVE")]
        TouchDeviceIndirectRelative = 0x2,
        [NativeName("Name", "SDL_TOUCH_DEVICE_INVALID")]
        Invalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_TOUCH_DEVICE_DIRECT")]
        Direct = 0x0,
        [NativeName("Name", "SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE")]
        IndirectAbsolute = 0x1,
        [NativeName("Name", "SDL_TOUCH_DEVICE_INDIRECT_RELATIVE")]
        IndirectRelative = 0x2,
    }
}

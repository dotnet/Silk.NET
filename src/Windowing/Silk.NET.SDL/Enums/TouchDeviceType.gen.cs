// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_touch_L44_C9")]
    [NativeName("Name", "SDL_TouchDeviceType")]
    public enum TouchDeviceType : int
    {
        [NativeName("Name", "SDL_TOUCH_DEVICE_INVALID")]
        TouchDeviceInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_TOUCH_DEVICE_DIRECT")]
        TouchDeviceDirect = 0x0,
        [NativeName("Name", "SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE")]
        TouchDeviceIndirectAbsolute = 0x1,
        [NativeName("Name", "SDL_TOUCH_DEVICE_INDIRECT_RELATIVE")]
        TouchDeviceIndirectRelative = 0x2,
    }
}

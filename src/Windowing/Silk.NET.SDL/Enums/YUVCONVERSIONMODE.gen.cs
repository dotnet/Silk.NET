// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_surface_L104_C9")]
    [NativeName("Name", "SDL_YUV_CONVERSION_MODE")]
    public enum YUVCONVERSIONMODE
    {
        [NativeName("Name", "SDL_YUV_CONVERSION_JPEG")]
        YuvConversionJpeg = 0x0,
        [NativeName("Name", "SDL_YUV_CONVERSION_BT601")]
        YuvConversionBT601 = 0x1,
        [NativeName("Name", "SDL_YUV_CONVERSION_BT709")]
        YuvConversionBT709 = 0x2,
        [NativeName("Name", "SDL_YUV_CONVERSION_AUTOMATIC")]
        YuvConversionAutomatic = 0x3,
    }
}

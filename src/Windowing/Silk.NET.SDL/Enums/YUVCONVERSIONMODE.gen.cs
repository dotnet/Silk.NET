// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_surface_L106_C9")]
    [NativeName("Name", "SDL_YUV_CONVERSION_MODE")]
    public enum YUVCONVERSIONMODE : int
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

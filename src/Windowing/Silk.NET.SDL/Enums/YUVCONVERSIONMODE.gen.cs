// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_surface_L108_C9")]
    [NativeName("Name", "SDL_YUV_CONVERSION_MODE")]
    public enum YUVCONVERSIONMODE : int
    {
        [Obsolete("Deprecated in favour of \"Jpeg\"")]
        [NativeName("Name", "SDL_YUV_CONVERSION_JPEG")]
        YuvConversionJpeg = 0x0,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "SDL_YUV_CONVERSION_BT601")]
        YuvConversionBT601 = 0x1,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "SDL_YUV_CONVERSION_BT709")]
        YuvConversionBT709 = 0x2,
        [Obsolete("Deprecated in favour of \"Automatic\"")]
        [NativeName("Name", "SDL_YUV_CONVERSION_AUTOMATIC")]
        YuvConversionAutomatic = 0x3,
        [NativeName("Name", "SDL_YUV_CONVERSION_JPEG")]
        Jpeg = 0x0,
        [NativeName("Name", "SDL_YUV_CONVERSION_BT601")]
        BT601 = 0x1,
        [NativeName("Name", "SDL_YUV_CONVERSION_BT709")]
        BT709 = 0x2,
        [NativeName("Name", "SDL_YUV_CONVERSION_AUTOMATIC")]
        Automatic = 0x3,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapAlphaChannelOption")]
    public enum WICBitmapAlphaChannelOption : int
    {
        [Obsolete("Deprecated in favour of \"BitmapUseAlpha\"")]
        [NativeName("Name", "WICBitmapUseAlpha")]
        WicbitmapUseAlpha = 0x0,
        [Obsolete("Deprecated in favour of \"BitmapUsePremultipliedAlpha\"")]
        [NativeName("Name", "WICBitmapUsePremultipliedAlpha")]
        WicbitmapUsePremultipliedAlpha = 0x1,
        [Obsolete("Deprecated in favour of \"BitmapIgnoreAlpha\"")]
        [NativeName("Name", "WICBitmapIgnoreAlpha")]
        WicbitmapIgnoreAlpha = 0x2,
        [Obsolete("Deprecated in favour of \"ItmapalphachanneloptionsForceDword\"")]
        [NativeName("Name", "WICBITMAPALPHACHANNELOPTIONS_FORCE_DWORD")]
        WicbitmapalphachanneloptionsForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICBitmapUseAlpha")]
        BitmapUseAlpha = 0x0,
        [NativeName("Name", "WICBitmapUsePremultipliedAlpha")]
        BitmapUsePremultipliedAlpha = 0x1,
        [NativeName("Name", "WICBitmapIgnoreAlpha")]
        BitmapIgnoreAlpha = 0x2,
        [NativeName("Name", "WICBITMAPALPHACHANNELOPTIONS_FORCE_DWORD")]
        ItmapalphachanneloptionsForceDword = 0x7FFFFFFF,
    }
}

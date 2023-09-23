// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapAlphaChannelOption")]
    public enum BitmapAlphaChannelOption : int
    {
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

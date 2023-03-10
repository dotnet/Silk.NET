// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS")]
    public enum ImageSourceFromDxgiOptions : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_NONE")]
        ImageSourceFromDxgiOptionsNone = 0x0,
        [Obsolete("Deprecated in favour of \"LowQualityPrimaryConversion\"")]
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_LOW_QUALITY_PRIMARY_CONVERSION")]
        ImageSourceFromDxgiOptionsLowQualityPrimaryConversion = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_FORCE_DWORD")]
        ImageSourceFromDxgiOptionsForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_LOW_QUALITY_PRIMARY_CONVERSION")]
        LowQualityPrimaryConversion = 0x1,
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

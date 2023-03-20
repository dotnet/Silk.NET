// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS")]
    public enum ImageSourceFromDxgiOptions : int
    {
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_LOW_QUALITY_PRIMARY_CONVERSION")]
        LowQualityPrimaryConversion = 0x1,
        [NativeName("Name", "D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_VideoLighting")]
    public enum DXVA2VideoLighting : int
    {
        [Obsolete("Deprecated in favour of \"VideoLightingMask\"")]
        [NativeName("Name", "DXVA2_VideoLightingMask")]
        DXVA2VideoLightingMask = 0xF,
        [Obsolete("Deprecated in favour of \"VideoLightingUnknown\"")]
        [NativeName("Name", "DXVA2_VideoLighting_Unknown")]
        DXVA2VideoLightingUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"VideoLightingBright\"")]
        [NativeName("Name", "DXVA2_VideoLighting_bright")]
        DXVA2VideoLightingBright = 0x1,
        [Obsolete("Deprecated in favour of \"VideoLightingOffice\"")]
        [NativeName("Name", "DXVA2_VideoLighting_office")]
        DXVA2VideoLightingOffice = 0x2,
        [Obsolete("Deprecated in favour of \"VideoLightingDim\"")]
        [NativeName("Name", "DXVA2_VideoLighting_dim")]
        DXVA2VideoLightingDim = 0x3,
        [Obsolete("Deprecated in favour of \"VideoLightingDark\"")]
        [NativeName("Name", "DXVA2_VideoLighting_dark")]
        DXVA2VideoLightingDark = 0x4,
        [NativeName("Name", "DXVA2_VideoLightingMask")]
        VideoLightingMask = 0xF,
        [NativeName("Name", "DXVA2_VideoLighting_Unknown")]
        VideoLightingUnknown = 0x0,
        [NativeName("Name", "DXVA2_VideoLighting_bright")]
        VideoLightingBright = 0x1,
        [NativeName("Name", "DXVA2_VideoLighting_office")]
        VideoLightingOffice = 0x2,
        [NativeName("Name", "DXVA2_VideoLighting_dim")]
        VideoLightingDim = 0x3,
        [NativeName("Name", "DXVA2_VideoLighting_dark")]
        VideoLightingDark = 0x4,
    }
}

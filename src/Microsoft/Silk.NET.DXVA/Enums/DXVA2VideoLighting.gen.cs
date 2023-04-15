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
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_VideoLightingMask")]
        DXVA2VideoLightingMask = 0xF,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_VideoLighting_Unknown")]
        DXVA2VideoLightingUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Bright\"")]
        [NativeName("Name", "DXVA2_VideoLighting_bright")]
        DXVA2VideoLightingBright = 0x1,
        [Obsolete("Deprecated in favour of \"Office\"")]
        [NativeName("Name", "DXVA2_VideoLighting_office")]
        DXVA2VideoLightingOffice = 0x2,
        [Obsolete("Deprecated in favour of \"Dim\"")]
        [NativeName("Name", "DXVA2_VideoLighting_dim")]
        DXVA2VideoLightingDim = 0x3,
        [Obsolete("Deprecated in favour of \"Dark\"")]
        [NativeName("Name", "DXVA2_VideoLighting_dark")]
        DXVA2VideoLightingDark = 0x4,
        [NativeName("Name", "DXVA2_VideoLightingMask")]
        Mask = 0xF,
        [NativeName("Name", "DXVA2_VideoLighting_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA2_VideoLighting_bright")]
        Bright = 0x1,
        [NativeName("Name", "DXVA2_VideoLighting_office")]
        Office = 0x2,
        [NativeName("Name", "DXVA2_VideoLighting_dim")]
        Dim = 0x3,
        [NativeName("Name", "DXVA2_VideoLighting_dark")]
        Dark = 0x4,
    }
}

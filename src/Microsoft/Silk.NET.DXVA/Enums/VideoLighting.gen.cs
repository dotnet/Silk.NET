// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_VideoLighting")]
    public enum VideoLighting : int
    {
        [Obsolete("Deprecated in favour of \"Shift\"")]
        [NativeName("Name", "DXVA_VideoLightingShift")]
        VideoLightingShift = 0x12,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA_VideoLightingMask")]
        VideoLightingMask = 0x3C0000,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA_VideoLighting_Unknown")]
        VideoLightingUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Bright\"")]
        [NativeName("Name", "DXVA_VideoLighting_bright")]
        VideoLightingBright = 0x1,
        [Obsolete("Deprecated in favour of \"Office\"")]
        [NativeName("Name", "DXVA_VideoLighting_office")]
        VideoLightingOffice = 0x2,
        [Obsolete("Deprecated in favour of \"Dim\"")]
        [NativeName("Name", "DXVA_VideoLighting_dim")]
        VideoLightingDim = 0x3,
        [Obsolete("Deprecated in favour of \"Dark\"")]
        [NativeName("Name", "DXVA_VideoLighting_dark")]
        VideoLightingDark = 0x4,
        [NativeName("Name", "DXVA_VideoLightingShift")]
        Shift = 0x12,
        [NativeName("Name", "DXVA_VideoLightingMask")]
        Mask = 0x3C0000,
        [NativeName("Name", "DXVA_VideoLighting_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA_VideoLighting_bright")]
        Bright = 0x1,
        [NativeName("Name", "DXVA_VideoLighting_office")]
        Office = 0x2,
        [NativeName("Name", "DXVA_VideoLighting_dim")]
        Dim = 0x3,
        [NativeName("Name", "DXVA_VideoLighting_dark")]
        Dark = 0x4,
    }
}

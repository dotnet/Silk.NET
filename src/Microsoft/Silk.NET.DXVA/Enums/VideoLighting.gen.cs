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
        [NativeName("Name", "DXVA_VideoLightingShift")]
        VideoLightingShift = 0x12,
        [NativeName("Name", "DXVA_VideoLightingMask")]
        VideoLightingMask = 0x3C0000,
        [NativeName("Name", "DXVA_VideoLighting_Unknown")]
        VideoLightingUnknown = 0x0,
        [NativeName("Name", "DXVA_VideoLighting_bright")]
        VideoLightingBright = 0x1,
        [NativeName("Name", "DXVA_VideoLighting_office")]
        VideoLightingOffice = 0x2,
        [NativeName("Name", "DXVA_VideoLighting_dim")]
        VideoLightingDim = 0x3,
        [NativeName("Name", "DXVA_VideoLighting_dark")]
        VideoLightingDark = 0x4,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA2_SampleFlags")]
    public enum DXVA2SampleFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PaletteChanged\"")]
        [NativeName("Name", "DXVA2_SampleFlag_Palette_Changed")]
        DXVA2SampleFlagPaletteChanged = 0x1,
        [Obsolete("Deprecated in favour of \"SrcRectChanged\"")]
        [NativeName("Name", "DXVA2_SampleFlag_SrcRect_Changed")]
        DXVA2SampleFlagSrcRectChanged = 0x2,
        [Obsolete("Deprecated in favour of \"DstRectChanged\"")]
        [NativeName("Name", "DXVA2_SampleFlag_DstRect_Changed")]
        DXVA2SampleFlagDstRectChanged = 0x4,
        [Obsolete("Deprecated in favour of \"ColorDataChanged\"")]
        [NativeName("Name", "DXVA2_SampleFlag_ColorData_Changed")]
        DXVA2SampleFlagColorDataChanged = 0x8,
        [Obsolete("Deprecated in favour of \"PlanarAlphaChanged\"")]
        [NativeName("Name", "DXVA2_SampleFlag_PlanarAlpha_Changed")]
        DXVA2SampleFlagPlanarAlphaChanged = 0x10,
        [Obsolete("Deprecated in favour of \"Rff\"")]
        [NativeName("Name", "DXVA2_SampleFlag_RFF")]
        DXVA2SampleFlagRff = 0x10000,
        [Obsolete("Deprecated in favour of \"Tff\"")]
        [NativeName("Name", "DXVA2_SampleFlag_TFF")]
        DXVA2SampleFlagTff = 0x20000,
        [Obsolete("Deprecated in favour of \"RffTffPresent\"")]
        [NativeName("Name", "DXVA2_SampleFlag_RFF_TFF_Present")]
        DXVA2SampleFlagRffTffPresent = 0x40000,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_SampleFlagsMask")]
        DXVA2SampleFlagsMask = unchecked((int) 0xFFFFFFFFFFFF001F),
        [NativeName("Name", "DXVA2_SampleFlag_Palette_Changed")]
        PaletteChanged = 0x1,
        [NativeName("Name", "DXVA2_SampleFlag_SrcRect_Changed")]
        SrcRectChanged = 0x2,
        [NativeName("Name", "DXVA2_SampleFlag_DstRect_Changed")]
        DstRectChanged = 0x4,
        [NativeName("Name", "DXVA2_SampleFlag_ColorData_Changed")]
        ColorDataChanged = 0x8,
        [NativeName("Name", "DXVA2_SampleFlag_PlanarAlpha_Changed")]
        PlanarAlphaChanged = 0x10,
        [NativeName("Name", "DXVA2_SampleFlag_RFF")]
        Rff = 0x10000,
        [NativeName("Name", "DXVA2_SampleFlag_TFF")]
        Tff = 0x20000,
        [NativeName("Name", "DXVA2_SampleFlag_RFF_TFF_Present")]
        RffTffPresent = 0x40000,
        [NativeName("Name", "DXVA2_SampleFlagsMask")]
        Mask = unchecked((int) 0xFFFFFFFFFFFF001F),
    }
}

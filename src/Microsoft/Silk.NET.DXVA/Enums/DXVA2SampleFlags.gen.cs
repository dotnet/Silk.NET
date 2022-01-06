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
        [NativeName("Name", "DXVA2_SampleFlag_Palette_Changed")]
        DXVA2SampleFlagPaletteChanged = 0x1,
        [NativeName("Name", "DXVA2_SampleFlag_SrcRect_Changed")]
        DXVA2SampleFlagSrcRectChanged = 0x2,
        [NativeName("Name", "DXVA2_SampleFlag_DstRect_Changed")]
        DXVA2SampleFlagDstRectChanged = 0x4,
        [NativeName("Name", "DXVA2_SampleFlag_ColorData_Changed")]
        DXVA2SampleFlagColorDataChanged = 0x8,
        [NativeName("Name", "DXVA2_SampleFlag_PlanarAlpha_Changed")]
        DXVA2SampleFlagPlanarAlphaChanged = 0x10,
        [NativeName("Name", "DXVA2_SampleFlag_RFF")]
        DXVA2SampleFlagRff = 0x10000,
        [NativeName("Name", "DXVA2_SampleFlag_TFF")]
        DXVA2SampleFlagTff = 0x20000,
        [NativeName("Name", "DXVA2_SampleFlag_RFF_TFF_Present")]
        DXVA2SampleFlagRffTffPresent = 0x40000,
        [NativeName("Name", "DXVA2_SampleFlagsMask")]
        DXVA2SampleFlagsMask = unchecked((int) 0xFFFFFFFFFFFF001F),
    }
}

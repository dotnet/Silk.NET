// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_SampleFlags")]
    public enum SampleFlags : int
    {
        [NativeName("Name", "DXVA_SampleFlagsMask")]
        SampleFlagsMask = 0xF,
        [NativeName("Name", "DXVA_SampleFlag_Palette_Changed")]
        SampleFlagPaletteChanged = 0x1,
        [NativeName("Name", "DXVA_SampleFlag_SrcRect_Changed")]
        SampleFlagSrcRectChanged = 0x2,
        [NativeName("Name", "DXVA_SampleFlag_DstRect_Changed")]
        SampleFlagDstRectChanged = 0x4,
        [NativeName("Name", "DXVA_SampleFlag_ColorData_Changed")]
        SampleFlagColorDataChanged = 0x8,
    }
}

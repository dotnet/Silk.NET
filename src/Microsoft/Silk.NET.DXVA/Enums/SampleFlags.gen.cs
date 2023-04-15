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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FlagsMask\"")]
        [NativeName("Name", "DXVA_SampleFlagsMask")]
        SampleFlagsMask = 0xF,
        [Obsolete("Deprecated in favour of \"FlagPaletteChanged\"")]
        [NativeName("Name", "DXVA_SampleFlag_Palette_Changed")]
        SampleFlagPaletteChanged = 0x1,
        [Obsolete("Deprecated in favour of \"FlagSrcRectChanged\"")]
        [NativeName("Name", "DXVA_SampleFlag_SrcRect_Changed")]
        SampleFlagSrcRectChanged = 0x2,
        [Obsolete("Deprecated in favour of \"FlagDstRectChanged\"")]
        [NativeName("Name", "DXVA_SampleFlag_DstRect_Changed")]
        SampleFlagDstRectChanged = 0x4,
        [Obsolete("Deprecated in favour of \"FlagColorDataChanged\"")]
        [NativeName("Name", "DXVA_SampleFlag_ColorData_Changed")]
        SampleFlagColorDataChanged = 0x8,
        [NativeName("Name", "DXVA_SampleFlagsMask")]
        FlagsMask = 0xF,
        [NativeName("Name", "DXVA_SampleFlag_Palette_Changed")]
        FlagPaletteChanged = 0x1,
        [NativeName("Name", "DXVA_SampleFlag_SrcRect_Changed")]
        FlagSrcRectChanged = 0x2,
        [NativeName("Name", "DXVA_SampleFlag_DstRect_Changed")]
        FlagDstRectChanged = 0x4,
        [NativeName("Name", "DXVA_SampleFlag_ColorData_Changed")]
        FlagColorDataChanged = 0x8,
    }
}

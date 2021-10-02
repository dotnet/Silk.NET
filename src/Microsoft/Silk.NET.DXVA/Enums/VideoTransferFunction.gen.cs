// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_VideoTransferFunction")]
    public enum VideoTransferFunction : int
    {
        [NativeName("Name", "DXVA_VideoTransFuncShift")]
        VideoTransFuncShift = 0x1B,
        [NativeName("Name", "DXVA_VideoTransFuncMask")]
        VideoTransFuncMask = unchecked((int) 0xFFFFFFFFF8000000),
        [NativeName("Name", "DXVA_VideoTransFunc_Unknown")]
        VideoTransFuncUnknown = 0x0,
        [NativeName("Name", "DXVA_VideoTransFunc_10")]
        VideoTransFunc10 = 0x1,
        [NativeName("Name", "DXVA_VideoTransFunc_18")]
        VideoTransFunc18 = 0x2,
        [NativeName("Name", "DXVA_VideoTransFunc_20")]
        VideoTransFunc20 = 0x3,
        [NativeName("Name", "DXVA_VideoTransFunc_22")]
        VideoTransFunc22 = 0x4,
        [NativeName("Name", "DXVA_VideoTransFunc_22_709")]
        VideoTransFunc22709 = 0x5,
        [NativeName("Name", "DXVA_VideoTransFunc_22_240M")]
        VideoTransFunc22240M = 0x6,
        [NativeName("Name", "DXVA_VideoTransFunc_22_8bit_sRGB")]
        VideoTransFunc228bitSRgb = 0x7,
        [NativeName("Name", "DXVA_VideoTransFunc_28")]
        VideoTransFunc28 = 0x8,
    }
}

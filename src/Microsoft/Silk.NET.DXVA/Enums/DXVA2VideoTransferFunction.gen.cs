// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_VideoTransferFunction")]
    public enum DXVA2VideoTransferFunction : int
    {
        [NativeName("Name", "DXVA2_VideoTransFuncMask")]
        DXVA2VideoTransFuncMask = 0x1F,
        [NativeName("Name", "DXVA2_VideoTransFunc_Unknown")]
        DXVA2VideoTransFuncUnknown = 0x0,
        [NativeName("Name", "DXVA2_VideoTransFunc_10")]
        DXVA2VideoTransFunc10 = 0x1,
        [NativeName("Name", "DXVA2_VideoTransFunc_18")]
        DXVA2VideoTransFunc18 = 0x2,
        [NativeName("Name", "DXVA2_VideoTransFunc_20")]
        DXVA2VideoTransFunc20 = 0x3,
        [NativeName("Name", "DXVA2_VideoTransFunc_22")]
        DXVA2VideoTransFunc22 = 0x4,
        [NativeName("Name", "DXVA2_VideoTransFunc_709")]
        DXVA2VideoTransFunc709 = 0x5,
        [NativeName("Name", "DXVA2_VideoTransFunc_240M")]
        DXVA2VideoTransFunc240M = 0x6,
        [NativeName("Name", "DXVA2_VideoTransFunc_sRGB")]
        DXVA2VideoTransFuncSRgb = 0x7,
        [NativeName("Name", "DXVA2_VideoTransFunc_28")]
        DXVA2VideoTransFunc28 = 0x8,
    }
}

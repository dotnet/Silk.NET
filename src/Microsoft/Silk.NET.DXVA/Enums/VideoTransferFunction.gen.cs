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
        [Obsolete("Deprecated in favour of \"FuncShift\"")]
        [NativeName("Name", "DXVA_VideoTransFuncShift")]
        VideoTransFuncShift = 0x1B,
        [Obsolete("Deprecated in favour of \"FuncMask\"")]
        [NativeName("Name", "DXVA_VideoTransFuncMask")]
        VideoTransFuncMask = unchecked((int) 0xFFFFFFFFF8000000),
        [Obsolete("Deprecated in favour of \"FuncUnknown\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_Unknown")]
        VideoTransFuncUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Func10\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_10")]
        VideoTransFunc10 = 0x1,
        [Obsolete("Deprecated in favour of \"Func18\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_18")]
        VideoTransFunc18 = 0x2,
        [Obsolete("Deprecated in favour of \"Func20\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_20")]
        VideoTransFunc20 = 0x3,
        [Obsolete("Deprecated in favour of \"Func22\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_22")]
        VideoTransFunc22 = 0x4,
        [Obsolete("Deprecated in favour of \"Func22709\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_22_709")]
        VideoTransFunc22709 = 0x5,
        [Obsolete("Deprecated in favour of \"Func22240M\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_22_240M")]
        VideoTransFunc22240M = 0x6,
        [Obsolete("Deprecated in favour of \"Func228bitSRgb\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_22_8bit_sRGB")]
        VideoTransFunc228bitSRgb = 0x7,
        [Obsolete("Deprecated in favour of \"Func28\"")]
        [NativeName("Name", "DXVA_VideoTransFunc_28")]
        VideoTransFunc28 = 0x8,
        [NativeName("Name", "DXVA_VideoTransFuncShift")]
        FuncShift = 0x1B,
        [NativeName("Name", "DXVA_VideoTransFuncMask")]
        FuncMask = unchecked((int) 0xFFFFFFFFF8000000),
        [NativeName("Name", "DXVA_VideoTransFunc_Unknown")]
        FuncUnknown = 0x0,
        [NativeName("Name", "DXVA_VideoTransFunc_10")]
        Func10 = 0x1,
        [NativeName("Name", "DXVA_VideoTransFunc_18")]
        Func18 = 0x2,
        [NativeName("Name", "DXVA_VideoTransFunc_20")]
        Func20 = 0x3,
        [NativeName("Name", "DXVA_VideoTransFunc_22")]
        Func22 = 0x4,
        [NativeName("Name", "DXVA_VideoTransFunc_22_709")]
        Func22709 = 0x5,
        [NativeName("Name", "DXVA_VideoTransFunc_22_240M")]
        Func22240M = 0x6,
        [NativeName("Name", "DXVA_VideoTransFunc_22_8bit_sRGB")]
        Func228bitSRgb = 0x7,
        [NativeName("Name", "DXVA_VideoTransFunc_28")]
        Func28 = 0x8,
    }
}

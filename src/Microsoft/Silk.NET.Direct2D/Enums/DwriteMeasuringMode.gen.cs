// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "DWRITE_MEASURING_MODE")]
    public enum DwriteMeasuringMode : int
    {
        [Obsolete("Deprecated in favour of \"Natural\"")]
        [NativeName("Name", "DWRITE_MEASURING_MODE_NATURAL")]
        DwriteMeasuringModeNatural = 0x0,
        [Obsolete("Deprecated in favour of \"GdiClassic\"")]
        [NativeName("Name", "DWRITE_MEASURING_MODE_GDI_CLASSIC")]
        DwriteMeasuringModeGdiClassic = 0x1,
        [Obsolete("Deprecated in favour of \"GdiNatural\"")]
        [NativeName("Name", "DWRITE_MEASURING_MODE_GDI_NATURAL")]
        DwriteMeasuringModeGdiNatural = 0x2,
        [NativeName("Name", "DWRITE_MEASURING_MODE_NATURAL")]
        Natural = 0x0,
        [NativeName("Name", "DWRITE_MEASURING_MODE_GDI_CLASSIC")]
        GdiClassic = 0x1,
        [NativeName("Name", "DWRITE_MEASURING_MODE_GDI_NATURAL")]
        GdiNatural = 0x2,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND")]
    public enum PanoseToolKind : int
    {
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_FLAT_NIB")]
        FlatNib = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_PRESSURE_POINT")]
        PressurePoint = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_ENGRAVED")]
        Engraved = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_BALL")]
        Ball = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_BRUSH")]
        Brush = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_ROUGH")]
        Rough = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_FELT_PEN_BRUSH_TIP")]
        FeltPenBrushTip = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_TOOL_KIND_WILD_BRUSH")]
        WildBrush = 0x9,
    }
}

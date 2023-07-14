// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE")]
    public enum SvgAttributePodType : int
    {
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT")]
        Float = 0x0,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR")]
        Color = 0x1,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE")]
        FillMode = 0x2,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY")]
        Display = 0x3,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW")]
        Overflow = 0x4,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP")]
        LineCap = 0x5,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN")]
        LineJoin = 0x6,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY")]
        Visibility = 0x7,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX")]
        Matrix = 0x8,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE")]
        UnitType = 0x9,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE")]
        ExtendMode = 0xA,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO")]
        PreserveAspectRatio = 0xB,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX")]
        Viewbox = 0xC,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH")]
        Length = 0xD,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

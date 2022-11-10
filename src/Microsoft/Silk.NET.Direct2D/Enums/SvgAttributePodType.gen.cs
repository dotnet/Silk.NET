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
        [Obsolete("Deprecated in favour of \"Float\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT")]
        SvgAttributePodTypeFloat = 0x0,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR")]
        SvgAttributePodTypeColor = 0x1,
        [Obsolete("Deprecated in favour of \"FillMode\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE")]
        SvgAttributePodTypeFillMode = 0x2,
        [Obsolete("Deprecated in favour of \"Display\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY")]
        SvgAttributePodTypeDisplay = 0x3,
        [Obsolete("Deprecated in favour of \"Overflow\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW")]
        SvgAttributePodTypeOverflow = 0x4,
        [Obsolete("Deprecated in favour of \"LineCap\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP")]
        SvgAttributePodTypeLineCap = 0x5,
        [Obsolete("Deprecated in favour of \"LineJoin\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN")]
        SvgAttributePodTypeLineJoin = 0x6,
        [Obsolete("Deprecated in favour of \"Visibility\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY")]
        SvgAttributePodTypeVisibility = 0x7,
        [Obsolete("Deprecated in favour of \"Matrix\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX")]
        SvgAttributePodTypeMatrix = 0x8,
        [Obsolete("Deprecated in favour of \"UnitType\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE")]
        SvgAttributePodTypeUnitType = 0x9,
        [Obsolete("Deprecated in favour of \"ExtendMode\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE")]
        SvgAttributePodTypeExtendMode = 0xA,
        [Obsolete("Deprecated in favour of \"PreserveAspectRatio\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO")]
        SvgAttributePodTypePreserveAspectRatio = 0xB,
        [Obsolete("Deprecated in favour of \"Viewbox\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX")]
        SvgAttributePodTypeViewbox = 0xC,
        [Obsolete("Deprecated in favour of \"Length\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH")]
        SvgAttributePodTypeLength = 0xD,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_POD_TYPE_FORCE_DWORD")]
        SvgAttributePodTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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

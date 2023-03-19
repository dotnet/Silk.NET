// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_ATTRIBUTE_STRING_TYPE")]
    public enum SvgAttributeStringType : int
    {
        [Obsolete("Deprecated in favour of \"Svg\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_STRING_TYPE_SVG")]
        SvgAttributeStringTypeSvg = 0x0,
        [Obsolete("Deprecated in favour of \"ID\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_STRING_TYPE_ID")]
        SvgAttributeStringTypeID = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_STRING_TYPE_FORCE_DWORD")]
        SvgAttributeStringTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_STRING_TYPE_SVG")]
        Svg = 0x0,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_STRING_TYPE_ID")]
        ID = 0x1,
        [NativeName("Name", "D2D1_SVG_ATTRIBUTE_STRING_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

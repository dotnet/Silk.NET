// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SVG_UNIT_TYPE")]
    public enum SvgUnitType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"UserSpaceOnUse\"")]
        [NativeName("Name", "D2D1_SVG_UNIT_TYPE_USER_SPACE_ON_USE")]
        SvgUnitTypeUserSpaceOnUse = 0x0,
        [Obsolete("Deprecated in favour of \"ObjectBoundingBox\"")]
        [NativeName("Name", "D2D1_SVG_UNIT_TYPE_OBJECT_BOUNDING_BOX")]
        SvgUnitTypeObjectBoundingBox = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_UNIT_TYPE_FORCE_DWORD")]
        SvgUnitTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SVG_UNIT_TYPE_USER_SPACE_ON_USE")]
        UserSpaceOnUse = 0x0,
        [NativeName("Name", "D2D1_SVG_UNIT_TYPE_OBJECT_BOUNDING_BOX")]
        ObjectBoundingBox = 0x1,
        [NativeName("Name", "D2D1_SVG_UNIT_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

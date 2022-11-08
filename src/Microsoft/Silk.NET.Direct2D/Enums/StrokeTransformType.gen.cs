// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE")]
    public enum StrokeTransformType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_NORMAL")]
        StrokeTransformTypeNormal = 0x0,
        [Obsolete("Deprecated in favour of \"Fixed\"")]
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_FIXED")]
        StrokeTransformTypeFixed = 0x1,
        [Obsolete("Deprecated in favour of \"Hairline\"")]
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_HAIRLINE")]
        StrokeTransformTypeHairline = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_FORCE_DWORD")]
        StrokeTransformTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_FIXED")]
        Fixed = 0x1,
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_HAIRLINE")]
        Hairline = 0x2,
        [NativeName("Name", "D2D1_STROKE_TRANSFORM_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

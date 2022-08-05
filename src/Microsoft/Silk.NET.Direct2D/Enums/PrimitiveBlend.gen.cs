// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_PRIMITIVE_BLEND")]
    public enum PrimitiveBlend : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SourceOver\"")]
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_SOURCE_OVER")]
        PrimitiveBlendSourceOver = 0x0,
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_COPY")]
        PrimitiveBlendCopy = 0x1,
        [Obsolete("Deprecated in favour of \"Min\"")]
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_MIN")]
        PrimitiveBlendMin = 0x2,
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_ADD")]
        PrimitiveBlendAdd = 0x3,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_MAX")]
        PrimitiveBlendMax = 0x4,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_FORCE_DWORD")]
        PrimitiveBlendForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_SOURCE_OVER")]
        SourceOver = 0x0,
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_COPY")]
        Copy = 0x1,
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_MIN")]
        Min = 0x2,
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_ADD")]
        Add = 0x3,
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_MAX")]
        Max = 0x4,
        [NativeName("Name", "D2D1_PRIMITIVE_BLEND_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

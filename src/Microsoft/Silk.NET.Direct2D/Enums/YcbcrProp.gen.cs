// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_YCBCR_PROP")]
    public enum YcbcrProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ChromaSubsampling\"")]
        [NativeName("Name", "D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING")]
        YcbcrPropChromaSubsampling = 0x0,
        [Obsolete("Deprecated in favour of \"TransformMatrix\"")]
        [NativeName("Name", "D2D1_YCBCR_PROP_TRANSFORM_MATRIX")]
        YcbcrPropTransformMatrix = 0x1,
        [Obsolete("Deprecated in favour of \"InterpolationMode\"")]
        [NativeName("Name", "D2D1_YCBCR_PROP_INTERPOLATION_MODE")]
        YcbcrPropInterpolationMode = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_YCBCR_PROP_FORCE_DWORD")]
        YcbcrPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING")]
        ChromaSubsampling = 0x0,
        [NativeName("Name", "D2D1_YCBCR_PROP_TRANSFORM_MATRIX")]
        TransformMatrix = 0x1,
        [NativeName("Name", "D2D1_YCBCR_PROP_INTERPOLATION_MODE")]
        InterpolationMode = 0x2,
        [NativeName("Name", "D2D1_YCBCR_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

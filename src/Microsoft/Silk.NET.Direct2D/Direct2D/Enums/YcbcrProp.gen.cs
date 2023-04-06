// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_YCBCR_PROP")]
    public enum YcbcrProp : int
    {
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

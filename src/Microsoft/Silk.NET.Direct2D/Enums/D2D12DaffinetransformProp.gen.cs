// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP")]
    public enum D2D12DaffinetransformProp : int
    {
        [Obsolete("Deprecated in favour of \"InterpolationMode\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_INTERPOLATION_MODE")]
        D2D12DaffinetransformPropInterpolationMode = 0x0,
        [Obsolete("Deprecated in favour of \"BorderMode\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_BORDER_MODE")]
        D2D12DaffinetransformPropBorderMode = 0x1,
        [Obsolete("Deprecated in favour of \"TransformMatrix\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_TRANSFORM_MATRIX")]
        D2D12DaffinetransformPropTransformMatrix = 0x2,
        [Obsolete("Deprecated in favour of \"Sharpness\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_SHARPNESS")]
        D2D12DaffinetransformPropSharpness = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_FORCE_DWORD")]
        D2D12DaffinetransformPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_INTERPOLATION_MODE")]
        InterpolationMode = 0x0,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_BORDER_MODE")]
        BorderMode = 0x1,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_TRANSFORM_MATRIX")]
        TransformMatrix = 0x2,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_SHARPNESS")]
        Sharpness = 0x3,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

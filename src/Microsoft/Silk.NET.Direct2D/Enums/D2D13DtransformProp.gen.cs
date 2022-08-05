// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_3DTRANSFORM_PROP")]
    public enum D2D13DtransformProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InterpolationMode\"")]
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_INTERPOLATION_MODE")]
        D2D13DtransformPropInterpolationMode = 0x0,
        [Obsolete("Deprecated in favour of \"BorderMode\"")]
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_BORDER_MODE")]
        D2D13DtransformPropBorderMode = 0x1,
        [Obsolete("Deprecated in favour of \"TransformMatrix\"")]
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_TRANSFORM_MATRIX")]
        D2D13DtransformPropTransformMatrix = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_FORCE_DWORD")]
        D2D13DtransformPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_INTERPOLATION_MODE")]
        InterpolationMode = 0x0,
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_BORDER_MODE")]
        BorderMode = 0x1,
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_TRANSFORM_MATRIX")]
        TransformMatrix = 0x2,
        [NativeName("Name", "D2D1_3DTRANSFORM_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

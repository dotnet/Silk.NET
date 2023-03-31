// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP")]
    public enum D2D13DperspectivetransformProp : int
    {
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_INTERPOLATION_MODE")]
        InterpolationMode = 0x0,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_BORDER_MODE")]
        BorderMode = 0x1,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_DEPTH")]
        Depth = 0x2,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_PERSPECTIVE_ORIGIN")]
        PerspectiveOrigin = 0x3,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_LOCAL_OFFSET")]
        LocalOffset = 0x4,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_GLOBAL_OFFSET")]
        GlobalOffset = 0x5,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION_ORIGIN")]
        RotationOrigin = 0x6,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION")]
        Rotation = 0x7,
        [NativeName("Name", "D2D1_3DPERSPECTIVETRANSFORM_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

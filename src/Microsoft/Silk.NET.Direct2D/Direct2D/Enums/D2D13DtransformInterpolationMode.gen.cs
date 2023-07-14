// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_3DTRANSFORM_INTERPOLATION_MODE")]
    public enum D2D13DtransformInterpolationMode : int
    {
        [NativeName("Name", "D2D1_3DTRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "D2D1_3DTRANSFORM_INTERPOLATION_MODE_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "D2D1_3DTRANSFORM_INTERPOLATION_MODE_CUBIC")]
        Cubic = 0x2,
        [NativeName("Name", "D2D1_3DTRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR")]
        MultiSampleLinear = 0x3,
        [NativeName("Name", "D2D1_3DTRANSFORM_INTERPOLATION_MODE_ANISOTROPIC")]
        Anisotropic = 0x4,
        [NativeName("Name", "D2D1_3DTRANSFORM_INTERPOLATION_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

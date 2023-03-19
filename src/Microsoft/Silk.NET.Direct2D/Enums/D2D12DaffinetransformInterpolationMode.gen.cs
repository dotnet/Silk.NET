// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE")]
    public enum D2D12DaffinetransformInterpolationMode : int
    {
        [Obsolete("Deprecated in favour of \"NearestNeighbor\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        D2D12DaffinetransformInterpolationModeNearestNeighbor = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_LINEAR")]
        D2D12DaffinetransformInterpolationModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"Cubic\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_CUBIC")]
        D2D12DaffinetransformInterpolationModeCubic = 0x2,
        [Obsolete("Deprecated in favour of \"MultiSampleLinear\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR")]
        D2D12DaffinetransformInterpolationModeMultiSampleLinear = 0x3,
        [Obsolete("Deprecated in favour of \"Anisotropic\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_ANISOTROPIC")]
        D2D12DaffinetransformInterpolationModeAnisotropic = 0x4,
        [Obsolete("Deprecated in favour of \"HighQualityCubic\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC")]
        D2D12DaffinetransformInterpolationModeHighQualityCubic = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_FORCE_DWORD")]
        D2D12DaffinetransformInterpolationModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_CUBIC")]
        Cubic = 0x2,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR")]
        MultiSampleLinear = 0x3,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_ANISOTROPIC")]
        Anisotropic = 0x4,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC")]
        HighQualityCubic = 0x5,
        [NativeName("Name", "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}

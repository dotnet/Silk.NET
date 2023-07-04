// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "(unnamed enum at d2d1.h:89:1)")]
    public enum D2D1unnamedEnumAtD2d1h891 : int
    {
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_CUBIC")]
        Cubic = 0x2,
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_MULTI_SAMPLE_LINEAR")]
        MultiSampleLinear = 0x3,
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_ANISOTROPIC")]
        Anisotropic = 0x4,
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_HIGH_QUALITY_CUBIC")]
        HighQualityCubic = 0x5,
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_FANT")]
        Fant = 0x6,
        [NativeName("Name", "D2D1_INTERPOLATION_MODE_DEFINITION_MIPMAP_LINEAR")]
        MipmapLinear = 0x7,
    }
}

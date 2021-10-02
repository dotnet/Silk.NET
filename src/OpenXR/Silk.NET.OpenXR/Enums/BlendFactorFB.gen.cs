// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBlendFactorFB")]
    public enum BlendFactorFB : int
    {
        [NativeName("Name", "XR_BLEND_FACTOR_ZERO_FB")]
        BlendFactorZeroFB = 0,
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_FB")]
        BlendFactorOneFB = 1,
        [NativeName("Name", "XR_BLEND_FACTOR_SRC_ALPHA_FB")]
        BlendFactorSrcAlphaFB = 2,
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA_FB")]
        BlendFactorOneMinusSrcAlphaFB = 3,
        [NativeName("Name", "XR_BLEND_FACTOR_DST_ALPHA_FB")]
        BlendFactorDstAlphaFB = 4,
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_MINUS_DST_ALPHA_FB")]
        BlendFactorOneMinusDstAlphaFB = 5,
    }
}

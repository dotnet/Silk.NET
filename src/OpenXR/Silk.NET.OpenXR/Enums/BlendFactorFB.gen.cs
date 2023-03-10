// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrBlendFactorFB")]
    public enum BlendFactorFB : int
    {
        [Obsolete("Deprecated in favour of \"ZeroFB\"")]
        [NativeName("Name", "XR_BLEND_FACTOR_ZERO_FB")]
        BlendFactorZeroFB = 0,
        [Obsolete("Deprecated in favour of \"OneFB\"")]
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_FB")]
        BlendFactorOneFB = 1,
        [Obsolete("Deprecated in favour of \"SrcAlphaFB\"")]
        [NativeName("Name", "XR_BLEND_FACTOR_SRC_ALPHA_FB")]
        BlendFactorSrcAlphaFB = 2,
        [Obsolete("Deprecated in favour of \"OneMinusSrcAlphaFB\"")]
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA_FB")]
        BlendFactorOneMinusSrcAlphaFB = 3,
        [Obsolete("Deprecated in favour of \"DstAlphaFB\"")]
        [NativeName("Name", "XR_BLEND_FACTOR_DST_ALPHA_FB")]
        BlendFactorDstAlphaFB = 4,
        [Obsolete("Deprecated in favour of \"OneMinusDstAlphaFB\"")]
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_MINUS_DST_ALPHA_FB")]
        BlendFactorOneMinusDstAlphaFB = 5,
        [NativeName("Name", "XR_BLEND_FACTOR_ZERO_FB")]
        ZeroFB = 0,
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_FB")]
        OneFB = 1,
        [NativeName("Name", "XR_BLEND_FACTOR_SRC_ALPHA_FB")]
        SrcAlphaFB = 2,
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA_FB")]
        OneMinusSrcAlphaFB = 3,
        [NativeName("Name", "XR_BLEND_FACTOR_DST_ALPHA_FB")]
        DstAlphaFB = 4,
        [NativeName("Name", "XR_BLEND_FACTOR_ONE_MINUS_DST_ALPHA_FB")]
        OneMinusDstAlphaFB = 5,
    }
}

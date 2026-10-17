// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBlendFactorFB")]
public enum BlendFactorFB : uint
{
    [NativeName("XR_BLEND_FACTOR_ZERO_FB")]
    Zero = 0,

    [NativeName("XR_BLEND_FACTOR_ONE_FB")]
    One = 1,

    [NativeName("XR_BLEND_FACTOR_SRC_ALPHA_FB")]
    SrcAlpha = 2,

    [NativeName("XR_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA_FB")]
    OneMinusSrcAlpha = 3,

    [NativeName("XR_BLEND_FACTOR_DST_ALPHA_FB")]
    DstAlpha = 4,

    [NativeName("XR_BLEND_FACTOR_ONE_MINUS_DST_ALPHA_FB")]
    OneMinusDstAlpha = 5,
}

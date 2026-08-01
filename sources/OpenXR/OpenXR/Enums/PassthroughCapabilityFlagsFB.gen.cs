// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughCapabilityFlagsFB")]
[Flags]
public enum PassthroughCapabilityFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_PASSTHROUGH_CAPABILITY_BIT_FB")]
    Bit = 0x1,

    [NativeName("XR_PASSTHROUGH_CAPABILITY_COLOR_BIT_FB")]
    ColorBit = 0x2,

    [NativeName("XR_PASSTHROUGH_CAPABILITY_LAYER_DEPTH_BIT_FB")]
    LayerDepthBit = 0x4,
}

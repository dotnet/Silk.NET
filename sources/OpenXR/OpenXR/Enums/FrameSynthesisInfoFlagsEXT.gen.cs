// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrameSynthesisInfoFlagsEXT")]
[Flags]
public enum FrameSynthesisInfoFlagsEXT : ulong
{
    None = 0x0,

    [NativeName("XR_FRAME_SYNTHESIS_INFO_USE_2D_MOTION_VECTOR_BIT_EXT")]
    Use2DMotionVectorBit = 0x1,

    [NativeName("XR_FRAME_SYNTHESIS_INFO_REQUEST_RELAXED_FRAME_INTERVAL_BIT_EXT")]
    RequestRelaxedFrameIntervalBit = 0x2,
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.window")]
public enum DeviceSideAvcMotionEstimationWindowINTEL : uint
{
    [NativeName("CL_AVC_ME_SEARCH_WINDOW_EXHAUSTIVE_INTEL")]
    WindowExhaustive = 0,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_SMALL_INTEL")]
    WindowSmall = 1,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_TINY_INTEL")]
    WindowTiny = 2,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_EXTRA_TINY_INTEL")]
    WindowExtraTiny = 3,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_DIAMOND_INTEL")]
    WindowDiamond = 4,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_LARGE_DIAMOND_INTEL")]
    WindowLargeDiamond = 5,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_RESERVED0_INTEL")]
    WindowReserved0 = 6,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_RESERVED1_INTEL")]
    WindowReserved1 = 7,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_CUSTOM_INTEL")]
    WindowCustom = 8,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_16x12_RADIUS_INTEL")]
    Window16x12Radius = 9,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_4x4_RADIUS_INTEL")]
    Window4x4Radius = 2,

    [NativeName("CL_AVC_ME_SEARCH_WINDOW_2x2_RADIUS_INTEL")]
    Window2x2Radius = 10,
}

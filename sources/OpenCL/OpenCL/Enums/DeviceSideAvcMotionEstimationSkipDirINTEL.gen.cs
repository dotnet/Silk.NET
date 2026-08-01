// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.skip.dir")]
public enum DeviceSideAvcMotionEstimationSkipDirINTEL : uint
{
    [NativeName("CL_AVC_ME_SKIP_BLOCK_16x16_FORWARD_ENABLE_INTEL")]
    Block16x16ForwardEnable = 16777216,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_16x16_BACKWARD_ENABLE_INTEL")]
    Block16x16BackwardEnable = 33554432,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_16x16_DUAL_ENABLE_INTEL")]
    Block16x16DualEnable = 50331648,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_FORWARD_ENABLE_INTEL")]
    Block8x8ForwardEnable = 1426063360,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_BACKWARD_ENABLE_INTEL")]
    Block8x8BackwardEnable = 2852126720,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_DUAL_ENABLE_INTEL")]
    Block8x8DualEnable = 4278190080,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_0_FORWARD_ENABLE_INTEL")]
    Block8x8x0ForwardEnable = 16777216,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_0_BACKWARD_ENABLE_INTEL")]
    Block8x8x0BackwardEnable = 33554432,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_1_FORWARD_ENABLE_INTEL")]
    Block8x8x1ForwardEnable = 67108864,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_1_BACKWARD_ENABLE_INTEL")]
    Block8x8x1BackwardEnable = 134217728,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_2_FORWARD_ENABLE_INTEL")]
    Block8x8x2ForwardEnable = 268435456,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_2_BACKWARD_ENABLE_INTEL")]
    Block8x8x2BackwardEnable = 536870912,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_3_FORWARD_ENABLE_INTEL")]
    Block8x8x3ForwardEnable = 1073741824,

    [NativeName("CL_AVC_ME_SKIP_BLOCK_8x8_3_BACKWARD_ENABLE_INTEL")]
    Block8x8x3BackwardEnable = 2147483648,
}

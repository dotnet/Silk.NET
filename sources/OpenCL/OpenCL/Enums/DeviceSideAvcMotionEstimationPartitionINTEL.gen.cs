// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.partition")]
public enum DeviceSideAvcMotionEstimationPartitionINTEL : uint
{
    [NativeName("CL_AVC_ME_PARTITION_MASK_ALL_INTEL")]
    MaskAll = 0,

    [NativeName("CL_AVC_ME_PARTITION_MASK_16x16_INTEL")]
    Mask16x16 = 126,

    [NativeName("CL_AVC_ME_PARTITION_MASK_16x8_INTEL")]
    Mask16x8 = 125,

    [NativeName("CL_AVC_ME_PARTITION_MASK_8x16_INTEL")]
    Mask8x16 = 123,

    [NativeName("CL_AVC_ME_PARTITION_MASK_8x8_INTEL")]
    Mask8x8 = 119,

    [NativeName("CL_AVC_ME_PARTITION_MASK_8x4_INTEL")]
    Mask8x4 = 111,

    [NativeName("CL_AVC_ME_PARTITION_MASK_4x8_INTEL")]
    Mask4x8 = 95,

    [NativeName("CL_AVC_ME_PARTITION_MASK_4x4_INTEL")]
    Mask4x4 = 63,
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.intra.neighbor")]
public enum DeviceSideAvcMotionEstimationIntraNeighborINTEL : uint
{
    [NativeName("CL_AVC_ME_INTRA_NEIGHBOR_LEFT_MASK_ENABLE_INTEL")]
    LeftMaskEnable = 96,

    [NativeName("CL_AVC_ME_INTRA_NEIGHBOR_UPPER_MASK_ENABLE_INTEL")]
    UpperMaskEnable = 16,

    [NativeName("CL_AVC_ME_INTRA_NEIGHBOR_UPPER_RIGHT_MASK_ENABLE_INTEL")]
    UpperRightMaskEnable = 8,

    [NativeName("CL_AVC_ME_INTRA_NEIGHBOR_UPPER_LEFT_MASK_ENABLE_INTEL")]
    UpperLeftMaskEnable = 4,
}

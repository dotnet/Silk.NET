// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.major.dir")]
public enum DeviceSideAvcMotionEstimationMajorDirIntel : uint
{
    [NativeName("CL_AVC_ME_MAJOR_FORWARD_INTEL")]
    ForwardINTEL = 0,

    [NativeName("CL_AVC_ME_MAJOR_BACKWARD_INTEL")]
    BackwardINTEL = 1,

    [NativeName("CL_AVC_ME_MAJOR_BIDIRECTIONAL_INTEL")]
    BidirectionalINTEL = 2,
}

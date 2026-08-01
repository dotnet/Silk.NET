// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.major")]
public enum DeviceSideAvcMotionEstimationMajorINTEL : uint
{
    [NativeName("CL_AVC_ME_MAJOR_16x16_INTEL")]
    Major16x16 = 0,

    [NativeName("CL_AVC_ME_MAJOR_16x8_INTEL")]
    Major16x8 = 1,

    [NativeName("CL_AVC_ME_MAJOR_8x16_INTEL")]
    Major8x16 = 2,

    [NativeName("CL_AVC_ME_MAJOR_8x8_INTEL")]
    Major8x8 = 3,
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.minor")]
public enum DeviceSideAvcMotionEstimationMinorIntel : uint
{
    [NativeName("CL_AVC_ME_MINOR_8x8_INTEL")]
    Minor8x8INTEL = 0,

    [NativeName("CL_AVC_ME_MINOR_8x4_INTEL")]
    Minor8x4INTEL = 1,

    [NativeName("CL_AVC_ME_MINOR_4x8_INTEL")]
    Minor4x8INTEL = 2,

    [NativeName("CL_AVC_ME_MINOR_4x4_INTEL")]
    Minor4x4INTEL = 3,
}

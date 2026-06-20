// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_advanced_motion_estimation.cl_motion_detect_desc_intel.2")]
public enum IntelAdvancedMotionEstimationClMotionDetectDescIntel2 : uint
{
    [NativeName("CL_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
    QuarterINTEL = 16,

    [NativeName("CL_ME_BIDIR_WEIGHT_THIRD_INTEL")]
    ThirdINTEL = 21,

    [NativeName("CL_ME_BIDIR_WEIGHT_HALF_INTEL")]
    HalfINTEL = 32,

    [NativeName("CL_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
    TwoThirdINTEL = 43,

    [NativeName("CL_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
    ThreeQuarterINTEL = 48,
}

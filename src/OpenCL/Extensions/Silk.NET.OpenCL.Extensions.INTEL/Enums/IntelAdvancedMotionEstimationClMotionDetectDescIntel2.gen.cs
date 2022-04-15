// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation_cl_motion_detect_desc_intel_2")]
    public enum IntelAdvancedMotionEstimationClMotionDetectDescIntel2 : int
    {
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
        Quarter = 0x16,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THIRD_INTEL")]
        Third = 0x21,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_HALF_INTEL")]
        Half = 0x32,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
        TwoThird = 0x43,
        [NativeName("Name", "CL_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
        ThreeQuarter = 0x48,
    }
}

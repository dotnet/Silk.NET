// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.weight")]
    public enum DeviceSideAvcMotionEstimationWeight : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
        Quarter = 0x10,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_THIRD_INTEL")]
        Third = 0x15,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_HALF_INTEL")]
        Half = 0x20,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
        TwoThird = 0x2B,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
        ThreeQuarter = 0x30,
    }
}

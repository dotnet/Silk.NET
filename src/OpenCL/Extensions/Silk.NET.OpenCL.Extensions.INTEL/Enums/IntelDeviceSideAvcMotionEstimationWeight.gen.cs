// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_weight")]
    public enum IntelDeviceSideAvcMotionEstimationWeight : int
    {
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_QUARTER_INTEL")]
        AvcMEBidirWeightQuarterIntel = 0x10,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_THIRD_INTEL")]
        AvcMEBidirWeightThirdIntel = 0x15,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_HALF_INTEL")]
        AvcMEBidirWeightHalfIntel = 0x20,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_TWO_THIRD_INTEL")]
        AvcMEBidirWeightTwoThirdIntel = 0x2B,
        [NativeName("Name", "CL_AVC_ME_BIDIR_WEIGHT_THREE_QUARTER_INTEL")]
        AvcMEBidirWeightThreeQuarterIntel = 0x30,
    }
}

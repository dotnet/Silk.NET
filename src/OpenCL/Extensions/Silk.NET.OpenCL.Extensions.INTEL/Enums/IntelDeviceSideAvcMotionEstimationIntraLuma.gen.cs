// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.intra.luma")]
    public enum IntelDeviceSideAvcMotionEstimationIntraLuma : int
    {
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_16x16_INTEL")]
        Cl16x16 = 0x6,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_8x8_INTEL")]
        Cl8x8 = 0x5,
        [NativeName("Name", "CL_AVC_ME_INTRA_LUMA_PARTITION_MASK_4x4_INTEL")]
        Cl4x4 = 0x3,
    }
}

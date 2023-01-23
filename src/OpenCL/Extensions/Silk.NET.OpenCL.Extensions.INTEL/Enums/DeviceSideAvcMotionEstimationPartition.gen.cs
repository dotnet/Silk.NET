// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.partition")]
    public enum DeviceSideAvcMotionEstimationPartition : int
    {
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_ALL_INTEL")]
        MaskAll = 0x0,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_16x16_INTEL")]
        Mask16x16 = 0x7E,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_16x8_INTEL")]
        Mask16x8 = 0x7D,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x16_INTEL")]
        Mask8x16 = 0x7B,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x8_INTEL")]
        Mask8x8 = 0x77,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_8x4_INTEL")]
        Mask8x4 = 0x6F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_4x8_INTEL")]
        Mask4x8 = 0x5F,
        [NativeName("Name", "CL_AVC_ME_PARTITION_MASK_4x4_INTEL")]
        Mask4x4 = 0x3F,
    }
}

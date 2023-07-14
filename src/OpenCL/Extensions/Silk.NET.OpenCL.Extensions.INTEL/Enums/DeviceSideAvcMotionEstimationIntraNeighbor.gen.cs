// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.intra.neighbor")]
    public enum DeviceSideAvcMotionEstimationIntraNeighbor : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_LEFT_MASK_ENABLE_INTEL")]
        LeftMaskEnable = 0x60,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_MASK_ENABLE_INTEL")]
        UpperMaskEnable = 0x10,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_RIGHT_MASK_ENABLE_INTEL")]
        UpperRightMaskEnable = 0x8,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_LEFT_MASK_ENABLE_INTEL")]
        UpperLeftMaskEnable = 0x4,
    }
}

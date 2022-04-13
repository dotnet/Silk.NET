// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_intra_neighbor")]
    public enum IntelDeviceSideAvcMotionEstimationIntraNeighbor : int
    {
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_LEFT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborLeftMaskEnableIntel = 0x60,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperMaskEnableIntel = 0x10,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_RIGHT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperRightMaskEnableIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_INTRA_NEIGHBOR_UPPER_LEFT_MASK_ENABLE_INTEL")]
        AvcMEIntraNeighborUpperLeftMaskEnableIntel = 0x4,
    }
}

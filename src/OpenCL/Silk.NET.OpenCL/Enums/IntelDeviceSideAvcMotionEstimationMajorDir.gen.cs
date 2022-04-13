// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_major_dir")]
    public enum IntelDeviceSideAvcMotionEstimationMajorDir : int
    {
        [NativeName("Name", "CL_AVC_ME_MAJOR_FORWARD_INTEL")]
        AvcMEMajorForwardIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BACKWARD_INTEL")]
        AvcMEMajorBackwardIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BIDIRECTIONAL_INTEL")]
        AvcMEMajorBidirectionalIntel = 0x2,
    }
}

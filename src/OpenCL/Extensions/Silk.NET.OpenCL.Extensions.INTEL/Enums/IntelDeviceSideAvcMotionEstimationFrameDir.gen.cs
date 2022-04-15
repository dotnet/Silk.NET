// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_frame_dir")]
    public enum IntelDeviceSideAvcMotionEstimationFrameDir : int
    {
        [NativeName("Name", "CL_AVC_ME_FRAME_FORWARD_INTEL")]
        AvcMEFrameForwardIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_FRAME_BACKWARD_INTEL")]
        AvcMEFrameBackwardIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_FRAME_DUAL_INTEL")]
        AvcMEFrameDualIntel = 0x3,
    }
}

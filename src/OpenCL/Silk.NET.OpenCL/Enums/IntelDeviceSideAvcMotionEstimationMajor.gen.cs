// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_major")]
    public enum IntelDeviceSideAvcMotionEstimationMajor : int
    {
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x16_INTEL")]
        AvcMEMajor16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x8_INTEL")]
        AvcMEMajor16x8Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x16_INTEL")]
        AvcMEMajor8x16Intel = 0x2,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x8_INTEL")]
        AvcMEMajor8x8Intel = 0x3,
    }
}

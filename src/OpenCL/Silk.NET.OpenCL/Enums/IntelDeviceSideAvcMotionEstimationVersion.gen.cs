// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_version")]
    public enum IntelDeviceSideAvcMotionEstimationVersion : int
    {
        [NativeName("Name", "CL_AVC_ME_VERSION_0_INTEL")]
        AvcMEVersion0Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_VERSION_1_INTEL")]
        AvcMEVersion1Intel = 0x1,
    }
}

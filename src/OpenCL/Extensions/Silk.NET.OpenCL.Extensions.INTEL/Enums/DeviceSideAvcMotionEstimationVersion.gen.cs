// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.version")]
    public enum DeviceSideAvcMotionEstimationVersion : int
    {
        [NativeName("Name", "CL_AVC_ME_VERSION_0_INTEL")]
        Version0 = 0x0,
        [NativeName("Name", "CL_AVC_ME_VERSION_1_INTEL")]
        Version1 = 0x1,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.major")]
    public enum DeviceSideAvcMotionEstimationMajor : int
    {
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x16_INTEL")]
        Major16x16 = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_16x8_INTEL")]
        Major16x8 = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x16_INTEL")]
        Major8x16 = 0x2,
        [NativeName("Name", "CL_AVC_ME_MAJOR_8x8_INTEL")]
        Major8x8 = 0x3,
    }
}

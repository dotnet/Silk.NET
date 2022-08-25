// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.??")]
    public enum DeviceSideAvcMotionEstimation : int
    {
        [NativeName("Name", "CL_AVC_ME_INTRA_16x16_INTEL")]
        Intra16x16 = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTRA_8x8_INTEL")]
        Intra8x8 = 0x1,
        [NativeName("Name", "CL_AVC_ME_INTRA_4x4_INTEL")]
        Intra4x4 = 0x2,
    }
}

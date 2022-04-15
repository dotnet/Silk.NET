// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.??")]
    public enum IntelDeviceSideAvcMotionEstimation : int
    {
        [NativeName("Name", "CL_AVC_ME_INTRA_16x16_INTEL")]
        AvcMEIntra16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTRA_8x8_INTEL")]
        AvcMEIntra8x8Intel = 0x1,
        [NativeName("Name", "CL_AVC_ME_INTRA_4x4_INTEL")]
        AvcMEIntra4x4Intel = 0x2,
    }
}

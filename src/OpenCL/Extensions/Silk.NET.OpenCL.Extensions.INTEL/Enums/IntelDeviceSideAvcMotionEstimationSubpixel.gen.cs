// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_subpixel")]
    public enum IntelDeviceSideAvcMotionEstimationSubpixel : int
    {
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
        AvcMESubpixelModeIntegerIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_HPEL_INTEL")]
        AvcMESubpixelModeHpelIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SUBPIXEL_MODE_QPEL_INTEL")]
        AvcMESubpixelModeQpelIntel = 0x3,
    }
}

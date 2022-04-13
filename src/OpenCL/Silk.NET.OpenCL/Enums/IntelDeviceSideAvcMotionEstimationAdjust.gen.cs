// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_adjust")]
    public enum IntelDeviceSideAvcMotionEstimationAdjust : int
    {
        [NativeName("Name", "CL_AVC_ME_SAD_ADJUST_MODE_NONE_INTEL")]
        AvcMESadAdjustModeNoneIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
        AvcMESadAdjustModeHaarIntel = 0x2,
    }
}

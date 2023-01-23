// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.window")]
    public enum DeviceSideAvcMotionEstimationWindow : int
    {
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXHAUSTIVE_INTEL")]
        WindowExhaustive = 0x0,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_SMALL_INTEL")]
        WindowSmall = 0x1,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_TINY_INTEL")]
        WindowTiny = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXTRA_TINY_INTEL")]
        WindowExtraTiny = 0x3,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_DIAMOND_INTEL")]
        WindowDiamond = 0x4,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_LARGE_DIAMOND_INTEL")]
        WindowLargeDiamond = 0x5,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED0_INTEL")]
        WindowReserved0 = 0x6,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED1_INTEL")]
        WindowReserved1 = 0x7,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_CUSTOM_INTEL")]
        WindowCustom = 0x8,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_16x12_RADIUS_INTEL")]
        Window16x12Radius = 0x9,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_4x4_RADIUS_INTEL")]
        Window4x4Radius = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_2x2_RADIUS_INTEL")]
        Window2x2Radius = 0xA,
    }
}

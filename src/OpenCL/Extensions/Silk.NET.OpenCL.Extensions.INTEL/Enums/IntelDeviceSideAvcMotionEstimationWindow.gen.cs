// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_window")]
    public enum IntelDeviceSideAvcMotionEstimationWindow : int
    {
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXHAUSTIVE_INTEL")]
        Exhaustive = 0x0,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_SMALL_INTEL")]
        Small = 0x1,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_TINY_INTEL")]
        Tiny = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXTRA_TINY_INTEL")]
        ExtraTiny = 0x3,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_DIAMOND_INTEL")]
        Diamond = 0x4,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_LARGE_DIAMOND_INTEL")]
        LargeDiamond = 0x5,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED0_INTEL")]
        Reserved0 = 0x6,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED1_INTEL")]
        Reserved1 = 0x7,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_CUSTOM_INTEL")]
        Custom = 0x8,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_16x12_RADIUS_INTEL")]
        Cl16x12Radius = 0x9,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_4x4_RADIUS_INTEL")]
        Cl4x4Radius = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_2x2_RADIUS_INTEL")]
        Cl2x2Radius = 0xA,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_window")]
    public enum IntelDeviceSideAvcMotionEstimationWindow : int
    {
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXHAUSTIVE_INTEL")]
        AvcMESearchWindowExhaustiveIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_SMALL_INTEL")]
        AvcMESearchWindowSmallIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_TINY_INTEL")]
        AvcMESearchWindowTinyIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_EXTRA_TINY_INTEL")]
        AvcMESearchWindowExtraTinyIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_DIAMOND_INTEL")]
        AvcMESearchWindowDiamondIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_LARGE_DIAMOND_INTEL")]
        AvcMESearchWindowLargeDiamondIntel = 0x5,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED0_INTEL")]
        AvcMESearchWindowReserved0Intel = 0x6,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_RESERVED1_INTEL")]
        AvcMESearchWindowReserved1Intel = 0x7,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_CUSTOM_INTEL")]
        AvcMESearchWindowCustomIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_16x12_RADIUS_INTEL")]
        AvcMESearchWindow16x12RadiusIntel = 0x9,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_4x4_RADIUS_INTEL")]
        AvcMESearchWindow4x4RadiusIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_SEARCH_WINDOW_2x2_RADIUS_INTEL")]
        AvcMESearchWindow2x2RadiusIntel = 0xA,
    }
}

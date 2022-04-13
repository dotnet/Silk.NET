// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_skip_dir")]
    public enum IntelDeviceSideAvcMotionEstimationSkipDir : int
    {
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16ForwardEnableIntel = 16777216,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16BackwardEnableIntel = 33554432,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock16x16DualEnableIntel = 50331648,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8ForwardEnableIntel = 1426063360,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8BackwardEnableIntel = unchecked((int) -1442840576),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock8x8DualEnableIntel = unchecked((int) -16777216),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80ForwardEnableIntel = 16777216,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80BackwardEnableIntel = 33554432,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81ForwardEnableIntel = 67108864,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81BackwardEnableIntel = 134217728,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82ForwardEnableIntel = 268435456,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82BackwardEnableIntel = 536870912,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83ForwardEnableIntel = 1073741824,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83BackwardEnableIntel = unchecked((int) -2147483648),
    }
}

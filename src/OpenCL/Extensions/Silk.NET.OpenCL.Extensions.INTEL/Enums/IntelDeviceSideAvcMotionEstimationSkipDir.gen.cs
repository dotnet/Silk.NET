// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_skip_dir")]
    public enum IntelDeviceSideAvcMotionEstimationSkipDir : int
    {
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16ForwardEnableIntel = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock16x16BackwardEnableIntel = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock16x16DualEnableIntel = 0x3000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8ForwardEnableIntel = 0x55000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x8BackwardEnableIntel = unchecked((int) 0xAA000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_DUAL_ENABLE_INTEL")]
        AvcMESkipBlock8x8DualEnableIntel = unchecked((int) 0xFF000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80ForwardEnableIntel = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x80BackwardEnableIntel = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81ForwardEnableIntel = 0x4000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x81BackwardEnableIntel = 0x8000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82ForwardEnableIntel = 0x10000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x82BackwardEnableIntel = 0x20000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_FORWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83ForwardEnableIntel = 0x40000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_BACKWARD_ENABLE_INTEL")]
        AvcMESkipBlock8x83BackwardEnableIntel = unchecked((int) 0x80000000),
    }
}

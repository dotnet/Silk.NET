// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.skip.dir")]
    public enum DeviceSideAvcMotionEstimationSkipDir : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_FORWARD_ENABLE_INTEL")]
        Block16x16ForwardEnable = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_BACKWARD_ENABLE_INTEL")]
        Block16x16BackwardEnable = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_16x16_DUAL_ENABLE_INTEL")]
        Block16x16DualEnable = 0x3000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_FORWARD_ENABLE_INTEL")]
        Block8x8ForwardEnable = 0x55000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_BACKWARD_ENABLE_INTEL")]
        Block8x8BackwardEnable = unchecked((int) 0xAA000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_DUAL_ENABLE_INTEL")]
        Block8x8DualEnable = unchecked((int) 0xFF000000),
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_FORWARD_ENABLE_INTEL")]
        Block8x80ForwardEnable = 0x1000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_0_BACKWARD_ENABLE_INTEL")]
        Block8x80BackwardEnable = 0x2000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_FORWARD_ENABLE_INTEL")]
        Block8x81ForwardEnable = 0x4000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_1_BACKWARD_ENABLE_INTEL")]
        Block8x81BackwardEnable = 0x8000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_FORWARD_ENABLE_INTEL")]
        Block8x82ForwardEnable = 0x10000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_2_BACKWARD_ENABLE_INTEL")]
        Block8x82BackwardEnable = 0x20000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_FORWARD_ENABLE_INTEL")]
        Block8x83ForwardEnable = 0x40000000,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_8x8_3_BACKWARD_ENABLE_INTEL")]
        Block8x83BackwardEnable = unchecked((int) 0x80000000),
    }
}

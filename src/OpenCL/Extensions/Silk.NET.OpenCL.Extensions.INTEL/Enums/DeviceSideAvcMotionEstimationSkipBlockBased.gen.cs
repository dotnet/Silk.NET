// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.skip.block.based")]
    public enum DeviceSideAvcMotionEstimationSkipBlockBased : int
    {
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_4x4_INTEL")]
        Skip4x4 = 0x0,
        [NativeName("Name", "CL_AVC_ME_BLOCK_BASED_SKIP_8x8_INTEL")]
        Skip8x8 = 0x80,
    }
}

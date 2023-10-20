// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation.skip_block_type")]
    public enum AdvancedMotionEstimationSkipBlockType : int
    {
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_16x16_INTEL")]
        Type16x16 = 0x0,
        [NativeName("Name", "CL_ME_SKIP_BLOCK_TYPE_8x8_INTEL")]
        Type8x8 = 0x4,
    }
}

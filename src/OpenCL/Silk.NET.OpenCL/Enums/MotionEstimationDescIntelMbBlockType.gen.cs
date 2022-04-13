// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_motion_estimation_desc_intel_mb_block_type")]
    public enum MotionEstimationDescIntelMbBlockType : int
    {
        [NativeName("Name", "CL_ME_MB_TYPE_16x16_INTEL")]
        MEMBType16x16Intel = 0x0,
        [NativeName("Name", "CL_ME_MB_TYPE_8x8_INTEL")]
        MEMBType8x8Intel = 0x1,
        [NativeName("Name", "CL_ME_MB_TYPE_4x4_INTEL")]
        MEMBType4x4Intel = 0x2,
    }
}

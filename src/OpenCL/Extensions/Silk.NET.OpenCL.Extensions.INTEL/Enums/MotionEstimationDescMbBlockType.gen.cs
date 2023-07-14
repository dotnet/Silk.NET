// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_motion_estimation_desc_intel.mb_block_type")]
    public enum MotionEstimationDescMbBlockType : int
    {
        [NativeName("Name", "CL_ME_MB_TYPE_16x16_INTEL")]
        Type16x16 = 0x0,
        [NativeName("Name", "CL_ME_MB_TYPE_8x8_INTEL")]
        Type8x8 = 0x1,
        [NativeName("Name", "CL_ME_MB_TYPE_4x4_INTEL")]
        Type4x4 = 0x2,
    }
}

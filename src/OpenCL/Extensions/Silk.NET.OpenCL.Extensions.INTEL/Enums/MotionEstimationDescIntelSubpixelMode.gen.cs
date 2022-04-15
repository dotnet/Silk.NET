// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_motion_estimation_desc_intel_subpixel_mode")]
    public enum MotionEstimationDescIntelSubpixelMode : int
    {
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
        MESubpixelModeIntegerIntel = 0x0,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_HPEL_INTEL")]
        MESubpixelModeHpelIntel = 0x1,
        [NativeName("Name", "CL_ME_SUBPIXEL_MODE_QPEL_INTEL")]
        MESubpixelModeQpelIntel = 0x2,
    }
}

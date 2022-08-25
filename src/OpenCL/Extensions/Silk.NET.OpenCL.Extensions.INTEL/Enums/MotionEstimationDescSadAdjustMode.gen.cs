// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_motion_estimation_desc_intel.sad_adjust_mode")]
    public enum MotionEstimationDescSadAdjustMode : int
    {
        [NativeName("Name", "CL_ME_SAD_ADJUST_MODE_NONE_INTEL")]
        None = 0x0,
        [NativeName("Name", "CL_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
        Haar = 0x1,
    }
}

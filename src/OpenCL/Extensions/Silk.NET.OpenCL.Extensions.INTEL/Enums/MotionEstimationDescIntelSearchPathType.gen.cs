// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_motion_estimation_desc_intel.search_path_type")]
    public enum MotionEstimationDescIntelSearchPathType : int
    {
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_2_2_INTEL")]
        Cl22 = 0x0,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_4_4_INTEL")]
        Cl44 = 0x1,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_16_12_INTEL")]
        Cl1612 = 0x5,
    }
}

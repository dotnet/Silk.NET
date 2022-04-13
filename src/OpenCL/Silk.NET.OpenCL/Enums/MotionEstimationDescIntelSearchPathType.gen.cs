// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_motion_estimation_desc_intel_search_path_type")]
    public enum MotionEstimationDescIntelSearchPathType : int
    {
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_2_2_INTEL")]
        MESearchPathRadius22Intel = 0x0,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_4_4_INTEL")]
        MESearchPathRadius44Intel = 0x1,
        [NativeName("Name", "CL_ME_SEARCH_PATH_RADIUS_16_12_INTEL")]
        MESearchPathRadius1612Intel = 0x5,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation_search_cost_precision")]
    public enum IntelAdvancedMotionEstimationSearchCostPrecision : int
    {
        [NativeName("Name", "CL_ME_COST_PRECISION_QPEL_INTEL")]
        MECostPrecisionQpelIntel = 0x0,
        [NativeName("Name", "CL_ME_COST_PRECISION_HPEL_INTEL")]
        MECostPrecisionHpelIntel = 0x1,
        [NativeName("Name", "CL_ME_COST_PRECISION_PEL_INTEL")]
        MECostPrecisionPelIntel = 0x2,
        [NativeName("Name", "CL_ME_COST_PRECISION_DPEL_INTEL")]
        MECostPrecisionDpelIntel = 0x3,
    }
}

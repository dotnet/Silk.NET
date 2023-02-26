// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_advanced_motion_estimation.search_cost_precision")]
    public enum AdvancedMotionEstimationSearchCostPrecision : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_ME_COST_PRECISION_QPEL_INTEL")]
        Qpel = 0x0,
        [NativeName("Name", "CL_ME_COST_PRECISION_HPEL_INTEL")]
        Hpel = 0x1,
        [NativeName("Name", "CL_ME_COST_PRECISION_PEL_INTEL")]
        Pel = 0x2,
        [NativeName("Name", "CL_ME_COST_PRECISION_DPEL_INTEL")]
        Dpel = 0x3,
    }
}

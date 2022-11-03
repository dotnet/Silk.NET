// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation.search_cost_penalty")]
    public enum AdvancedMotionEstimationSearchCostPenalty : int
    {
        [NativeName("Name", "CL_ME_COST_PENALTY_NONE_INTEL")]
        None = 0x0,
        [NativeName("Name", "CL_ME_COST_PENALTY_LOW_INTEL")]
        Low = 0x1,
        [NativeName("Name", "CL_ME_COST_PENALTY_NORMAL_INTEL")]
        Normal = 0x2,
        [NativeName("Name", "CL_ME_COST_PENALTY_HIGH_INTEL")]
        High = 0x3,
    }
}

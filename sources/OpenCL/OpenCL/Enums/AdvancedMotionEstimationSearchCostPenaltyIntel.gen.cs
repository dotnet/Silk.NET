// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_advanced_motion_estimation.search_cost_penalty")]
public enum AdvancedMotionEstimationSearchCostPenaltyIntel : uint
{
    [NativeName("CL_ME_COST_PENALTY_NONE_INTEL")]
    NoneINTEL = 0,

    [NativeName("CL_ME_COST_PENALTY_LOW_INTEL")]
    LowINTEL = 1,

    [NativeName("CL_ME_COST_PENALTY_NORMAL_INTEL")]
    NormalINTEL = 2,

    [NativeName("CL_ME_COST_PENALTY_HIGH_INTEL")]
    HighINTEL = 3,
}

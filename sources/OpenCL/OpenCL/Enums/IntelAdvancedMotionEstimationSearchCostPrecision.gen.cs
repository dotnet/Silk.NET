// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_advanced_motion_estimation.search_cost_precision")]
public enum IntelAdvancedMotionEstimationSearchCostPrecision : uint
{
    [NativeName("CL_ME_COST_PRECISION_QPEL_INTEL")]
    QpelINTEL = 0,

    [NativeName("CL_ME_COST_PRECISION_HPEL_INTEL")]
    HpelINTEL = 1,

    [NativeName("CL_ME_COST_PRECISION_PEL_INTEL")]
    PelINTEL = 2,

    [NativeName("CL_ME_COST_PRECISION_DPEL_INTEL")]
    DpelINTEL = 3,
}

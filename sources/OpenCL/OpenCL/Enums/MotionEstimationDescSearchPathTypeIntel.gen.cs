// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_motion_estimation_desc_intel.search_path_type")]
[Flags]
public enum MotionEstimationDescSearchPathTypeIntel : uint
{
    [NativeName("CL_ME_SEARCH_PATH_RADIUS_2_2_INTEL")]
    Radius2x2INTEL = 0x0,

    [NativeName("CL_ME_SEARCH_PATH_RADIUS_4_4_INTEL")]
    Radius4x4INTEL = 0x1,

    [NativeName("CL_ME_SEARCH_PATH_RADIUS_16_12_INTEL")]
    Radius16x12INTEL = 0x5,
}

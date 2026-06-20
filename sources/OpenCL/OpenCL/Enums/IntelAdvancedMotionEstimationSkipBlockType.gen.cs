// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_advanced_motion_estimation.skip_block_type")]
public enum IntelAdvancedMotionEstimationSkipBlockType : uint
{
    [NativeName("CL_ME_SKIP_BLOCK_TYPE_16x16_INTEL")]
    Type16x16INTEL = 0,

    [NativeName("CL_ME_SKIP_BLOCK_TYPE_8x8_INTEL")]
    Type8x8INTEL = 4,
}

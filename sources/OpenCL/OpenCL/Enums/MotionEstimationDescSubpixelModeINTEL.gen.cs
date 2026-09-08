// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_motion_estimation_desc_intel.subpixel_mode")]
[Flags]
public enum MotionEstimationDescSubpixelModeINTEL : uint
{
    [NativeName("CL_ME_SUBPIXEL_MODE_INTEGER_INTEL")]
    Integer = 0x0,

    [NativeName("CL_ME_SUBPIXEL_MODE_HPEL_INTEL")]
    Hpel = 0x1,

    [NativeName("CL_ME_SUBPIXEL_MODE_QPEL_INTEL")]
    Qpel = 0x2,
}

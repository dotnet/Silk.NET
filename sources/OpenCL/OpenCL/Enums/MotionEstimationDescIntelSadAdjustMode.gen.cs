// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_motion_estimation_desc_intel.sad_adjust_mode")]
[Flags]
public enum MotionEstimationDescIntelSadAdjustMode : uint
{
    [NativeName("CL_ME_SAD_ADJUST_MODE_NONE_INTEL")]
    NoneINTEL = 0x0,

    [NativeName("CL_ME_SAD_ADJUST_MODE_HAAR_INTEL")]
    HaarINTEL = 0x1,
}

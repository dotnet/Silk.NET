// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_advanced_motion_estimation.cl_motion_detect_desc_intel")]
public enum AdvancedMotionEstimationMotionDetectDescINTEL : uint
{
    [NativeName("CL_ME_FORWARD_INPUT_MODE_INTEL")]
    ForwardInputMode = 1,

    [NativeName("CL_ME_BACKWARD_INPUT_MODE_INTEL")]
    BackwardInputMode = 2,

    [NativeName("CL_ME_BIDIRECTION_INPUT_MODE_INTEL")]
    BidirectionInputMode = 3,
}

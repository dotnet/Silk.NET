// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_advanced_motion_estimation.flags")]
[Flags]
public enum AdvancedMotionEstimationFlagsIntel : uint
{
    None = 0x0,

    [NativeName("CL_ME_CHROMA_INTRA_PREDICT_ENABLED_INTEL")]
    ChromaIntraPredictEnabledINTEL = 0x1,

    [NativeName("CL_ME_LUMA_INTRA_PREDICT_ENABLED_INTEL")]
    LumaIntraPredictEnabledINTEL = 0x2,
}

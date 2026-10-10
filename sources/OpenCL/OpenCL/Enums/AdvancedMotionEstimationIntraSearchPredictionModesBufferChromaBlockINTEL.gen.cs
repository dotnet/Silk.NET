// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName(
    "cl_intel_advanced_motion_estimation.intra_search_prediction_modes_buffer.chroma_block"
)]
public enum AdvancedMotionEstimationIntraSearchPredictionModesBufferChromaBlockINTEL : uint
{
    [NativeName("CL_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
    Dc = 0,

    [NativeName("CL_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
    Horizontal = 1,

    [NativeName("CL_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
    Vertical = 2,

    [NativeName("CL_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
    Plane = 3,
}

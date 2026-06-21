// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_intel_device_side_avc_motion_estimation.luma.predictor")]
public enum DeviceSideAvcMotionEstimationLumaPredictorIntel : uint
{
    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
    LumaPredictorModeVerticalINTEL = 0,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
    LumaPredictorModeHorizontalINTEL = 1,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
    LumaPredictorModeDcINTEL = 2,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
    LumaPredictorModeDiagonalDownLeftINTEL = 3,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
    LumaPredictorModeDiagonalDownRightINTEL = 4,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
    LumaPredictorModePlaneINTEL = 4,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
    LumaPredictorModeVerticalRightINTEL = 5,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
    LumaPredictorModeHorizontalDownINTEL = 6,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
    LumaPredictorModeVerticalLeftINTEL = 7,

    [NativeName("CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
    LumaPredictorModeHorizontalUpINTEL = 8,

    [NativeName("CL_AVC_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
    ChromaPredictorModeDcINTEL = 0,

    [NativeName("CL_AVC_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
    ChromaPredictorModeHorizontalINTEL = 1,

    [NativeName("CL_AVC_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
    ChromaPredictorModeVerticalINTEL = 2,

    [NativeName("CL_AVC_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
    ChromaPredictorModePlaneINTEL = 3,
}

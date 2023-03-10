// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.luma.predictor")]
    public enum DeviceSideAvcMotionEstimationLumaPredictor : int
    {
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        LumaPredictorModeVertical = 0x0,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        LumaPredictorModeHorizontal = 0x1,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        LumaPredictorModeDC = 0x2,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        LumaPredictorModeDiagonalDownLeft = 0x3,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        LumaPredictorModeDiagonalDownRight = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        LumaPredictorModePlane = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        LumaPredictorModeVerticalRight = 0x5,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        LumaPredictorModeHorizontalDown = 0x6,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        LumaPredictorModeVerticalLeft = 0x7,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        LumaPredictorModeHorizontalUp = 0x8,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        ChromaPredictorModeDC = 0x0,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        ChromaPredictorModeHorizontal = 0x1,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        ChromaPredictorModeVertical = 0x2,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        ChromaPredictorModePlane = 0x3,
    }
}

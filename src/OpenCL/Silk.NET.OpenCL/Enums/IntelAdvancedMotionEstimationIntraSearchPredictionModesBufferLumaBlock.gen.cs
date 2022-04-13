// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation_intra_search_prediction_modes_buffer_luma_block")]
    public enum IntelAdvancedMotionEstimationIntraSearchPredictionModesBufferLumaBlock : int
    {
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        MELumaPredictorModeVerticalIntel = 0x0,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        MELumaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        MELumaPredictorModeDCIntel = 0x2,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        MELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        MELumaPredictorModeDiagonalDownRightIntel = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        MELumaPredictorModePlaneIntel = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        MELumaPredictorModeVerticalRightIntel = 0x5,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        MELumaPredictorModeHorizontalDownIntel = 0x6,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        MELumaPredictorModeVerticalLeftIntel = 0x7,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        MELumaPredictorModeHorizontalUpIntel = 0x8,
    }
}

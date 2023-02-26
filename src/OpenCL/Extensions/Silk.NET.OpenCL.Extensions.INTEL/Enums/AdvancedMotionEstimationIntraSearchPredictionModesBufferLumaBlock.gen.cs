// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_advanced_motion_estimation.intra_search_prediction_modes_buffer.luma_block")]
    public enum AdvancedMotionEstimationIntraSearchPredictionModesBufferLumaBlock : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        Vertical = 0x0,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        Horizontal = 0x1,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        DC = 0x2,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        DiagonalDownLeft = 0x3,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        DiagonalDownRight = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        Plane = 0x4,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        VerticalRight = 0x5,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        HorizontalDown = 0x6,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        VerticalLeft = 0x7,
        [NativeName("Name", "CL_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        HorizontalUp = 0x8,
    }
}

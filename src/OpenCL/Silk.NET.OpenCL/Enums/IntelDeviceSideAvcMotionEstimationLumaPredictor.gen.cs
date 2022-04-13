// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_luma_predictor")]
    public enum IntelDeviceSideAvcMotionEstimationLumaPredictor : int
    {
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        AvcMELumaPredictorModeVerticalIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        AvcMELumaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DC_INTEL")]
        AvcMELumaPredictorModeDCIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_LEFT_INTEL")]
        AvcMELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_DIAGONAL_DOWN_RIGHT_INTEL")]
        AvcMELumaPredictorModeDiagonalDownRightIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_PLANE_INTEL")]
        AvcMELumaPredictorModePlaneIntel = 0x4,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_RIGHT_INTEL")]
        AvcMELumaPredictorModeVerticalRightIntel = 0x5,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_DOWN_INTEL")]
        AvcMELumaPredictorModeHorizontalDownIntel = 0x6,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_VERTICAL_LEFT_INTEL")]
        AvcMELumaPredictorModeVerticalLeftIntel = 0x7,
        [NativeName("Name", "CL_AVC_ME_LUMA_PREDICTOR_MODE_HORIZONTAL_UP_INTEL")]
        AvcMELumaPredictorModeHorizontalUpIntel = 0x8,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        AvcMEChromaPredictorModeDCIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        AvcMEChromaPredictorModeHorizontalIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        AvcMEChromaPredictorModeVerticalIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        AvcMEChromaPredictorModePlaneIntel = 0x3,
    }
}

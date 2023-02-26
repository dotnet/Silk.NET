// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_advanced_motion_estimation.intra_search_prediction_modes_buffer.chroma_block")]
    public enum AdvancedMotionEstimationIntraSearchPredictionModesBufferChromaBlock : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_DC_INTEL")]
        DC = 0x0,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_HORIZONTAL_INTEL")]
        Horizontal = 0x1,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_VERTICAL_INTEL")]
        Vertical = 0x2,
        [NativeName("Name", "CL_ME_CHROMA_PREDICTOR_MODE_PLANE_INTEL")]
        Plane = 0x3,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation_flags")]
    public enum IntelAdvancedMotionEstimationFlags : int
    {
        [NativeName("Name", "CL_ME_CHROMA_INTRA_PREDICT_ENABLED_INTEL")]
        MEChromaIntraPredictEnabledIntel = 0x1,
        [NativeName("Name", "CL_ME_LUMA_INTRA_PREDICT_ENABLED_INTEL")]
        MELumaIntraPredictEnabledIntel = 0x2,
    }
}

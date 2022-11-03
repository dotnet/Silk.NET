// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_intel_advanced_motion_estimation.flags")]
    public enum AdvancedMotionEstimation : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_ME_CHROMA_INTRA_PREDICT_ENABLED_INTEL")]
        ChromaIntraPredictEnabled = 0x1,
        [NativeName("Name", "CL_ME_LUMA_INTRA_PREDICT_ENABLED_INTEL")]
        LumaIntraPredictEnabled = 0x2,
    }
}

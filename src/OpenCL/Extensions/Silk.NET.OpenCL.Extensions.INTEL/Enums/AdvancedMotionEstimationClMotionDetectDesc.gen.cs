// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation.cl_motion_detect_desc_intel")]
    public enum AdvancedMotionEstimationClMotionDetectDesc : int
    {
        [NativeName("Name", "CL_ME_FORWARD_INPUT_MODE_INTEL")]
        ForwardInputMode = 0x1,
        [NativeName("Name", "CL_ME_BACKWARD_INPUT_MODE_INTEL")]
        BackwardInputMode = 0x2,
        [NativeName("Name", "CL_ME_BIDIRECTION_INPUT_MODE_INTEL")]
        BidirectionInputMode = 0x3,
    }
}

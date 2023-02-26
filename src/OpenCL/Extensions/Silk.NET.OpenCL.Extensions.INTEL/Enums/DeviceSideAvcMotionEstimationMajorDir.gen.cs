// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.major.dir")]
    public enum DeviceSideAvcMotionEstimationMajorDir : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_FORWARD_INTEL")]
        Forward = 0x0,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BACKWARD_INTEL")]
        Backward = 0x1,
        [NativeName("Name", "CL_AVC_ME_MAJOR_BIDIRECTIONAL_INTEL")]
        Bidirectional = 0x2,
    }
}

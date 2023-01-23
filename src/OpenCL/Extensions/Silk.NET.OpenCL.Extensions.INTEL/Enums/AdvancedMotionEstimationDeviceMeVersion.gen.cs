// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_advanced_motion_estimation.device_me_version")]
    public enum AdvancedMotionEstimationDeviceMeVersion : int
    {
        [NativeName("Name", "CL_ME_VERSION_LEGACY_INTEL")]
        Legacy = 0x0,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_1_INTEL")]
        AdvancedVer1 = 0x1,
        [NativeName("Name", "CL_ME_VERSION_ADVANCED_VER_2_INTEL")]
        AdvancedVer2 = 0x2,
    }
}

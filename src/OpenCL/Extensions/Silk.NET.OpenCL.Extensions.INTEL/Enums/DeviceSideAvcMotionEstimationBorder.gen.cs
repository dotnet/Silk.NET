// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.border")]
    public enum DeviceSideAvcMotionEstimationBorder : int
    {
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_LEFT_INTEL")]
        Left = 0x0,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_RIGHT_INTEL")]
        Right = 0x2,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_TOP_INTEL")]
        Top = 0x4,
        [NativeName("Name", "CL_AVC_ME_BORDER_REACHED_BOTTOM_INTEL")]
        Bottom = 0x8,
    }
}

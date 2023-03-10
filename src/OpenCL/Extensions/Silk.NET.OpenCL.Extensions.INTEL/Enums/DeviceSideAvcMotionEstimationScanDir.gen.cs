// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.scan.dir")]
    public enum DeviceSideAvcMotionEstimationScanDir : int
    {
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_TOP_FIELD_INTEL")]
        TopField = 0x0,
        [NativeName("Name", "CL_AVC_ME_INTERLACED_SCAN_BOTTOM_FIELD_INTEL")]
        BottomField = 0x1,
    }
}

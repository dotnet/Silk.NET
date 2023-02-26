// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Flags]
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation.slice")]
    public enum DeviceSideAvcMotionEstimationSlice : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_PRED_INTEL")]
        Pred = 0x0,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_BPRED_INTEL")]
        Bpred = 0x1,
        [NativeName("Name", "CL_AVC_ME_SLICE_TYPE_INTRA_INTEL")]
        Intra = 0x2,
    }
}

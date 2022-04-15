// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_cost_precision")]
    public enum IntelDeviceSideAvcMotionEstimationCostPrecision : int
    {
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_QPEL_INTEL")]
        AvcMECostPrecisionQpelIntel = 0x0,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_HPEL_INTEL")]
        AvcMECostPrecisionHpelIntel = 0x1,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_PEL_INTEL")]
        AvcMECostPrecisionPelIntel = 0x2,
        [NativeName("Name", "CL_AVC_ME_COST_PRECISION_DPEL_INTEL")]
        AvcMECostPrecisionDpelIntel = 0x3,
    }
}

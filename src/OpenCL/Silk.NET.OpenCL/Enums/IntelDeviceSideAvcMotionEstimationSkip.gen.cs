// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_device_side_avc_motion_estimation_skip")]
    public enum IntelDeviceSideAvcMotionEstimationSkip : int
    {
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_16x16_INTEL")]
        AvcMESkipBlockPartition16x16Intel = 0x0,
        [NativeName("Name", "CL_AVC_ME_SKIP_BLOCK_PARTITION_8x8_INTEL")]
        AvcMESkipBlockPartition8x8Intel = 0x4000,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [System.Flags]
    [NativeName("Name", "cl_device_scheduling_controls_capabilities_arm")]
    public enum DeviceSchedulingControlsCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_KERNEL_BATCHING_ARM")]
        KernelBatching = 0x1,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_WORKGROUP_BATCH_SIZE_ARM")]
        WorkgroupBatchSize = 0x2,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
        WorkgroupBatchSizeModifier = 0x4,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_DEFERRED_FLUSH_ARM")]
        DeferredFlush = 0x8,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_REGISTER_ALLOCATION_ARM")]
        RegisterAllocation = 0x10,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_WARP_THROTTLING_ARM")]
        WarpThrottling = 0x20,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_COMPUTE_UNIT_BATCH_QUEUE_SIZE_ARM")]
        ComputeUnitBatchQueueSize = 0x40,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_COMPUTE_UNIT_LIMIT_ARM")]
        ComputeUnitLimit = 0x80,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_scheduling_controls_capabilities_arm")]
[Flags]
public enum DeviceSchedulingControlsCapabilitiesARM : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_SCHEDULING_KERNEL_BATCHING_ARM")]
    KernelBatching = 0x1,

    [NativeName("CL_DEVICE_SCHEDULING_WORKGROUP_BATCH_SIZE_ARM")]
    WorkgroupBatchSize = 0x2,

    [NativeName("CL_DEVICE_SCHEDULING_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
    WorkgroupBatchSizeModifier = 0x4,

    [NativeName("CL_DEVICE_SCHEDULING_DEFERRED_FLUSH_ARM")]
    DeferredFlush = 0x8,

    [NativeName("CL_DEVICE_SCHEDULING_REGISTER_ALLOCATION_ARM")]
    RegisterAllocation = 0x10,

    [NativeName("CL_DEVICE_SCHEDULING_WARP_THROTTLING_ARM")]
    WarpThrottling = 0x20,

    [NativeName("CL_DEVICE_SCHEDULING_COMPUTE_UNIT_BATCH_QUEUE_SIZE_ARM")]
    ComputeUnitBatchQueueSize = 0x40,

    [NativeName("CL_DEVICE_SCHEDULING_COMPUTE_UNIT_LIMIT_ARM")]
    ComputeUnitLimit = 0x80,
}

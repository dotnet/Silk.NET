// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_queue_properties")]
public enum QueueProperties : ulong
{
    [NativeName("CL_QUEUE_PRIORITY_KHR")]
    PriorityKHR = 4246,

    [NativeName("CL_QUEUE_THROTTLE_KHR")]
    ThrottleKHR = 4247,

    [NativeName("CL_QUEUE_JOB_SLOT_ARM")]
    JobSlotARM = 16865,

    [NativeName("CL_QUEUE_KERNEL_BATCHING_ARM")]
    KernelBatchingARM = 16871,

    [NativeName("CL_QUEUE_DEFERRED_FLUSH_ARM")]
    DeferredFlushARM = 16876,

    [NativeName("CL_QUEUE_COMPUTE_UNIT_LIMIT_ARM")]
    ComputeUnitLimitARM = 16883,

    [NativeName("CL_QUEUE_FAMILY_INTEL")]
    FamilyINTEL = 16780,

    [NativeName("CL_QUEUE_INDEX_INTEL")]
    IndexINTEL = 16781,
}

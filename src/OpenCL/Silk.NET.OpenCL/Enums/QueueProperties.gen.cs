// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_queue_properties")]
    public enum QueueProperties : ulong
    {
        [NativeName("Name", "CL_QUEUE_PRIORITY_KHR")]
        PriorityKhr = 0x1096,
        [NativeName("Name", "CL_QUEUE_THROTTLE_KHR")]
        ThrottleKhr = 0x1097,
        [NativeName("Name", "CL_QUEUE_KERNEL_BATCHING_ARM")]
        KernelBatchingArm = 0x41E7,
        [NativeName("Name", "CL_QUEUE_DEFERRED_FLUSH_ARM")]
        DeferredFlushArm = 0x41EC,
        [NativeName("Name", "CL_QUEUE_COMPUTE_UNIT_LIMIT_ARM")]
        ComputeUnitLimitArm = 0x41F3,
        [NativeName("Name", "CL_QUEUE_FAMILY_INTEL")]
        FamilyIntel = 0x418C,
        [NativeName("Name", "CL_QUEUE_INDEX_INTEL")]
        IndexIntel = 0x418D,
        [NativeName("Name", "CL_QUEUE_JOB_SLOT_ARM")]
        JobSlotArm = 0x41E1,
    }
}

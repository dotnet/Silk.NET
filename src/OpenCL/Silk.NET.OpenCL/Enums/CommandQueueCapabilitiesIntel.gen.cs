// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_command_queue_capabilities_intel")]
    public enum CommandQueueCapabilitiesIntel : ulong
    {
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_SINGLE_QUEUE_EVENTS_INTEL")]
        QueueCapabilityCreateSingleQueueEventsIntel = 0x1,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CREATE_CROSS_QUEUE_EVENTS_INTEL")]
        QueueCapabilityCreateCrossQueueEventsIntel = 0x2,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_SINGLE_QUEUE_EVENT_WAIT_LIST_INTEL")]
        QueueCapabilitySingleQueueEventWaitListIntel = 0x4,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_CROSS_QUEUE_EVENT_WAIT_LIST_INTEL")]
        QueueCapabilityCrossQueueEventWaitListIntel = 0x8,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_INTEL")]
        QueueCapabilityTransferBufferIntel = 0x100,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_RECT_INTEL")]
        QueueCapabilityTransferBufferRectIntel = 0x200,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_BUFFER_INTEL")]
        QueueCapabilityMapBufferIntel = 0x400,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_BUFFER_INTEL")]
        QueueCapabilityFillBufferIntel = 0x800,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_INTEL")]
        QueueCapabilityTransferImageIntel = 0x1000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MAP_IMAGE_INTEL")]
        QueueCapabilityMapImageIntel = 0x2000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_FILL_IMAGE_INTEL")]
        QueueCapabilityFillImageIntel = 0x4000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_IMAGE_INTEL")]
        QueueCapabilityTransferBufferImageIntel = 0x8000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_BUFFER_INTEL")]
        QueueCapabilityTransferImageBufferIntel = 0x10000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_MARKER_INTEL")]
        QueueCapabilityMarkerIntel = 0x1000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_BARRIER_INTEL")]
        QueueCapabilityBarrierIntel = 0x2000000,
        [NativeName("Name", "CL_QUEUE_CAPABILITY_KERNEL_INTEL")]
        QueueCapabilityKernelIntel = 0x4000000,
    }
}

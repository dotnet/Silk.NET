// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_command_queue_capabilities_intel")]
[Flags]
public enum CommandQueueCapabilitiesINTEL : ulong
{
    None = 0x0,

    [NativeName("CL_QUEUE_CAPABILITY_CREATE_SINGLE_QUEUE_EVENTS_INTEL")]
    CreateSingleQueueEvents = 0x1,

    [NativeName("CL_QUEUE_CAPABILITY_CREATE_CROSS_QUEUE_EVENTS_INTEL")]
    CreateCrossQueueEvents = 0x2,

    [NativeName("CL_QUEUE_CAPABILITY_SINGLE_QUEUE_EVENT_WAIT_LIST_INTEL")]
    SingleQueueEventWaitList = 0x4,

    [NativeName("CL_QUEUE_CAPABILITY_CROSS_QUEUE_EVENT_WAIT_LIST_INTEL")]
    CrossQueueEventWaitList = 0x8,

    [NativeName("CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_INTEL")]
    TransferBuffer = 0x100,

    [NativeName("CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_RECT_INTEL")]
    TransferBufferRect = 0x200,

    [NativeName("CL_QUEUE_CAPABILITY_MAP_BUFFER_INTEL")]
    MapBuffer = 0x400,

    [NativeName("CL_QUEUE_CAPABILITY_FILL_BUFFER_INTEL")]
    FillBuffer = 0x800,

    [NativeName("CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_INTEL")]
    TransferImage = 0x1000,

    [NativeName("CL_QUEUE_CAPABILITY_MAP_IMAGE_INTEL")]
    MapImage = 0x2000,

    [NativeName("CL_QUEUE_CAPABILITY_FILL_IMAGE_INTEL")]
    FillImage = 0x4000,

    [NativeName("CL_QUEUE_CAPABILITY_TRANSFER_BUFFER_IMAGE_INTEL")]
    TransferBufferImage = 0x8000,

    [NativeName("CL_QUEUE_CAPABILITY_TRANSFER_IMAGE_BUFFER_INTEL")]
    TransferImageBuffer = 0x10000,

    [NativeName("CL_QUEUE_CAPABILITY_MARKER_INTEL")]
    Marker = 0x1000000,

    [NativeName("CL_QUEUE_CAPABILITY_BARRIER_INTEL")]
    Barrier = 0x2000000,

    [NativeName("CL_QUEUE_CAPABILITY_KERNEL_INTEL")]
    Kernel = 0x4000000,
}

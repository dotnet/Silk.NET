// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_command_buffer_capabilities_khr")]
[Flags]
public enum DeviceCommandBufferCapabilitiesKHR : ulong
{
    None = 0x0,

    [NativeName("CL_COMMAND_BUFFER_CAPABILITY_KERNEL_PRINTF_KHR")]
    KernelPrintf = 0x1,

    [NativeName("CL_COMMAND_BUFFER_CAPABILITY_DEVICE_SIDE_ENQUEUE_KHR")]
    DeviceSideEnqueue = 0x2,

    [NativeName("CL_COMMAND_BUFFER_CAPABILITY_SIMULTANEOUS_USE_KHR")]
    SimultaneousUse = 0x4,

    [NativeName("CL_COMMAND_BUFFER_CAPABILITY_MULTIPLE_QUEUE_KHR")]
    MultipleQueue = 0x10,
}

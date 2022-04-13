// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_command_buffer_capabilities_khr ")]
    public enum DeviceCommandBufferCapabilitiesKhr : int
    {
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_KERNEL_PRINTF_KHR")]
        CommandBufferCapabilityKernelPrintfKhr = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_DEVICE_SIDE_ENQUEUE_KHR")]
        CommandBufferCapabilityDeviceSideEnqueueKhr = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_SIMULTANEOUS_USE_KHR")]
        CommandBufferCapabilitySimultaneousUseKhr = 0x4,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_OUT_OF_ORDER_KHR")]
        CommandBufferCapabilityOutOfOrderKhr = 0x8,
    }
}

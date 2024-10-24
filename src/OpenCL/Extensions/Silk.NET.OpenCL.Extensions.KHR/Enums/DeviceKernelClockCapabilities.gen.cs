// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_device_kernel_clock_capabilities_khr")]
    public enum DeviceKernelClockCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_KERNEL_CLOCK_SCOPE_DEVICE_KHR")]
        Device = 0x1,
        [NativeName("Name", "CL_DEVICE_KERNEL_CLOCK_SCOPE_WORK_GROUP_KHR")]
        WorkGroup = 0x2,
        [NativeName("Name", "CL_DEVICE_KERNEL_CLOCK_SCOPE_SUB_GROUP_KHR")]
        SubGroup = 0x4,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_kernel_clock_capabilities_khr")]
[Flags]
public enum DeviceKernelClockCapabilitiesKHR : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_KERNEL_CLOCK_SCOPE_DEVICE_KHR")]
    Device = 0x1,

    [NativeName("CL_DEVICE_KERNEL_CLOCK_SCOPE_WORK_GROUP_KHR")]
    WorkGroup = 0x2,

    [NativeName("CL_DEVICE_KERNEL_CLOCK_SCOPE_SUB_GROUP_KHR")]
    SubGroup = 0x4,
}

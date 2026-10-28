// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceType")]
public enum PhysicalDeviceType : uint
{
    [NativeName("VK_PHYSICAL_DEVICE_TYPE_OTHER")]
    Other = 0,

    [NativeName("VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU")]
    IntegratedGpu = 1,

    [NativeName("VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU")]
    DiscreteGpu = 2,

    [NativeName("VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU")]
    VirtualGpu = 3,

    [NativeName("VK_PHYSICAL_DEVICE_TYPE_CPU")]
    Cpu = 4,
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceLayeredApiKHR")]
public enum PhysicalDeviceLayeredApiKHR : uint
{
    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR")]
    Vulkan = 0,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR")]
    D3D12 = 1,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR")]
    Metal = 2,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR")]
    Opengl = 3,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR")]
    Opengles = 4,
}

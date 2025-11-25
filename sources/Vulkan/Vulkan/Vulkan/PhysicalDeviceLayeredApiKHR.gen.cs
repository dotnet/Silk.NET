// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum PhysicalDeviceLayeredApiKHR : uint
{
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VulkanKHR = 0,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    D3D12KHR = 1,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    MetalKHR = 2,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    OpenglKHR = 3,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    OpenglesKHR = 4,
}

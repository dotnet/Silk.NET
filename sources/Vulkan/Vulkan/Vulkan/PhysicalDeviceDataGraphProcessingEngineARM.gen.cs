// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDataGraphProcessingEngineARM")]
[SupportedApiProfile("vulkan")]
public partial struct PhysicalDeviceDataGraphProcessingEngineARM
{
    [NativeName("type")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public PhysicalDeviceDataGraphProcessingEngineTypeARM Type;

    [NativeName("isForeign")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = [
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_extended_flags",
            "VK_VERSION_1_3+VK_KHR_deferred_host_operations+VK_KHR_maintenance5",
        ]
    )]
    public MaybeBool<uint> IsForeign;
}

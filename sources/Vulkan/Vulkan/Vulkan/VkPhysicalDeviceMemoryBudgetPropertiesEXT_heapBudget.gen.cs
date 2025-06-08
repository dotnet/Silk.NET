// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(16)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_memory_budget"],
    ImpliesSets = [
        "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
        "VK_EXT_memory_budget+VK_VERSION_1_1",
    ]
)]
public partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT_heapBudget
{
    [SupportedApiProfile("vulkan")]
    public ulong e0;
}

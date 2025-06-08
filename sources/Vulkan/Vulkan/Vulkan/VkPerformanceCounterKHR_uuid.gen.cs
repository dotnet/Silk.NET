// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(16)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_performance_query"],
    ImpliesSets = [
        "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
        "VK_KHR_performance_query+VK_VERSION_1_1",
    ]
)]
public partial struct VkPerformanceCounterKHR_uuid
{
    [SupportedApiProfile("vulkan")]
    public byte e0;
}

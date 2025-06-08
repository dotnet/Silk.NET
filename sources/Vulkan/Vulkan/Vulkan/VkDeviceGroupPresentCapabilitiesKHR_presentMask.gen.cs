// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(32)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_swapchain", "VK_VERSION_1_1"],
    ImpliesSets = ["VK_KHR_surface"],
    RequireAll = true
)]
public partial struct VkDeviceGroupPresentCapabilitiesKHR_presentMask
{
    [SupportedApiProfile("vulkan")]
    public uint e0;
}

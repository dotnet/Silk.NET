// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(8)]
[SupportedApiProfile(
    "vulkan",
    ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
    MinVersion = "1.2"
)]
public partial struct VkPhysicalDeviceVulkan11Properties_deviceLUID
{
    [SupportedApiProfile("vulkan")]
    public byte e0;
}

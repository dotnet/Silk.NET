// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(2)]
[SupportedApiProfile(
    "vulkan",
    ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
    MinVersion = "1.0"
)]
public partial struct VkPhysicalDeviceLimits_pointSizeRange
{
    [SupportedApiProfile("vulkan")]
    public float e0;
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(16)]
[SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
public partial struct VkQueueFamilyGlobalPriorityProperties_priorities
{
    [SupportedApiProfile("vulkan")]
    public VkQueueGlobalPriority e0;
}

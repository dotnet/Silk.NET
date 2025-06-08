// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(256)]
[SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
public partial struct VkPhysicalDeviceToolProperties_description
{
    [SupportedApiProfile("vulkan")]
    public sbyte e0;
}

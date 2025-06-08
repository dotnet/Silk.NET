// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(256)]
[SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
public partial struct VkPhysicalDeviceLayeredApiPropertiesKHR_deviceName
{
    [SupportedApiProfile("vulkan")]
    public sbyte e0;
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(16)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_device_fault"],
    ImpliesSets = [
        "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
        "VK_EXT_device_fault+VK_VERSION_1_1",
    ]
)]
public partial struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT_pipelineCacheUUID
{
    [SupportedApiProfile("vulkan")]
    public byte e0;
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(2)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_sample_locations"],
    ImpliesSets = [
        "VK_EXT_sample_locations+VK_KHR_get_physical_device_properties2",
        "VK_EXT_sample_locations+VK_VERSION_1_1",
    ]
)]
public partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT_sampleLocationCoordinateRange
{
    [SupportedApiProfile("vulkan")]
    public float e0;
}

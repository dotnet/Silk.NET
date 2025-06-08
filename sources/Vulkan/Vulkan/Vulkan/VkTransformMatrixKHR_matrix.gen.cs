// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(3 * 4)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_acceleration_structure"],
    ImpliesSets = [
        "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
        "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
    ]
)]
public partial struct VkTransformMatrixKHR_matrix
{
    [SupportedApiProfile("vulkan")]
    public float e0_0;
}

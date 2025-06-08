// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(2)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_fragment_shading_rate"],
    ImpliesSets = [
        "VK_KHR_create_renderpass2+VK_KHR_get_physical_device_properties2",
        "VK_KHR_create_renderpass2+VK_VERSION_1_1",
        "VK_VERSION_1_2",
    ]
)]
public partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR_combinerOps
{
    [SupportedApiProfile("vulkan")]
    public VkFragmentShadingRateCombinerOpKHR e0;
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(2)]
[SupportedApiProfile(
    "vulkan",
    ["VK_NV_fragment_shading_rate_enums"],
    ImpliesSets = ["VK_KHR_fragment_shading_rate"]
)]
public partial struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV_combinerOps
{
    [SupportedApiProfile("vulkan")]
    public VkFragmentShadingRateCombinerOpKHR e0;
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(32)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_pipeline_binary"],
    ImpliesSets = [
        "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
        "VK_KHR_pipeline_binary+VK_VERSION_1_4",
    ]
)]
public partial struct VkPipelineBinaryKeyKHR_key
{
    [SupportedApiProfile("vulkan")]
    public byte e0;
}

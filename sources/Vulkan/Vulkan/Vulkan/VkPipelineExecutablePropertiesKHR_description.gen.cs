// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(256)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_pipeline_executable_properties"],
    ImpliesSets = [
        "VK_KHR_pipeline_executable_properties+VK_KHR_get_physical_device_properties2",
        "VK_KHR_pipeline_executable_properties+VK_VERSION_1_1",
    ]
)]
public partial struct VkPipelineExecutablePropertiesKHR_description
{
    [SupportedApiProfile("vulkan")]
    public sbyte e0;
}

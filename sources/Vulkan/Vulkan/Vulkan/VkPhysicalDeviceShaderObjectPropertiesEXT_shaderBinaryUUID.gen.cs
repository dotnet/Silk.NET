// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(16)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_shader_object"],
    ImpliesSets = [
        "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
        "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
        "VK_VERSION_1_3",
    ]
)]
public partial struct VkPhysicalDeviceShaderObjectPropertiesEXT_shaderBinaryUUID
{
    [SupportedApiProfile("vulkan")]
    public byte e0;
}

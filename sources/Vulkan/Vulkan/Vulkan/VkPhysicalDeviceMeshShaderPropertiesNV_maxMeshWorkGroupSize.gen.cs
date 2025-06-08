// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(3)]
[SupportedApiProfile(
    "vulkan",
    ["VK_NV_mesh_shader"],
    ImpliesSets = [
        "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
        "VK_NV_mesh_shader+VK_VERSION_1_1",
    ]
)]
public partial struct VkPhysicalDeviceMeshShaderPropertiesNV_maxMeshWorkGroupSize
{
    [SupportedApiProfile("vulkan")]
    public uint e0;
}

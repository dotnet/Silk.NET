// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(3)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_mesh_shader"],
    ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
)]
public partial struct VkPhysicalDeviceMeshShaderPropertiesEXT_maxMeshWorkGroupSize
{
    [SupportedApiProfile("vulkan")]
    public uint e0;
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceCooperativeVectorPropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public void* pNext;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint cooperativeVectorSupportedStages;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint cooperativeVectorTrainingFloat16Accumulation;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint cooperativeVectorTrainingFloat32Accumulation;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint maxCooperativeVectorComponents;
}

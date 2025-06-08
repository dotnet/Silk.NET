// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_shader_atomic_float16_vector"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_NV_shader_atomic_float16_vector"])]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_atomic_float16_vector"])]
    public uint shaderFloat16VectorAtomics;
}

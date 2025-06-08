// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCooperativeVectorPropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public void* pNext;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkComponentTypeKHR inputType;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkComponentTypeKHR inputInterpretation;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkComponentTypeKHR matrixInterpretation;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkComponentTypeKHR biasInterpretation;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkComponentTypeKHR resultType;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint transpose;
}

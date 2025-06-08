// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_shader_relaxed_extended_instruction"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_KHR_shader_relaxed_extended_instruction"])]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_shader_relaxed_extended_instruction"])]
    public uint shaderRelaxedExtendedInstruction;
}

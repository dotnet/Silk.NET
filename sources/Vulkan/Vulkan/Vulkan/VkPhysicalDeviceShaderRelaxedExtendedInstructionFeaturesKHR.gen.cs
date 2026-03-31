// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_relaxed_extended_instruction"],
        ImpliesSets = [
            "VK_KHR_shader_relaxed_extended_instruction+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_relaxed_extended_instruction+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_relaxed_extended_instruction"],
        ImpliesSets = [
            "VK_KHR_shader_relaxed_extended_instruction+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_relaxed_extended_instruction+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderRelaxedExtendedInstruction")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_relaxed_extended_instruction"],
        ImpliesSets = [
            "VK_KHR_shader_relaxed_extended_instruction+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_relaxed_extended_instruction+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderRelaxedExtendedInstruction;
}

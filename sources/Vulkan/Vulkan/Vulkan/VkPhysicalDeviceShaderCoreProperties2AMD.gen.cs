// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderCoreProperties2AMD")]
[NameAffix("Suffix", "KhronosVendor", "AMD")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderCoreProperties2AMD
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    public void* PNext;

    [NativeName("shaderCoreFeatures")]
    [NativeTypeName("VkShaderCorePropertiesFlagsAMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    public VkShaderCorePropertiesFlagsAMD ShaderCoreFeatures;

    [NativeName("activeComputeUnitCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    public uint ActiveComputeUnitCount;
}

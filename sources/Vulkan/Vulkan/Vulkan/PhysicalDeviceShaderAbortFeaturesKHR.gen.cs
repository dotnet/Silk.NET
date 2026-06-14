// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderAbortFeaturesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderAbortFeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_abort"],
        ImpliesSets = ["VK_KHR_device_fault", "VK_KHR_shader_constant_data"]
    )]
    public StructureType SType = StructureType.PhysicalDeviceShaderAbortFeaturesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_abort"],
        ImpliesSets = ["VK_KHR_device_fault", "VK_KHR_shader_constant_data"]
    )]
    public void* PNext;

    [NativeName("shaderAbort")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_abort"],
        ImpliesSets = ["VK_KHR_device_fault", "VK_KHR_shader_constant_data"]
    )]
    public MaybeBool<uint> ShaderAbort;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_abort"],
        ImpliesSets = ["VK_KHR_device_fault", "VK_KHR_shader_constant_data"]
    )]
    public PhysicalDeviceShaderAbortFeaturesKHR() { }
}

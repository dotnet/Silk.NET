// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderQuadControlFeaturesKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_quad_control"],
        ImpliesSets = [
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_1+VK_KHR_vulkan_memory_model",
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_2",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_quad_control"],
        ImpliesSets = [
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_1+VK_KHR_vulkan_memory_model",
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_2",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_quad_control"],
        ImpliesSets = [
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_1+VK_KHR_vulkan_memory_model",
            "VK_KHR_shader_maximal_reconvergence+VK_VERSION_1_2",
        ]
    )]
    public uint ShaderQuadControl;
}

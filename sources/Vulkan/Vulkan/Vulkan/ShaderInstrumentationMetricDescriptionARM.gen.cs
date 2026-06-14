// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderInstrumentationMetricDescriptionARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ShaderInstrumentationMetricDescriptionARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.ShaderInstrumentationMetricDescriptionARM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("name")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public ShaderInstrumentationMetricDescriptionARMName Name;

    [NativeName("description")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public ShaderInstrumentationMetricDescriptionARMDescription Description;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public ShaderInstrumentationMetricDescriptionARM() { }
}

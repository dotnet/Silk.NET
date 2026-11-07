// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderInstrumentationPropertiesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderInstrumentationPropertiesARM
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
    public StructureType SType = StructureType.PhysicalDeviceShaderInstrumentationPropertiesARM;

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

    [NativeName("numMetrics")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public uint NumMetrics;

    [NativeName("perBasicBlockGranularity")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> PerBasicBlockGranularity;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceShaderInstrumentationPropertiesARM() { }
}

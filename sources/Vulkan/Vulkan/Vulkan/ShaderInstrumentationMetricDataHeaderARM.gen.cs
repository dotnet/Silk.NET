// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderInstrumentationMetricDataHeaderARM")]
[SupportedApiProfile("vulkan")]
public partial struct ShaderInstrumentationMetricDataHeaderARM
{
    [NativeName("resultIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public uint ResultIndex;

    [NativeName("resultSubIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public uint ResultSubIndex;

    [NativeName("stages")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public ShaderStageFlags Stages;

    [NativeName("basicBlockIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_shader_instrumentation"],
        ImpliesSets = [
            "VK_ARM_shader_instrumentation+VK_KHR_get_physical_device_properties2",
            "VK_ARM_shader_instrumentation+VK_VERSION_1_1",
        ]
    )]
    public uint BasicBlockIndex;
}

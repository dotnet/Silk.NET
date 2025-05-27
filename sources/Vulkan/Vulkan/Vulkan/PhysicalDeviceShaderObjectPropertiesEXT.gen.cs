// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderObjectPropertiesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    public void* PNext;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    public PhysicalDeviceShaderObjectPropertiesEXTShaderBinaryUUID ShaderBinaryUUID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    public uint ShaderBinaryVersion;
}

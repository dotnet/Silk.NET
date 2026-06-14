// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_shader_mixed_float_dot_product"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_shader_float16_int8",
            "VK_KHR_get_physical_device_properties2+VK_VERSION_1_2",
            "VK_VERSION_1_1+VK_KHR_shader_float16_int8",
            "VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    public StructureType SType =
        StructureType.PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_shader_mixed_float_dot_product"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_shader_float16_int8",
            "VK_KHR_get_physical_device_properties2+VK_VERSION_1_2",
            "VK_VERSION_1_1+VK_KHR_shader_float16_int8",
            "VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    public void* PNext;

    [NativeName("shaderMixedFloatDotProductFloat16AccFloat32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_shader_mixed_float_dot_product"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_shader_float16_int8",
            "VK_KHR_get_physical_device_properties2+VK_VERSION_1_2",
            "VK_VERSION_1_1+VK_KHR_shader_float16_int8",
            "VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    public MaybeBool<uint> ShaderMixedFloatDotProductFloat16AccFloat32;

    [NativeName("shaderMixedFloatDotProductFloat16AccFloat16")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_shader_mixed_float_dot_product"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_shader_float16_int8",
            "VK_KHR_get_physical_device_properties2+VK_VERSION_1_2",
            "VK_VERSION_1_1+VK_KHR_shader_float16_int8",
            "VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    public MaybeBool<uint> ShaderMixedFloatDotProductFloat16AccFloat16;

    [NativeName("shaderMixedFloatDotProductBFloat16Acc")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_shader_mixed_float_dot_product"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_shader_float16_int8",
            "VK_KHR_get_physical_device_properties2+VK_VERSION_1_2",
            "VK_VERSION_1_1+VK_KHR_shader_float16_int8",
            "VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    public MaybeBool<uint> ShaderMixedFloatDotProductBFloat16Acc;

    [NativeName("shaderMixedFloatDotProductFloat8AccFloat32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_shader_mixed_float_dot_product"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_shader_float16_int8",
            "VK_KHR_get_physical_device_properties2+VK_VERSION_1_2",
            "VK_VERSION_1_1+VK_KHR_shader_float16_int8",
            "VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    public MaybeBool<uint> ShaderMixedFloatDotProductFloat8AccFloat32;

    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_shader_mixed_float_dot_product"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_shader_float16_int8",
            "VK_KHR_get_physical_device_properties2+VK_VERSION_1_2",
            "VK_VERSION_1_1+VK_KHR_shader_float16_int8",
            "VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    public PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE() { }
}

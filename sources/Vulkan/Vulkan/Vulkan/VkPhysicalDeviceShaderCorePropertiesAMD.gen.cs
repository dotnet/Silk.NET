// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderCorePropertiesAMD")]
[NameAffix("Suffix", "KhronosVendor", "AMD")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderEngineCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderEngineCount;

    [NativeName("shaderArraysPerEngineCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderArraysPerEngineCount;

    [NativeName("computeUnitsPerShaderArray")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint ComputeUnitsPerShaderArray;

    [NativeName("simdPerComputeUnit")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint SimdPerComputeUnit;

    [NativeName("wavefrontsPerSimd")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint WavefrontsPerSimd;

    [NativeName("wavefrontSize")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint WavefrontSize;

    [NativeName("sgprsPerSimd")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint SgprsPerSimd;

    [NativeName("minSgprAllocation")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint MinSgprAllocation;

    [NativeName("maxSgprAllocation")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint MaxSgprAllocation;

    [NativeName("sgprAllocationGranularity")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint SgprAllocationGranularity;

    [NativeName("vgprsPerSimd")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint VgprsPerSimd;

    [NativeName("minVgprAllocation")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint MinVgprAllocation;

    [NativeName("maxVgprAllocation")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint MaxVgprAllocation;

    [NativeName("vgprAllocationGranularity")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties"],
        ImpliesSets = [
            "VK_AMD_shader_core_properties+VK_KHR_get_physical_device_properties2",
            "VK_AMD_shader_core_properties+VK_VERSION_1_1",
        ]
    )]
    public uint VgprAllocationGranularity;
}

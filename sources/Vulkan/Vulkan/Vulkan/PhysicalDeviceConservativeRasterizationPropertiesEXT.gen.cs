// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkPhysicalDeviceConservativeRasterizationPropertiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceConservativeRasterizationPropertiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("primitiveOverestimationSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public float PrimitiveOverestimationSize;

    [NativeName("maxExtraPrimitiveOverestimationSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public float MaxExtraPrimitiveOverestimationSize;

    [NativeName("extraPrimitiveOverestimationSizeGranularity")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public float ExtraPrimitiveOverestimationSizeGranularity;

    [NativeName("primitiveUnderestimation")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public uint PrimitiveUnderestimation;

    [NativeName("conservativePointAndLineRasterization")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public uint ConservativePointAndLineRasterization;

    [NativeName("degenerateTrianglesRasterized")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public uint DegenerateTrianglesRasterized;

    [NativeName("degenerateLinesRasterized")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public uint DegenerateLinesRasterized;

    [NativeName("fullyCoveredFragmentShaderInputVariable")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public uint FullyCoveredFragmentShaderInputVariable;

    [NativeName("conservativeRasterizationPostDepthCoverage")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    public uint ConservativeRasterizationPostDepthCoverage;
}

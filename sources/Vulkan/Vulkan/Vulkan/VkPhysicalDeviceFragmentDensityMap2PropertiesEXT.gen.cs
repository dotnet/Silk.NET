// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFragmentDensityMap2PropertiesEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    public void* PNext;

    [NativeName("subsampledLoads")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    public uint SubsampledLoads;

    [NativeName("subsampledCoarseReconstructionEarlyAccess")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    public uint SubsampledCoarseReconstructionEarlyAccess;

    [NativeName("maxSubsampledArrayLayers")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    public uint MaxSubsampledArrayLayers;

    [NativeName("maxDescriptorSetSubsampledSamplers")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map2"],
        ImpliesSets = ["VK_EXT_fragment_density_map"]
    )]
    public uint MaxDescriptorSetSubsampledSamplers;
}

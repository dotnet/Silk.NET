// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTextureCompressionASTC3DFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceTextureCompressionAstc3DFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_3d"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_3d+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_3d+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceTextureCompressionAstc3DFeaturesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_3d"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_3d+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_3d+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("textureCompressionASTC_3D")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_3d"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_3d+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_3d+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> TextureCompressionAstc3D;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_3d"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_3d+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_3d+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceTextureCompressionAstc3DFeaturesEXT() { }
}

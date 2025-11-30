// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkPhysicalDeviceShaderTileImagePropertiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderTileImagePropertiesExt
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("shaderTileImageCoherentReadAccelerated")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderTileImageCoherentReadAccelerated;

    [NativeName("shaderTileImageReadSampleFromPixelRateInvocation")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderTileImageReadSampleFromPixelRateInvocation;

    [NativeName("shaderTileImageReadFromHelperInvocation")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderTileImageReadFromHelperInvocation;
}

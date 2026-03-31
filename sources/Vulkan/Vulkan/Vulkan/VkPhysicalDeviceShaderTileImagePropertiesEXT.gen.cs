// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderTileImagePropertiesEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderTileImagePropertiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("shaderTileImageCoherentReadAccelerated")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderTileImageCoherentReadAccelerated;

    [NativeName("shaderTileImageReadSampleFromPixelRateInvocation")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderTileImageReadSampleFromPixelRateInvocation;

    [NativeName("shaderTileImageReadFromHelperInvocation")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderTileImageReadFromHelperInvocation;
}

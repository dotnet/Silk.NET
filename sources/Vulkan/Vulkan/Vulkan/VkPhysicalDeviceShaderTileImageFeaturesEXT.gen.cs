// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderTileImageFeaturesEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint shaderTileImageColorReadAccess;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint shaderTileImageDepthReadAccess;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_tile_image"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint shaderTileImageStencilReadAccess;
}

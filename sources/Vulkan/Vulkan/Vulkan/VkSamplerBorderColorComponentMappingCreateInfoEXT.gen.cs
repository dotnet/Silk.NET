// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerBorderColorComponentMappingCreateInfoEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    public void* PNext;

    [NativeName("components")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    public VkComponentMapping Components;

    [NativeName("srgb")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_border_color_swizzle"],
        ImpliesSets = ["VK_EXT_custom_border_color"]
    )]
    public uint Srgb;
}

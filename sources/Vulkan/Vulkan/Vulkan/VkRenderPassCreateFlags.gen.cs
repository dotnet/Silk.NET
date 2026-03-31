// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassCreateFlagBits")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkRenderPassCreateFlags : uint
{
    [NativeName("VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    VkRenderPassCreateTransformBitQCOM = 0x00000002,

    [NativeName("VK_RENDER_PASS_CREATE_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    VkRenderPassCreatePerLayerFragmentDensityBitVALVE = 0x00000004,

    [NativeName("VK_RENDER_PASS_CREATE_FLAG_BITS_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkRenderPassCreateFlagBitsMaxEnum = 0x7FFFFFFF,
}

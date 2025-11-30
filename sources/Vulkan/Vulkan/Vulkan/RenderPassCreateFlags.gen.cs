// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassCreateFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum RenderPassCreateFlags : uint
{
    None = 0x0,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    TransformBitqcom = 0x2,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_RENDER_PASS_CREATE_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PerLayerFragmentDensityBitvalve = 0x4,
}

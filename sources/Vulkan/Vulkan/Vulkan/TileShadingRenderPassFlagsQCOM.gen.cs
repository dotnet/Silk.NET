// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("QCOM", 0)]
[NativeName("VkTileShadingRenderPassFlagBitsQCOM")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum TileShadingRenderPassFlagsQCOM : uint
{
    None = 0x0,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_TILE_SHADING_RENDER_PASS_ENABLE_BIT_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    EnableBitQCOM = 0x1,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_TILE_SHADING_RENDER_PASS_PER_TILE_EXECUTION_BIT_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    PerTileExecutionBitQCOM = 0x2,
}

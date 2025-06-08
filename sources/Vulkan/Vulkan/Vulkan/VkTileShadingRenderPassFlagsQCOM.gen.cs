// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkTileShadingRenderPassFlagsQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_TILE_SHADING_RENDER_PASS_ENABLE_BIT_QCOM = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_TILE_SHADING_RENDER_PASS_PER_TILE_EXECUTION_BIT_QCOM = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VK_TILE_SHADING_RENDER_PASS_FLAG_BITS_MAX_ENUM_QCOM = 0x7FFFFFFF,
}

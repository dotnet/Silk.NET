// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassDescriptionFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum SubpassDescriptionFlags : uint
{
    None = 0x0,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    PerViewAttributesBitnvx = 0x1,

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    PerViewPositionXOnlyBitnvx = 0x2,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_shader_resolve"])]
    FragmentRegionBitqcom = 0x4,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_shader_resolve"])]
    ShaderResolveBitqcom = 0x8,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_TILE_SHADING_APRON_BIT_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    TileShadingApronBitqcom = 0x100,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentColorAccessBitext = 0x10,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentDepthAccessBitext = 0x20,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentStencilAccessBitext = 0x40,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_dithering"],
        ImpliesSets = [
            "VK_EXT_legacy_dithering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_legacy_dithering+VK_VERSION_1_1",
        ]
    )]
    EnableLegacyDitheringBitext = 0x80,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentColorAccessBitarm = RasterizationOrderAttachmentColorAccessBitext,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentDepthAccessBitarm = RasterizationOrderAttachmentDepthAccessBitext,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    RasterizationOrderAttachmentStencilAccessBitarm =
        RasterizationOrderAttachmentStencilAccessBitext,
}

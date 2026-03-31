// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassDescriptionFlagBits")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkSubpassDescriptionFlags : uint
{
    [NativeName("VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionPerViewAttributesBitNVX = 0x00000001,

    [NativeName("VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX")]
    [NameAffix("Suffix", "KhronosVendor", "NVX")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NVX_multiview_per_view_attributes"],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionPerViewPositionXOnlyBitNVX = 0x00000002,

    [NativeName("VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_shader_resolve"])]
    VkSubpassDescriptionFragmentRegionBitQCOM = 0x00000004,

    [NativeName("VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_shader_resolve"])]
    VkSubpassDescriptionShaderResolveBitQCOM = 0x00000008,

    [NativeName("VK_SUBPASS_DESCRIPTION_TILE_SHADING_APRON_BIT_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    VkSubpassDescriptionTileShadingApronBitQCOM = 0x00000100,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionRasterizationOrderAttachmentColorAccessBitEXT = 0x00000010,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionRasterizationOrderAttachmentDepthAccessBitEXT = 0x00000020,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_EXT_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_EXT_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionRasterizationOrderAttachmentStencilAccessBitEXT = 0x00000040,

    [NativeName("VK_SUBPASS_DESCRIPTION_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_legacy_dithering"],
        ImpliesSets = [
            "VK_EXT_legacy_dithering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_legacy_dithering+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionEnableLegacyDitheringBitEXT = 0x00000080,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionRasterizationOrderAttachmentColorAccessBitARM =
        VkSubpassDescriptionRasterizationOrderAttachmentColorAccessBitEXT,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionRasterizationOrderAttachmentDepthAccessBitARM =
        VkSubpassDescriptionRasterizationOrderAttachmentDepthAccessBitEXT,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_rasterization_order_attachment_access"],
        ImpliesSets = [
            "VK_ARM_rasterization_order_attachment_access+VK_KHR_get_physical_device_properties2",
            "VK_ARM_rasterization_order_attachment_access+VK_VERSION_1_1",
        ]
    )]
    VkSubpassDescriptionRasterizationOrderAttachmentStencilAccessBitARM =
        VkSubpassDescriptionRasterizationOrderAttachmentStencilAccessBitEXT,

    [NativeName("VK_SUBPASS_DESCRIPTION_FLAG_BITS_MAX_ENUM")]
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
    VkSubpassDescriptionFlagBitsMaxEnum = 0x7FFFFFFF,
}

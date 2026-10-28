// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassDescriptionFlags")]
[Flags]
public enum SubpassDescriptionFlags : uint
{
    None = 0x0,

    [NativeName("VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX")]
    PerViewAttributesBitNVX = 0x1,

    [NativeName("VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX")]
    PerViewPositionXOnlyBitNVX = 0x2,

    [NativeName("VK_SUBPASS_DESCRIPTION_TILE_SHADING_APRON_BIT_QCOM")]
    TileShadingApronBitQCOM = 0x100,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT")]
    RasterizationOrderAttachmentColorAccessBitEXT = 0x10,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT")]
    RasterizationOrderAttachmentDepthAccessBitEXT = 0x20,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT")]
    RasterizationOrderAttachmentStencilAccessBitEXT = 0x40,

    [NativeName("VK_SUBPASS_DESCRIPTION_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    EnableLegacyDitheringBitEXT = 0x80,

    [NativeName("VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_EXT")]
    FragmentRegionBitEXT = 0x4,

    [NativeName("VK_SUBPASS_DESCRIPTION_CUSTOM_RESOLVE_BIT_EXT")]
    CustomResolveBitEXT = 0x8,

    [NativeName("VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM")]
    FragmentRegionBitQCOM = FragmentRegionBitEXT,

    [NativeName("VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM")]
    ShaderResolveBitQCOM = CustomResolveBitEXT,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM")]
    RasterizationOrderAttachmentColorAccessBitARM = RasterizationOrderAttachmentColorAccessBitEXT,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
    RasterizationOrderAttachmentDepthAccessBitARM = RasterizationOrderAttachmentDepthAccessBitEXT,

    [NativeName("VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
    RasterizationOrderAttachmentStencilAccessBitARM =
        RasterizationOrderAttachmentStencilAccessBitEXT,
}

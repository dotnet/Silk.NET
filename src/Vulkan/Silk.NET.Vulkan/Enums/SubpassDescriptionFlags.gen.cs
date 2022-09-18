// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSubpassDescriptionFlags")]
    public enum SubpassDescriptionFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PerViewAttributesBitNvx\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX")]
        SubpassDescriptionPerViewAttributesBitNvx = 1,
        [Obsolete("Deprecated in favour of \"PerViewPositionXOnlyBitNvx\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX")]
        SubpassDescriptionPerViewPositionXOnlyBitNvx = 2,
        [Obsolete("Deprecated in favour of \"FragmentRegionBitQCom\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM")]
        SubpassDescriptionFragmentRegionBitQCom = 4,
        [Obsolete("Deprecated in favour of \"ShaderResolveBitQCom\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM")]
        SubpassDescriptionShaderResolveBitQCom = 8,
        [Obsolete("Deprecated in favour of \"RasterizationOrderAttachmentColorAccessBitArm\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM")]
        SubpassDescriptionRasterizationOrderAttachmentColorAccessBitArm = 16,
        [Obsolete("Deprecated in favour of \"RasterizationOrderAttachmentDepthAccessBitArm\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
        SubpassDescriptionRasterizationOrderAttachmentDepthAccessBitArm = 32,
        [Obsolete("Deprecated in favour of \"RasterizationOrderAttachmentStencilAccessBitArm\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
        SubpassDescriptionRasterizationOrderAttachmentStencilAccessBitArm = 64,
        [Obsolete("Deprecated in favour of \"Reserved7BitExt\"")]
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RESERVED_7_BIT_EXT")]
        SubpassDescriptionReserved7BitExt = 128,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX")]
        PerViewAttributesBitNvx = 1,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX")]
        PerViewPositionXOnlyBitNvx = 2,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM")]
        FragmentRegionBitQCom = 4,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM")]
        ShaderResolveBitQCom = 8,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM")]
        RasterizationOrderAttachmentColorAccessBitArm = 16,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
        RasterizationOrderAttachmentDepthAccessBitArm = 32,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
        RasterizationOrderAttachmentStencilAccessBitArm = 64,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RESERVED_7_BIT_EXT")]
        Reserved7BitExt = 128,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSubpassDescriptionFlags")]
    public enum SubpassDescriptionFlags : int
    {
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX")]
        SubpassDescriptionPerViewAttributesBitNvx = 1,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX")]
        SubpassDescriptionPerViewPositionXOnlyBitNvx = 2,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM")]
        SubpassDescriptionFragmentRegionBitQCom = 4,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM")]
        SubpassDescriptionShaderResolveBitQCom = 8,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_ARM")]
        SubpassDescriptionRasterizationOrderAttachmentColorAccessBitArm = 16,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
        SubpassDescriptionRasterizationOrderAttachmentDepthAccessBitArm = 32,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
        SubpassDescriptionRasterizationOrderAttachmentStencilAccessBitArm = 64,
    }
}

// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSubpassDescriptionFlags")]
    public enum SubpassDescriptionFlags
    {
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX")]
        SubpassDescriptionPerViewAttributesBitNvx = 1,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX")]
        SubpassDescriptionPerViewPositionXOnlyBitNvx = 2,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM")]
        SubpassDescriptionFragmentRegionBitQCom = 4,
        [NativeName("Name", "VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM")]
        SubpassDescriptionShaderResolveBitQCom = 8,
    }
}

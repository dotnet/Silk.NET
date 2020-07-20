// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBlendFactor")]
    public enum BlendFactor
    {
        [NativeName("Name", "VK_BLEND_FACTOR_ZERO")]
        Zero = 0,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE")]
        One = 1,
        [NativeName("Name", "VK_BLEND_FACTOR_SRC_COLOR")]
        SrcColor = 2,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR")]
        OneMinusSrcColor = 3,
        [NativeName("Name", "VK_BLEND_FACTOR_DST_COLOR")]
        DstColor = 4,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR")]
        OneMinusDstColor = 5,
        [NativeName("Name", "VK_BLEND_FACTOR_SRC_ALPHA")]
        SrcAlpha = 6,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA")]
        OneMinusSrcAlpha = 7,
        [NativeName("Name", "VK_BLEND_FACTOR_DST_ALPHA")]
        DstAlpha = 8,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA")]
        OneMinusDstAlpha = 9,
        [NativeName("Name", "VK_BLEND_FACTOR_CONSTANT_COLOR")]
        ConstantColor = 10,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR")]
        OneMinusConstantColor = 11,
        [NativeName("Name", "VK_BLEND_FACTOR_CONSTANT_ALPHA")]
        ConstantAlpha = 12,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA")]
        OneMinusConstantAlpha = 13,
        [NativeName("Name", "VK_BLEND_FACTOR_SRC_ALPHA_SATURATE")]
        SrcAlphaSaturate = 14,
        [NativeName("Name", "VK_BLEND_FACTOR_SRC1_COLOR")]
        Src1Color = 15,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR")]
        OneMinusSrc1Color = 16,
        [NativeName("Name", "VK_BLEND_FACTOR_SRC1_ALPHA")]
        Src1Alpha = 17,
        [NativeName("Name", "VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA")]
        OneMinusSrc1Alpha = 18,
    }
}

// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFragmentShadingRateCombinerOpKHR")]
    public enum FragmentShadingRateCombinerOpKHR : int
    {
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR")]
        FragmentShadingRateCombinerOpKeepKhr = 0,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR")]
        FragmentShadingRateCombinerOpReplaceKhr = 1,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR")]
        FragmentShadingRateCombinerOpMinKhr = 2,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR")]
        FragmentShadingRateCombinerOpMaxKhr = 3,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR")]
        FragmentShadingRateCombinerOpMulKhr = 4,
    }
}

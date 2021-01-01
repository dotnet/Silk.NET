// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBlendOverlapEXT")]
    public enum BlendOverlapEXT : int
    {
        [NativeName("Name", "VK_BLEND_OVERLAP_UNCORRELATED_EXT")]
        BlendOverlapUncorrelatedExt = 0,
        [NativeName("Name", "VK_BLEND_OVERLAP_DISJOINT_EXT")]
        BlendOverlapDisjointExt = 1,
        [NativeName("Name", "VK_BLEND_OVERLAP_CONJOINT_EXT")]
        BlendOverlapConjointExt = 2,
    }
}

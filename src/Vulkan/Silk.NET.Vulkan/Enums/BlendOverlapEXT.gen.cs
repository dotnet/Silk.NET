// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

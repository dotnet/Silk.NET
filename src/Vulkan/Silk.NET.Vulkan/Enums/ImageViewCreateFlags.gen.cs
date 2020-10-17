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
    [NativeName("Name", "VkImageViewCreateFlags")]
    public enum ImageViewCreateFlags
    {
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT")]
        ImageViewCreateFragmentDensityMapDynamicBitExt = 1,
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT")]
        ImageViewCreateFragmentDensityMapDeferredBitExt = 2,
    }
}

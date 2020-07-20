// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageTiling")]
    public enum ImageTiling
    {
        [NativeName("Name", "VK_IMAGE_TILING_OPTIMAL")]
        Optimal = 0,
        [NativeName("Name", "VK_IMAGE_TILING_LINEAR")]
        Linear = 1,
        [NativeName("Name", "VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT")]
        DrmFormatModifierExt = 1000158000,
    }
}

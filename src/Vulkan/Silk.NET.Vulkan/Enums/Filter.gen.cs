// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFilter")]
    public enum Filter
    {
        [NativeName("Name", "VK_FILTER_NEAREST")]
        Nearest = 0,
        [NativeName("Name", "VK_FILTER_LINEAR")]
        Linear = 1,
        [NativeName("Name", "VK_FILTER_CUBIC_IMG")]
        CubicImg = 1000015000,
        [NativeName("Name", "VK_FILTER_CUBIC_EXT")]
        CubicExt = 1000170000,
    }
}

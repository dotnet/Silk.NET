// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBorderColor")]
    public enum BorderColor : int
    {
        [NativeName("Name", "VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK")]
        FloatTransparentBlack = 0,
        [NativeName("Name", "VK_BORDER_COLOR_INT_TRANSPARENT_BLACK")]
        IntTransparentBlack = 1,
        [NativeName("Name", "VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK")]
        FloatOpaqueBlack = 2,
        [NativeName("Name", "VK_BORDER_COLOR_INT_OPAQUE_BLACK")]
        IntOpaqueBlack = 3,
        [NativeName("Name", "VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE")]
        FloatOpaqueWhite = 4,
        [NativeName("Name", "VK_BORDER_COLOR_INT_OPAQUE_WHITE")]
        IntOpaqueWhite = 5,
        [NativeName("Name", "VK_BORDER_COLOR_FLOAT_CUSTOM_EXT")]
        FloatCustomExt = 1000287003,
        [NativeName("Name", "VK_BORDER_COLOR_INT_CUSTOM_EXT")]
        IntCustomExt = 1000287004,
    }
}

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
    [NativeName("Name", "VkDisplayPlaneAlphaFlagsKHR")]
    public enum DisplayPlaneAlphaFlagsKHR
    {
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR")]
        DisplayPlaneAlphaOpaqueBitKhr = 1,
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR")]
        DisplayPlaneAlphaGlobalBitKhr = 2,
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR")]
        DisplayPlaneAlphaPerPixelBitKhr = 4,
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR")]
        DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 8,
    }
}

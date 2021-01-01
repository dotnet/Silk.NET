// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplayEventTypeEXT")]
    public enum DisplayEventTypeEXT : int
    {
        [NativeName("Name", "VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT")]
        DisplayEventTypeFirstPixelOutExt = 0,
    }
}

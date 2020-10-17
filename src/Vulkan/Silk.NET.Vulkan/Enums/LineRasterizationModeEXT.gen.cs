// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLineRasterizationModeEXT")]
    public enum LineRasterizationModeEXT
    {
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT")]
        LineRasterizationModeDefaultExt = 0,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT")]
        LineRasterizationModeRectangularExt = 1,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT")]
        LineRasterizationModeBresenhamExt = 2,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT")]
        LineRasterizationModeRectangularSmoothExt = 3,
    }
}

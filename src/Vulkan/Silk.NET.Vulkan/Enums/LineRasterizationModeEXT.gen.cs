// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLineRasterizationModeEXT")]
    public enum LineRasterizationModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_DEFAULT")]
        LineRasterizationModeDefault = 0,
        [Obsolete("Deprecated in favour of \"Rectangular\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR")]
        LineRasterizationModeRectangular = 1,
        [Obsolete("Deprecated in favour of \"Bresenham\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_BRESENHAM")]
        LineRasterizationModeBresenham = 2,
        [Obsolete("Deprecated in favour of \"RectangularSmooth\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH")]
        LineRasterizationModeRectangularSmooth = 3,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_DEFAULT")]
        Default = 0,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR")]
        Rectangular = 1,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_BRESENHAM")]
        Bresenham = 2,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH")]
        RectangularSmooth = 3,
    }
}

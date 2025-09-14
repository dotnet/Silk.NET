// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLineRasterizationMode")]
    public enum LineRasterizationMode : int
    {
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

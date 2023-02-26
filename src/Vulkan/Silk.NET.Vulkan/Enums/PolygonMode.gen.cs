// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPolygonMode")]
    public enum PolygonMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_POLYGON_MODE_FILL")]
        Fill = 0,
        [NativeName("Name", "VK_POLYGON_MODE_LINE")]
        Line = 1,
        [NativeName("Name", "VK_POLYGON_MODE_POINT")]
        Point = 2,
        [NativeName("Name", "VK_POLYGON_MODE_FILL_RECTANGLE_NV")]
        FillRectangleNV = 1000153000,
    }
}

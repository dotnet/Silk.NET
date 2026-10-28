// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLineRasterizationMode")]
public enum LineRasterizationMode : uint
{
    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT")]
    Default = 0,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR")]
    Rectangular = 1,

    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM")]
    Bresenham = 2,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH")]
    RectangularSmooth = 3,

    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT")]
    DefaultEXT = Default,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT")]
    RectangularEXT = Rectangular,

    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT")]
    BresenhamEXT = Bresenham,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT")]
    RectangularSmoothEXT = RectangularSmooth,

    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR")]
    DefaultKHR = Default,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR")]
    RectangularKHR = Rectangular,

    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR")]
    BresenhamKHR = Bresenham,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR")]
    RectangularSmoothKHR = RectangularSmooth,
}

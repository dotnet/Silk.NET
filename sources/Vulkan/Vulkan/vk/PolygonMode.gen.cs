// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPolygonMode")]
public enum PolygonMode : uint
{
    [NativeName("VK_POLYGON_MODE_FILL")]
    Fill = 0,

    [NativeName("VK_POLYGON_MODE_LINE")]
    Line = 1,

    [NativeName("VK_POLYGON_MODE_POINT")]
    Point = 2,

    [NativeName("VK_POLYGON_MODE_FILL_RECTANGLE_NV")]
    FillRectangleNV = 1000153000,
}

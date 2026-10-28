// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkViewportCoordinateSwizzleNV")]
public enum ViewportCoordinateSwizzleNV : uint
{
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV")]
    PositiveX = 0,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV")]
    NegativeX = 1,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV")]
    PositiveY = 2,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV")]
    NegativeY = 3,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV")]
    PositiveZ = 4,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV")]
    NegativeZ = 5,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV")]
    PositiveW = 6,

    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV")]
    NegativeW = 7,
}

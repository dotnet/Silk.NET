// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkViewportCoordinateSwizzleNV")]
    public enum ViewportCoordinateSwizzleNV : int
    {
        [Obsolete("Deprecated in favour of \"PositiveXNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV")]
        ViewportCoordinateSwizzlePositiveXNV = 0,
        [Obsolete("Deprecated in favour of \"NegativeXNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV")]
        ViewportCoordinateSwizzleNegativeXNV = 1,
        [Obsolete("Deprecated in favour of \"PositiveYNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV")]
        ViewportCoordinateSwizzlePositiveYNV = 2,
        [Obsolete("Deprecated in favour of \"NegativeYNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV")]
        ViewportCoordinateSwizzleNegativeYNV = 3,
        [Obsolete("Deprecated in favour of \"PositiveZNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV")]
        ViewportCoordinateSwizzlePositiveZNV = 4,
        [Obsolete("Deprecated in favour of \"NegativeZNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV")]
        ViewportCoordinateSwizzleNegativeZNV = 5,
        [Obsolete("Deprecated in favour of \"PositiveWNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV")]
        ViewportCoordinateSwizzlePositiveWNV = 6,
        [Obsolete("Deprecated in favour of \"NegativeWNV\"")]
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV")]
        ViewportCoordinateSwizzleNegativeWNV = 7,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV")]
        PositiveXNV = 0,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV")]
        NegativeXNV = 1,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV")]
        PositiveYNV = 2,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV")]
        NegativeYNV = 3,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV")]
        PositiveZNV = 4,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV")]
        NegativeZNV = 5,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV")]
        PositiveWNV = 6,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV")]
        NegativeWNV = 7,
    }
}

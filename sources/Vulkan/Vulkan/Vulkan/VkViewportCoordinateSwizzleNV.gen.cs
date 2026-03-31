// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkViewportCoordinateSwizzleNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkViewportCoordinateSwizzleNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzlePositiveX = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzleNegativeX = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzlePositiveY = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzleNegativeY = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzlePositiveZ = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzleNegativeZ = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzlePositiveW = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzleNegativeW = 7,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_VIEWPORT_COORDINATE_SWIZZLE_MAX_ENUM_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    VkViewportCoordinateSwizzleMaxEnum = 0x7FFFFFFF,
}

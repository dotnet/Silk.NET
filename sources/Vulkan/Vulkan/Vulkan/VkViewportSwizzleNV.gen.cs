// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkViewportSwizzleNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public partial struct VkViewportSwizzleNV
{
    [NativeName("x")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV X;

    [NativeName("y")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV Y;

    [NativeName("z")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV Z;

    [NativeName("w")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportCoordinateSwizzleNV W;
}

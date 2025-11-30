// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkViewportSwizzleNV")]
[SupportedApiProfile("vulkan")]
public partial struct ViewportSwizzleNv
{
    [NativeName("x")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNv X;

    [NativeName("y")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNv Y;

    [NativeName("z")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNv Z;

    [NativeName("w")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNv W;
}

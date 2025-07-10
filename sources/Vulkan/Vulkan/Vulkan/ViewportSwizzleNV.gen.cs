// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct ViewportSwizzleNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNV X;

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNV Y;

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNV Z;

    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public ViewportCoordinateSwizzleNV W;
}

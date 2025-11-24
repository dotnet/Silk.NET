// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum SurfaceTransformFlagsKHR
{
    None = 0,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    IdentityBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    Rotate90BitKHR = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    Rotate180BitKHR = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    Rotate270BitKHR = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    HorizontalMirrorBitKHR = 0x00000010,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    HorizontalMirrorRotate90BitKHR = 0x00000020,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    HorizontalMirrorRotate180BitKHR = 0x00000040,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    HorizontalMirrorRotate270BitKHR = 0x00000080,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    InheritBitKHR = 0x00000100,
}

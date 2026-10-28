// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSurfaceTransformFlagsKHR")]
[Flags]
public enum SurfaceTransformFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR")]
    IdentityBit = 0x1,

    [NativeName("VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR")]
    Rotate90Bit = 0x2,

    [NativeName("VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR")]
    Rotate180Bit = 0x4,

    [NativeName("VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR")]
    Rotate270Bit = 0x8,

    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR")]
    HorizontalMirrorBit = 0x10,

    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR")]
    HorizontalMirrorRotate90Bit = 0x20,

    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR")]
    HorizontalMirrorRotate180Bit = 0x40,

    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR")]
    HorizontalMirrorRotate270Bit = 0x80,

    [NativeName("VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR")]
    InheritBit = 0x100,
}

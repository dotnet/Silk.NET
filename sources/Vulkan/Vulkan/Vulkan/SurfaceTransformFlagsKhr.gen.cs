// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkSurfaceTransformFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum SurfaceTransformFlagsKhr : uint
{
    None = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    IdentityBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    Rotate90Bitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    Rotate180Bitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    Rotate270Bitkhr = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    HorizontalMirrorBitkhr = 0x10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    HorizontalMirrorRotate90Bitkhr = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    HorizontalMirrorRotate180Bitkhr = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    HorizontalMirrorRotate270Bitkhr = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    InheritBitkhr = 0x100,
}

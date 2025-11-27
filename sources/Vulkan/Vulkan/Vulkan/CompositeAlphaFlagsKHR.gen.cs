// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCompositeAlphaFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum CompositeAlphaFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    OpaqueBitKHR = 0x1,

    [NativeName("VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    PreMultipliedBitKHR = 0x2,

    [NativeName("VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    PostMultipliedBitKHR = 0x4,

    [NativeName("VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    InheritBitKHR = 0x8,
}

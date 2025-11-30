// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkCompositeAlphaFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum CompositeAlphaFlagsKhr : uint
{
    None = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    OpaqueBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    PreMultipliedBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    PostMultipliedBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    InheritBitkhr = 0x8,
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkCompositeAlphaFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkCompositeAlphaFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkCompositeAlphaOpaqueBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkCompositeAlphaPreMultipliedBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkCompositeAlphaPostMultipliedBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkCompositeAlphaInheritBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPOSITE_ALPHA_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkCompositeAlphaFlagBitsMaxEnum = 0x7FFFFFFF,
}

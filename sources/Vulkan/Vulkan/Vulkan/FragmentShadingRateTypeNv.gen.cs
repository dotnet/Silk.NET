// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkFragmentShadingRateTypeNV")]
[SupportedApiProfile("vulkan")]
public enum FragmentShadingRateTypeNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    FragmentSizenv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Enumsnv = 1,
}

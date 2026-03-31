// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkFragmentShadingRateTypeNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkFragmentShadingRateTypeNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRateTypeFragmentSize = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRateTypeEnums = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_TYPE_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRateTypeMaxEnum = 0x7FFFFFFF,
}

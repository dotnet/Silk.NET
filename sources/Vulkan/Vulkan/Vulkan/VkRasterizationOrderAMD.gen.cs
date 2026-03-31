// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "AMD")]
[NativeName("VkRasterizationOrderAMD")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkRasterizationOrderAMD : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_RASTERIZATION_ORDER_STRICT_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    VkRasterizationOrderStrict = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_RASTERIZATION_ORDER_RELAXED_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    VkRasterizationOrderRelaxed = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_RASTERIZATION_ORDER_MAX_ENUM_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_rasterization_order"])]
    VkRasterizationOrderMaxEnum = 0x7FFFFFFF,
}

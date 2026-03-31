// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "ARM")]
[NativeName("VkTensorTilingARM")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkTensorTilingARM : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_TILING_OPTIMAL_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkTensorTilingOptimal = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_TILING_LINEAR_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkTensorTilingLinear = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_TILING_MAX_ENUM_ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkTensorTilingMaxEnum = 0x7FFFFFFF,
}

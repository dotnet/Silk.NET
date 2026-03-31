// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "ARM")]
[NativeName("VkTensorUsageFlagsARM")]
[Transformed]
[Flags]
public enum VkTensorUsageFlagsARM : ulong
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_USAGE_SHADER_BIT_ARM")]
    VkTensorUsageShaderBit = unchecked((ulong)0x00000002UL),

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_USAGE_TRANSFER_SRC_BIT_ARM")]
    VkTensorUsageTransferSrcBit = unchecked((ulong)0x00000004UL),

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_USAGE_TRANSFER_DST_BIT_ARM")]
    VkTensorUsageTransferDstBit = unchecked((ulong)0x00000008UL),

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_USAGE_IMAGE_ALIASING_BIT_ARM")]
    VkTensorUsageImageAliasingBit = unchecked((ulong)0x00000010UL),

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_USAGE_DATA_GRAPH_BIT_ARM")]
    VkTensorUsageDataGraphBit = unchecked((ulong)0x00000020UL),
}

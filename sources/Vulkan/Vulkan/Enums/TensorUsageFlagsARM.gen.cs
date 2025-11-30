// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "ARM", 0)]
[NativeName("VkTensorUsageFlagsARM")]
[Flags]
public enum TensorUsageFlagsARM : ulong
{
    None = 0x0,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_SHADER_BIT_ARM")]
    ShaderBitarm = 0x2,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_TRANSFER_SRC_BIT_ARM")]
    TransferSrcBitarm = 0x4,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_TRANSFER_DST_BIT_ARM")]
    TransferDstBitarm = 0x8,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_IMAGE_ALIASING_BIT_ARM")]
    ImageAliasingBitarm = 0x10,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_DATA_GRAPH_BIT_ARM")]
    DataGraphBitarm = 0x20,
}

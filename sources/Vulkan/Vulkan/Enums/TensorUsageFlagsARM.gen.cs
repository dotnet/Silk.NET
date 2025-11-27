// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("ARM", 0)]
[NativeName("VkTensorUsageFlagsARM")]
[Flags]
public enum TensorUsageFlagsARM : ulong
{
    None = 0x0,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_SHADER_BIT_ARM")]
    ShaderBitARM = 0x2,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_TRANSFER_SRC_BIT_ARM")]
    TransferSrcBitARM = 0x4,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_TRANSFER_DST_BIT_ARM")]
    TransferDstBitARM = 0x8,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_IMAGE_ALIASING_BIT_ARM")]
    ImageAliasingBitARM = 0x10,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_TENSOR_USAGE_DATA_GRAPH_BIT_ARM")]
    DataGraphBitARM = 0x20,
}

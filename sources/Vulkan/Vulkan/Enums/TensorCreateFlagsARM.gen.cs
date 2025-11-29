// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "ARM", 0)]
[NativeName("VkTensorCreateFlagsARM")]
[Flags]
public enum TensorCreateFlagsARM : ulong
{
    None = 0x0,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_CREATE_MUTABLE_FORMAT_BIT_ARM")]
    MutableFormatBitARM = 0x1,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_CREATE_PROTECTED_BIT_ARM")]
    ProtectedBitARM = 0x2,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_TENSOR_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM")]
    DescriptorBufferCaptureReplayBitARM = 0x4,
}

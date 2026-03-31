// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "ARM")]
[NativeName("VkTensorCreateFlagsARM")]
[Transformed]
[Flags]
public enum VkTensorCreateFlagsARM : ulong
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_CREATE_MUTABLE_FORMAT_BIT_ARM")]
    VkTensorCreateMutableFormatBit = unchecked((ulong)0x00000001UL),

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_CREATE_PROTECTED_BIT_ARM")]
    VkTensorCreateProtectedBit = unchecked((ulong)0x00000002UL),

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_TENSOR_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM")]
    VkTensorCreateDescriptorBufferCaptureReplayBit = unchecked((ulong)0x00000004UL),
}

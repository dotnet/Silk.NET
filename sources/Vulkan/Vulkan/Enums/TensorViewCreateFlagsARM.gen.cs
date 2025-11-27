// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTensorViewCreateFlagBitsARM")]
[Flags]
public enum TensorViewCreateFlagsARM : ulong
{
    None = 0x0,

    [NativeName("VK_TENSOR_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM")]
    DescriptorBufferCaptureReplayBitARM = 0x1,
}

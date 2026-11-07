// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueFlags")]
[Flags]
public enum QueueFlags : uint
{
    None = 0x0,

    [NativeName("VK_QUEUE_GRAPHICS_BIT")]
    GraphicsBit = 0x1,

    [NativeName("VK_QUEUE_COMPUTE_BIT")]
    ComputeBit = 0x2,

    [NativeName("VK_QUEUE_TRANSFER_BIT")]
    TransferBit = 0x4,

    [NativeName("VK_QUEUE_SPARSE_BINDING_BIT")]
    SparseBindingBit = 0x8,

    [NativeName("VK_QUEUE_PROTECTED_BIT")]
    ProtectedBit = 0x10,

    [NativeName("VK_QUEUE_VIDEO_DECODE_BIT_KHR")]
    VideoDecodeBitKHR = 0x20,

    [NativeName("VK_QUEUE_VIDEO_ENCODE_BIT_KHR")]
    VideoEncodeBitKHR = 0x40,

    [NativeName("VK_QUEUE_OPTICAL_FLOW_BIT_NV")]
    OpticalFlowBitNV = 0x100,

    [NativeName("VK_QUEUE_DATA_GRAPH_BIT_ARM")]
    DataGraphBitARM = 0x400,
}

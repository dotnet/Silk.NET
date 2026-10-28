// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPeerMemoryFeatureFlags")]
[Flags]
public enum PeerMemoryFeatureFlags : uint
{
    None = 0x0,

    [NativeName("VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT")]
    CopySrcBit = 0x1,

    [NativeName("VK_PEER_MEMORY_FEATURE_COPY_DST_BIT")]
    CopyDstBit = 0x2,

    [NativeName("VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT")]
    GenericSrcBit = 0x4,

    [NativeName("VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT")]
    GenericDstBit = 0x8,

    [NativeName("VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT_KHR")]
    CopySrcBitKHR = CopySrcBit,

    [NativeName("VK_PEER_MEMORY_FEATURE_COPY_DST_BIT_KHR")]
    CopyDstBitKHR = CopyDstBit,

    [NativeName("VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT_KHR")]
    GenericSrcBitKHR = GenericSrcBit,

    [NativeName("VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT_KHR")]
    GenericDstBitKHR = GenericDstBit,
}

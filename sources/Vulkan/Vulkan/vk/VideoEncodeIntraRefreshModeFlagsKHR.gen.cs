// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeIntraRefreshModeFlagsKHR")]
[Flags]
public enum VideoEncodeIntraRefreshModeFlagsKHR : uint
{
    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_NONE_KHR")]
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_PER_PICTURE_PARTITION_BIT_KHR")]
    PerPicturePartitionBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_BASED_BIT_KHR")]
    BlockBasedBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_ROW_BASED_BIT_KHR")]
    BlockRowBasedBit = 0x4,

    [NativeName("VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_COLUMN_BASED_BIT_KHR")]
    BlockColumnBasedBit = 0x8,
}

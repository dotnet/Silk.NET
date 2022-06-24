// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265TransformBlockSizeFlagsEXT")]
    public enum VideoEncodeH265TransformBlockSizeFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Size4BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_EXT")]
        VideoEncodeH265TransformBlockSize4BitExt = 1,
        [Obsolete("Deprecated in favour of \"Size8BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_EXT")]
        VideoEncodeH265TransformBlockSize8BitExt = 2,
        [Obsolete("Deprecated in favour of \"Size16BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_EXT")]
        VideoEncodeH265TransformBlockSize16BitExt = 4,
        [Obsolete("Deprecated in favour of \"Size32BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_EXT")]
        VideoEncodeH265TransformBlockSize32BitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_EXT")]
        Size4BitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_EXT")]
        Size8BitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_EXT")]
        Size16BitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_EXT")]
        Size32BitExt = 8,
    }
}

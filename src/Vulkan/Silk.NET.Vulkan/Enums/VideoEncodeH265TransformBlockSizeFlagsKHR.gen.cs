// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265TransformBlockSizeFlagsKHR")]
    public enum VideoEncodeH265TransformBlockSizeFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Size4BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_KHR")]
        VideoEncodeH265TransformBlockSize4BitKhr = 1,
        [Obsolete("Deprecated in favour of \"Size8BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_KHR")]
        VideoEncodeH265TransformBlockSize8BitKhr = 2,
        [Obsolete("Deprecated in favour of \"Size16BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_KHR")]
        VideoEncodeH265TransformBlockSize16BitKhr = 4,
        [Obsolete("Deprecated in favour of \"Size32BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_KHR")]
        VideoEncodeH265TransformBlockSize32BitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_KHR")]
        Size4BitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_KHR")]
        Size8BitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_KHR")]
        Size16BitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_KHR")]
        Size32BitKhr = 8,
    }
}

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
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_EXT")]
        VideoEncodeH265TransformBlockSize4BitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_EXT")]
        VideoEncodeH265TransformBlockSize8BitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_EXT")]
        VideoEncodeH265TransformBlockSize16BitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_EXT")]
        VideoEncodeH265TransformBlockSize32BitExt = 8,
    }
}

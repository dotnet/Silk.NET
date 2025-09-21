// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeIntraRefreshModeFlagsKHR")]
    public enum VideoEncodeIntraRefreshModeFlagsKHR : int
    {
        [Obsolete("Deprecated in favour of \"NoneKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_NONE_KHR")]
        VideoEncodeIntraRefreshModeNoneKhr = 0,
        [Obsolete("Deprecated in favour of \"PerPicturePartitionBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_PER_PICTURE_PARTITION_BIT_KHR")]
        VideoEncodeIntraRefreshModePerPicturePartitionBitKhr = 1,
        [Obsolete("Deprecated in favour of \"BlockBasedBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_BASED_BIT_KHR")]
        VideoEncodeIntraRefreshModeBlockBasedBitKhr = 2,
        [Obsolete("Deprecated in favour of \"BlockRowBasedBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_ROW_BASED_BIT_KHR")]
        VideoEncodeIntraRefreshModeBlockRowBasedBitKhr = 4,
        [Obsolete("Deprecated in favour of \"BlockColumnBasedBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_COLUMN_BASED_BIT_KHR")]
        VideoEncodeIntraRefreshModeBlockColumnBasedBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_NONE_KHR")]
        NoneKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_PER_PICTURE_PARTITION_BIT_KHR")]
        PerPicturePartitionBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_BASED_BIT_KHR")]
        BlockBasedBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_ROW_BASED_BIT_KHR")]
        BlockRowBasedBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_BLOCK_COLUMN_BASED_BIT_KHR")]
        BlockColumnBasedBitKhr = 8,
    }
}

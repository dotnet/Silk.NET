// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
    public enum VideoEncodeAV1SuperblockSizeFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Size64BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_64_BIT_KHR")]
        VideoEncodeAV1SuperblockSize64BitKhr = 1,
        [Obsolete("Deprecated in favour of \"Size128BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_128_BIT_KHR")]
        VideoEncodeAV1SuperblockSize128BitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_64_BIT_KHR")]
        Size64BitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_128_BIT_KHR")]
        Size128BitKhr = 2,
    }
}

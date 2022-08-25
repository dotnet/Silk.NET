// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265CtbSizeFlagsEXT")]
    public enum VideoEncodeH265CtbSizeFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Size16BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_EXT")]
        VideoEncodeH265CtbSize16BitExt = 1,
        [Obsolete("Deprecated in favour of \"Size32BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_EXT")]
        VideoEncodeH265CtbSize32BitExt = 2,
        [Obsolete("Deprecated in favour of \"Size64BitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_EXT")]
        VideoEncodeH265CtbSize64BitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_EXT")]
        Size16BitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_EXT")]
        Size32BitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_EXT")]
        Size64BitExt = 4,
    }
}

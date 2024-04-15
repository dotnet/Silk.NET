// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265CtbSizeFlagsKHR")]
    public enum VideoEncodeH265CtbSizeFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Size16BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_KHR")]
        VideoEncodeH265CtbSize16BitKhr = 1,
        [Obsolete("Deprecated in favour of \"Size32BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_KHR")]
        VideoEncodeH265CtbSize32BitKhr = 2,
        [Obsolete("Deprecated in favour of \"Size64BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_KHR")]
        VideoEncodeH265CtbSize64BitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_KHR")]
        Size16BitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_KHR")]
        Size32BitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_KHR")]
        Size64BitKhr = 4,
    }
}

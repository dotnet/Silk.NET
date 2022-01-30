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
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_8_BIT_EXT")]
        VideoEncodeH265CtbSize8BitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_EXT")]
        VideoEncodeH265CtbSize16BitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_EXT")]
        VideoEncodeH265CtbSize32BitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_EXT")]
        VideoEncodeH265CtbSize64BitExt = 8,
    }
}

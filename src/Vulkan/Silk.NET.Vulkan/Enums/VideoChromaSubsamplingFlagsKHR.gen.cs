// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoChromaSubsamplingFlagsKHR")]
    public enum VideoChromaSubsamplingFlagsKHR : int
    {
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_BIT_KHR")]
        VideoChromaSubsamplingInvalidBitKhr = 0,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR")]
        VideoChromaSubsamplingMonochromeBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR")]
        VideoChromaSubsampling420BitKhr = 2,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR")]
        VideoChromaSubsampling422BitKhr = 4,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR")]
        VideoChromaSubsampling444BitKhr = 8,
    }
}

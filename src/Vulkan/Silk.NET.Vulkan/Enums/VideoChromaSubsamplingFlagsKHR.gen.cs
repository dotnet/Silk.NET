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
        [Obsolete("Deprecated in favour of \"SubsamplingInvalidKhr\"")]
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR")]
        VideoChromaSubsamplingInvalidKhr = 0,
        [Obsolete("Deprecated in favour of \"SubsamplingMonochromeBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR")]
        VideoChromaSubsamplingMonochromeBitKhr = 1,
        [Obsolete("Deprecated in favour of \"Subsampling420BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR")]
        VideoChromaSubsampling420BitKhr = 2,
        [Obsolete("Deprecated in favour of \"Subsampling422BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR")]
        VideoChromaSubsampling422BitKhr = 4,
        [Obsolete("Deprecated in favour of \"Subsampling444BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR")]
        VideoChromaSubsampling444BitKhr = 8,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR")]
        SubsamplingInvalidKhr = 0,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR")]
        SubsamplingMonochromeBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR")]
        Subsampling420BitKhr = 2,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR")]
        Subsampling422BitKhr = 4,
        [NativeName("Name", "VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR")]
        Subsampling444BitKhr = 8,
    }
}

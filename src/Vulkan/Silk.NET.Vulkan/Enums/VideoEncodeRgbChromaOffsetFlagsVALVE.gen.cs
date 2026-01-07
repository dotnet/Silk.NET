// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
    public enum VideoEncodeRgbChromaOffsetFlagsVALVE : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CositedEvenBitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_COSITED_EVEN_BIT_VALVE")]
        VideoEncodeRgbChromaOffsetCositedEvenBitValve = 1,
        [Obsolete("Deprecated in favour of \"MidpointBitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_MIDPOINT_BIT_VALVE")]
        VideoEncodeRgbChromaOffsetMidpointBitValve = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_COSITED_EVEN_BIT_VALVE")]
        CositedEvenBitValve = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_MIDPOINT_BIT_VALVE")]
        MidpointBitValve = 2,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeH264RateControlStructureEXT")]
    public enum VideoEncodeH264RateControlStructureEXT : int
    {
        [Obsolete("Deprecated in favour of \"UnknownExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_UNKNOWN_EXT")]
        VideoEncodeH264RateControlStructureUnknownExt = 0,
        [Obsolete("Deprecated in favour of \"FlatExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_FLAT_EXT")]
        VideoEncodeH264RateControlStructureFlatExt = 1,
        [Obsolete("Deprecated in favour of \"DyadicExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_DYADIC_EXT")]
        VideoEncodeH264RateControlStructureDyadicExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_UNKNOWN_EXT")]
        UnknownExt = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_FLAT_EXT")]
        FlatExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_STRUCTURE_DYADIC_EXT")]
        DyadicExt = 2,
    }
}

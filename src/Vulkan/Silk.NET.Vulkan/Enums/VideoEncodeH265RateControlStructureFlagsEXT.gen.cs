// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkVideoEncodeH265RateControlStructureFlagsEXT")]
    public enum VideoEncodeH265RateControlStructureFlagsEXT : int
    {
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_UNKNOWN_EXT")]
        VideoEncodeH265RateControlStructureUnknownExt = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_FLAT_BIT_EXT")]
        VideoEncodeH265RateControlStructureFlatBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_STRUCTURE_DYADIC_BIT_EXT")]
        VideoEncodeH265RateControlStructureDyadicBitExt = 2,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeAV1StdFlagsKHR")]
    public enum VideoEncodeAV1StdFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"UniformTileSpacingFlagSetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_UNIFORM_TILE_SPACING_FLAG_SET_BIT_KHR")]
        VideoEncodeAV1StdUniformTileSpacingFlagSetBitKhr = 1,
        [Obsolete("Deprecated in favour of \"SkipModePresentUnsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_SKIP_MODE_PRESENT_UNSET_BIT_KHR")]
        VideoEncodeAV1StdSkipModePresentUnsetBitKhr = 2,
        [Obsolete("Deprecated in favour of \"PrimaryRefFrameBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_PRIMARY_REF_FRAME_BIT_KHR")]
        VideoEncodeAV1StdPrimaryRefFrameBitKhr = 4,
        [Obsolete("Deprecated in favour of \"DeltaQBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_DELTA_Q_BIT_KHR")]
        VideoEncodeAV1StdDeltaQBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_UNIFORM_TILE_SPACING_FLAG_SET_BIT_KHR")]
        UniformTileSpacingFlagSetBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_SKIP_MODE_PRESENT_UNSET_BIT_KHR")]
        SkipModePresentUnsetBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_PRIMARY_REF_FRAME_BIT_KHR")]
        PrimaryRefFrameBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_STD_DELTA_Q_BIT_KHR")]
        DeltaQBitKhr = 8,
    }
}

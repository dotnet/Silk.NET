// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodePerPartitionFeedbackFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VideoEncodePerPartitionFeedbackFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_STATUS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PerPartitionFeedbackStatusBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PerPartitionFeedbackBitstreamBufferOffsetBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PerPartitionFeedbackBitstreamBytesWrittenBit = 0x4,
}

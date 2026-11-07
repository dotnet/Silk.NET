// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeFeedbackFlagsKHR")]
[Flags]
public enum VideoEncodeFeedbackFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR")]
    BitstreamBufferOffsetBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR")]
    BitstreamBytesWrittenBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_HAS_OVERRIDES_BIT_KHR")]
    BitstreamHasOverridesBit = 0x4,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_AVERAGE_QUANTIZATION_BIT_KHR")]
    AverageQuantizationBit = 0x8,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_MIN_QUANTIZATION_BIT_KHR")]
    MinQuantizationBit = 0x10,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_MAX_QUANTIZATION_BIT_KHR")]
    MaxQuantizationBit = 0x20,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_INTRA_PIXELS_BIT_KHR")]
    IntraPixelsBit = 0x40,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_INTER_PIXELS_BIT_KHR")]
    InterPixelsBit = 0x80,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_SKIPPED_PIXELS_BIT_KHR")]
    SkippedPixelsBit = 0x100,

    [NativeName("VK_VIDEO_ENCODE_FEEDBACK_PICTURE_PARTITION_COUNT_BIT_KHR")]
    PicturePartitionCountBit = 0x200,
}

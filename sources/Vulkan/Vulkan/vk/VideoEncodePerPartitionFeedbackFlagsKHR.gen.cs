// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodePerPartitionFeedbackFlagsKHR")]
[Flags]
public enum VideoEncodePerPartitionFeedbackFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_STATUS_BIT_KHR")]
    PerPartitionFeedbackStatusBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR")]
    PerPartitionFeedbackBitstreamBufferOffsetBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR")]
    PerPartitionFeedbackBitstreamBytesWrittenBit = 0x4,
}

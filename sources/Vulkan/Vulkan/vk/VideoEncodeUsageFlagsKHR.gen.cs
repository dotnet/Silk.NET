// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeUsageFlagsKHR")]
[Flags]
public enum VideoEncodeUsageFlagsKHR : uint
{
    [NativeName("VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR")]
    Default = 0x0,

    [NativeName("VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR")]
    TranscodingBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR")]
    StreamingBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR")]
    RecordingBit = 0x4,

    [NativeName("VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR")]
    ConferencingBit = 0x8,
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeCapabilityFlagsKHR")]
[Flags]
public enum VideoEncodeCapabilityFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_ENCODE_CAPABILITY_PRECEDING_EXTERNALLY_ENCODED_BYTES_BIT_KHR")]
    PrecedingExternallyEncodedBytesBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_CAPABILITY_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_DETECTION_BIT_KHR")]
    InsufficientBitstreamBufferRangeDetectionBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_CAPABILITY_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    QuantizationDeltaMapBit = 0x4,

    [NativeName("VK_VIDEO_ENCODE_CAPABILITY_EMPHASIS_MAP_BIT_KHR")]
    EmphasisMapBit = 0x8,
}

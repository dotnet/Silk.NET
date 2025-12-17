// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeCapabilityFlagsKHR")]
    public enum VideoEncodeCapabilityFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PrecedingExternallyEncodedBytesBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_PRECEDING_EXTERNALLY_ENCODED_BYTES_BIT_KHR")]
        VideoEncodeCapabilityPrecedingExternallyEncodedBytesBitKhr = 1,
        [Obsolete("Deprecated in favour of \"InsufficientBitstreamBufferRangeDetectionBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_DETECTION_BIT_KHR")]
        VideoEncodeCapabilityInsufficientBitstreamBufferRangeDetectionBitKhr = 2,
        [Obsolete("Deprecated in favour of \"QuantizationDeltaMapBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_QUANTIZATION_DELTA_MAP_BIT_KHR")]
        VideoEncodeCapabilityQuantizationDeltaMapBitKhr = 4,
        [Obsolete("Deprecated in favour of \"EmphasisMapBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_EMPHASIS_MAP_BIT_KHR")]
        VideoEncodeCapabilityEmphasisMapBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_PRECEDING_EXTERNALLY_ENCODED_BYTES_BIT_KHR")]
        PrecedingExternallyEncodedBytesBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_DETECTION_BIT_KHR")]
        InsufficientBitstreamBufferRangeDetectionBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_QUANTIZATION_DELTA_MAP_BIT_KHR")]
        QuantizationDeltaMapBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_CAPABILITY_EMPHASIS_MAP_BIT_KHR")]
        EmphasisMapBitKhr = 8,
    }
}

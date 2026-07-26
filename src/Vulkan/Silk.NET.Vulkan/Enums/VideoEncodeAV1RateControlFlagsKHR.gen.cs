// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeAV1RateControlFlagsKHR")]
    public enum VideoEncodeAV1RateControlFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"RegularGopBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REGULAR_GOP_BIT_KHR")]
        VideoEncodeAV1RateControlRegularGopBitKhr = 1,
        [Obsolete("Deprecated in favour of \"TemporalLayerPatternDyadicBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_KHR")]
        VideoEncodeAV1RateControlTemporalLayerPatternDyadicBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ReferencePatternFlatBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR")]
        VideoEncodeAV1RateControlReferencePatternFlatBitKhr = 4,
        [Obsolete("Deprecated in favour of \"ReferencePatternDyadicBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR")]
        VideoEncodeAV1RateControlReferencePatternDyadicBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REGULAR_GOP_BIT_KHR")]
        RegularGopBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_KHR")]
        TemporalLayerPatternDyadicBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR")]
        ReferencePatternFlatBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR")]
        ReferencePatternDyadicBitKhr = 8,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264RateControlFlagsEXT")]
    public enum VideoEncodeH264RateControlFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AttemptHrdComplianceBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXT")]
        VideoEncodeH264RateControlAttemptHrdComplianceBitExt = 1,
        [Obsolete("Deprecated in favour of \"RegularGopBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REGULAR_GOP_BIT_EXT")]
        VideoEncodeH264RateControlRegularGopBitExt = 2,
        [Obsolete("Deprecated in favour of \"ReferencePatternFlatBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXT")]
        VideoEncodeH264RateControlReferencePatternFlatBitExt = 4,
        [Obsolete("Deprecated in favour of \"ReferencePatternDyadicBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXT")]
        VideoEncodeH264RateControlReferencePatternDyadicBitExt = 8,
        [Obsolete("Deprecated in favour of \"TemporalLayerPatternDyadicBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_EXT")]
        VideoEncodeH264RateControlTemporalLayerPatternDyadicBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXT")]
        AttemptHrdComplianceBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REGULAR_GOP_BIT_EXT")]
        RegularGopBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXT")]
        ReferencePatternFlatBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXT")]
        ReferencePatternDyadicBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_EXT")]
        TemporalLayerPatternDyadicBitExt = 16,
    }
}

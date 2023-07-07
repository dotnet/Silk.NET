// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265RateControlFlagsEXT")]
    public enum VideoEncodeH265RateControlFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AttemptHrdComplianceBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXT")]
        VideoEncodeH265RateControlAttemptHrdComplianceBitExt = 1,
        [Obsolete("Deprecated in favour of \"RegularGopBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_EXT")]
        VideoEncodeH265RateControlRegularGopBitExt = 2,
        [Obsolete("Deprecated in favour of \"ReferencePatternFlatBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXT")]
        VideoEncodeH265RateControlReferencePatternFlatBitExt = 4,
        [Obsolete("Deprecated in favour of \"ReferencePatternDyadicBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXT")]
        VideoEncodeH265RateControlReferencePatternDyadicBitExt = 8,
        [Obsolete("Deprecated in favour of \"TemporalSubLayerPatternDyadicBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_EXT")]
        VideoEncodeH265RateControlTemporalSubLayerPatternDyadicBitExt = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXT")]
        AttemptHrdComplianceBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_EXT")]
        RegularGopBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXT")]
        ReferencePatternFlatBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXT")]
        ReferencePatternDyadicBitExt = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_EXT")]
        TemporalSubLayerPatternDyadicBitExt = 16,
    }
}

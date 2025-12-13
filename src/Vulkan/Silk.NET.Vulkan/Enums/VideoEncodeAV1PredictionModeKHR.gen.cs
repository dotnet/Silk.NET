// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeAV1PredictionModeKHR")]
    public enum VideoEncodeAV1PredictionModeKHR : int
    {
        [Obsolete("Deprecated in favour of \"IntraOnlyKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR")]
        VideoEncodeAV1PredictionModeIntraOnlyKhr = 0,
        [Obsolete("Deprecated in favour of \"SingleReferenceKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR")]
        VideoEncodeAV1PredictionModeSingleReferenceKhr = 1,
        [Obsolete("Deprecated in favour of \"UnidirectionalCompoundKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR")]
        VideoEncodeAV1PredictionModeUnidirectionalCompoundKhr = 2,
        [Obsolete("Deprecated in favour of \"BidirectionalCompoundKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR")]
        VideoEncodeAV1PredictionModeBidirectionalCompoundKhr = 3,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR")]
        IntraOnlyKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR")]
        SingleReferenceKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR")]
        UnidirectionalCompoundKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR")]
        BidirectionalCompoundKhr = 3,
    }
}

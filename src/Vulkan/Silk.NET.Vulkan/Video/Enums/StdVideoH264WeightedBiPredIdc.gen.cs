// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264WeightedBiPredIdc")]
    public enum StdVideoH264WeightedBiPredIdc : int
    {
        [NativeName("Name", "std_video_h264_default_weighted_b_slices_prediction_idc")]
        StdVideoH264DefaultWeightedBSlicesPredictionIdc = 0x0,
        [NativeName("Name", "std_video_h264_explicit_weighted_b_slices_prediction_idc")]
        StdVideoH264ExplicitWeightedBSlicesPredictionIdc = 0x1,
        [NativeName("Name", "std_video_h264_implicit_weighted_b_slices_prediction_idc")]
        StdVideoH264ImplicitWeightedBSlicesPredictionIdc = 0x2,
        [NativeName("Name", "std_video_h264_invalid_weighted_b_slices_prediction_idc")]
        StdVideoH264InvalidWeightedBSlicesPredictionIdc = 0x7FFFFFFF,
    }
}

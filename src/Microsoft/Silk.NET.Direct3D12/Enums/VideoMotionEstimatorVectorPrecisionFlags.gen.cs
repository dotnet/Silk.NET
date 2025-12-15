// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS")]
    public enum VideoMotionEstimatorVectorPrecisionFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE")]
        VideoMotionEstimatorVectorPrecisionFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"QuarterPel\"")]
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL")]
        VideoMotionEstimatorVectorPrecisionFlagQuarterPel = 0x1,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL")]
        QuarterPel = 0x1,
    }
}

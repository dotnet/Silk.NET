// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS")]
    public enum VideoMotionEstimatorVectorPrecisionFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE")]
        VideoMotionEstimatorVectorPrecisionFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL")]
        VideoMotionEstimatorVectorPrecisionFlagQuarterPel = 0x1,
    }
}

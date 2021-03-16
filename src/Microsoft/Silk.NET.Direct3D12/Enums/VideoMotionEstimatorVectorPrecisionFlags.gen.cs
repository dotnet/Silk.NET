// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS")]
    public enum VideoMotionEstimatorVectorPrecisionFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE")]
        VideoMotionEstimatorVectorPrecisionFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL")]
        VideoMotionEstimatorVectorPrecisionFlagQuarterPel = 0x1,
    }
}

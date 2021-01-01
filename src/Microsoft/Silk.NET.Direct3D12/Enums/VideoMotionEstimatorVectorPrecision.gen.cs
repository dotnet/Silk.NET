// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION")]
    public enum VideoMotionEstimatorVectorPrecision : int
    {
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL")]
        VideoMotionEstimatorVectorPrecisionQuarterPel = 0x0,
    }
}

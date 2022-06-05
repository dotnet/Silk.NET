// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION")]
    public enum VideoMotionEstimatorVectorPrecision : int
    {
        [Obsolete("Deprecated in favour of \"QuarterPel\"")]
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL")]
        VideoMotionEstimatorVectorPrecisionQuarterPel = 0x0,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL")]
        QuarterPel = 0x0,
    }
}

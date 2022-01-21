// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE")]
    public enum VideoMotionEstimatorSearchBlockSize : int
    {
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_8X8")]
        VideoMotionEstimatorSearchBlockSize8X8 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_16X16")]
        VideoMotionEstimatorSearchBlockSize16X16 = 0x1,
    }
}

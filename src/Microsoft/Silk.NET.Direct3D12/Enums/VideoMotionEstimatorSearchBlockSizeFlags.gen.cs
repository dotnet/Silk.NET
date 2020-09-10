// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS")]
    public enum VideoMotionEstimatorSearchBlockSizeFlags
    {
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAG_NONE")]
        VideoMotionEstimatorSearchBlockSizeFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAG_8X8")]
        VideoMotionEstimatorSearchBlockSizeFlag8X8 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAG_16X16")]
        VideoMotionEstimatorSearchBlockSizeFlag16X16 = 0x2,
    }
}

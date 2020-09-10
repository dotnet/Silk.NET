// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR")]
    public unsafe partial struct FeatureDataVideoMotionEstimator
    {
        public FeatureDataVideoMotionEstimator
        (
            uint nodeIndex = default,
            Silk.NET.DXGI.Format inputFormat = default,
            VideoMotionEstimatorSearchBlockSizeFlags blockSizeFlags = default,
            VideoMotionEstimatorVectorPrecisionFlags precisionFlags = default,
            VideoSizeRange sizeRange = default
        )
        {
            NodeIndex = nodeIndex;
            InputFormat = inputFormat;
            BlockSizeFlags = blockSizeFlags;
            PrecisionFlags = precisionFlags;
            SizeRange = sizeRange;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "InputFormat")]
        public Silk.NET.DXGI.Format InputFormat;

        [NativeName("Type", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS")]
        [NativeName("Name", "BlockSizeFlags")]
        public VideoMotionEstimatorSearchBlockSizeFlags BlockSizeFlags;

        [NativeName("Type", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS")]
        [NativeName("Name", "PrecisionFlags")]
        public VideoMotionEstimatorVectorPrecisionFlags PrecisionFlags;

        [NativeName("Type", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Type.Name", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Name", "SizeRange")]
        public VideoSizeRange SizeRange;
    }
}

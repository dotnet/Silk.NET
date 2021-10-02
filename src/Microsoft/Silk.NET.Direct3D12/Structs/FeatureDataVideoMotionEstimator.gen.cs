// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            uint? nodeIndex = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoMotionEstimatorSearchBlockSizeFlags? blockSizeFlags = null,
            VideoMotionEstimatorVectorPrecisionFlags? precisionFlags = null,
            VideoSizeRange? sizeRange = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (inputFormat is not null)
            {
                InputFormat = inputFormat.Value;
            }

            if (blockSizeFlags is not null)
            {
                BlockSizeFlags = blockSizeFlags.Value;
            }

            if (precisionFlags is not null)
            {
                PrecisionFlags = precisionFlags.Value;
            }

            if (sizeRange is not null)
            {
                SizeRange = sizeRange.Value;
            }
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

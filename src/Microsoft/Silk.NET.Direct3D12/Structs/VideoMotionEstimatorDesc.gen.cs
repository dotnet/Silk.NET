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
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_DESC")]
    public unsafe partial struct VideoMotionEstimatorDesc
    {
        public VideoMotionEstimatorDesc
        (
            uint nodeMask = default,
            Silk.NET.DXGI.Format inputFormat = default,
            VideoMotionEstimatorSearchBlockSize blockSize = default,
            VideoMotionEstimatorVectorPrecision precision = default,
            VideoSizeRange sizeRange = default
        )
        {
            NodeMask = nodeMask;
            InputFormat = inputFormat;
            BlockSize = blockSize;
            Precision = precision;
            SizeRange = sizeRange;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "InputFormat")]
        public Silk.NET.DXGI.Format InputFormat;

        [NativeName("Type", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE")]
        [NativeName("Type.Name", "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE")]
        [NativeName("Name", "BlockSize")]
        public VideoMotionEstimatorSearchBlockSize BlockSize;

        [NativeName("Type", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION")]
        [NativeName("Type.Name", "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION")]
        [NativeName("Name", "Precision")]
        public VideoMotionEstimatorVectorPrecision Precision;

        [NativeName("Type", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Type.Name", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Name", "SizeRange")]
        public VideoSizeRange SizeRange;
    }
}

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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE")]
    public unsafe partial struct FeatureDataVideoMotionEstimatorSize
    {
        public FeatureDataVideoMotionEstimatorSize
        (
            uint nodeIndex = default,
            Silk.NET.DXGI.Format inputFormat = default,
            VideoMotionEstimatorSearchBlockSize blockSize = default,
            VideoMotionEstimatorVectorPrecision precision = default,
            VideoSizeRange sizeRange = default,
            int @protected = default,
            ulong motionVectorHeapMemoryPoolL0Size = default,
            ulong motionVectorHeapMemoryPoolL1Size = default,
            ulong motionEstimatorMemoryPoolL0Size = default,
            ulong motionEstimatorMemoryPoolL1Size = default
        )
        {
            NodeIndex = nodeIndex;
            InputFormat = inputFormat;
            BlockSize = blockSize;
            Precision = precision;
            SizeRange = sizeRange;
            Protected = @protected;
            MotionVectorHeapMemoryPoolL0Size = motionVectorHeapMemoryPoolL0Size;
            MotionVectorHeapMemoryPoolL1Size = motionVectorHeapMemoryPoolL1Size;
            MotionEstimatorMemoryPoolL0Size = motionEstimatorMemoryPoolL0Size;
            MotionEstimatorMemoryPoolL1Size = motionEstimatorMemoryPoolL1Size;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

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

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Protected")]
        public int Protected;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MotionVectorHeapMemoryPoolL0Size")]
        public ulong MotionVectorHeapMemoryPoolL0Size;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MotionVectorHeapMemoryPoolL1Size")]
        public ulong MotionVectorHeapMemoryPoolL1Size;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MotionEstimatorMemoryPoolL0Size")]
        public ulong MotionEstimatorMemoryPoolL0Size;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MotionEstimatorMemoryPoolL1Size")]
        public ulong MotionEstimatorMemoryPoolL1Size;
    }
}

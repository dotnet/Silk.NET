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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE")]
    public unsafe partial struct FeatureDataVideoMotionEstimatorSize
    {
        public FeatureDataVideoMotionEstimatorSize
        (
            uint? nodeIndex = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoMotionEstimatorSearchBlockSize? blockSize = null,
            VideoMotionEstimatorVectorPrecision? precision = null,
            VideoSizeRange? sizeRange = null,
            Silk.NET.Core.Bool32? @protected = null,
            ulong? motionVectorHeapMemoryPoolL0Size = null,
            ulong? motionVectorHeapMemoryPoolL1Size = null,
            ulong? motionEstimatorMemoryPoolL0Size = null,
            ulong? motionEstimatorMemoryPoolL1Size = null
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

            if (blockSize is not null)
            {
                BlockSize = blockSize.Value;
            }

            if (precision is not null)
            {
                Precision = precision.Value;
            }

            if (sizeRange is not null)
            {
                SizeRange = sizeRange.Value;
            }

            if (@protected is not null)
            {
                Protected = @protected.Value;
            }

            if (motionVectorHeapMemoryPoolL0Size is not null)
            {
                MotionVectorHeapMemoryPoolL0Size = motionVectorHeapMemoryPoolL0Size.Value;
            }

            if (motionVectorHeapMemoryPoolL1Size is not null)
            {
                MotionVectorHeapMemoryPoolL1Size = motionVectorHeapMemoryPoolL1Size.Value;
            }

            if (motionEstimatorMemoryPoolL0Size is not null)
            {
                MotionEstimatorMemoryPoolL0Size = motionEstimatorMemoryPoolL0Size.Value;
            }

            if (motionEstimatorMemoryPoolL1Size is not null)
            {
                MotionEstimatorMemoryPoolL1Size = motionEstimatorMemoryPoolL1Size.Value;
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
        public Silk.NET.Core.Bool32 Protected;

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

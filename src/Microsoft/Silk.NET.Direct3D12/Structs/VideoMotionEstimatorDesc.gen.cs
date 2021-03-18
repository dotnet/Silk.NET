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
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_DESC")]
    public unsafe partial struct VideoMotionEstimatorDesc
    {
        public VideoMotionEstimatorDesc
        (
            uint? nodeMask = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoMotionEstimatorSearchBlockSize? blockSize = null,
            VideoMotionEstimatorVectorPrecision? precision = null,
            VideoSizeRange? sizeRange = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
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

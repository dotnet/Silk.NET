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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L10281_C5")]
    public unsafe partial struct VideoEncoderInputMapDataUnion
    {
        public VideoEncoderInputMapDataUnion
        (
            VideoEncoderInputMapDataQuantizationMatrix? quantization = null,
            VideoEncoderInputMapDataDirtyRegions? dirtyRegions = null,
            VideoEncoderInputMapDataMotionVectors? motionVectors = null
        ) : this()
        {
            if (quantization is not null)
            {
                Quantization = quantization.Value;
            }

            if (dirtyRegions is not null)
            {
                DirtyRegions = dirtyRegions.Value;
            }

            if (motionVectors is not null)
            {
                MotionVectors = motionVectors.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX")]
        [NativeName("Name", "Quantization")]
        public VideoEncoderInputMapDataQuantizationMatrix Quantization;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS")]
        [NativeName("Name", "DirtyRegions")]
        public VideoEncoderInputMapDataDirtyRegions DirtyRegions;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS")]
        [NativeName("Name", "MotionVectors")]
        public VideoEncoderInputMapDataMotionVectors MotionVectors;
    }
}

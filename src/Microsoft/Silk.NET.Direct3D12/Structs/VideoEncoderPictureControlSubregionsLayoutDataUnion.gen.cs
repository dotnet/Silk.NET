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
    [NativeName("Name", "__AnonymousRecord_d3d12video_L7562_C5")]
    public unsafe partial struct VideoEncoderPictureControlSubregionsLayoutDataUnion
    {
        public VideoEncoderPictureControlSubregionsLayoutDataUnion
        (
            VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartitionH264 = null,
            VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartitionHEVC = null,
            VideoEncoderAV1PictureControlSubregionsLayoutDataTiles* pTilesPartitionAV1 = null
        ) : this()
        {
            if (pSlicesPartitionH264 is not null)
            {
                PSlicesPartitionH264 = pSlicesPartitionH264;
            }

            if (pSlicesPartitionHEVC is not null)
            {
                PSlicesPartitionHEVC = pSlicesPartitionHEVC;
            }

            if (pTilesPartitionAV1 is not null)
            {
                PTilesPartitionAV1 = pTilesPartitionAV1;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES *")]
        [NativeName("Name", "pSlicesPartition_H264")]
        public VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartitionH264;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES *")]
        [NativeName("Name", "pSlicesPartition_HEVC")]
        public VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartitionHEVC;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES *")]
        [NativeName("Name", "pTilesPartition_AV1")]
        public VideoEncoderAV1PictureControlSubregionsLayoutDataTiles* PTilesPartitionAV1;
    }
}

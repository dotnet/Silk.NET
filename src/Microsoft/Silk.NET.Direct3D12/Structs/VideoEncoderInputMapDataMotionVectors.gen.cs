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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS")]
    public unsafe partial struct VideoEncoderInputMapDataMotionVectors
    {
        public VideoEncoderInputMapDataMotionVectors
        (
            VideoEncoderFrameMotionSearchModeConfig? motionSearchModeConfiguration = null,
            uint? numHintsPerPixel = null,
            ID3D12Resource** ppMotionVectorMaps = null,
            uint* pMotionVectorMapsSubresources = null,
            ID3D12Resource** ppMotionVectorMapsMetadata = null,
            uint* pMotionVectorMapsMetadataSubresources = null,
            VideoEncoderFrameInputMotionUnitPrecision? motionUnitPrecision = null,
            VideoEncoderPictureControlCodecData1? pictureControlConfiguration = null
        ) : this()
        {
            if (motionSearchModeConfiguration is not null)
            {
                MotionSearchModeConfiguration = motionSearchModeConfiguration.Value;
            }

            if (numHintsPerPixel is not null)
            {
                NumHintsPerPixel = numHintsPerPixel.Value;
            }

            if (ppMotionVectorMaps is not null)
            {
                PpMotionVectorMaps = ppMotionVectorMaps;
            }

            if (pMotionVectorMapsSubresources is not null)
            {
                PMotionVectorMapsSubresources = pMotionVectorMapsSubresources;
            }

            if (ppMotionVectorMapsMetadata is not null)
            {
                PpMotionVectorMapsMetadata = ppMotionVectorMapsMetadata;
            }

            if (pMotionVectorMapsMetadataSubresources is not null)
            {
                PMotionVectorMapsMetadataSubresources = pMotionVectorMapsMetadataSubresources;
            }

            if (motionUnitPrecision is not null)
            {
                MotionUnitPrecision = motionUnitPrecision.Value;
            }

            if (pictureControlConfiguration is not null)
            {
                PictureControlConfiguration = pictureControlConfiguration.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG")]
        [NativeName("Name", "MotionSearchModeConfiguration")]
        public VideoEncoderFrameMotionSearchModeConfig MotionSearchModeConfiguration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumHintsPerPixel")]
        public uint NumHintsPerPixel;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppMotionVectorMaps")]
        public ID3D12Resource** PpMotionVectorMaps;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pMotionVectorMapsSubresources")]
        public uint* PMotionVectorMapsSubresources;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppMotionVectorMapsMetadata")]
        public ID3D12Resource** PpMotionVectorMapsMetadata;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pMotionVectorMapsMetadataSubresources")]
        public uint* PMotionVectorMapsMetadataSubresources;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION")]
        [NativeName("Name", "MotionUnitPrecision")]
        public VideoEncoderFrameInputMotionUnitPrecision MotionUnitPrecision;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1")]
        [NativeName("Name", "PictureControlConfiguration")]
        public VideoEncoderPictureControlCodecData1 PictureControlConfiguration;
    }
}

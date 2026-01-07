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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1")]
    public unsafe partial struct VideoEncoderPictureControlDesc1
    {
        public VideoEncoderPictureControlDesc1
        (
            uint? intraRefreshFrameIndex = null,
            VideoEncoderPictureControlFlags? flags = null,
            VideoEncoderPictureControlCodecData1? pictureControlCodecData = null,
            VideoEncodeReferenceFrames? referenceFrames = null,
            VideoEncoderFrameMotionVectors? motionVectors = null,
            VideoEncoderDirtyRegions? dirtyRects = null,
            VideoEncoderQuantizationOpaqueMap? quantizationTextureMap = null,
            VideoEncoderFrameAnalysis? frameAnalysis = null
        ) : this()
        {
            if (intraRefreshFrameIndex is not null)
            {
                IntraRefreshFrameIndex = intraRefreshFrameIndex.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pictureControlCodecData is not null)
            {
                PictureControlCodecData = pictureControlCodecData.Value;
            }

            if (referenceFrames is not null)
            {
                ReferenceFrames = referenceFrames.Value;
            }

            if (motionVectors is not null)
            {
                MotionVectors = motionVectors.Value;
            }

            if (dirtyRects is not null)
            {
                DirtyRects = dirtyRects.Value;
            }

            if (quantizationTextureMap is not null)
            {
                QuantizationTextureMap = quantizationTextureMap.Value;
            }

            if (frameAnalysis is not null)
            {
                FrameAnalysis = frameAnalysis.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IntraRefreshFrameIndex")]
        public uint IntraRefreshFrameIndex;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderPictureControlFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1")]
        [NativeName("Name", "PictureControlCodecData")]
        public VideoEncoderPictureControlCodecData1 PictureControlCodecData;

        [NativeName("Type", "D3D12_VIDEO_ENCODE_REFERENCE_FRAMES")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODE_REFERENCE_FRAMES")]
        [NativeName("Name", "ReferenceFrames")]
        public VideoEncodeReferenceFrames ReferenceFrames;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_MOTION_VECTORS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_VECTORS")]
        [NativeName("Name", "MotionVectors")]
        public VideoEncoderFrameMotionVectors MotionVectors;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS")]
        [NativeName("Name", "DirtyRects")]
        public VideoEncoderDirtyRegions DirtyRects;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_QUANTIZATION_OPAQUE_MAP")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_QUANTIZATION_OPAQUE_MAP")]
        [NativeName("Name", "QuantizationTextureMap")]
        public VideoEncoderQuantizationOpaqueMap QuantizationTextureMap;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_ANALYSIS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_ANALYSIS")]
        [NativeName("Name", "FrameAnalysis")]
        public VideoEncoderFrameAnalysis FrameAnalysis;
    }
}

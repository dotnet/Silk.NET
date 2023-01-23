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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC")]
    public unsafe partial struct VideoEncoderPictureControlDesc
    {
        public VideoEncoderPictureControlDesc
        (
            uint? intraRefreshFrameIndex = null,
            VideoEncoderPictureControlFlags? flags = null,
            VideoEncoderPictureControlCodecData? pictureControlCodecData = null,
            VideoEncodeReferenceFrames? referenceFrames = null
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
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IntraRefreshFrameIndex")]
        public uint IntraRefreshFrameIndex;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderPictureControlFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA")]
        [NativeName("Name", "PictureControlCodecData")]
        public VideoEncoderPictureControlCodecData PictureControlCodecData;

        [NativeName("Type", "D3D12_VIDEO_ENCODE_REFERENCE_FRAMES")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODE_REFERENCE_FRAMES")]
        [NativeName("Name", "ReferenceFrames")]
        public VideoEncodeReferenceFrames ReferenceFrames;
    }
}

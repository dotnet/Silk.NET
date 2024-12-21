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
    [NativeName("Name", "__AnonymousRecord_d3d12video_L8363_C5")]
    public unsafe partial struct VideoEncoderPictureControlCodecDataUnion
    {
        public VideoEncoderPictureControlCodecDataUnion
        (
            VideoEncoderPictureControlCodecDataH264* pH264PicData = null,
            VideoEncoderPictureControlCodecDataHevc* pHEVCPicData = null,
            VideoEncoderAV1PictureControlCodecData* pAV1PicData = null
        ) : this()
        {
            if (pH264PicData is not null)
            {
                PH264PicData = pH264PicData;
            }

            if (pHEVCPicData is not null)
            {
                PHEVCPicData = pHEVCPicData;
            }

            if (pAV1PicData is not null)
            {
                PAV1PicData = pAV1PicData;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264 *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264 *")]
        [NativeName("Name", "pH264PicData")]
        public VideoEncoderPictureControlCodecDataH264* PH264PicData;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC *")]
        [NativeName("Name", "pHEVCPicData")]
        public VideoEncoderPictureControlCodecDataHevc* PHEVCPicData;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA *")]
        [NativeName("Name", "pAV1PicData")]
        public VideoEncoderAV1PictureControlCodecData* PAV1PicData;
    }
}

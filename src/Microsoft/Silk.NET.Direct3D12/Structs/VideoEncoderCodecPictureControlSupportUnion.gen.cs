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
    [NativeName("Name", "__AnonymousRecord_d3d12video_L7359_C5")]
    public unsafe partial struct VideoEncoderCodecPictureControlSupportUnion
    {
        public VideoEncoderCodecPictureControlSupportUnion
        (
            VideoEncoderCodecPictureControlSupportH264* pH264Support = null,
            VideoEncoderCodecPictureControlSupportHevc* pHEVCSupport = null,
            VideoEncoderCodecAV1PictureControlSupport* pAV1Support = null
        ) : this()
        {
            if (pH264Support is not null)
            {
                PH264Support = pH264Support;
            }

            if (pHEVCSupport is not null)
            {
                PHEVCSupport = pHEVCSupport;
            }

            if (pAV1Support is not null)
            {
                PAV1Support = pAV1Support;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264 *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264 *")]
        [NativeName("Name", "pH264Support")]
        public VideoEncoderCodecPictureControlSupportH264* PH264Support;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC *")]
        [NativeName("Name", "pHEVCSupport")]
        public VideoEncoderCodecPictureControlSupportHevc* PHEVCSupport;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT *")]
        [NativeName("Name", "pAV1Support")]
        public VideoEncoderCodecAV1PictureControlSupport* PAV1Support;
    }
}

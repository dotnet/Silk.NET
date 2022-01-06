// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS")]
    public enum VideoEncoderPictureControlCodecDataH264Flags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_NONE")]
        VideoEncoderPictureControlCodecDataH264FlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_REQUEST_INTRA_CONSTRAINED_SLICES")]
        VideoEncoderPictureControlCodecDataH264FlagRequestIntraConstrainedSlices = 0x1,
    }
}

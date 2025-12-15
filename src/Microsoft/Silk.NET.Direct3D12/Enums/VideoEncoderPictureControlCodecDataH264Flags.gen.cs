// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS")]
    public enum VideoEncoderPictureControlCodecDataH264Flags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_NONE")]
        VideoEncoderPictureControlCodecDataH264FlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"RequestIntraConstrainedSlices\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_REQUEST_INTRA_CONSTRAINED_SLICES")]
        VideoEncoderPictureControlCodecDataH264FlagRequestIntraConstrainedSlices = 0x1,
        [Obsolete("Deprecated in favour of \"RequestNumRefIdxActiveOverrideFlagSlice\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_REQUEST_NUM_REF_IDX_ACTIVE_OVERRIDE_FLAG_SLICE")]
        VideoEncoderPictureControlCodecDataH264FlagRequestNumRefIdxActiveOverrideFlagSlice = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_REQUEST_INTRA_CONSTRAINED_SLICES")]
        RequestIntraConstrainedSlices = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAG_REQUEST_NUM_REF_IDX_ACTIVE_OVERRIDE_FLAG_SLICE")]
        RequestNumRefIdxActiveOverrideFlagSlice = 0x2,
    }
}

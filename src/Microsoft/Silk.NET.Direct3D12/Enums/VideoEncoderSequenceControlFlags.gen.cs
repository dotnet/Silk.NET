// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS")]
    public enum VideoEncoderSequenceControlFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_NONE")]
        VideoEncoderSequenceControlFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"ResolutionChange\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RESOLUTION_CHANGE")]
        VideoEncoderSequenceControlFlagResolutionChange = 0x1,
        [Obsolete("Deprecated in favour of \"RateControlChange\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RATE_CONTROL_CHANGE")]
        VideoEncoderSequenceControlFlagRateControlChange = 0x2,
        [Obsolete("Deprecated in favour of \"SubregionLayoutChange\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_SUBREGION_LAYOUT_CHANGE")]
        VideoEncoderSequenceControlFlagSubregionLayoutChange = 0x4,
        [Obsolete("Deprecated in favour of \"RequestIntraRefresh\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_REQUEST_INTRA_REFRESH")]
        VideoEncoderSequenceControlFlagRequestIntraRefresh = 0x8,
        [Obsolete("Deprecated in favour of \"GopSequenceChange\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_GOP_SEQUENCE_CHANGE")]
        VideoEncoderSequenceControlFlagGopSequenceChange = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RESOLUTION_CHANGE")]
        ResolutionChange = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RATE_CONTROL_CHANGE")]
        RateControlChange = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_SUBREGION_LAYOUT_CHANGE")]
        SubregionLayoutChange = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_REQUEST_INTRA_REFRESH")]
        RequestIntraRefresh = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_GOP_SEQUENCE_CHANGE")]
        GopSequenceChange = 0x10,
    }
}

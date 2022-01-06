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
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_NONE")]
        VideoEncoderSequenceControlFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RESOLUTION_CHANGE")]
        VideoEncoderSequenceControlFlagResolutionChange = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RATE_CONTROL_CHANGE")]
        VideoEncoderSequenceControlFlagRateControlChange = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_SUBREGION_LAYOUT_CHANGE")]
        VideoEncoderSequenceControlFlagSubregionLayoutChange = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_REQUEST_INTRA_REFRESH")]
        VideoEncoderSequenceControlFlagRequestIntraRefresh = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_GOP_SEQUENCE_CHANGE")]
        VideoEncoderSequenceControlFlagGopSequenceChange = 0x10,
    }
}

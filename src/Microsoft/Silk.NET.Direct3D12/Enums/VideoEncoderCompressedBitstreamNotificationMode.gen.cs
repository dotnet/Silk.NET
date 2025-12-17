// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE")]
    public enum VideoEncoderCompressedBitstreamNotificationMode : int
    {
        [Obsolete("Deprecated in favour of \"FullFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE_FULL_FRAME")]
        VideoEncoderCompressedBitstreamNotificationModeFullFrame = 0x0,
        [Obsolete("Deprecated in favour of \"Subregions\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE_SUBREGIONS")]
        VideoEncoderCompressedBitstreamNotificationModeSubregions = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE_FULL_FRAME")]
        FullFrame = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE_SUBREGIONS")]
        Subregions = 0x1,
    }
}

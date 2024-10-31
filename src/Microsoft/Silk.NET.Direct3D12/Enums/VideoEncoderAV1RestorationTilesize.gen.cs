// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE")]
    public enum VideoEncoderAV1RestorationTilesize : int
    {
        [Obsolete("Deprecated in favour of \"TilesizeDisabled\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_DISABLED")]
        VideoEncoderAV1RestorationTilesizeDisabled = 0x0,
        [Obsolete("Deprecated in favour of \"Tilesize32x32\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_32x32")]
        VideoEncoderAV1RestorationTilesize32x32 = 0x1,
        [Obsolete("Deprecated in favour of \"Tilesize64x64\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_64x64")]
        VideoEncoderAV1RestorationTilesize64x64 = 0x2,
        [Obsolete("Deprecated in favour of \"Tilesize128x128\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_128x128")]
        VideoEncoderAV1RestorationTilesize128x128 = 0x3,
        [Obsolete("Deprecated in favour of \"Tilesize256x256\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_256x256")]
        VideoEncoderAV1RestorationTilesize256x256 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_DISABLED")]
        TilesizeDisabled = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_32x32")]
        Tilesize32x32 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_64x64")]
        Tilesize64x64 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_128x128")]
        Tilesize128x128 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_256x256")]
        Tilesize256x256 = 0x4,
    }
}

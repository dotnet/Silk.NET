// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS")]
    public enum VideoEncoderAV1Levels : int
    {
        [Obsolete("Deprecated in favour of \"Levels20\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_0")]
        VideoEncoderAV1Levels20 = 0x0,
        [Obsolete("Deprecated in favour of \"Levels21\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_1")]
        VideoEncoderAV1Levels21 = 0x1,
        [Obsolete("Deprecated in favour of \"Levels22\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_2")]
        VideoEncoderAV1Levels22 = 0x2,
        [Obsolete("Deprecated in favour of \"Levels23\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_3")]
        VideoEncoderAV1Levels23 = 0x3,
        [Obsolete("Deprecated in favour of \"Levels30\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_0")]
        VideoEncoderAV1Levels30 = 0x4,
        [Obsolete("Deprecated in favour of \"Levels31\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_1")]
        VideoEncoderAV1Levels31 = 0x5,
        [Obsolete("Deprecated in favour of \"Levels32\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_2")]
        VideoEncoderAV1Levels32 = 0x6,
        [Obsolete("Deprecated in favour of \"Levels33\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_3")]
        VideoEncoderAV1Levels33 = 0x7,
        [Obsolete("Deprecated in favour of \"Levels40\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_0")]
        VideoEncoderAV1Levels40 = 0x8,
        [Obsolete("Deprecated in favour of \"Levels41\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_1")]
        VideoEncoderAV1Levels41 = 0x9,
        [Obsolete("Deprecated in favour of \"Levels42\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_2")]
        VideoEncoderAV1Levels42 = 0xA,
        [Obsolete("Deprecated in favour of \"Levels43\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_3")]
        VideoEncoderAV1Levels43 = 0xB,
        [Obsolete("Deprecated in favour of \"Levels50\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_0")]
        VideoEncoderAV1Levels50 = 0xC,
        [Obsolete("Deprecated in favour of \"Levels51\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_1")]
        VideoEncoderAV1Levels51 = 0xD,
        [Obsolete("Deprecated in favour of \"Levels52\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_2")]
        VideoEncoderAV1Levels52 = 0xE,
        [Obsolete("Deprecated in favour of \"Levels53\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_3")]
        VideoEncoderAV1Levels53 = 0xF,
        [Obsolete("Deprecated in favour of \"Levels60\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_0")]
        VideoEncoderAV1Levels60 = 0x10,
        [Obsolete("Deprecated in favour of \"Levels61\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_1")]
        VideoEncoderAV1Levels61 = 0x11,
        [Obsolete("Deprecated in favour of \"Levels62\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_2")]
        VideoEncoderAV1Levels62 = 0x12,
        [Obsolete("Deprecated in favour of \"Levels63\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_3")]
        VideoEncoderAV1Levels63 = 0x13,
        [Obsolete("Deprecated in favour of \"Levels70\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_0")]
        VideoEncoderAV1Levels70 = 0x14,
        [Obsolete("Deprecated in favour of \"Levels71\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_1")]
        VideoEncoderAV1Levels71 = 0x15,
        [Obsolete("Deprecated in favour of \"Levels72\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_2")]
        VideoEncoderAV1Levels72 = 0x16,
        [Obsolete("Deprecated in favour of \"Levels73\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_3")]
        VideoEncoderAV1Levels73 = 0x17,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_0")]
        Levels20 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_1")]
        Levels21 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_2")]
        Levels22 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_2_3")]
        Levels23 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_0")]
        Levels30 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_1")]
        Levels31 = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_2")]
        Levels32 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_3_3")]
        Levels33 = 0x7,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_0")]
        Levels40 = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_1")]
        Levels41 = 0x9,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_2")]
        Levels42 = 0xA,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_4_3")]
        Levels43 = 0xB,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_0")]
        Levels50 = 0xC,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_1")]
        Levels51 = 0xD,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_2")]
        Levels52 = 0xE,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_5_3")]
        Levels53 = 0xF,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_0")]
        Levels60 = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_1")]
        Levels61 = 0x11,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_2")]
        Levels62 = 0x12,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_6_3")]
        Levels63 = 0x13,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_0")]
        Levels70 = 0x14,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_1")]
        Levels71 = 0x15,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_2")]
        Levels72 = 0x16,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS_7_3")]
        Levels73 = 0x17,
    }
}

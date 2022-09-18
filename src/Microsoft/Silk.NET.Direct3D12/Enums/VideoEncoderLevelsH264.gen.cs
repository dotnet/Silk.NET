// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264")]
    public enum VideoEncoderLevelsH264 : int
    {
        [Obsolete("Deprecated in favour of \"H2641\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_1")]
        VideoEncoderLevelsH2641 = 0x0,
        [Obsolete("Deprecated in favour of \"H2641b\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_1b")]
        VideoEncoderLevelsH2641b = 0x1,
        [Obsolete("Deprecated in favour of \"H26411\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_11")]
        VideoEncoderLevelsH26411 = 0x2,
        [Obsolete("Deprecated in favour of \"H26412\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_12")]
        VideoEncoderLevelsH26412 = 0x3,
        [Obsolete("Deprecated in favour of \"H26413\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_13")]
        VideoEncoderLevelsH26413 = 0x4,
        [Obsolete("Deprecated in favour of \"H2642\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_2")]
        VideoEncoderLevelsH2642 = 0x5,
        [Obsolete("Deprecated in favour of \"H26421\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_21")]
        VideoEncoderLevelsH26421 = 0x6,
        [Obsolete("Deprecated in favour of \"H26422\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_22")]
        VideoEncoderLevelsH26422 = 0x7,
        [Obsolete("Deprecated in favour of \"H2643\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_3")]
        VideoEncoderLevelsH2643 = 0x8,
        [Obsolete("Deprecated in favour of \"H26431\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_31")]
        VideoEncoderLevelsH26431 = 0x9,
        [Obsolete("Deprecated in favour of \"H26432\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_32")]
        VideoEncoderLevelsH26432 = 0xA,
        [Obsolete("Deprecated in favour of \"H2644\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_4")]
        VideoEncoderLevelsH2644 = 0xB,
        [Obsolete("Deprecated in favour of \"H26441\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_41")]
        VideoEncoderLevelsH26441 = 0xC,
        [Obsolete("Deprecated in favour of \"H26442\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_42")]
        VideoEncoderLevelsH26442 = 0xD,
        [Obsolete("Deprecated in favour of \"H2645\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_5")]
        VideoEncoderLevelsH2645 = 0xE,
        [Obsolete("Deprecated in favour of \"H26451\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_51")]
        VideoEncoderLevelsH26451 = 0xF,
        [Obsolete("Deprecated in favour of \"H26452\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_52")]
        VideoEncoderLevelsH26452 = 0x10,
        [Obsolete("Deprecated in favour of \"H2646\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_6")]
        VideoEncoderLevelsH2646 = 0x11,
        [Obsolete("Deprecated in favour of \"H26461\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_61")]
        VideoEncoderLevelsH26461 = 0x12,
        [Obsolete("Deprecated in favour of \"H26462\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_62")]
        VideoEncoderLevelsH26462 = 0x13,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_1")]
        H2641 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_1b")]
        H2641b = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_11")]
        H26411 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_12")]
        H26412 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_13")]
        H26413 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_2")]
        H2642 = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_21")]
        H26421 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_22")]
        H26422 = 0x7,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_3")]
        H2643 = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_31")]
        H26431 = 0x9,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_32")]
        H26432 = 0xA,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_4")]
        H2644 = 0xB,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_41")]
        H26441 = 0xC,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_42")]
        H26442 = 0xD,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_5")]
        H2645 = 0xE,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_51")]
        H26451 = 0xF,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_52")]
        H26452 = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_6")]
        H2646 = 0x11,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_61")]
        H26461 = 0x12,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_H264_62")]
        H26462 = 0x13,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC")]
    public enum VideoEncoderLevelsHevc : int
    {
        [Obsolete("Deprecated in favour of \"Hevc1\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_1")]
        VideoEncoderLevelsHevc1 = 0x0,
        [Obsolete("Deprecated in favour of \"Hevc2\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_2")]
        VideoEncoderLevelsHevc2 = 0x1,
        [Obsolete("Deprecated in favour of \"Hevc21\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_21")]
        VideoEncoderLevelsHevc21 = 0x2,
        [Obsolete("Deprecated in favour of \"Hevc3\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_3")]
        VideoEncoderLevelsHevc3 = 0x3,
        [Obsolete("Deprecated in favour of \"Hevc31\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_31")]
        VideoEncoderLevelsHevc31 = 0x4,
        [Obsolete("Deprecated in favour of \"Hevc4\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_4")]
        VideoEncoderLevelsHevc4 = 0x5,
        [Obsolete("Deprecated in favour of \"Hevc41\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_41")]
        VideoEncoderLevelsHevc41 = 0x6,
        [Obsolete("Deprecated in favour of \"Hevc5\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_5")]
        VideoEncoderLevelsHevc5 = 0x7,
        [Obsolete("Deprecated in favour of \"Hevc51\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_51")]
        VideoEncoderLevelsHevc51 = 0x8,
        [Obsolete("Deprecated in favour of \"Hevc52\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_52")]
        VideoEncoderLevelsHevc52 = 0x9,
        [Obsolete("Deprecated in favour of \"Hevc6\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_6")]
        VideoEncoderLevelsHevc6 = 0xA,
        [Obsolete("Deprecated in favour of \"Hevc61\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_61")]
        VideoEncoderLevelsHevc61 = 0xB,
        [Obsolete("Deprecated in favour of \"Hevc62\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_62")]
        VideoEncoderLevelsHevc62 = 0xC,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_1")]
        Hevc1 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_2")]
        Hevc2 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_21")]
        Hevc21 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_3")]
        Hevc3 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_31")]
        Hevc31 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_4")]
        Hevc4 = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_41")]
        Hevc41 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_5")]
        Hevc5 = 0x7,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_51")]
        Hevc51 = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_52")]
        Hevc52 = 0x9,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_6")]
        Hevc6 = 0xA,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_61")]
        Hevc61 = 0xB,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_62")]
        Hevc62 = 0xC,
    }
}

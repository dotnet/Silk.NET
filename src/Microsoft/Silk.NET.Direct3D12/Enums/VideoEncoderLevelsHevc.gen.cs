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
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_1")]
        VideoEncoderLevelsHevc1 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_2")]
        VideoEncoderLevelsHevc2 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_21")]
        VideoEncoderLevelsHevc21 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_3")]
        VideoEncoderLevelsHevc3 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_31")]
        VideoEncoderLevelsHevc31 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_4")]
        VideoEncoderLevelsHevc4 = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_41")]
        VideoEncoderLevelsHevc41 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_5")]
        VideoEncoderLevelsHevc5 = 0x7,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_51")]
        VideoEncoderLevelsHevc51 = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_52")]
        VideoEncoderLevelsHevc52 = 0x9,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_6")]
        VideoEncoderLevelsHevc6 = 0xA,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_61")]
        VideoEncoderLevelsHevc61 = 0xB,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC_62")]
        VideoEncoderLevelsHevc62 = 0xC,
    }
}

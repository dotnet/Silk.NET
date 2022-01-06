// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODES")]
    public enum VideoEncoderCodecConfigurationH264SlicesDeblockingModes : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_0_ALL_LUMA_CHROMA_SLICE_BLOCK_EDGES_ALWAYS_FILTERED")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode0AllLumaChromaSliceBlockEdgesAlwaysFiltered = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_1_DISABLE_ALL_SLICE_BLOCK_EDGES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode1DisableAllSliceBlockEdges = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_2_DISABLE_SLICE_BOUNDARIES_BLOCKS")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode2DisableSliceBoundariesBlocks = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_3_USE_TWO_STAGE_DEBLOCKING")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode3UseTwoStageDeblocking = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_4_DISABLE_CHROMA_BLOCK_EDGES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode4DisableChromaBlockEdges = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_5_DISABLE_CHROMA_BLOCK_EDGES_AND_LUMA_BOUNDARIES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode5DisableChromaBlockEdgesAndLumaBoundaries = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_6_DISABLE_CHROMA_BLOCK_EDGES_AND_USE_LUMA_TWO_STAGE_DEBLOCKING")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking = 0x6,
    }
}

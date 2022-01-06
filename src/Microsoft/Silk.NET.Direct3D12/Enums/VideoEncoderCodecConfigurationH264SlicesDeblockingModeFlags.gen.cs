// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAGS")]
    public enum VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_NONE")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_0_ALL_LUMA_CHROMA_SLICE_BLOCK_EDGES_ALWAYS_FILTERED")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlag0AllLumaChromaSliceBlockEdgesAlwaysFiltered = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_1_DISABLE_ALL_SLICE_BLOCK_EDGES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlag1DisableAllSliceBlockEdges = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_2_DISABLE_SLICE_BOUNDARIES_BLOCKS")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlag2DisableSliceBoundariesBlocks = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_3_USE_TWO_STAGE_DEBLOCKING")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlag3UseTwoStageDeblocking = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_4_DISABLE_CHROMA_BLOCK_EDGES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlag4DisableChromaBlockEdges = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_5_DISABLE_CHROMA_BLOCK_EDGES_AND_LUMA_BOUNDARIES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlag5DisableChromaBlockEdgesAndLumaBoundaries = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAG_6_DISABLE_CHROMA_BLOCK_EDGES_AND_USE_LUMA_TWO_STAGE_DEBLOCKING")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlag6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking = 0x40,
    }
}

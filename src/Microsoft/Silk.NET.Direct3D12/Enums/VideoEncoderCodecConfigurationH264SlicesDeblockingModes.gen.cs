// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODES")]
    public enum VideoEncoderCodecConfigurationH264SlicesDeblockingModes : int
    {
        [Obsolete("Deprecated in favour of \"Mode0AllLumaChromaSliceBlockEdgesAlwaysFiltered\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_0_ALL_LUMA_CHROMA_SLICE_BLOCK_EDGES_ALWAYS_FILTERED")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode0AllLumaChromaSliceBlockEdgesAlwaysFiltered = 0x0,
        [Obsolete("Deprecated in favour of \"Mode1DisableAllSliceBlockEdges\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_1_DISABLE_ALL_SLICE_BLOCK_EDGES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode1DisableAllSliceBlockEdges = 0x1,
        [Obsolete("Deprecated in favour of \"Mode2DisableSliceBoundariesBlocks\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_2_DISABLE_SLICE_BOUNDARIES_BLOCKS")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode2DisableSliceBoundariesBlocks = 0x2,
        [Obsolete("Deprecated in favour of \"Mode3UseTwoStageDeblocking\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_3_USE_TWO_STAGE_DEBLOCKING")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode3UseTwoStageDeblocking = 0x3,
        [Obsolete("Deprecated in favour of \"Mode4DisableChromaBlockEdges\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_4_DISABLE_CHROMA_BLOCK_EDGES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode4DisableChromaBlockEdges = 0x4,
        [Obsolete("Deprecated in favour of \"Mode5DisableChromaBlockEdgesAndLumaBoundaries\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_5_DISABLE_CHROMA_BLOCK_EDGES_AND_LUMA_BOUNDARIES")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode5DisableChromaBlockEdgesAndLumaBoundaries = 0x5,
        [Obsolete("Deprecated in favour of \"Mode6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_6_DISABLE_CHROMA_BLOCK_EDGES_AND_USE_LUMA_TWO_STAGE_DEBLOCKING")]
        VideoEncoderCodecConfigurationH264SlicesDeblockingMode6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_0_ALL_LUMA_CHROMA_SLICE_BLOCK_EDGES_ALWAYS_FILTERED")]
        Mode0AllLumaChromaSliceBlockEdgesAlwaysFiltered = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_1_DISABLE_ALL_SLICE_BLOCK_EDGES")]
        Mode1DisableAllSliceBlockEdges = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_2_DISABLE_SLICE_BOUNDARIES_BLOCKS")]
        Mode2DisableSliceBoundariesBlocks = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_3_USE_TWO_STAGE_DEBLOCKING")]
        Mode3UseTwoStageDeblocking = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_4_DISABLE_CHROMA_BLOCK_EDGES")]
        Mode4DisableChromaBlockEdges = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_5_DISABLE_CHROMA_BLOCK_EDGES_AND_LUMA_BOUNDARIES")]
        Mode5DisableChromaBlockEdgesAndLumaBoundaries = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_6_DISABLE_CHROMA_BLOCK_EDGES_AND_USE_LUMA_TWO_STAGE_DEBLOCKING")]
        Mode6DisableChromaBlockEdgesAndUseLumaTwoStageDeblocking = 0x6,
    }
}

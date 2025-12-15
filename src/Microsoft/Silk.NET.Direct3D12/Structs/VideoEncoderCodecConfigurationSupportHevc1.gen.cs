// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1")]
    public unsafe partial struct VideoEncoderCodecConfigurationSupportHevc1
    {
        public VideoEncoderCodecConfigurationSupportHevc1
        (
            VideoEncoderCodecConfigurationSupportHevcFlags? supportFlags = null,
            VideoEncoderCodecConfigurationHevcCusize? minLumaCodingUnitSize = null,
            VideoEncoderCodecConfigurationHevcCusize? maxLumaCodingUnitSize = null,
            VideoEncoderCodecConfigurationHevcTusize? minLumaTransformUnitSize = null,
            VideoEncoderCodecConfigurationHevcTusize? maxLumaTransformUnitSize = null,
            byte? maxTransformHierarchyDepthInter = null,
            byte? maxTransformHierarchyDepthIntra = null,
            uint? allowedDiffCuChromaQpOffsetDepthValues = null,
            uint? allowedLog2SaoOffsetScaleLumaValues = null,
            uint? allowedLog2SaoOffsetScaleChromaValues = null,
            uint? allowedLog2MaxTransformSkipBlockSizeMinus2Values = null,
            uint? allowedChromaQpOffsetListLenMinus1Values = null,
            VideoEncoderCodecConfigurationSupportHevcFlags1? supportFlags1 = null
        ) : this()
        {
            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

            if (minLumaCodingUnitSize is not null)
            {
                MinLumaCodingUnitSize = minLumaCodingUnitSize.Value;
            }

            if (maxLumaCodingUnitSize is not null)
            {
                MaxLumaCodingUnitSize = maxLumaCodingUnitSize.Value;
            }

            if (minLumaTransformUnitSize is not null)
            {
                MinLumaTransformUnitSize = minLumaTransformUnitSize.Value;
            }

            if (maxLumaTransformUnitSize is not null)
            {
                MaxLumaTransformUnitSize = maxLumaTransformUnitSize.Value;
            }

            if (maxTransformHierarchyDepthInter is not null)
            {
                MaxTransformHierarchyDepthInter = maxTransformHierarchyDepthInter.Value;
            }

            if (maxTransformHierarchyDepthIntra is not null)
            {
                MaxTransformHierarchyDepthIntra = maxTransformHierarchyDepthIntra.Value;
            }

            if (allowedDiffCuChromaQpOffsetDepthValues is not null)
            {
                AllowedDiffCuChromaQpOffsetDepthValues = allowedDiffCuChromaQpOffsetDepthValues.Value;
            }

            if (allowedLog2SaoOffsetScaleLumaValues is not null)
            {
                AllowedLog2SaoOffsetScaleLumaValues = allowedLog2SaoOffsetScaleLumaValues.Value;
            }

            if (allowedLog2SaoOffsetScaleChromaValues is not null)
            {
                AllowedLog2SaoOffsetScaleChromaValues = allowedLog2SaoOffsetScaleChromaValues.Value;
            }

            if (allowedLog2MaxTransformSkipBlockSizeMinus2Values is not null)
            {
                AllowedLog2MaxTransformSkipBlockSizeMinus2Values = allowedLog2MaxTransformSkipBlockSizeMinus2Values.Value;
            }

            if (allowedChromaQpOffsetListLenMinus1Values is not null)
            {
                AllowedChromaQpOffsetListLenMinus1Values = allowedChromaQpOffsetListLenMinus1Values.Value;
            }

            if (supportFlags1 is not null)
            {
                SupportFlags1 = supportFlags1.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderCodecConfigurationSupportHevcFlags SupportFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE")]
        [NativeName("Name", "MinLumaCodingUnitSize")]
        public VideoEncoderCodecConfigurationHevcCusize MinLumaCodingUnitSize;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE")]
        [NativeName("Name", "MaxLumaCodingUnitSize")]
        public VideoEncoderCodecConfigurationHevcCusize MaxLumaCodingUnitSize;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE")]
        [NativeName("Name", "MinLumaTransformUnitSize")]
        public VideoEncoderCodecConfigurationHevcTusize MinLumaTransformUnitSize;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE")]
        [NativeName("Name", "MaxLumaTransformUnitSize")]
        public VideoEncoderCodecConfigurationHevcTusize MaxLumaTransformUnitSize;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "max_transform_hierarchy_depth_inter")]
        public byte MaxTransformHierarchyDepthInter;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "max_transform_hierarchy_depth_intra")]
        public byte MaxTransformHierarchyDepthIntra;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "allowed_diff_cu_chroma_qp_offset_depth_values")]
        public uint AllowedDiffCuChromaQpOffsetDepthValues;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "allowed_log2_sao_offset_scale_luma_values")]
        public uint AllowedLog2SaoOffsetScaleLumaValues;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "allowed_log2_sao_offset_scale_chroma_values")]
        public uint AllowedLog2SaoOffsetScaleChromaValues;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "allowed_log2_max_transform_skip_block_size_minus2_values")]
        public uint AllowedLog2MaxTransformSkipBlockSizeMinus2Values;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "allowed_chroma_qp_offset_list_len_minus1_values")]
        public uint AllowedChromaQpOffsetListLenMinus1Values;
        [NativeName("Type", "UINT[6]")]
        [NativeName("Type.Name", "UINT[6]")]
        [NativeName("Name", "allowed_cb_qp_offset_list_values")]
        public fixed uint AllowedCbQpOffsetListValues[6];
        [NativeName("Type", "UINT[6]")]
        [NativeName("Type.Name", "UINT[6]")]
        [NativeName("Name", "allowed_cr_qp_offset_list_values")]
        public fixed uint AllowedCrQpOffsetListValues[6];

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS1")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS1")]
        [NativeName("Name", "SupportFlags1")]
        public VideoEncoderCodecConfigurationSupportHevcFlags1 SupportFlags1;
    }
}

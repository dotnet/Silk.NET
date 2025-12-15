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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC")]
    public unsafe partial struct VideoEncoderCodecConfigurationSupportHevc
    {
        public VideoEncoderCodecConfigurationSupportHevc
        (
            VideoEncoderCodecConfigurationSupportHevcFlags? supportFlags = null,
            VideoEncoderCodecConfigurationHevcCusize? minLumaCodingUnitSize = null,
            VideoEncoderCodecConfigurationHevcCusize? maxLumaCodingUnitSize = null,
            VideoEncoderCodecConfigurationHevcTusize? minLumaTransformUnitSize = null,
            VideoEncoderCodecConfigurationHevcTusize? maxLumaTransformUnitSize = null,
            byte? maxTransformHierarchyDepthInter = null,
            byte? maxTransformHierarchyDepthIntra = null
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
    }
}

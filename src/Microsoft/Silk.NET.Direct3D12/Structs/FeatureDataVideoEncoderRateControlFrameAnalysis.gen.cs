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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS")]
    public unsafe partial struct FeatureDataVideoEncoderRateControlFrameAnalysis
    {
        public FeatureDataVideoEncoderRateControlFrameAnalysis
        (
            uint? nodeIndex = null,
            VideoEncoderCodec? codec = null,
            VideoEncoderProfileDesc? profile = null,
            VideoEncoderLevelSetting? level = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoEncoderPictureResolutionDesc? inputResolution = null,
            VideoEncoderCodecConfiguration? codecConfiguration = null,
            VideoEncoderFrameSubregionLayoutMode? subregionFrameEncoding = null,
            VideoEncoderPictureControlSubregionsLayoutData? subregionFrameEncodingData = null,
            VideoEncoderQpmapConfiguration? qPMap = null,
            VideoEncoderDirtyRegionsConfiguration? dirtyRegions = null,
            VideoEncoderMotionSearchConfiguration? motionSearch = null,
            uint? pow2DownscaleFactor = null,
            VideoEncoderRateControlFrameAnalysisSupportFlags? supportFlags = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (codec is not null)
            {
                Codec = codec.Value;
            }

            if (profile is not null)
            {
                Profile = profile.Value;
            }

            if (level is not null)
            {
                Level = level.Value;
            }

            if (inputFormat is not null)
            {
                InputFormat = inputFormat.Value;
            }

            if (inputResolution is not null)
            {
                InputResolution = inputResolution.Value;
            }

            if (codecConfiguration is not null)
            {
                CodecConfiguration = codecConfiguration.Value;
            }

            if (subregionFrameEncoding is not null)
            {
                SubregionFrameEncoding = subregionFrameEncoding.Value;
            }

            if (subregionFrameEncodingData is not null)
            {
                SubregionFrameEncodingData = subregionFrameEncodingData.Value;
            }

            if (qPMap is not null)
            {
                QPMap = qPMap.Value;
            }

            if (dirtyRegions is not null)
            {
                DirtyRegions = dirtyRegions.Value;
            }

            if (motionSearch is not null)
            {
                MotionSearch = motionSearch.Value;
            }

            if (pow2DownscaleFactor is not null)
            {
                Pow2DownscaleFactor = pow2DownscaleFactor.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Name", "Codec")]
        public VideoEncoderCodec Codec;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Name", "Profile")]
        public VideoEncoderProfileDesc Profile;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Name", "Level")]
        public VideoEncoderLevelSetting Level;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "InputFormat")]
        public Silk.NET.DXGI.Format InputFormat;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "InputResolution")]
        public VideoEncoderPictureResolutionDesc InputResolution;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Name", "CodecConfiguration")]
        public VideoEncoderCodecConfiguration CodecConfiguration;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Name", "SubregionFrameEncoding")]
        public VideoEncoderFrameSubregionLayoutMode SubregionFrameEncoding;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA")]
        [NativeName("Name", "SubregionFrameEncodingData")]
        public VideoEncoderPictureControlSubregionsLayoutData SubregionFrameEncodingData;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_QPMAP_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_QPMAP_CONFIGURATION")]
        [NativeName("Name", "QPMap")]
        public VideoEncoderQpmapConfiguration QPMap;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_CONFIGURATION")]
        [NativeName("Name", "DirtyRegions")]
        public VideoEncoderDirtyRegionsConfiguration DirtyRegions;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_CONFIGURATION")]
        [NativeName("Name", "MotionSearch")]
        public VideoEncoderMotionSearchConfiguration MotionSearch;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Pow2DownscaleFactor")]
        public uint Pow2DownscaleFactor;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderRateControlFrameAnalysisSupportFlags SupportFlags;
    }
}

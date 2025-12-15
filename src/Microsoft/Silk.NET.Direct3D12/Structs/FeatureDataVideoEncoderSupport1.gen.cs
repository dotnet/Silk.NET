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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1")]
    public unsafe partial struct FeatureDataVideoEncoderSupport1
    {
        public FeatureDataVideoEncoderSupport1
        (
            uint? nodeIndex = null,
            VideoEncoderCodec? codec = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoEncoderCodecConfiguration? codecConfiguration = null,
            VideoEncoderSequenceGopStructure? codecGopSequence = null,
            VideoEncoderRateControl? rateControl = null,
            VideoEncoderIntraRefreshMode? intraRefresh = null,
            VideoEncoderFrameSubregionLayoutMode? subregionFrameEncoding = null,
            uint? resolutionsListCount = null,
            VideoEncoderPictureResolutionDesc* pResolutionList = null,
            uint? maxReferenceFramesInDPB = null,
            VideoEncoderValidationFlags? validationFlags = null,
            VideoEncoderSupportFlags? supportFlags = null,
            VideoEncoderProfileDesc? suggestedProfile = null,
            VideoEncoderLevelSetting? suggestedLevel = null,
            FeatureDataVideoEncoderResolutionSupportLimits* pResolutionDependentSupport = null,
            VideoEncoderPictureControlSubregionsLayoutData? subregionFrameEncodingData = null,
            uint? maxQualityVsSpeed = null
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

            if (inputFormat is not null)
            {
                InputFormat = inputFormat.Value;
            }

            if (codecConfiguration is not null)
            {
                CodecConfiguration = codecConfiguration.Value;
            }

            if (codecGopSequence is not null)
            {
                CodecGopSequence = codecGopSequence.Value;
            }

            if (rateControl is not null)
            {
                RateControl = rateControl.Value;
            }

            if (intraRefresh is not null)
            {
                IntraRefresh = intraRefresh.Value;
            }

            if (subregionFrameEncoding is not null)
            {
                SubregionFrameEncoding = subregionFrameEncoding.Value;
            }

            if (resolutionsListCount is not null)
            {
                ResolutionsListCount = resolutionsListCount.Value;
            }

            if (pResolutionList is not null)
            {
                PResolutionList = pResolutionList;
            }

            if (maxReferenceFramesInDPB is not null)
            {
                MaxReferenceFramesInDPB = maxReferenceFramesInDPB.Value;
            }

            if (validationFlags is not null)
            {
                ValidationFlags = validationFlags.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

            if (suggestedProfile is not null)
            {
                SuggestedProfile = suggestedProfile.Value;
            }

            if (suggestedLevel is not null)
            {
                SuggestedLevel = suggestedLevel.Value;
            }

            if (pResolutionDependentSupport is not null)
            {
                PResolutionDependentSupport = pResolutionDependentSupport;
            }

            if (subregionFrameEncodingData is not null)
            {
                SubregionFrameEncodingData = subregionFrameEncodingData.Value;
            }

            if (maxQualityVsSpeed is not null)
            {
                MaxQualityVsSpeed = maxQualityVsSpeed.Value;
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

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "InputFormat")]
        public Silk.NET.DXGI.Format InputFormat;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Name", "CodecConfiguration")]
        public VideoEncoderCodecConfiguration CodecConfiguration;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE")]
        [NativeName("Name", "CodecGopSequence")]
        public VideoEncoderSequenceGopStructure CodecGopSequence;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_RATE_CONTROL")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL")]
        [NativeName("Name", "RateControl")]
        public VideoEncoderRateControl RateControl;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
        [NativeName("Name", "IntraRefresh")]
        public VideoEncoderIntraRefreshMode IntraRefresh;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Name", "SubregionFrameEncoding")]
        public VideoEncoderFrameSubregionLayoutMode SubregionFrameEncoding;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ResolutionsListCount")]
        public uint ResolutionsListCount;

        [NativeName("Type", "const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
        [NativeName("Name", "pResolutionList")]
        public VideoEncoderPictureResolutionDesc* PResolutionList;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxReferenceFramesInDPB")]
        public uint MaxReferenceFramesInDPB;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_VALIDATION_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_VALIDATION_FLAGS")]
        [NativeName("Name", "ValidationFlags")]
        public VideoEncoderValidationFlags ValidationFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderSupportFlags SupportFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Name", "SuggestedProfile")]
        public VideoEncoderProfileDesc SuggestedProfile;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Name", "SuggestedLevel")]
        public VideoEncoderLevelSetting SuggestedLevel;

        [NativeName("Type", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS *")]
        [NativeName("Type.Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS *")]
        [NativeName("Name", "pResolutionDependentSupport")]
        public FeatureDataVideoEncoderResolutionSupportLimits* PResolutionDependentSupport;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA")]
        [NativeName("Name", "SubregionFrameEncodingData")]
        public VideoEncoderPictureControlSubregionsLayoutData SubregionFrameEncodingData;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxQualityVsSpeed")]
        public uint MaxQualityVsSpeed;
    }
}

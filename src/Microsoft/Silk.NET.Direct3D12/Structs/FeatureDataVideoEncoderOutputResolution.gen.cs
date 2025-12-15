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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION")]
    public unsafe partial struct FeatureDataVideoEncoderOutputResolution
    {
        public FeatureDataVideoEncoderOutputResolution
        (
            uint? nodeIndex = null,
            VideoEncoderCodec? codec = null,
            uint? resolutionRatiosCount = null,
            Silk.NET.Core.Bool32? isSupported = null,
            VideoEncoderPictureResolutionDesc? minResolutionSupported = null,
            VideoEncoderPictureResolutionDesc? maxResolutionSupported = null,
            uint? resolutionWidthMultipleRequirement = null,
            uint? resolutionHeightMultipleRequirement = null,
            VideoEncoderPictureResolutionRatioDesc* pResolutionRatios = null
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

            if (resolutionRatiosCount is not null)
            {
                ResolutionRatiosCount = resolutionRatiosCount.Value;
            }

            if (isSupported is not null)
            {
                IsSupported = isSupported.Value;
            }

            if (minResolutionSupported is not null)
            {
                MinResolutionSupported = minResolutionSupported.Value;
            }

            if (maxResolutionSupported is not null)
            {
                MaxResolutionSupported = maxResolutionSupported.Value;
            }

            if (resolutionWidthMultipleRequirement is not null)
            {
                ResolutionWidthMultipleRequirement = resolutionWidthMultipleRequirement.Value;
            }

            if (resolutionHeightMultipleRequirement is not null)
            {
                ResolutionHeightMultipleRequirement = resolutionHeightMultipleRequirement.Value;
            }

            if (pResolutionRatios is not null)
            {
                PResolutionRatios = pResolutionRatios;
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

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ResolutionRatiosCount")]
        public uint ResolutionRatiosCount;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsSupported")]
        public Silk.NET.Core.Bool32 IsSupported;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "MinResolutionSupported")]
        public VideoEncoderPictureResolutionDesc MinResolutionSupported;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "MaxResolutionSupported")]
        public VideoEncoderPictureResolutionDesc MaxResolutionSupported;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ResolutionWidthMultipleRequirement")]
        public uint ResolutionWidthMultipleRequirement;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ResolutionHeightMultipleRequirement")]
        public uint ResolutionHeightMultipleRequirement;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_RATIO_DESC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_RATIO_DESC *")]
        [NativeName("Name", "pResolutionRatios")]
        public VideoEncoderPictureResolutionRatioDesc* PResolutionRatios;
    }
}

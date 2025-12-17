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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1")]
    public unsafe partial struct FeatureDataVideoEncoderResourceRequirements1
    {
        public FeatureDataVideoEncoderResourceRequirements1
        (
            uint? nodeIndex = null,
            VideoEncoderCodec? codec = null,
            VideoEncoderProfileDesc? profile = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoEncoderPictureResolutionDesc? pictureTargetResolution = null,
            Silk.NET.Core.Bool32? isSupported = null,
            uint? compressedBitstreamBufferAccessAlignment = null,
            uint? encoderMetadataBufferAccessAlignment = null,
            uint? maxEncoderOutputMetadataBufferSize = null,
            VideoEncoderOptionalMetadataEnableFlags? optionalMetadata = null,
            VideoEncoderCodecConfiguration? codecConfiguration = null,
            VideoEncoderPictureResolutionDesc? encoderOutputMetadataQPMapTextureDimensions = null,
            VideoEncoderPictureResolutionDesc? encoderOutputMetadataSATDMapTextureDimensions = null,
            VideoEncoderPictureResolutionDesc? encoderOutputMetadataBitAllocationMapTextureDimensions = null,
            uint? encoderOutputMetadataFramePSNRComponentsNumber = null,
            uint? encoderOutputMetadataSubregionsPSNRComponentsNumber = null,
            uint? encoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize = null
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

            if (inputFormat is not null)
            {
                InputFormat = inputFormat.Value;
            }

            if (pictureTargetResolution is not null)
            {
                PictureTargetResolution = pictureTargetResolution.Value;
            }

            if (isSupported is not null)
            {
                IsSupported = isSupported.Value;
            }

            if (compressedBitstreamBufferAccessAlignment is not null)
            {
                CompressedBitstreamBufferAccessAlignment = compressedBitstreamBufferAccessAlignment.Value;
            }

            if (encoderMetadataBufferAccessAlignment is not null)
            {
                EncoderMetadataBufferAccessAlignment = encoderMetadataBufferAccessAlignment.Value;
            }

            if (maxEncoderOutputMetadataBufferSize is not null)
            {
                MaxEncoderOutputMetadataBufferSize = maxEncoderOutputMetadataBufferSize.Value;
            }

            if (optionalMetadata is not null)
            {
                OptionalMetadata = optionalMetadata.Value;
            }

            if (codecConfiguration is not null)
            {
                CodecConfiguration = codecConfiguration.Value;
            }

            if (encoderOutputMetadataQPMapTextureDimensions is not null)
            {
                EncoderOutputMetadataQPMapTextureDimensions = encoderOutputMetadataQPMapTextureDimensions.Value;
            }

            if (encoderOutputMetadataSATDMapTextureDimensions is not null)
            {
                EncoderOutputMetadataSATDMapTextureDimensions = encoderOutputMetadataSATDMapTextureDimensions.Value;
            }

            if (encoderOutputMetadataBitAllocationMapTextureDimensions is not null)
            {
                EncoderOutputMetadataBitAllocationMapTextureDimensions = encoderOutputMetadataBitAllocationMapTextureDimensions.Value;
            }

            if (encoderOutputMetadataFramePSNRComponentsNumber is not null)
            {
                EncoderOutputMetadataFramePSNRComponentsNumber = encoderOutputMetadataFramePSNRComponentsNumber.Value;
            }

            if (encoderOutputMetadataSubregionsPSNRComponentsNumber is not null)
            {
                EncoderOutputMetadataSubregionsPSNRComponentsNumber = encoderOutputMetadataSubregionsPSNRComponentsNumber.Value;
            }

            if (encoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize is not null)
            {
                EncoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize = encoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize.Value;
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

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "InputFormat")]
        public Silk.NET.DXGI.Format InputFormat;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "PictureTargetResolution")]
        public VideoEncoderPictureResolutionDesc PictureTargetResolution;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsSupported")]
        public Silk.NET.Core.Bool32 IsSupported;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CompressedBitstreamBufferAccessAlignment")]
        public uint CompressedBitstreamBufferAccessAlignment;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncoderMetadataBufferAccessAlignment")]
        public uint EncoderMetadataBufferAccessAlignment;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxEncoderOutputMetadataBufferSize")]
        public uint MaxEncoderOutputMetadataBufferSize;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS")]
        [NativeName("Name", "OptionalMetadata")]
        public VideoEncoderOptionalMetadataEnableFlags OptionalMetadata;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Name", "CodecConfiguration")]
        public VideoEncoderCodecConfiguration CodecConfiguration;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "EncoderOutputMetadataQPMapTextureDimensions")]
        public VideoEncoderPictureResolutionDesc EncoderOutputMetadataQPMapTextureDimensions;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "EncoderOutputMetadataSATDMapTextureDimensions")]
        public VideoEncoderPictureResolutionDesc EncoderOutputMetadataSATDMapTextureDimensions;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "EncoderOutputMetadataBitAllocationMapTextureDimensions")]
        public VideoEncoderPictureResolutionDesc EncoderOutputMetadataBitAllocationMapTextureDimensions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncoderOutputMetadataFramePSNRComponentsNumber")]
        public uint EncoderOutputMetadataFramePSNRComponentsNumber;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncoderOutputMetadataSubregionsPSNRComponentsNumber")]
        public uint EncoderOutputMetadataSubregionsPSNRComponentsNumber;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize")]
        public uint EncoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize;
    }
}

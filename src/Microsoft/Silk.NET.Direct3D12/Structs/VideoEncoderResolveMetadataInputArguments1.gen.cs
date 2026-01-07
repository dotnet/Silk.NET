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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1")]
    public unsafe partial struct VideoEncoderResolveMetadataInputArguments1
    {
        public VideoEncoderResolveMetadataInputArguments1
        (
            VideoEncoderCodec? encoderCodec = null,
            VideoEncoderProfileDesc? encoderProfile = null,
            Silk.NET.DXGI.Format? encoderInputFormat = null,
            VideoEncoderPictureResolutionDesc? encodedPictureEffectiveResolution = null,
            VideoEncoderEncodeOperationMetadataBuffer? hWLayoutMetadata = null,
            VideoEncoderOptionalMetadataEnableFlags? optionalMetadata = null,
            VideoEncoderCodecConfiguration? codecConfiguration = null
        ) : this()
        {
            if (encoderCodec is not null)
            {
                EncoderCodec = encoderCodec.Value;
            }

            if (encoderProfile is not null)
            {
                EncoderProfile = encoderProfile.Value;
            }

            if (encoderInputFormat is not null)
            {
                EncoderInputFormat = encoderInputFormat.Value;
            }

            if (encodedPictureEffectiveResolution is not null)
            {
                EncodedPictureEffectiveResolution = encodedPictureEffectiveResolution.Value;
            }

            if (hWLayoutMetadata is not null)
            {
                HWLayoutMetadata = hWLayoutMetadata.Value;
            }

            if (optionalMetadata is not null)
            {
                OptionalMetadata = optionalMetadata.Value;
            }

            if (codecConfiguration is not null)
            {
                CodecConfiguration = codecConfiguration.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Name", "EncoderCodec")]
        public VideoEncoderCodec EncoderCodec;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Name", "EncoderProfile")]
        public VideoEncoderProfileDesc EncoderProfile;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "EncoderInputFormat")]
        public Silk.NET.DXGI.Format EncoderInputFormat;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "EncodedPictureEffectiveResolution")]
        public VideoEncoderPictureResolutionDesc EncodedPictureEffectiveResolution;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Name", "HWLayoutMetadata")]
        public VideoEncoderEncodeOperationMetadataBuffer HWLayoutMetadata;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS")]
        [NativeName("Name", "OptionalMetadata")]
        public VideoEncoderOptionalMetadataEnableFlags OptionalMetadata;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Name", "CodecConfiguration")]
        public VideoEncoderCodecConfiguration CodecConfiguration;
    }
}

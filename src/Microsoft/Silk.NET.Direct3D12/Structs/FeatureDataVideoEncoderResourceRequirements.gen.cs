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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS")]
    public unsafe partial struct FeatureDataVideoEncoderResourceRequirements
    {
        public FeatureDataVideoEncoderResourceRequirements
        (
            uint? nodeIndex = null,
            VideoEncoderCodec? codec = null,
            VideoEncoderProfileDesc? profile = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoEncoderPictureResolutionDesc? pictureTargetResolution = null,
            Silk.NET.Core.Bool32? isSupported = null,
            uint? compressedBitstreamBufferAccessAlignment = null,
            uint? encoderMetadataBufferAccessAlignment = null,
            uint? maxEncoderOutputMetadataBufferSize = null
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
    }
}

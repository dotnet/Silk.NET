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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS1")]
    public unsafe partial struct VideoEncoderEncodeframeOutputArguments1
    {
        public VideoEncoderEncodeframeOutputArguments1
        (
            VideoEncoderCompressedBitstream1? bitstream = null,
            VideoEncoderReconstructedPicture? reconstructedPicture = null,
            VideoEncoderEncodeOperationMetadataBuffer? encoderOutputMetadata = null,
            VideoEncoderReconstructedPicture? frameAnalysisReconstructedPicture = null
        ) : this()
        {
            if (bitstream is not null)
            {
                Bitstream = bitstream.Value;
            }

            if (reconstructedPicture is not null)
            {
                ReconstructedPicture = reconstructedPicture.Value;
            }

            if (encoderOutputMetadata is not null)
            {
                EncoderOutputMetadata = encoderOutputMetadata.Value;
            }

            if (frameAnalysisReconstructedPicture is not null)
            {
                FrameAnalysisReconstructedPicture = frameAnalysisReconstructedPicture.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1")]
        [NativeName("Name", "Bitstream")]
        public VideoEncoderCompressedBitstream1 Bitstream;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE")]
        [NativeName("Name", "ReconstructedPicture")]
        public VideoEncoderReconstructedPicture ReconstructedPicture;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Name", "EncoderOutputMetadata")]
        public VideoEncoderEncodeOperationMetadataBuffer EncoderOutputMetadata;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE")]
        [NativeName("Name", "FrameAnalysisReconstructedPicture")]
        public VideoEncoderReconstructedPicture FrameAnalysisReconstructedPicture;
    }
}

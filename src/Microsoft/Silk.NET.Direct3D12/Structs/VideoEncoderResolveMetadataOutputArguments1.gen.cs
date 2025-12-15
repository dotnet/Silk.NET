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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RESOLVE_METADATA_OUTPUT_ARGUMENTS1")]
    public unsafe partial struct VideoEncoderResolveMetadataOutputArguments1
    {
        public VideoEncoderResolveMetadataOutputArguments1
        (
            VideoEncoderEncodeOperationMetadataBuffer? resolvedLayoutMetadata = null,
            ID3D12Resource* pOutputQPMap = null,
            ID3D12Resource* pOutputSATDMap = null,
            ID3D12Resource* pOutputBitAllocationMap = null,
            VideoEncoderEncodeOperationMetadataBuffer? resolvedFramePSNRData = null,
            VideoEncoderEncodeOperationMetadataBuffer? resolvedSubregionsPSNRData = null
        ) : this()
        {
            if (resolvedLayoutMetadata is not null)
            {
                ResolvedLayoutMetadata = resolvedLayoutMetadata.Value;
            }

            if (pOutputQPMap is not null)
            {
                POutputQPMap = pOutputQPMap;
            }

            if (pOutputSATDMap is not null)
            {
                POutputSATDMap = pOutputSATDMap;
            }

            if (pOutputBitAllocationMap is not null)
            {
                POutputBitAllocationMap = pOutputBitAllocationMap;
            }

            if (resolvedFramePSNRData is not null)
            {
                ResolvedFramePSNRData = resolvedFramePSNRData.Value;
            }

            if (resolvedSubregionsPSNRData is not null)
            {
                ResolvedSubregionsPSNRData = resolvedSubregionsPSNRData.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Name", "ResolvedLayoutMetadata")]
        public VideoEncoderEncodeOperationMetadataBuffer ResolvedLayoutMetadata;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOutputQPMap")]
        public ID3D12Resource* POutputQPMap;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOutputSATDMap")]
        public ID3D12Resource* POutputSATDMap;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOutputBitAllocationMap")]
        public ID3D12Resource* POutputBitAllocationMap;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Name", "ResolvedFramePSNRData")]
        public VideoEncoderEncodeOperationMetadataBuffer ResolvedFramePSNRData;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Name", "ResolvedSubregionsPSNRData")]
        public VideoEncoderEncodeOperationMetadataBuffer ResolvedSubregionsPSNRData;
    }
}

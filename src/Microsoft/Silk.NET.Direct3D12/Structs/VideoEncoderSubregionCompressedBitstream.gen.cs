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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM")]
    public unsafe partial struct VideoEncoderSubregionCompressedBitstream
    {
        public VideoEncoderSubregionCompressedBitstream
        (
            VideoEncoderSubregionCompressedBitstreamBufferMode? bufferMode = null,
            uint? expectedSubregionCount = null,
            ulong* pSubregionBitstreamsBaseOffsets = null,
            ID3D12Resource** ppSubregionBitstreams = null,
            ID3D12Resource** ppSubregionSizes = null,
            ID3D12Resource** ppSubregionOffsets = null,
            ID3D12Fence** ppSubregionFences = null,
            ulong* pSubregionFenceValues = null
        ) : this()
        {
            if (bufferMode is not null)
            {
                BufferMode = bufferMode.Value;
            }

            if (expectedSubregionCount is not null)
            {
                ExpectedSubregionCount = expectedSubregionCount.Value;
            }

            if (pSubregionBitstreamsBaseOffsets is not null)
            {
                PSubregionBitstreamsBaseOffsets = pSubregionBitstreamsBaseOffsets;
            }

            if (ppSubregionBitstreams is not null)
            {
                PpSubregionBitstreams = ppSubregionBitstreams;
            }

            if (ppSubregionSizes is not null)
            {
                PpSubregionSizes = ppSubregionSizes;
            }

            if (ppSubregionOffsets is not null)
            {
                PpSubregionOffsets = ppSubregionOffsets;
            }

            if (ppSubregionFences is not null)
            {
                PpSubregionFences = ppSubregionFences;
            }

            if (pSubregionFenceValues is not null)
            {
                PSubregionFenceValues = pSubregionFenceValues;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE")]
        [NativeName("Name", "BufferMode")]
        public VideoEncoderSubregionCompressedBitstreamBufferMode BufferMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ExpectedSubregionCount")]
        public uint ExpectedSubregionCount;

        [NativeName("Type", "UINT64 *")]
        [NativeName("Type.Name", "UINT64 *")]
        [NativeName("Name", "pSubregionBitstreamsBaseOffsets")]
        public ulong* PSubregionBitstreamsBaseOffsets;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppSubregionBitstreams")]
        public ID3D12Resource** PpSubregionBitstreams;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppSubregionSizes")]
        public ID3D12Resource** PpSubregionSizes;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppSubregionOffsets")]
        public ID3D12Resource** PpSubregionOffsets;

        [NativeName("Type", "ID3D12Fence **")]
        [NativeName("Type.Name", "ID3D12Fence **")]
        [NativeName("Name", "ppSubregionFences")]
        public ID3D12Fence** PpSubregionFences;

        [NativeName("Type", "UINT64 *")]
        [NativeName("Type.Name", "UINT64 *")]
        [NativeName("Name", "pSubregionFenceValues")]
        public ulong* PSubregionFenceValues;
    }
}

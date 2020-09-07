// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_DESC2")]
    public unsafe partial struct VideoDecoderBufferDesc2
    {
        public VideoDecoderBufferDesc2
        (
            VideoDecoderBufferType bufferType = default,
            uint dataOffset = default,
            uint dataSize = default,
            void* pIV = default,
            uint iVSize = default,
            VideoDecoderSubSampleMappingBlock* pSubSampleMappingBlock = default,
            uint subSampleMappingCount = default,
            uint cBlocksStripeEncrypted = default,
            uint cBlocksStripeClear = default
        )
        {
            BufferType = bufferType;
            DataOffset = dataOffset;
            DataSize = dataSize;
            PIV = pIV;
            IVSize = iVSize;
            PSubSampleMappingBlock = pSubSampleMappingBlock;
            SubSampleMappingCount = subSampleMappingCount;
            CBlocksStripeEncrypted = cBlocksStripeEncrypted;
            CBlocksStripeClear = cBlocksStripeClear;
        }


        [NativeName("Type", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
        [NativeName("Type.Name", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
        [NativeName("Name", "BufferType")]
        public VideoDecoderBufferType BufferType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataOffset")]
        public uint DataOffset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pIV")]
        public void* PIV;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IVSize")]
        public uint IVSize;

        [NativeName("Type", "D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK *")]
        [NativeName("Type.Name", "D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK *")]
        [NativeName("Name", "pSubSampleMappingBlock")]
        public VideoDecoderSubSampleMappingBlock* PSubSampleMappingBlock;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubSampleMappingCount")]
        public uint SubSampleMappingCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cBlocksStripeEncrypted")]
        public uint CBlocksStripeEncrypted;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cBlocksStripeClear")]
        public uint CBlocksStripeClear;
    }
}

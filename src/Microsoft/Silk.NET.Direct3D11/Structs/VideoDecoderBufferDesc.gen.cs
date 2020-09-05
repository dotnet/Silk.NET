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
    [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_DESC")]
    public unsafe partial struct VideoDecoderBufferDesc
    {
        public VideoDecoderBufferDesc
        (
            VideoDecoderBufferType bufferType = default,
            uint bufferIndex = default,
            uint dataOffset = default,
            uint dataSize = default,
            uint firstMBaddress = default,
            uint numMBsInBuffer = default,
            uint width = default,
            uint height = default,
            uint stride = default,
            uint reservedBits = default,
            void* pIV = default,
            uint iVSize = default,
            int partialEncryption = default,
            EncryptedBlockInfo encryptedBlockInfo = default
        )
        {
            BufferType = bufferType;
            BufferIndex = bufferIndex;
            DataOffset = dataOffset;
            DataSize = dataSize;
            FirstMBaddress = firstMBaddress;
            NumMBsInBuffer = numMBsInBuffer;
            Width = width;
            Height = height;
            Stride = stride;
            ReservedBits = reservedBits;
            PIV = pIV;
            IVSize = iVSize;
            PartialEncryption = partialEncryption;
            EncryptedBlockInfo = encryptedBlockInfo;
        }


        [NativeName("Type", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
        [NativeName("Type.Name", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
        [NativeName("Name", "BufferType")]
        public VideoDecoderBufferType BufferType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BufferIndex")]
        public uint BufferIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataOffset")]
        public uint DataOffset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstMBaddress")]
        public uint FirstMBaddress;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumMBsInBuffer")]
        public uint NumMBsInBuffer;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Stride")]
        public uint Stride;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReservedBits")]
        public uint ReservedBits;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pIV")]
        public void* PIV;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IVSize")]
        public uint IVSize;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PartialEncryption")]
        public int PartialEncryption;

        [NativeName("Type", "D3D11_ENCRYPTED_BLOCK_INFO")]
        [NativeName("Type.Name", "D3D11_ENCRYPTED_BLOCK_INFO")]
        [NativeName("Name", "EncryptedBlockInfo")]
        public EncryptedBlockInfo EncryptedBlockInfo;
    }
}

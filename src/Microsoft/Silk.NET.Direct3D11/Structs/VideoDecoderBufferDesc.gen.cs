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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_DESC")]
    public unsafe partial struct VideoDecoderBufferDesc
    {
        public VideoDecoderBufferDesc
        (
            VideoDecoderBufferType? bufferType = null,
            uint? bufferIndex = null,
            uint? dataOffset = null,
            uint? dataSize = null,
            uint? firstMBaddress = null,
            uint? numMBsInBuffer = null,
            uint? width = null,
            uint? height = null,
            uint? stride = null,
            uint? reservedBits = null,
            void* pIV = null,
            uint? iVSize = null,
            Silk.NET.Core.Bool32? partialEncryption = null,
            EncryptedBlockInfo? encryptedBlockInfo = null
        ) : this()
        {
            if (bufferType is not null)
            {
                BufferType = bufferType.Value;
            }

            if (bufferIndex is not null)
            {
                BufferIndex = bufferIndex.Value;
            }

            if (dataOffset is not null)
            {
                DataOffset = dataOffset.Value;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (firstMBaddress is not null)
            {
                FirstMBaddress = firstMBaddress.Value;
            }

            if (numMBsInBuffer is not null)
            {
                NumMBsInBuffer = numMBsInBuffer.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (reservedBits is not null)
            {
                ReservedBits = reservedBits.Value;
            }

            if (pIV is not null)
            {
                PIV = pIV;
            }

            if (iVSize is not null)
            {
                IVSize = iVSize.Value;
            }

            if (partialEncryption is not null)
            {
                PartialEncryption = partialEncryption.Value;
            }

            if (encryptedBlockInfo is not null)
            {
                EncryptedBlockInfo = encryptedBlockInfo.Value;
            }
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
        public Silk.NET.Core.Bool32 PartialEncryption;

        [NativeName("Type", "D3D11_ENCRYPTED_BLOCK_INFO")]
        [NativeName("Type.Name", "D3D11_ENCRYPTED_BLOCK_INFO")]
        [NativeName("Name", "EncryptedBlockInfo")]
        public EncryptedBlockInfo EncryptedBlockInfo;
    }
}

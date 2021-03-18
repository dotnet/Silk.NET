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
    [NativeName("Name", "D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION")]
    public unsafe partial struct VideoDecoderBeginFrameCryptoSession
    {
        public VideoDecoderBeginFrameCryptoSession
        (
            ID3D11CryptoSession* pCryptoSession = null,
            uint? blobSize = null,
            void* pBlob = null,
            Guid* pKeyInfoId = null,
            uint? privateDataSize = null,
            void* pPrivateData = null
        ) : this()
        {
            if (pCryptoSession is not null)
            {
                PCryptoSession = pCryptoSession;
            }

            if (blobSize is not null)
            {
                BlobSize = blobSize.Value;
            }

            if (pBlob is not null)
            {
                PBlob = pBlob;
            }

            if (pKeyInfoId is not null)
            {
                PKeyInfoId = pKeyInfoId;
            }

            if (privateDataSize is not null)
            {
                PrivateDataSize = privateDataSize.Value;
            }

            if (pPrivateData is not null)
            {
                PPrivateData = pPrivateData;
            }
        }


        [NativeName("Type", "ID3D11CryptoSession *")]
        [NativeName("Type.Name", "ID3D11CryptoSession *")]
        [NativeName("Name", "pCryptoSession")]
        public ID3D11CryptoSession* PCryptoSession;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BlobSize")]
        public uint BlobSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pBlob")]
        public void* PBlob;

        [NativeName("Type", "GUID *")]
        [NativeName("Type.Name", "GUID *")]
        [NativeName("Name", "pKeyInfoId")]
        public Guid* PKeyInfoId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateDataSize")]
        public uint PrivateDataSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pPrivateData")]
        public void* PPrivateData;
    }
}

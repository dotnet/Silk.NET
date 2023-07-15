// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION
{
    /// <include file='D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.pCryptoSession"]/*'/>
    public ID3D11CryptoSession* pCryptoSession;
    /// <include file='D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.BlobSize"]/*'/>
    public uint BlobSize;
    /// <include file='D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.pBlob"]/*'/>
    public void* pBlob;
    /// <include file='D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.pKeyInfoId"]/*'/>
    public Guid* pKeyInfoId;
    /// <include file='D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.PrivateDataSize"]/*'/>
    public uint PrivateDataSize;
    /// <include file='D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION.pPrivateData"]/*'/>
    public void* pPrivateData;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct D3D11_VIDEO_DECODER_EXTENSION
{
    /// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION.Function"]/*' />
    public uint Function;

    /// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION.pPrivateInputData"]/*' />
    public void* pPrivateInputData;

    /// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION.PrivateInputDataSize"]/*' />
    public uint PrivateInputDataSize;

    /// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION.pPrivateOutputData"]/*' />
    public void* pPrivateOutputData;

    /// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION.PrivateOutputDataSize"]/*' />
    public uint PrivateOutputDataSize;

    /// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION.ResourceCount"]/*' />
    public uint ResourceCount;

    /// <include file='D3D11_VIDEO_DECODER_EXTENSION.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_EXTENSION.ppResourceList"]/*' />
    public ID3D11Resource** ppResourceList;
}

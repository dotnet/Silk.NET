// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_DESC"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_DECODER_DESC
{
    /// <include file='D3D11_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_DESC.Guid"]/*'/>
    public Guid Guid;
    /// <include file='D3D11_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_DESC.SampleWidth"]/*'/>
    public uint SampleWidth;
    /// <include file='D3D11_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_DESC.SampleHeight"]/*'/>
    public uint SampleHeight;
    /// <include file='D3D11_VIDEO_DECODER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_DESC.OutputFormat"]/*'/>
    public DXGI_FORMAT OutputFormat;
}
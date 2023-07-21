// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_SAMPLE_DESC.xml' path='doc/member[@name="D3D11_VIDEO_SAMPLE_DESC"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct D3D11_VIDEO_SAMPLE_DESC
{
    /// <include file='D3D11_VIDEO_SAMPLE_DESC.xml' path='doc/member[@name="D3D11_VIDEO_SAMPLE_DESC.Width"]/*' />
    public uint Width;

    /// <include file='D3D11_VIDEO_SAMPLE_DESC.xml' path='doc/member[@name="D3D11_VIDEO_SAMPLE_DESC.Height"]/*' />
    public uint Height;

    /// <include file='D3D11_VIDEO_SAMPLE_DESC.xml' path='doc/member[@name="D3D11_VIDEO_SAMPLE_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D11_VIDEO_SAMPLE_DESC.xml' path='doc/member[@name="D3D11_VIDEO_SAMPLE_DESC.ColorSpace"]/*' />
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
}

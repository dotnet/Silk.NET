// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_PROCESSOR_CONTENT_DESC
{
    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.InputFrameFormat"]/*' />
    public D3D11_VIDEO_FRAME_FORMAT InputFrameFormat;

    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.InputFrameRate"]/*' />
    public DXGI_RATIONAL InputFrameRate;

    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.InputWidth"]/*' />
    public uint InputWidth;

    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.InputHeight"]/*' />
    public uint InputHeight;

    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.OutputFrameRate"]/*' />
    public DXGI_RATIONAL OutputFrameRate;

    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.OutputWidth"]/*' />
    public uint OutputWidth;

    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.OutputHeight"]/*' />
    public uint OutputHeight;

    /// <include file='D3D11_VIDEO_PROCESSOR_CONTENT_DESC.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CONTENT_DESC.Usage"]/*' />
    public D3D11_VIDEO_USAGE Usage;
}

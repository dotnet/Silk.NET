// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_FRAME_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_FRAME_FORMAT"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_FRAME_FORMAT
{
    /// <include file='D3D11_VIDEO_FRAME_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_FRAME_FORMAT.D3D11_VIDEO_FRAME_FORMAT_PROGRESSIVE"]/*' />
    D3D11_VIDEO_FRAME_FORMAT_PROGRESSIVE = 0,

    /// <include file='D3D11_VIDEO_FRAME_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_FRAME_FORMAT.D3D11_VIDEO_FRAME_FORMAT_INTERLACED_TOP_FIELD_FIRST"]/*' />
    D3D11_VIDEO_FRAME_FORMAT_INTERLACED_TOP_FIELD_FIRST = 1,

    /// <include file='D3D11_VIDEO_FRAME_FORMAT.xml' path='doc/member[@name="D3D11_VIDEO_FRAME_FORMAT.D3D11_VIDEO_FRAME_FORMAT_INTERLACED_BOTTOM_FIELD_FIRST"]/*' />
    D3D11_VIDEO_FRAME_FORMAT_INTERLACED_BOTTOM_FIELD_FIRST = 2,
}

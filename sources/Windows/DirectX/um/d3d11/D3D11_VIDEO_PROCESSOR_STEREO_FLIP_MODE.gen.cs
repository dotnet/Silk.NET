// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE
{
    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE.D3D11_VIDEO_PROCESSOR_STEREO_FLIP_NONE"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FLIP_NONE = 0,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE.D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME0"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME0 = 1,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE.D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME1"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME1 = 2,
}

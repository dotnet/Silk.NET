// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ROTATION"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_ROTATION
{
    /// <include file='D3D11_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ROTATION.D3D11_VIDEO_PROCESSOR_ROTATION_IDENTITY"]/*' />
    D3D11_VIDEO_PROCESSOR_ROTATION_IDENTITY = 0,

    /// <include file='D3D11_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ROTATION.D3D11_VIDEO_PROCESSOR_ROTATION_90"]/*' />
    D3D11_VIDEO_PROCESSOR_ROTATION_90 = 1,

    /// <include file='D3D11_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ROTATION.D3D11_VIDEO_PROCESSOR_ROTATION_180"]/*' />
    D3D11_VIDEO_PROCESSOR_ROTATION_180 = 2,

    /// <include file='D3D11_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ROTATION.D3D11_VIDEO_PROCESSOR_ROTATION_270"]/*' />
    D3D11_VIDEO_PROCESSOR_ROTATION_270 = 3,
}

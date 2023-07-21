// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_STEREO_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_CAPS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_STEREO_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_CAPS.D3D11_VIDEO_PROCESSOR_STEREO_CAPS_MONO_OFFSET"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_MONO_OFFSET = 0x1,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_CAPS.D3D11_VIDEO_PROCESSOR_STEREO_CAPS_ROW_INTERLEAVED"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_ROW_INTERLEAVED = 0x2,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_CAPS.D3D11_VIDEO_PROCESSOR_STEREO_CAPS_COLUMN_INTERLEAVED"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_COLUMN_INTERLEAVED = 0x4,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_CAPS.D3D11_VIDEO_PROCESSOR_STEREO_CAPS_CHECKERBOARD"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_CHECKERBOARD = 0x8,

    /// <include file='D3D11_VIDEO_PROCESSOR_STEREO_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STEREO_CAPS.D3D11_VIDEO_PROCESSOR_STEREO_CAPS_FLIP_MODE"]/*' />
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_FLIP_MODE = 0x10,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG"]/*' />
[Flags]
public enum D3D11_BIND_FLAG
{
    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_VERTEX_BUFFER"]/*' />
    D3D11_BIND_VERTEX_BUFFER = 0x1,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_INDEX_BUFFER"]/*' />
    D3D11_BIND_INDEX_BUFFER = 0x2,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_CONSTANT_BUFFER"]/*' />
    D3D11_BIND_CONSTANT_BUFFER = 0x4,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE"]/*' />
    D3D11_BIND_SHADER_RESOURCE = 0x8,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_STREAM_OUTPUT"]/*' />
    D3D11_BIND_STREAM_OUTPUT = 0x10,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_RENDER_TARGET"]/*' />
    D3D11_BIND_RENDER_TARGET = 0x20,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_DEPTH_STENCIL"]/*' />
    D3D11_BIND_DEPTH_STENCIL = 0x40,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_UNORDERED_ACCESS"]/*' />
    D3D11_BIND_UNORDERED_ACCESS = 0x80,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_DECODER"]/*' />
    D3D11_BIND_DECODER = 0x200,

    /// <include file='D3D11_BIND_FLAG.xml' path='doc/member[@name="D3D11_BIND_FLAG.D3D11_BIND_VIDEO_ENCODER"]/*' />
    D3D11_BIND_VIDEO_ENCODER = 0x400,
}

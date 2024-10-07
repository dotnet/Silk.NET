// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS"]/*'/>
[Flags]
public enum D3D12_RESOURCE_FLAGS
{
    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_NONE"]/*'/>

    D3D12_RESOURCE_FLAG_NONE = 0,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET"]/*'/>

    D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET = 0x1,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL"]/*'/>

    D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL = 0x2,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS"]/*'/>

    D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS = 0x4,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE"]/*'/>

    D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE = 0x8,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER"]/*'/>

    D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER = 0x10,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS"]/*'/>

    D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS = 0x20,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY"]/*'/>

    D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY = 0x40,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY"]/*'/>

    D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY = 0x80,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_RAYTRACING_ACCELERATION_STRUCTURE"]/*'/>

    D3D12_RESOURCE_FLAG_RAYTRACING_ACCELERATION_STRUCTURE = 0x100,
}

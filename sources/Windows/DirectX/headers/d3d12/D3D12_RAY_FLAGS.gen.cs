// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS"]/*' />
[Flags]
public enum D3D12_RAY_FLAGS
{
    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_NONE"]/*' />
    D3D12_RAY_FLAG_NONE = 0,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_FORCE_OPAQUE"]/*' />
    D3D12_RAY_FLAG_FORCE_OPAQUE = 0x1,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_FORCE_NON_OPAQUE"]/*' />
    D3D12_RAY_FLAG_FORCE_NON_OPAQUE = 0x2,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH"]/*' />
    D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH = 0x4,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER"]/*' />
    D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER = 0x8,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES"]/*' />
    D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES = 0x10,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES"]/*' />
    D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES = 0x20,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_OPAQUE"]/*' />
    D3D12_RAY_FLAG_CULL_OPAQUE = 0x40,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_NON_OPAQUE"]/*' />
    D3D12_RAY_FLAG_CULL_NON_OPAQUE = 0x80,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_SKIP_TRIANGLES"]/*' />
    D3D12_RAY_FLAG_SKIP_TRIANGLES = 0x100,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES"]/*' />
    D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES = 0x200,
}

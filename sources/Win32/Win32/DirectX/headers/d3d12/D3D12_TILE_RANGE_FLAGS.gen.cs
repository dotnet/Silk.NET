// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_TILE_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_TILE_RANGE_FLAGS"]/*'/>
[Flags]
public enum D3D12_TILE_RANGE_FLAGS
{
    /// <include file='D3D12_TILE_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_TILE_RANGE_FLAGS.D3D12_TILE_RANGE_FLAG_NONE"]/*'/>

    D3D12_TILE_RANGE_FLAG_NONE = 0,

    /// <include file='D3D12_TILE_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_TILE_RANGE_FLAGS.D3D12_TILE_RANGE_FLAG_NULL"]/*'/>

    D3D12_TILE_RANGE_FLAG_NULL = 1,

    /// <include file='D3D12_TILE_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_TILE_RANGE_FLAGS.D3D12_TILE_RANGE_FLAG_SKIP"]/*'/>

    D3D12_TILE_RANGE_FLAG_SKIP = 2,

    /// <include file='D3D12_TILE_RANGE_FLAGS.xml' path='doc/member[@name="D3D12_TILE_RANGE_FLAGS.D3D12_TILE_RANGE_FLAG_REUSE_SINGLE_TILE"]/*'/>

    D3D12_TILE_RANGE_FLAG_REUSE_SINGLE_TILE = 4,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_TILE_RANGE_FLAG.xml' path='doc/member[@name="D3D11_TILE_RANGE_FLAG"]/*' />
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum D3D11_TILE_RANGE_FLAG
{
    /// <include file='D3D11_TILE_RANGE_FLAG.xml' path='doc/member[@name="D3D11_TILE_RANGE_FLAG.D3D11_TILE_RANGE_NULL"]/*' />
    D3D11_TILE_RANGE_NULL = 0x1,

    /// <include file='D3D11_TILE_RANGE_FLAG.xml' path='doc/member[@name="D3D11_TILE_RANGE_FLAG.D3D11_TILE_RANGE_SKIP"]/*' />
    D3D11_TILE_RANGE_SKIP = 0x2,

    /// <include file='D3D11_TILE_RANGE_FLAG.xml' path='doc/member[@name="D3D11_TILE_RANGE_FLAG.D3D11_TILE_RANGE_REUSE_SINGLE_TILE"]/*' />
    D3D11_TILE_RANGE_REUSE_SINGLE_TILE = 0x4,
}

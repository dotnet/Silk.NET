// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D10_MAP.xml' path='doc/member[@name="D3D10_MAP"]/*' />
public enum D3D10_MAP
{
    /// <include file='D3D10_MAP.xml' path='doc/member[@name="D3D10_MAP.D3D10_MAP_READ"]/*' />
    D3D10_MAP_READ = 1,

    /// <include file='D3D10_MAP.xml' path='doc/member[@name="D3D10_MAP.D3D10_MAP_WRITE"]/*' />
    D3D10_MAP_WRITE = 2,

    /// <include file='D3D10_MAP.xml' path='doc/member[@name="D3D10_MAP.D3D10_MAP_READ_WRITE"]/*' />
    D3D10_MAP_READ_WRITE = 3,

    /// <include file='D3D10_MAP.xml' path='doc/member[@name="D3D10_MAP.D3D10_MAP_WRITE_DISCARD"]/*' />
    D3D10_MAP_WRITE_DISCARD = 4,

    /// <include file='D3D10_MAP.xml' path='doc/member[@name="D3D10_MAP.D3D10_MAP_WRITE_NO_OVERWRITE"]/*' />
    D3D10_MAP_WRITE_NO_OVERWRITE = 5,
}

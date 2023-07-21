// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP"]/*' />
public enum D3D10_STENCIL_OP
{
    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_KEEP"]/*' />
    D3D10_STENCIL_OP_KEEP = 1,

    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_ZERO"]/*' />
    D3D10_STENCIL_OP_ZERO = 2,

    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_REPLACE"]/*' />
    D3D10_STENCIL_OP_REPLACE = 3,

    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_INCR_SAT"]/*' />
    D3D10_STENCIL_OP_INCR_SAT = 4,

    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_DECR_SAT"]/*' />
    D3D10_STENCIL_OP_DECR_SAT = 5,

    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_INVERT"]/*' />
    D3D10_STENCIL_OP_INVERT = 6,

    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_INCR"]/*' />
    D3D10_STENCIL_OP_INCR = 7,

    /// <include file='D3D10_STENCIL_OP.xml' path='doc/member[@name="D3D10_STENCIL_OP.D3D10_STENCIL_OP_DECR"]/*' />
    D3D10_STENCIL_OP_DECR = 8,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP"]/*'/>
public enum D3D12_STENCIL_OP
{
    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_KEEP"]/*'/>

    D3D12_STENCIL_OP_KEEP = 1,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_ZERO"]/*'/>

    D3D12_STENCIL_OP_ZERO = 2,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_REPLACE"]/*'/>

    D3D12_STENCIL_OP_REPLACE = 3,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_INCR_SAT"]/*'/>

    D3D12_STENCIL_OP_INCR_SAT = 4,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_DECR_SAT"]/*'/>

    D3D12_STENCIL_OP_DECR_SAT = 5,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_INVERT"]/*'/>

    D3D12_STENCIL_OP_INVERT = 6,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_INCR"]/*'/>

    D3D12_STENCIL_OP_INCR = 7,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_DECR"]/*'/>

    D3D12_STENCIL_OP_DECR = 8,
}

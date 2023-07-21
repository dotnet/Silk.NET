// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP"]/*' />
public enum D3D12_LOGIC_OP
{
    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_CLEAR"]/*' />
    D3D12_LOGIC_OP_CLEAR = 0,

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_SET"]/*' />
    D3D12_LOGIC_OP_SET = (D3D12_LOGIC_OP_CLEAR + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_COPY"]/*' />
    D3D12_LOGIC_OP_COPY = (D3D12_LOGIC_OP_SET + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_COPY_INVERTED"]/*' />
    D3D12_LOGIC_OP_COPY_INVERTED = (D3D12_LOGIC_OP_COPY + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_NOOP"]/*' />
    D3D12_LOGIC_OP_NOOP = (D3D12_LOGIC_OP_COPY_INVERTED + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_INVERT"]/*' />
    D3D12_LOGIC_OP_INVERT = (D3D12_LOGIC_OP_NOOP + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_AND"]/*' />
    D3D12_LOGIC_OP_AND = (D3D12_LOGIC_OP_INVERT + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_NAND"]/*' />
    D3D12_LOGIC_OP_NAND = (D3D12_LOGIC_OP_AND + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_OR"]/*' />
    D3D12_LOGIC_OP_OR = (D3D12_LOGIC_OP_NAND + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_NOR"]/*' />
    D3D12_LOGIC_OP_NOR = (D3D12_LOGIC_OP_OR + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_XOR"]/*' />
    D3D12_LOGIC_OP_XOR = (D3D12_LOGIC_OP_NOR + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_EQUIV"]/*' />
    D3D12_LOGIC_OP_EQUIV = (D3D12_LOGIC_OP_XOR + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_AND_REVERSE"]/*' />
    D3D12_LOGIC_OP_AND_REVERSE = (D3D12_LOGIC_OP_EQUIV + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_AND_INVERTED"]/*' />
    D3D12_LOGIC_OP_AND_INVERTED = (D3D12_LOGIC_OP_AND_REVERSE + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_OR_REVERSE"]/*' />
    D3D12_LOGIC_OP_OR_REVERSE = (D3D12_LOGIC_OP_AND_INVERTED + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_OR_INVERTED"]/*' />
    D3D12_LOGIC_OP_OR_INVERTED = (D3D12_LOGIC_OP_OR_REVERSE + 1),
}

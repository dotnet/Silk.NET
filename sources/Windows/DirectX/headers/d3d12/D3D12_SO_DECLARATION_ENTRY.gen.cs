// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D12_SO_DECLARATION_ENTRY"]/*' />
public unsafe partial struct D3D12_SO_DECLARATION_ENTRY
{
    /// <include file='D3D12_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D12_SO_DECLARATION_ENTRY.Stream"]/*' />
    public uint Stream;

    /// <include file='D3D12_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D12_SO_DECLARATION_ENTRY.SemanticName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;

    /// <include file='D3D12_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D12_SO_DECLARATION_ENTRY.SemanticIndex"]/*' />
    public uint SemanticIndex;

    /// <include file='D3D12_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D12_SO_DECLARATION_ENTRY.StartComponent"]/*' />
    public byte StartComponent;

    /// <include file='D3D12_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D12_SO_DECLARATION_ENTRY.ComponentCount"]/*' />
    public byte ComponentCount;

    /// <include file='D3D12_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D12_SO_DECLARATION_ENTRY.OutputSlot"]/*' />
    public byte OutputSlot;
}

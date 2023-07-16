// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D11_SO_DECLARATION_ENTRY"]/*'/>
public unsafe partial struct D3D11_SO_DECLARATION_ENTRY
{
    /// <include file='D3D11_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D11_SO_DECLARATION_ENTRY.Stream"]/*'/>
    public uint Stream;
    /// <include file='D3D11_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D11_SO_DECLARATION_ENTRY.SemanticName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;
    /// <include file='D3D11_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D11_SO_DECLARATION_ENTRY.SemanticIndex"]/*'/>
    public uint SemanticIndex;
    /// <include file='D3D11_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D11_SO_DECLARATION_ENTRY.StartComponent"]/*'/>
    public byte StartComponent;
    /// <include file='D3D11_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D11_SO_DECLARATION_ENTRY.ComponentCount"]/*'/>
    public byte ComponentCount;
    /// <include file='D3D11_SO_DECLARATION_ENTRY.xml' path='doc/member[@name="D3D11_SO_DECLARATION_ENTRY.OutputSlot"]/*'/>
    public byte OutputSlot;
}
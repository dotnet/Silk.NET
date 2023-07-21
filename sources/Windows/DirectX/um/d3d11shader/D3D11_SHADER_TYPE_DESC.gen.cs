// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC"]/*' />
public unsafe partial struct D3D11_SHADER_TYPE_DESC
{
    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Class"]/*' />
    public D3D_SHADER_VARIABLE_CLASS Class;

    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Type"]/*' />
    public D3D_SHADER_VARIABLE_TYPE Type;

    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Rows"]/*' />
    public uint Rows;

    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Columns"]/*' />
    public uint Columns;

    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Elements"]/*' />
    public uint Elements;

    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Members"]/*' />
    public uint Members;

    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Offset"]/*' />
    public uint Offset;

    /// <include file='D3D11_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D11_SHADER_TYPE_DESC.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
}

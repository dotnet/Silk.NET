// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D10_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D10_SHADER_BUFFER_DESC"]/*' />
public unsafe partial struct D3D10_SHADER_BUFFER_DESC
{
    /// <include file='D3D10_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D10_SHADER_BUFFER_DESC.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D10_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D10_SHADER_BUFFER_DESC.Type"]/*' />
    [NativeTypeName("D3D10_CBUFFER_TYPE")]
    public D3D_CBUFFER_TYPE Type;

    /// <include file='D3D10_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D10_SHADER_BUFFER_DESC.Variables"]/*' />
    public uint Variables;

    /// <include file='D3D10_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D10_SHADER_BUFFER_DESC.Size"]/*' />
    public uint Size;

    /// <include file='D3D10_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D10_SHADER_BUFFER_DESC.uFlags"]/*' />
    public uint uFlags;
}

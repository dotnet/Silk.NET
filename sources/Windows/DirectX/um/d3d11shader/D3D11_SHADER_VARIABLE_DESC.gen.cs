// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC"]/*' />
public unsafe partial struct D3D11_SHADER_VARIABLE_DESC
{
    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.StartOffset"]/*' />
    public uint StartOffset;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.Size"]/*' />
    public uint Size;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.uFlags"]/*' />
    public uint uFlags;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.DefaultValue"]/*' />
    [NativeTypeName("LPVOID")]
    public void* DefaultValue;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.StartTexture"]/*' />
    public uint StartTexture;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.TextureSize"]/*' />
    public uint TextureSize;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.StartSampler"]/*' />
    public uint StartSampler;

    /// <include file='D3D11_SHADER_VARIABLE_DESC.xml' path='doc/member[@name="D3D11_SHADER_VARIABLE_DESC.SamplerSize"]/*' />
    public uint SamplerSize;
}

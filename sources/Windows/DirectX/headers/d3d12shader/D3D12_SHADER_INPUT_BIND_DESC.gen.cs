// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC"]/*'/>
public unsafe partial struct D3D12_SHADER_INPUT_BIND_DESC
{
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Name"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Type"]/*'/>
    public D3D_SHADER_INPUT_TYPE Type;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.BindPoint"]/*'/>
    public uint BindPoint;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.BindCount"]/*'/>
    public uint BindCount;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.uFlags"]/*'/>
    public uint uFlags;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.ReturnType"]/*'/>
    public D3D_RESOURCE_RETURN_TYPE ReturnType;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Dimension"]/*'/>
    public D3D_SRV_DIMENSION Dimension;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.NumSamples"]/*'/>
    public uint NumSamples;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Space"]/*'/>
    public uint Space;
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.uID"]/*'/>
    public uint uID;
}
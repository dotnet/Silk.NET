// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC"]/*'/>
public unsafe partial struct D3D12_SHADER_TYPE_DESC
{
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Class"]/*'/>
    public D3D_SHADER_VARIABLE_CLASS Class;
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Type"]/*'/>
    public D3D_SHADER_VARIABLE_TYPE Type;
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Rows"]/*'/>
    public uint Rows;
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Columns"]/*'/>
    public uint Columns;
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Elements"]/*'/>
    public uint Elements;
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Members"]/*'/>
    public uint Members;
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Offset"]/*'/>
    public uint Offset;
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Name"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
}
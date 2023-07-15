// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_LIBRARY_DESC"]/*'/>
public unsafe partial struct D3D12_LIBRARY_DESC
{
    /// <include file='D3D12_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_LIBRARY_DESC.Creator"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;
    /// <include file='D3D12_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_LIBRARY_DESC.Flags"]/*'/>
    public uint Flags;
    /// <include file='D3D12_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_LIBRARY_DESC.FunctionCount"]/*'/>
    public uint FunctionCount;
}
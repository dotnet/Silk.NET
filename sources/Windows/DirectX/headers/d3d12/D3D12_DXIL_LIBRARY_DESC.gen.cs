// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_DXIL_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_DXIL_LIBRARY_DESC"]/*'/>
public unsafe partial struct D3D12_DXIL_LIBRARY_DESC
{
    /// <include file='D3D12_DXIL_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_DXIL_LIBRARY_DESC.DXILLibrary"]/*'/>
    public D3D12_SHADER_BYTECODE DXILLibrary;
    /// <include file='D3D12_DXIL_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_DXIL_LIBRARY_DESC.NumExports"]/*'/>
    public uint NumExports;
    /// <include file='D3D12_DXIL_LIBRARY_DESC.xml' path='doc/member[@name="D3D12_DXIL_LIBRARY_DESC.pExports"]/*'/>
    public D3D12_EXPORT_DESC* pExports;
}
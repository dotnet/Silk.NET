// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST"]/*'/>
public unsafe partial struct D3D12_MEMCPY_DEST
{
    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.pData"]/*'/>
    public void* pData;
    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.RowPitch"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint RowPitch;
    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.SlicePitch"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint SlicePitch;
}
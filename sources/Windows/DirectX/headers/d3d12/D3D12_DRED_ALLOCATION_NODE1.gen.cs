// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_DRED_ALLOCATION_NODE1.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1"]/*'/>
public unsafe partial struct D3D12_DRED_ALLOCATION_NODE1
{
    /// <include file='D3D12_DRED_ALLOCATION_NODE1.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1.ObjectNameA"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* ObjectNameA;
    /// <include file='D3D12_DRED_ALLOCATION_NODE1.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1.ObjectNameW"]/*'/>
    [NativeTypeName("const wchar_t *")]
    public ushort* ObjectNameW;
    /// <include file='D3D12_DRED_ALLOCATION_NODE1.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1.AllocationType"]/*'/>
    public D3D12_DRED_ALLOCATION_TYPE AllocationType;
    /// <include file='D3D12_DRED_ALLOCATION_NODE1.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1.pNext"]/*'/>
    [NativeTypeName("const struct D3D12_DRED_ALLOCATION_NODE1 *")]
    public D3D12_DRED_ALLOCATION_NODE1* pNext;
    /// <include file='D3D12_DRED_ALLOCATION_NODE1.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_NODE1.pObject"]/*'/>
    [NativeTypeName("const IUnknown *")]
    public IUnknown* pObject;
}
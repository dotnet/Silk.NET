// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT1.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT1"]/*'/>
public unsafe partial struct D3D12_DRED_PAGE_FAULT_OUTPUT1
{
    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT1.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT1.PageFaultVA"]/*'/>
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong PageFaultVA;
    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT1.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT1.pHeadExistingAllocationNode"]/*'/>
    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE1 *")]
    public D3D12_DRED_ALLOCATION_NODE1* pHeadExistingAllocationNode;
    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT1.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT1.pHeadRecentFreedAllocationNode"]/*'/>
    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE1 *")]
    public D3D12_DRED_ALLOCATION_NODE1* pHeadRecentFreedAllocationNode;
}
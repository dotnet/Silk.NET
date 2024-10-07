// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1"]/*'/>
public unsafe partial struct D3D12_AUTO_BREADCRUMB_NODE1
{
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pCommandListDebugNameA"]/*'/>

    [NativeTypeName("const char *")]
    public sbyte* pCommandListDebugNameA;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pCommandListDebugNameW"]/*'/>

    [NativeTypeName("const wchar_t *")]
    public ushort* pCommandListDebugNameW;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pCommandQueueDebugNameA"]/*'/>

    [NativeTypeName("const char *")]
    public sbyte* pCommandQueueDebugNameA;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pCommandQueueDebugNameW"]/*'/>

    [NativeTypeName("const wchar_t *")]
    public ushort* pCommandQueueDebugNameW;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pCommandList"]/*'/>

    public ID3D12GraphicsCommandList* pCommandList;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pCommandQueue"]/*'/>

    public ID3D12CommandQueue* pCommandQueue;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.BreadcrumbCount"]/*'/>

    public uint BreadcrumbCount;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pLastBreadcrumbValue"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* pLastBreadcrumbValue;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pCommandHistory"]/*'/>

    [NativeTypeName("const D3D12_AUTO_BREADCRUMB_OP *")]
    public D3D12_AUTO_BREADCRUMB_OP* pCommandHistory;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pNext"]/*'/>

    [NativeTypeName("const struct D3D12_AUTO_BREADCRUMB_NODE1 *")]
    public D3D12_AUTO_BREADCRUMB_NODE1* pNext;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.BreadcrumbContextsCount"]/*'/>

    public uint BreadcrumbContextsCount;

    /// <include file='D3D12_AUTO_BREADCRUMB_NODE1.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE1.pBreadcrumbContexts"]/*'/>

    public D3D12_DRED_BREADCRUMB_CONTEXT* pBreadcrumbContexts;
}

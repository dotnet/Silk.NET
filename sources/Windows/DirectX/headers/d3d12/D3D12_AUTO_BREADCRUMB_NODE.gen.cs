// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE"]/*'/>
public unsafe partial struct D3D12_AUTO_BREADCRUMB_NODE
{
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandListDebugNameA"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* pCommandListDebugNameA;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandListDebugNameW"]/*'/>
    [NativeTypeName("const wchar_t *")]
    public ushort* pCommandListDebugNameW;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandQueueDebugNameA"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* pCommandQueueDebugNameA;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandQueueDebugNameW"]/*'/>
    [NativeTypeName("const wchar_t *")]
    public ushort* pCommandQueueDebugNameW;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandList"]/*'/>
    public ID3D12GraphicsCommandList* pCommandList;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandQueue"]/*'/>
    public ID3D12CommandQueue* pCommandQueue;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.BreadcrumbCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint BreadcrumbCount;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pLastBreadcrumbValue"]/*'/>
    [NativeTypeName("const UINT32 *")]
    public uint* pLastBreadcrumbValue;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pCommandHistory"]/*'/>
    [NativeTypeName("const D3D12_AUTO_BREADCRUMB_OP *")]
    public D3D12_AUTO_BREADCRUMB_OP* pCommandHistory;
    /// <include file='D3D12_AUTO_BREADCRUMB_NODE.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE.pNext"]/*'/>
    [NativeTypeName("const struct D3D12_AUTO_BREADCRUMB_NODE *")]
    public D3D12_AUTO_BREADCRUMB_NODE* pNext;
}
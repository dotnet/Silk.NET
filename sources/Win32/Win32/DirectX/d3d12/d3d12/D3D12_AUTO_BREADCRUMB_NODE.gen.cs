// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_AUTO_BREADCRUMB_NODE
{
    [NativeTypeName("const char *")]
    public sbyte* pCommandListDebugNameA;

    [NativeTypeName("const wchar_t *")]
    public ushort* pCommandListDebugNameW;

    [NativeTypeName("const char *")]
    public sbyte* pCommandQueueDebugNameA;

    [NativeTypeName("const wchar_t *")]
    public ushort* pCommandQueueDebugNameW;
    public ID3D12GraphicsCommandList pCommandList;
    public ID3D12CommandQueue pCommandQueue;

    [NativeTypeName("UINT32")]
    public uint BreadcrumbCount;

    [NativeTypeName("const UINT32 *")]
    public uint* pLastBreadcrumbValue;

    [NativeTypeName("const D3D12_AUTO_BREADCRUMB_OP *")]
    public D3D12_AUTO_BREADCRUMB_OP* pCommandHistory;

    [NativeTypeName("const struct D3D12_AUTO_BREADCRUMB_NODE *")]
    public D3D12_AUTO_BREADCRUMB_NODE* pNext;
}

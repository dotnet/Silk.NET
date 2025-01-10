// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_TEXTURE_BARRIER
{
    public D3D12_BARRIER_SYNC SyncBefore;
    public D3D12_BARRIER_SYNC SyncAfter;
    public D3D12_BARRIER_ACCESS AccessBefore;
    public D3D12_BARRIER_ACCESS AccessAfter;
    public D3D12_BARRIER_LAYOUT LayoutBefore;
    public D3D12_BARRIER_LAYOUT LayoutAfter;
    public ID3D12Resource pResource;
    public D3D12_BARRIER_SUBRESOURCE_RANGE Subresources;
    public D3D12_TEXTURE_BARRIER_FLAGS Flags;
}

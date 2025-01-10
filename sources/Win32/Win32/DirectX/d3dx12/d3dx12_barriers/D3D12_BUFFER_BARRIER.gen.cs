// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_barriers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_BUFFER_BARRIER : D3D12_BUFFER_BARRIER")]
[NativeInheritance("D3D12_BUFFER_BARRIER")]
public unsafe partial struct D3D12_BUFFER_BARRIER
{
    public D3D12_BUFFER_BARRIER(
        D3D12_BARRIER_SYNC syncBefore,
        D3D12_BARRIER_SYNC syncAfter,
        D3D12_BARRIER_ACCESS accessBefore,
        D3D12_BARRIER_ACCESS accessAfter,
        ID3D12Resource pRes
    )
    {
        SyncBefore = syncBefore;
        SyncAfter = syncAfter;
        AccessBefore = accessBefore;
        AccessAfter = accessAfter;
        pResource = pRes;
        Offset = 0;
        Size = 0xffffffffffffffffUL;
    }
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_SUBRESOURCE_RANGE_UINT64 : D3D12_SUBRESOURCE_RANGE_UINT64")]
[NativeInheritance("D3D12_SUBRESOURCE_RANGE_UINT64")]
public unsafe partial struct D3D12_SUBRESOURCE_RANGE_UINT64
{
    public D3D12_SUBRESOURCE_RANGE_UINT64(
        uint subresource,
        [NativeTypeName("const D3D12_RANGE_UINT64 &")] D3D12_RANGE_UINT64* range
    )
    {
        Subresource = subresource;
        Range = *range;
    }

    public D3D12_SUBRESOURCE_RANGE_UINT64(
        uint subresource,
        [NativeTypeName("UINT64")] ulong begin,
        [NativeTypeName("UINT64")] ulong end
    )
    {
        Subresource = subresource;
        Range.Begin = begin;
        Range.End = end;
    }
}

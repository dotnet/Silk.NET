// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_barriers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_BARRIER_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_BARRIER_GROUP : D3D12_BARRIER_GROUP")]
[NativeInheritance("D3D12_BARRIER_GROUP")]
public unsafe partial struct D3D12_BARRIER_GROUP
{
    public D3D12_BARRIER_GROUP(
        [NativeTypeName("UINT32")] uint numBarriers,
        [NativeTypeName("const D3D12_BUFFER_BARRIER *")] D3D12_BUFFER_BARRIER* pBarriers
    )
    {
        Type = D3D12_BARRIER_TYPE_BUFFER;
        NumBarriers = numBarriers;
        Anonymous.pBufferBarriers = pBarriers;
    }

    public D3D12_BARRIER_GROUP(
        [NativeTypeName("UINT32")] uint numBarriers,
        [NativeTypeName("const D3D12_TEXTURE_BARRIER *")] D3D12_TEXTURE_BARRIER* pBarriers
    )
    {
        Type = D3D12_BARRIER_TYPE_TEXTURE;
        NumBarriers = numBarriers;
        Anonymous.pTextureBarriers = pBarriers;
    }

    public D3D12_BARRIER_GROUP(
        [NativeTypeName("UINT32")] uint numBarriers,
        [NativeTypeName("const D3D12_GLOBAL_BARRIER *")] D3D12_GLOBAL_BARRIER* pBarriers
    )
    {
        Type = D3D12_BARRIER_TYPE_GLOBAL;
        NumBarriers = numBarriers;
        Anonymous.pGlobalBarriers = pBarriers;
    }
}

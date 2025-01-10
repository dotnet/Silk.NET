// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_TILED_RESOURCE_COORDINATE : D3D12_TILED_RESOURCE_COORDINATE")]
[NativeInheritance("D3D12_TILED_RESOURCE_COORDINATE")]
public partial struct D3D12_TILED_RESOURCE_COORDINATE
{
    public D3D12_TILED_RESOURCE_COORDINATE(uint x, uint y, uint z, uint subresource)
    {
        X = x;
        Y = y;
        Z = z;
        Subresource = subresource;
    }
}

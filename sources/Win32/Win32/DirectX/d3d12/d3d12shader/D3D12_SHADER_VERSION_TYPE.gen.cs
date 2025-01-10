// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_SHADER_VERSION_TYPE
{
    D3D12_SHVER_PIXEL_SHADER = 0,
    D3D12_SHVER_VERTEX_SHADER = 1,
    D3D12_SHVER_GEOMETRY_SHADER = 2,
    D3D12_SHVER_HULL_SHADER = 3,
    D3D12_SHVER_DOMAIN_SHADER = 4,
    D3D12_SHVER_COMPUTE_SHADER = 5,
    D3D12_SHVER_LIBRARY = 6,
    D3D12_SHVER_RAY_GENERATION_SHADER = 7,
    D3D12_SHVER_INTERSECTION_SHADER = 8,
    D3D12_SHVER_ANY_HIT_SHADER = 9,
    D3D12_SHVER_CLOSEST_HIT_SHADER = 10,
    D3D12_SHVER_MISS_SHADER = 11,
    D3D12_SHVER_CALLABLE_SHADER = 12,
    D3D12_SHVER_MESH_SHADER = 13,
    D3D12_SHVER_AMPLIFICATION_SHADER = 14,
    D3D12_SHVER_NODE_SHADER = 15,
    D3D12_SHVER_RESERVED0 = 0xFFF0,
}

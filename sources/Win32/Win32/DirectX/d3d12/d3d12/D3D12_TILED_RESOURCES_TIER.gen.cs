// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_TILED_RESOURCES_TIER
{
    D3D12_TILED_RESOURCES_TIER_NOT_SUPPORTED = 0,
    D3D12_TILED_RESOURCES_TIER_1 = 1,
    D3D12_TILED_RESOURCES_TIER_2 = 2,
    D3D12_TILED_RESOURCES_TIER_3 = 3,
    D3D12_TILED_RESOURCES_TIER_4 = 4,
}

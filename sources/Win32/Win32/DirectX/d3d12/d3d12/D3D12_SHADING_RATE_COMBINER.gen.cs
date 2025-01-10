// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_SHADING_RATE_COMBINER
{
    D3D12_SHADING_RATE_COMBINER_PASSTHROUGH = 0,
    D3D12_SHADING_RATE_COMBINER_OVERRIDE = 1,
    D3D12_SHADING_RATE_COMBINER_MIN = 2,
    D3D12_SHADING_RATE_COMBINER_MAX = 3,
    D3D12_SHADING_RATE_COMBINER_SUM = 4,
}

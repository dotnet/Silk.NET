// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_SHADING_RATE
{
    D3D12_SHADING_RATE_1X1 = 0,
    D3D12_SHADING_RATE_1X2 = 0x1,
    D3D12_SHADING_RATE_2X1 = 0x4,
    D3D12_SHADING_RATE_2X2 = 0x5,
    D3D12_SHADING_RATE_2X4 = 0x6,
    D3D12_SHADING_RATE_4X2 = 0x9,
    D3D12_SHADING_RATE_4X4 = 0xa,
}

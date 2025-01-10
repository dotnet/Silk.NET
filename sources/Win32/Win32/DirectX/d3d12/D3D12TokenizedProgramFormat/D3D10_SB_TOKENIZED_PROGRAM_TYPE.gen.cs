// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_SB_TOKENIZED_PROGRAM_TYPE
{
    D3D10_SB_PIXEL_SHADER = 0,
    D3D10_SB_VERTEX_SHADER = 1,
    D3D10_SB_GEOMETRY_SHADER = 2,
    D3D11_SB_HULL_SHADER = 3,
    D3D11_SB_DOMAIN_SHADER = 4,
    D3D11_SB_COMPUTE_SHADER = 5,
    D3D12_SB_MESH_SHADER = 13,
    D3D12_SB_AMPLIFICATION_SHADER = 14,
    D3D11_SB_RESERVED0 = 0xFFF0,
}

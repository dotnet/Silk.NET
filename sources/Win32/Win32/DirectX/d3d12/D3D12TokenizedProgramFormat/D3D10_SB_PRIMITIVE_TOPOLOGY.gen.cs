// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_SB_PRIMITIVE_TOPOLOGY
{
    D3D10_SB_PRIMITIVE_TOPOLOGY_UNDEFINED = 0,
    D3D10_SB_PRIMITIVE_TOPOLOGY_POINTLIST = 1,
    D3D10_SB_PRIMITIVE_TOPOLOGY_LINELIST = 2,
    D3D10_SB_PRIMITIVE_TOPOLOGY_LINESTRIP = 3,
    D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLELIST = 4,
    D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = 5,
    D3D10_SB_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = 10,
    D3D10_SB_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = 11,
    D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = 12,
    D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = 13,
}

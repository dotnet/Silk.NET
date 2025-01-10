// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_SB_COMPONENT_MASK
{
    D3D10_SB_COMPONENT_MASK_X = 1,
    D3D10_SB_COMPONENT_MASK_Y = 2,
    D3D10_SB_COMPONENT_MASK_Z = 4,
    D3D10_SB_COMPONENT_MASK_W = 8,
    D3D10_SB_COMPONENT_MASK_R = 1,
    D3D10_SB_COMPONENT_MASK_G = 2,
    D3D10_SB_COMPONENT_MASK_B = 4,
    D3D10_SB_COMPONENT_MASK_A = 8,
    D3D10_SB_COMPONENT_MASK_ALL = 15,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_SB_OPERAND_INDEX_REPRESENTATION
{
    D3D10_SB_OPERAND_INDEX_IMMEDIATE32 = 0,
    D3D10_SB_OPERAND_INDEX_IMMEDIATE64 = 1,
    D3D10_SB_OPERAND_INDEX_RELATIVE = 2,
    D3D10_SB_OPERAND_INDEX_IMMEDIATE32_PLUS_RELATIVE = 3,
    D3D10_SB_OPERAND_INDEX_IMMEDIATE64_PLUS_RELATIVE = 4,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D11_SB_OPERAND_MIN_PRECISION
{
    D3D11_SB_OPERAND_MIN_PRECISION_DEFAULT = 0,
    D3D11_SB_OPERAND_MIN_PRECISION_FLOAT_16 = 1,
    D3D11_SB_OPERAND_MIN_PRECISION_FLOAT_2_8 = 2,
    D3D11_SB_OPERAND_MIN_PRECISION_SINT_16 = 4,
    D3D11_SB_OPERAND_MIN_PRECISION_UINT_16 = 5,
}

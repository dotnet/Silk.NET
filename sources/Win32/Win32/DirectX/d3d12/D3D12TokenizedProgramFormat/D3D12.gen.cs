// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D12
{
    [NativeTypeName("#define D3D12_SB_OPERAND_NON_UNIFORM_MASK 0x00020000")]
    public const int D3D12_SB_OPERAND_NON_UNIFORM_MASK = 0x00020000;

    [NativeTypeName("#define D3D12_SB_OPERAND_NON_UNIFORM_SHIFT 17")]
    public const int D3D12_SB_OPERAND_NON_UNIFORM_SHIFT = 17;

    [NativeTypeName("#define D3D12_SB_GLOBAL_FLAG_ALL_RESOURCES_BOUND (1<<19)")]
    public const int D3D12_SB_GLOBAL_FLAG_ALL_RESOURCES_BOUND = (1 << 19);
}

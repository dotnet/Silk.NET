// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DSHADER
{
    [NativeTypeName("#define D3DSHADER_COMPARISON_SHIFT D3DSP_OPCODESPECIFICCONTROL_SHIFT")]
    public const int D3DSHADER_COMPARISON_SHIFT = 16;

    [NativeTypeName("#define D3DSHADER_COMPARISON_MASK (0x7<<D3DSHADER_COMPARISON_SHIFT)")]
    public const int D3DSHADER_COMPARISON_MASK = (0x7 << 16);

    [NativeTypeName("#define D3DSHADER_INSTRUCTION_PREDICATED (0x1 << 28)")]
    public const int D3DSHADER_INSTRUCTION_PREDICATED = (0x1 << 28);

    [NativeTypeName("#define D3DSHADER_ADDRESSMODE_SHIFT 13")]
    public const int D3DSHADER_ADDRESSMODE_SHIFT = 13;

    [NativeTypeName("#define D3DSHADER_ADDRESSMODE_MASK (1 << D3DSHADER_ADDRESSMODE_SHIFT)")]
    public const int D3DSHADER_ADDRESSMODE_MASK = (1 << 13);
}

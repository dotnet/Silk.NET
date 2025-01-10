// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DSI_
{
    [NativeTypeName("#define D3DSI_OPCODE_MASK 0x0000FFFF")]
    public const int D3DSI_OPCODE_MASK = 0x0000FFFF;

    [NativeTypeName("#define D3DSI_INSTLENGTH_MASK 0x0F000000")]
    public const int D3DSI_INSTLENGTH_MASK = 0x0F000000;

    [NativeTypeName("#define D3DSI_INSTLENGTH_SHIFT 24")]
    public const int D3DSI_INSTLENGTH_SHIFT = 24;

    [NativeTypeName("#define D3DSI_COISSUE 0x40000000")]
    public const int D3DSI_COISSUE = 0x40000000;

    [NativeTypeName("#define D3DSI_TEXLD_PROJECT (0x01 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
    public const int D3DSI_TEXLD_PROJECT = (0x01 << 16);

    [NativeTypeName("#define D3DSI_TEXLD_BIAS (0x02 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
    public const int D3DSI_TEXLD_BIAS = (0x02 << 16);

    [NativeTypeName("#define D3DSI_COMMENTSIZE_SHIFT 16")]
    public const int D3DSI_COMMENTSIZE_SHIFT = 16;

    [NativeTypeName("#define D3DSI_COMMENTSIZE_MASK 0x7FFF0000")]
    public const int D3DSI_COMMENTSIZE_MASK = 0x7FFF0000;
}

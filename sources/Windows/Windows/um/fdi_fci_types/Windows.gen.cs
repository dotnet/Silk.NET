// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi_fci_types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define INCLUDED_TYPES_FCI_FDI 1")]
    public const int INCLUDED_TYPES_FCI_FDI = 1;

    [NativeTypeName("#define tcompMASK_TYPE 0x000F")]
    public const int tcompMASK_TYPE = 0x000F;

    [NativeTypeName("#define tcompTYPE_NONE 0x0000")]
    public const int tcompTYPE_NONE = 0x0000;

    [NativeTypeName("#define tcompTYPE_MSZIP 0x0001")]
    public const int tcompTYPE_MSZIP = 0x0001;

    [NativeTypeName("#define tcompTYPE_QUANTUM 0x0002")]
    public const int tcompTYPE_QUANTUM = 0x0002;

    [NativeTypeName("#define tcompTYPE_LZX 0x0003")]
    public const int tcompTYPE_LZX = 0x0003;

    [NativeTypeName("#define tcompBAD 0x000F")]
    public const int tcompBAD = 0x000F;

    [NativeTypeName("#define tcompMASK_LZX_WINDOW 0x1F00")]
    public const int tcompMASK_LZX_WINDOW = 0x1F00;

    [NativeTypeName("#define tcompLZX_WINDOW_LO 0x0F00")]
    public const int tcompLZX_WINDOW_LO = 0x0F00;

    [NativeTypeName("#define tcompLZX_WINDOW_HI 0x1500")]
    public const int tcompLZX_WINDOW_HI = 0x1500;

    [NativeTypeName("#define tcompSHIFT_LZX_WINDOW 8")]
    public const int tcompSHIFT_LZX_WINDOW = 8;

    [NativeTypeName("#define tcompMASK_QUANTUM_LEVEL 0x00F0")]
    public const int tcompMASK_QUANTUM_LEVEL = 0x00F0;

    [NativeTypeName("#define tcompQUANTUM_LEVEL_LO 0x0010")]
    public const int tcompQUANTUM_LEVEL_LO = 0x0010;

    [NativeTypeName("#define tcompQUANTUM_LEVEL_HI 0x0070")]
    public const int tcompQUANTUM_LEVEL_HI = 0x0070;

    [NativeTypeName("#define tcompSHIFT_QUANTUM_LEVEL 4")]
    public const int tcompSHIFT_QUANTUM_LEVEL = 4;

    [NativeTypeName("#define tcompMASK_QUANTUM_MEM 0x1F00")]
    public const int tcompMASK_QUANTUM_MEM = 0x1F00;

    [NativeTypeName("#define tcompQUANTUM_MEM_LO 0x0A00")]
    public const int tcompQUANTUM_MEM_LO = 0x0A00;

    [NativeTypeName("#define tcompQUANTUM_MEM_HI 0x1500")]
    public const int tcompQUANTUM_MEM_HI = 0x1500;

    [NativeTypeName("#define tcompSHIFT_QUANTUM_MEM 8")]
    public const int tcompSHIFT_QUANTUM_MEM = 8;

    [NativeTypeName("#define tcompMASK_RESERVED 0xE000")]
    public const int tcompMASK_RESERVED = 0xE000;
}

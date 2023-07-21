// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class RC
{
    [NativeTypeName("#define RC_BITBLT 1")]
    public const int RC_BITBLT = 1;

    [NativeTypeName("#define RC_BANDING 2")]
    public const int RC_BANDING = 2;

    [NativeTypeName("#define RC_SCALING 4")]
    public const int RC_SCALING = 4;

    [NativeTypeName("#define RC_BITMAP64 8")]
    public const int RC_BITMAP64 = 8;

    [NativeTypeName("#define RC_GDI20_OUTPUT 0x0010")]
    public const int RC_GDI20_OUTPUT = 0x0010;

    [NativeTypeName("#define RC_GDI20_STATE 0x0020")]
    public const int RC_GDI20_STATE = 0x0020;

    [NativeTypeName("#define RC_SAVEBITMAP 0x0040")]
    public const int RC_SAVEBITMAP = 0x0040;

    [NativeTypeName("#define RC_DI_BITMAP 0x0080")]
    public const int RC_DI_BITMAP = 0x0080;

    [NativeTypeName("#define RC_PALETTE 0x0100")]
    public const int RC_PALETTE = 0x0100;

    [NativeTypeName("#define RC_DIBTODEV 0x0200")]
    public const int RC_DIBTODEV = 0x0200;

    [NativeTypeName("#define RC_BIGFONT 0x0400")]
    public const int RC_BIGFONT = 0x0400;

    [NativeTypeName("#define RC_STRETCHBLT 0x0800")]
    public const int RC_STRETCHBLT = 0x0800;

    [NativeTypeName("#define RC_FLOODFILL 0x1000")]
    public const int RC_FLOODFILL = 0x1000;

    [NativeTypeName("#define RC_STRETCHDIB 0x2000")]
    public const int RC_STRETCHDIB = 0x2000;

    [NativeTypeName("#define RC_OP_DX_OUTPUT 0x4000")]
    public const int RC_OP_DX_OUTPUT = 0x4000;

    [NativeTypeName("#define RC_DEVBITS 0x8000")]
    public const int RC_DEVBITS = 0x8000;
}

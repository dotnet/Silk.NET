// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BF
{
    [NativeTypeName("#define BF_LEFT 0x0001")]
    public const int BF_LEFT = 0x0001;

    [NativeTypeName("#define BF_TOP 0x0002")]
    public const int BF_TOP = 0x0002;

    [NativeTypeName("#define BF_RIGHT 0x0004")]
    public const int BF_RIGHT = 0x0004;

    [NativeTypeName("#define BF_BOTTOM 0x0008")]
    public const int BF_BOTTOM = 0x0008;

    [NativeTypeName("#define BF_TOPLEFT (BF_TOP | BF_LEFT)")]
    public const int BF_TOPLEFT = (0x0002 | 0x0001);

    [NativeTypeName("#define BF_TOPRIGHT (BF_TOP | BF_RIGHT)")]
    public const int BF_TOPRIGHT = (0x0002 | 0x0004);

    [NativeTypeName("#define BF_BOTTOMLEFT (BF_BOTTOM | BF_LEFT)")]
    public const int BF_BOTTOMLEFT = (0x0008 | 0x0001);

    [NativeTypeName("#define BF_BOTTOMRIGHT (BF_BOTTOM | BF_RIGHT)")]
    public const int BF_BOTTOMRIGHT = (0x0008 | 0x0004);

    [NativeTypeName("#define BF_RECT (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM)")]
    public const int BF_RECT = (0x0001 | 0x0002 | 0x0004 | 0x0008);

    [NativeTypeName("#define BF_DIAGONAL 0x0010")]
    public const int BF_DIAGONAL = 0x0010;

    [NativeTypeName("#define BF_DIAGONAL_ENDTOPRIGHT (BF_DIAGONAL | BF_TOP | BF_RIGHT)")]
    public const int BF_DIAGONAL_ENDTOPRIGHT = (0x0010 | 0x0002 | 0x0004);

    [NativeTypeName("#define BF_DIAGONAL_ENDTOPLEFT (BF_DIAGONAL | BF_TOP | BF_LEFT)")]
    public const int BF_DIAGONAL_ENDTOPLEFT = (0x0010 | 0x0002 | 0x0001);

    [NativeTypeName("#define BF_DIAGONAL_ENDBOTTOMLEFT (BF_DIAGONAL | BF_BOTTOM | BF_LEFT)")]
    public const int BF_DIAGONAL_ENDBOTTOMLEFT = (0x0010 | 0x0008 | 0x0001);

    [NativeTypeName("#define BF_DIAGONAL_ENDBOTTOMRIGHT (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT)")]
    public const int BF_DIAGONAL_ENDBOTTOMRIGHT = (0x0010 | 0x0008 | 0x0004);

    [NativeTypeName("#define BF_MIDDLE 0x0800")]
    public const int BF_MIDDLE = 0x0800;

    [NativeTypeName("#define BF_SOFT 0x1000")]
    public const int BF_SOFT = 0x1000;

    [NativeTypeName("#define BF_ADJUST 0x2000")]
    public const int BF_ADJUST = 0x2000;

    [NativeTypeName("#define BF_FLAT 0x4000")]
    public const int BF_FLAT = 0x4000;

    [NativeTypeName("#define BF_MONO 0x8000")]
    public const int BF_MONO = 0x8000;
}

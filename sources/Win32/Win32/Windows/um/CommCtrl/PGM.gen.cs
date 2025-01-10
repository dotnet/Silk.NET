// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PGM
{
    [NativeTypeName("#define PGM_FIRST 0x1400")]
    public const int PGM_FIRST = 0x1400;

    [NativeTypeName("#define PGM_SETCHILD (PGM_FIRST + 1)")]
    public const int PGM_SETCHILD = (0x1400 + 1);

    [NativeTypeName("#define PGM_RECALCSIZE (PGM_FIRST + 2)")]
    public const int PGM_RECALCSIZE = (0x1400 + 2);

    [NativeTypeName("#define PGM_FORWARDMOUSE (PGM_FIRST + 3)")]
    public const int PGM_FORWARDMOUSE = (0x1400 + 3);

    [NativeTypeName("#define PGM_SETBKCOLOR (PGM_FIRST + 4)")]
    public const int PGM_SETBKCOLOR = (0x1400 + 4);

    [NativeTypeName("#define PGM_GETBKCOLOR (PGM_FIRST + 5)")]
    public const int PGM_GETBKCOLOR = (0x1400 + 5);

    [NativeTypeName("#define PGM_SETBORDER (PGM_FIRST + 6)")]
    public const int PGM_SETBORDER = (0x1400 + 6);

    [NativeTypeName("#define PGM_GETBORDER (PGM_FIRST + 7)")]
    public const int PGM_GETBORDER = (0x1400 + 7);

    [NativeTypeName("#define PGM_SETPOS (PGM_FIRST + 8)")]
    public const int PGM_SETPOS = (0x1400 + 8);

    [NativeTypeName("#define PGM_GETPOS (PGM_FIRST + 9)")]
    public const int PGM_GETPOS = (0x1400 + 9);

    [NativeTypeName("#define PGM_SETBUTTONSIZE (PGM_FIRST + 10)")]
    public const int PGM_SETBUTTONSIZE = (0x1400 + 10);

    [NativeTypeName("#define PGM_GETBUTTONSIZE (PGM_FIRST + 11)")]
    public const int PGM_GETBUTTONSIZE = (0x1400 + 11);

    [NativeTypeName("#define PGM_GETBUTTONSTATE (PGM_FIRST + 12)")]
    public const int PGM_GETBUTTONSTATE = (0x1400 + 12);

    [NativeTypeName("#define PGM_GETDROPTARGET CCM_GETDROPTARGET")]
    public const int PGM_GETDROPTARGET = (0x2000 + 4);

    [NativeTypeName("#define PGM_SETSCROLLINFO (PGM_FIRST + 13)")]
    public const int PGM_SETSCROLLINFO = (0x1400 + 13);
}

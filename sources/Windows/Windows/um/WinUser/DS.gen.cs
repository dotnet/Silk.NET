// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DS
{
    [NativeTypeName("#define DS_ABSALIGN 0x01L")]
    public const int DS_ABSALIGN = 0x01;

    [NativeTypeName("#define DS_SYSMODAL 0x02L")]
    public const int DS_SYSMODAL = 0x02;

    [NativeTypeName("#define DS_LOCALEDIT 0x20L")]
    public const int DS_LOCALEDIT = 0x20;

    [NativeTypeName("#define DS_SETFONT 0x40L")]
    public const int DS_SETFONT = 0x40;

    [NativeTypeName("#define DS_MODALFRAME 0x80L")]
    public const int DS_MODALFRAME = 0x80;

    [NativeTypeName("#define DS_NOIDLEMSG 0x100L")]
    public const int DS_NOIDLEMSG = 0x100;

    [NativeTypeName("#define DS_SETFOREGROUND 0x200L")]
    public const int DS_SETFOREGROUND = 0x200;

    [NativeTypeName("#define DS_3DLOOK 0x0004L")]
    public const int DS_3DLOOK = 0x0004;

    [NativeTypeName("#define DS_FIXEDSYS 0x0008L")]
    public const int DS_FIXEDSYS = 0x0008;

    [NativeTypeName("#define DS_NOFAILCREATE 0x0010L")]
    public const int DS_NOFAILCREATE = 0x0010;

    [NativeTypeName("#define DS_CONTROL 0x0400L")]
    public const int DS_CONTROL = 0x0400;

    [NativeTypeName("#define DS_CENTER 0x0800L")]
    public const int DS_CENTER = 0x0800;

    [NativeTypeName("#define DS_CENTERMOUSE 0x1000L")]
    public const int DS_CENTERMOUSE = 0x1000;

    [NativeTypeName("#define DS_CONTEXTHELP 0x2000L")]
    public const int DS_CONTEXTHELP = 0x2000;

    [NativeTypeName("#define DS_SHELLFONT (DS_SETFONT | DS_FIXEDSYS)")]
    public const int DS_SHELLFONT = (0x40 | 0x0008);
}

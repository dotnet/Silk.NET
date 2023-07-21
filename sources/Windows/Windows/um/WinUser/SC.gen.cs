// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SC
{
    [NativeTypeName("#define SC_SIZE 0xF000")]
    public const int SC_SIZE = 0xF000;

    [NativeTypeName("#define SC_MOVE 0xF010")]
    public const int SC_MOVE = 0xF010;

    [NativeTypeName("#define SC_MINIMIZE 0xF020")]
    public const int SC_MINIMIZE = 0xF020;

    [NativeTypeName("#define SC_MAXIMIZE 0xF030")]
    public const int SC_MAXIMIZE = 0xF030;

    [NativeTypeName("#define SC_NEXTWINDOW 0xF040")]
    public const int SC_NEXTWINDOW = 0xF040;

    [NativeTypeName("#define SC_PREVWINDOW 0xF050")]
    public const int SC_PREVWINDOW = 0xF050;

    [NativeTypeName("#define SC_CLOSE 0xF060")]
    public const int SC_CLOSE = 0xF060;

    [NativeTypeName("#define SC_VSCROLL 0xF070")]
    public const int SC_VSCROLL = 0xF070;

    [NativeTypeName("#define SC_HSCROLL 0xF080")]
    public const int SC_HSCROLL = 0xF080;

    [NativeTypeName("#define SC_MOUSEMENU 0xF090")]
    public const int SC_MOUSEMENU = 0xF090;

    [NativeTypeName("#define SC_KEYMENU 0xF100")]
    public const int SC_KEYMENU = 0xF100;

    [NativeTypeName("#define SC_ARRANGE 0xF110")]
    public const int SC_ARRANGE = 0xF110;

    [NativeTypeName("#define SC_RESTORE 0xF120")]
    public const int SC_RESTORE = 0xF120;

    [NativeTypeName("#define SC_TASKLIST 0xF130")]
    public const int SC_TASKLIST = 0xF130;

    [NativeTypeName("#define SC_SCREENSAVE 0xF140")]
    public const int SC_SCREENSAVE = 0xF140;

    [NativeTypeName("#define SC_HOTKEY 0xF150")]
    public const int SC_HOTKEY = 0xF150;

    [NativeTypeName("#define SC_DEFAULT 0xF160")]
    public const int SC_DEFAULT = 0xF160;

    [NativeTypeName("#define SC_MONITORPOWER 0xF170")]
    public const int SC_MONITORPOWER = 0xF170;

    [NativeTypeName("#define SC_CONTEXTHELP 0xF180")]
    public const int SC_CONTEXTHELP = 0xF180;

    [NativeTypeName("#define SC_SEPARATOR 0xF00F")]
    public const int SC_SEPARATOR = 0xF00F;

    [NativeTypeName("#define SC_ICON SC_MINIMIZE")]
    public const int SC_ICON = 0xF020;

    [NativeTypeName("#define SC_ZOOM SC_MAXIMIZE")]
    public const int SC_ZOOM = 0xF030;
}

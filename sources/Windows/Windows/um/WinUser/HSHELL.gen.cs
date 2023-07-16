// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class HSHELL
{
    [NativeTypeName("#define HSHELL_WINDOWCREATED 1")]
    public const int HSHELL_WINDOWCREATED = 1;
    [NativeTypeName("#define HSHELL_WINDOWDESTROYED 2")]
    public const int HSHELL_WINDOWDESTROYED = 2;
    [NativeTypeName("#define HSHELL_ACTIVATESHELLWINDOW 3")]
    public const int HSHELL_ACTIVATESHELLWINDOW = 3;
    [NativeTypeName("#define HSHELL_WINDOWACTIVATED 4")]
    public const int HSHELL_WINDOWACTIVATED = 4;
    [NativeTypeName("#define HSHELL_GETMINRECT 5")]
    public const int HSHELL_GETMINRECT = 5;
    [NativeTypeName("#define HSHELL_REDRAW 6")]
    public const int HSHELL_REDRAW = 6;
    [NativeTypeName("#define HSHELL_TASKMAN 7")]
    public const int HSHELL_TASKMAN = 7;
    [NativeTypeName("#define HSHELL_LANGUAGE 8")]
    public const int HSHELL_LANGUAGE = 8;
    [NativeTypeName("#define HSHELL_SYSMENU 9")]
    public const int HSHELL_SYSMENU = 9;
    [NativeTypeName("#define HSHELL_ENDTASK 10")]
    public const int HSHELL_ENDTASK = 10;
    [NativeTypeName("#define HSHELL_ACCESSIBILITYSTATE 11")]
    public const int HSHELL_ACCESSIBILITYSTATE = 11;
    [NativeTypeName("#define HSHELL_APPCOMMAND 12")]
    public const int HSHELL_APPCOMMAND = 12;
    [NativeTypeName("#define HSHELL_WINDOWREPLACED 13")]
    public const int HSHELL_WINDOWREPLACED = 13;
    [NativeTypeName("#define HSHELL_WINDOWREPLACING 14")]
    public const int HSHELL_WINDOWREPLACING = 14;
    [NativeTypeName("#define HSHELL_MONITORCHANGED 16")]
    public const int HSHELL_MONITORCHANGED = 16;
    [NativeTypeName("#define HSHELL_HIGHBIT 0x8000")]
    public const int HSHELL_HIGHBIT = 0x8000;
    [NativeTypeName("#define HSHELL_FLASH (HSHELL_REDRAW|HSHELL_HIGHBIT)")]
    public const int HSHELL_FLASH = (6 | 0x8000);
    [NativeTypeName("#define HSHELL_RUDEAPPACTIVATED (HSHELL_WINDOWACTIVATED|HSHELL_HIGHBIT)")]
    public const int HSHELL_RUDEAPPACTIVATED = (4 | 0x8000);
}
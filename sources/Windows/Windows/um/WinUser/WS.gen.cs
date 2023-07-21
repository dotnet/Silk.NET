// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WS
{
    [NativeTypeName("#define WS_OVERLAPPED 0x00000000L")]
    public const int WS_OVERLAPPED = 0x00000000;

    [NativeTypeName("#define WS_POPUP 0x80000000L")]
    public const uint WS_POPUP = 0x80000000;

    [NativeTypeName("#define WS_CHILD 0x40000000L")]
    public const int WS_CHILD = 0x40000000;

    [NativeTypeName("#define WS_MINIMIZE 0x20000000L")]
    public const int WS_MINIMIZE = 0x20000000;

    [NativeTypeName("#define WS_VISIBLE 0x10000000L")]
    public const int WS_VISIBLE = 0x10000000;

    [NativeTypeName("#define WS_DISABLED 0x08000000L")]
    public const int WS_DISABLED = 0x08000000;

    [NativeTypeName("#define WS_CLIPSIBLINGS 0x04000000L")]
    public const int WS_CLIPSIBLINGS = 0x04000000;

    [NativeTypeName("#define WS_CLIPCHILDREN 0x02000000L")]
    public const int WS_CLIPCHILDREN = 0x02000000;

    [NativeTypeName("#define WS_MAXIMIZE 0x01000000L")]
    public const int WS_MAXIMIZE = 0x01000000;

    [NativeTypeName("#define WS_CAPTION 0x00C00000L")]
    public const int WS_CAPTION = 0x00C00000;

    [NativeTypeName("#define WS_BORDER 0x00800000L")]
    public const int WS_BORDER = 0x00800000;

    [NativeTypeName("#define WS_DLGFRAME 0x00400000L")]
    public const int WS_DLGFRAME = 0x00400000;

    [NativeTypeName("#define WS_VSCROLL 0x00200000L")]
    public const int WS_VSCROLL = 0x00200000;

    [NativeTypeName("#define WS_HSCROLL 0x00100000L")]
    public const int WS_HSCROLL = 0x00100000;

    [NativeTypeName("#define WS_SYSMENU 0x00080000L")]
    public const int WS_SYSMENU = 0x00080000;

    [NativeTypeName("#define WS_THICKFRAME 0x00040000L")]
    public const int WS_THICKFRAME = 0x00040000;

    [NativeTypeName("#define WS_GROUP 0x00020000L")]
    public const int WS_GROUP = 0x00020000;

    [NativeTypeName("#define WS_TABSTOP 0x00010000L")]
    public const int WS_TABSTOP = 0x00010000;

    [NativeTypeName("#define WS_MINIMIZEBOX 0x00020000L")]
    public const int WS_MINIMIZEBOX = 0x00020000;

    [NativeTypeName("#define WS_MAXIMIZEBOX 0x00010000L")]
    public const int WS_MAXIMIZEBOX = 0x00010000;

    [NativeTypeName("#define WS_TILED WS_OVERLAPPED")]
    public const int WS_TILED = 0x00000000;

    [NativeTypeName("#define WS_ICONIC WS_MINIMIZE")]
    public const int WS_ICONIC = 0x20000000;

    [NativeTypeName("#define WS_SIZEBOX WS_THICKFRAME")]
    public const int WS_SIZEBOX = 0x00040000;

    [NativeTypeName("#define WS_TILEDWINDOW WS_OVERLAPPEDWINDOW")]
    public const int WS_TILEDWINDOW = (0x00000000 | 0x00C00000 | 0x00080000 | 0x00040000 | 0x00020000 | 0x00010000);

    [NativeTypeName("#define WS_OVERLAPPEDWINDOW (WS_OVERLAPPED     | \\\r\n                             WS_CAPTION        | \\\r\n                             WS_SYSMENU        | \\\r\n                             WS_THICKFRAME     | \\\r\n                             WS_MINIMIZEBOX    | \\\r\n                             WS_MAXIMIZEBOX)")]
    public const int WS_OVERLAPPEDWINDOW = (0x00000000 | 0x00C00000 | 0x00080000 | 0x00040000 | 0x00020000 | 0x00010000);

    [NativeTypeName("#define WS_POPUPWINDOW (WS_POPUP          | \\\r\n                             WS_BORDER         | \\\r\n                             WS_SYSMENU)")]
    public const uint WS_POPUPWINDOW = (0x80000000 | 0x00800000 | 0x00080000);

    [NativeTypeName("#define WS_CHILDWINDOW (WS_CHILD)")]
    public const int WS_CHILDWINDOW = (0x40000000);

    [NativeTypeName("#define WS_EX_DLGMODALFRAME 0x00000001L")]
    public const int WS_EX_DLGMODALFRAME = 0x00000001;

    [NativeTypeName("#define WS_EX_NOPARENTNOTIFY 0x00000004L")]
    public const int WS_EX_NOPARENTNOTIFY = 0x00000004;

    [NativeTypeName("#define WS_EX_TOPMOST 0x00000008L")]
    public const int WS_EX_TOPMOST = 0x00000008;

    [NativeTypeName("#define WS_EX_ACCEPTFILES 0x00000010L")]
    public const int WS_EX_ACCEPTFILES = 0x00000010;

    [NativeTypeName("#define WS_EX_TRANSPARENT 0x00000020L")]
    public const int WS_EX_TRANSPARENT = 0x00000020;

    [NativeTypeName("#define WS_EX_MDICHILD 0x00000040L")]
    public const int WS_EX_MDICHILD = 0x00000040;

    [NativeTypeName("#define WS_EX_TOOLWINDOW 0x00000080L")]
    public const int WS_EX_TOOLWINDOW = 0x00000080;

    [NativeTypeName("#define WS_EX_WINDOWEDGE 0x00000100L")]
    public const int WS_EX_WINDOWEDGE = 0x00000100;

    [NativeTypeName("#define WS_EX_CLIENTEDGE 0x00000200L")]
    public const int WS_EX_CLIENTEDGE = 0x00000200;

    [NativeTypeName("#define WS_EX_CONTEXTHELP 0x00000400L")]
    public const int WS_EX_CONTEXTHELP = 0x00000400;

    [NativeTypeName("#define WS_EX_RIGHT 0x00001000L")]
    public const int WS_EX_RIGHT = 0x00001000;

    [NativeTypeName("#define WS_EX_LEFT 0x00000000L")]
    public const int WS_EX_LEFT = 0x00000000;

    [NativeTypeName("#define WS_EX_RTLREADING 0x00002000L")]
    public const int WS_EX_RTLREADING = 0x00002000;

    [NativeTypeName("#define WS_EX_LTRREADING 0x00000000L")]
    public const int WS_EX_LTRREADING = 0x00000000;

    [NativeTypeName("#define WS_EX_LEFTSCROLLBAR 0x00004000L")]
    public const int WS_EX_LEFTSCROLLBAR = 0x00004000;

    [NativeTypeName("#define WS_EX_RIGHTSCROLLBAR 0x00000000L")]
    public const int WS_EX_RIGHTSCROLLBAR = 0x00000000;

    [NativeTypeName("#define WS_EX_CONTROLPARENT 0x00010000L")]
    public const int WS_EX_CONTROLPARENT = 0x00010000;

    [NativeTypeName("#define WS_EX_STATICEDGE 0x00020000L")]
    public const int WS_EX_STATICEDGE = 0x00020000;

    [NativeTypeName("#define WS_EX_APPWINDOW 0x00040000L")]
    public const int WS_EX_APPWINDOW = 0x00040000;

    [NativeTypeName("#define WS_EX_OVERLAPPEDWINDOW (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE)")]
    public const int WS_EX_OVERLAPPEDWINDOW = (0x00000100 | 0x00000200);

    [NativeTypeName("#define WS_EX_PALETTEWINDOW (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST)")]
    public const int WS_EX_PALETTEWINDOW = (0x00000100 | 0x00000080 | 0x00000008);

    [NativeTypeName("#define WS_EX_LAYERED 0x00080000")]
    public const int WS_EX_LAYERED = 0x00080000;

    [NativeTypeName("#define WS_EX_NOINHERITLAYOUT 0x00100000L")]
    public const int WS_EX_NOINHERITLAYOUT = 0x00100000;

    [NativeTypeName("#define WS_EX_NOREDIRECTIONBITMAP 0x00200000L")]
    public const int WS_EX_NOREDIRECTIONBITMAP = 0x00200000;

    [NativeTypeName("#define WS_EX_LAYOUTRTL 0x00400000L")]
    public const int WS_EX_LAYOUTRTL = 0x00400000;

    [NativeTypeName("#define WS_EX_COMPOSITED 0x02000000L")]
    public const int WS_EX_COMPOSITED = 0x02000000;

    [NativeTypeName("#define WS_EX_NOACTIVATE 0x08000000L")]
    public const int WS_EX_NOACTIVATE = 0x08000000;

    [NativeTypeName("#define WS_ACTIVECAPTION 0x0001")]
    public const int WS_ACTIVECAPTION = 0x0001;
}

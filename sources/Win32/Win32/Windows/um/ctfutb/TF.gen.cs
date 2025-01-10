// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TF
{
    [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEW L\"TF_FloatingLangBar_WndTitle\"")]
    public const string TF_FLOATINGLANGBAR_WNDTITLEW = "TF_FloatingLangBar_WndTitle";

    [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEA \"TF_FloatingLangBar_WndTitle\"")]
    public static ReadOnlySpan<byte> TF_FLOATINGLANGBAR_WNDTITLEA =>
        "TF_FloatingLangBar_WndTitle"u8;

    [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLE TF_FLOATINGLANGBAR_WNDTITLEW")]
    public const string TF_FLOATINGLANGBAR_WNDTITLE = "TF_FloatingLangBar_WndTitle";

    [NativeTypeName("#define TF_LBI_ICON 0x00000001")]
    public const int TF_LBI_ICON = 0x00000001;

    [NativeTypeName("#define TF_LBI_TEXT 0x00000002")]
    public const int TF_LBI_TEXT = 0x00000002;

    [NativeTypeName("#define TF_LBI_TOOLTIP 0x00000004")]
    public const int TF_LBI_TOOLTIP = 0x00000004;

    [NativeTypeName("#define TF_LBI_BITMAP 0x00000008")]
    public const int TF_LBI_BITMAP = 0x00000008;

    [NativeTypeName("#define TF_LBI_BALLOON 0x00000010")]
    public const int TF_LBI_BALLOON = 0x00000010;

    [NativeTypeName("#define TF_LBI_CUSTOMUI 0x00000020")]
    public const int TF_LBI_CUSTOMUI = 0x00000020;

    [NativeTypeName("#define TF_LBI_BTNALL (TF_LBI_ICON | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
    public const int TF_LBI_BTNALL = (0x00000001 | 0x00000002 | 0x00000004);

    [NativeTypeName("#define TF_LBI_BMPBTNALL (TF_LBI_BITMAP | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
    public const int TF_LBI_BMPBTNALL = (0x00000008 | 0x00000002 | 0x00000004);

    [NativeTypeName("#define TF_LBI_BMPALL (TF_LBI_BITMAP | TF_LBI_TOOLTIP)")]
    public const int TF_LBI_BMPALL = (0x00000008 | 0x00000004);

    [NativeTypeName("#define TF_LBI_STATUS 0x00010000")]
    public const int TF_LBI_STATUS = 0x00010000;

    [NativeTypeName("#define TF_LBI_STYLE_HIDDENSTATUSCONTROL 0x00000001")]
    public const int TF_LBI_STYLE_HIDDENSTATUSCONTROL = 0x00000001;

    [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAY 0x00000002")]
    public const int TF_LBI_STYLE_SHOWNINTRAY = 0x00000002;

    [NativeTypeName("#define TF_LBI_STYLE_HIDEONNOOTHERITEMS 0x00000004")]
    public const int TF_LBI_STYLE_HIDEONNOOTHERITEMS = 0x00000004;

    [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAYONLY 0x00000008")]
    public const int TF_LBI_STYLE_SHOWNINTRAYONLY = 0x00000008;

    [NativeTypeName("#define TF_LBI_STYLE_HIDDENBYDEFAULT 0x00000010")]
    public const int TF_LBI_STYLE_HIDDENBYDEFAULT = 0x00000010;

    [NativeTypeName("#define TF_LBI_STYLE_TEXTCOLORICON 0x00000020")]
    public const int TF_LBI_STYLE_TEXTCOLORICON = 0x00000020;

    [NativeTypeName("#define TF_LBI_STYLE_BTN_BUTTON 0x00010000")]
    public const int TF_LBI_STYLE_BTN_BUTTON = 0x00010000;

    [NativeTypeName("#define TF_LBI_STYLE_BTN_MENU 0x00020000")]
    public const int TF_LBI_STYLE_BTN_MENU = 0x00020000;

    [NativeTypeName("#define TF_LBI_STYLE_BTN_TOGGLE 0x00040000")]
    public const int TF_LBI_STYLE_BTN_TOGGLE = 0x00040000;

    [NativeTypeName("#define TF_LBI_STATUS_HIDDEN 0x00000001")]
    public const int TF_LBI_STATUS_HIDDEN = 0x00000001;

    [NativeTypeName("#define TF_LBI_STATUS_DISABLED 0x00000002")]
    public const int TF_LBI_STATUS_DISABLED = 0x00000002;

    [NativeTypeName("#define TF_LBI_STATUS_BTN_TOGGLED 0x00010000")]
    public const int TF_LBI_STATUS_BTN_TOGGLED = 0x00010000;

    [NativeTypeName("#define TF_LBI_BMPF_VERTICAL 0x00000001")]
    public const int TF_LBI_BMPF_VERTICAL = 0x00000001;

    [NativeTypeName("#define TF_SFT_SHOWNORMAL 0x00000001")]
    public const int TF_SFT_SHOWNORMAL = 0x00000001;

    [NativeTypeName("#define TF_SFT_DOCK 0x00000002")]
    public const int TF_SFT_DOCK = 0x00000002;

    [NativeTypeName("#define TF_SFT_MINIMIZED 0x00000004")]
    public const int TF_SFT_MINIMIZED = 0x00000004;

    [NativeTypeName("#define TF_SFT_HIDDEN 0x00000008")]
    public const int TF_SFT_HIDDEN = 0x00000008;

    [NativeTypeName("#define TF_SFT_NOTRANSPARENCY 0x00000010")]
    public const int TF_SFT_NOTRANSPARENCY = 0x00000010;

    [NativeTypeName("#define TF_SFT_LOWTRANSPARENCY 0x00000020")]
    public const int TF_SFT_LOWTRANSPARENCY = 0x00000020;

    [NativeTypeName("#define TF_SFT_HIGHTRANSPARENCY 0x00000040")]
    public const int TF_SFT_HIGHTRANSPARENCY = 0x00000040;

    [NativeTypeName("#define TF_SFT_LABELS 0x00000080")]
    public const int TF_SFT_LABELS = 0x00000080;

    [NativeTypeName("#define TF_SFT_NOLABELS 0x00000100")]
    public const int TF_SFT_NOLABELS = 0x00000100;

    [NativeTypeName("#define TF_SFT_EXTRAICONSONMINIMIZED 0x00000200")]
    public const int TF_SFT_EXTRAICONSONMINIMIZED = 0x00000200;

    [NativeTypeName("#define TF_SFT_NOEXTRAICONSONMINIMIZED 0x00000400")]
    public const int TF_SFT_NOEXTRAICONSONMINIMIZED = 0x00000400;

    [NativeTypeName("#define TF_SFT_DESKBAND 0x00000800")]
    public const int TF_SFT_DESKBAND = 0x00000800;

    [NativeTypeName("#define TF_INVALIDMENUITEM (UINT)(-1)")]
    public const uint TF_INVALIDMENUITEM = unchecked((uint)(-1));

    [NativeTypeName("#define TF_DTLBI_USEPROFILEICON 0x00000001")]
    public const int TF_DTLBI_USEPROFILEICON = 0x00000001;

    [NativeTypeName("#define TF_LBI_DESC_MAXLEN ( 32 )")]
    public const int TF_LBI_DESC_MAXLEN = (32);

    [NativeTypeName("#define TF_LBMENUF_CHECKED ( 0x1 )")]
    public const int TF_LBMENUF_CHECKED = (0x1);

    [NativeTypeName("#define TF_LBMENUF_SUBMENU ( 0x2 )")]
    public const int TF_LBMENUF_SUBMENU = (0x2);

    [NativeTypeName("#define TF_LBMENUF_SEPARATOR ( 0x4 )")]
    public const int TF_LBMENUF_SEPARATOR = (0x4);

    [NativeTypeName("#define TF_LBMENUF_RADIOCHECKED ( 0x8 )")]
    public const int TF_LBMENUF_RADIOCHECKED = (0x8);

    [NativeTypeName("#define TF_LBMENUF_GRAYED ( 0x10 )")]
    public const int TF_LBMENUF_GRAYED = (0x10);
}

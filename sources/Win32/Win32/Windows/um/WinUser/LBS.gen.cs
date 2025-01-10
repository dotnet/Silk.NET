// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LBS
{
    [NativeTypeName("#define LBS_NOTIFY 0x0001L")]
    public const int LBS_NOTIFY = 0x0001;

    [NativeTypeName("#define LBS_SORT 0x0002L")]
    public const int LBS_SORT = 0x0002;

    [NativeTypeName("#define LBS_NOREDRAW 0x0004L")]
    public const int LBS_NOREDRAW = 0x0004;

    [NativeTypeName("#define LBS_MULTIPLESEL 0x0008L")]
    public const int LBS_MULTIPLESEL = 0x0008;

    [NativeTypeName("#define LBS_OWNERDRAWFIXED 0x0010L")]
    public const int LBS_OWNERDRAWFIXED = 0x0010;

    [NativeTypeName("#define LBS_OWNERDRAWVARIABLE 0x0020L")]
    public const int LBS_OWNERDRAWVARIABLE = 0x0020;

    [NativeTypeName("#define LBS_HASSTRINGS 0x0040L")]
    public const int LBS_HASSTRINGS = 0x0040;

    [NativeTypeName("#define LBS_USETABSTOPS 0x0080L")]
    public const int LBS_USETABSTOPS = 0x0080;

    [NativeTypeName("#define LBS_NOINTEGRALHEIGHT 0x0100L")]
    public const int LBS_NOINTEGRALHEIGHT = 0x0100;

    [NativeTypeName("#define LBS_MULTICOLUMN 0x0200L")]
    public const int LBS_MULTICOLUMN = 0x0200;

    [NativeTypeName("#define LBS_WANTKEYBOARDINPUT 0x0400L")]
    public const int LBS_WANTKEYBOARDINPUT = 0x0400;

    [NativeTypeName("#define LBS_EXTENDEDSEL 0x0800L")]
    public const int LBS_EXTENDEDSEL = 0x0800;

    [NativeTypeName("#define LBS_DISABLENOSCROLL 0x1000L")]
    public const int LBS_DISABLENOSCROLL = 0x1000;

    [NativeTypeName("#define LBS_NODATA 0x2000L")]
    public const int LBS_NODATA = 0x2000;

    [NativeTypeName("#define LBS_NOSEL 0x4000L")]
    public const int LBS_NOSEL = 0x4000;

    [NativeTypeName("#define LBS_COMBOBOX 0x8000L")]
    public const int LBS_COMBOBOX = 0x8000;

    [NativeTypeName("#define LBS_STANDARD (LBS_NOTIFY | LBS_SORT | WS_VSCROLL | WS_BORDER)")]
    public const int LBS_STANDARD = (0x0001 | 0x0002 | 0x00200000 | 0x00800000);
}

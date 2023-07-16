// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CBS
{
    [NativeTypeName("#define CBS_SIMPLE 0x0001L")]
    public const int CBS_SIMPLE = 0x0001;
    [NativeTypeName("#define CBS_DROPDOWN 0x0002L")]
    public const int CBS_DROPDOWN = 0x0002;
    [NativeTypeName("#define CBS_DROPDOWNLIST 0x0003L")]
    public const int CBS_DROPDOWNLIST = 0x0003;
    [NativeTypeName("#define CBS_OWNERDRAWFIXED 0x0010L")]
    public const int CBS_OWNERDRAWFIXED = 0x0010;
    [NativeTypeName("#define CBS_OWNERDRAWVARIABLE 0x0020L")]
    public const int CBS_OWNERDRAWVARIABLE = 0x0020;
    [NativeTypeName("#define CBS_AUTOHSCROLL 0x0040L")]
    public const int CBS_AUTOHSCROLL = 0x0040;
    [NativeTypeName("#define CBS_OEMCONVERT 0x0080L")]
    public const int CBS_OEMCONVERT = 0x0080;
    [NativeTypeName("#define CBS_SORT 0x0100L")]
    public const int CBS_SORT = 0x0100;
    [NativeTypeName("#define CBS_HASSTRINGS 0x0200L")]
    public const int CBS_HASSTRINGS = 0x0200;
    [NativeTypeName("#define CBS_NOINTEGRALHEIGHT 0x0400L")]
    public const int CBS_NOINTEGRALHEIGHT = 0x0400;
    [NativeTypeName("#define CBS_DISABLENOSCROLL 0x0800L")]
    public const int CBS_DISABLENOSCROLL = 0x0800;
    [NativeTypeName("#define CBS_UPPERCASE 0x2000L")]
    public const int CBS_UPPERCASE = 0x2000;
    [NativeTypeName("#define CBS_LOWERCASE 0x4000L")]
    public const int CBS_LOWERCASE = 0x4000;
}
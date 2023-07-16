// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CB
{
    [NativeTypeName("#define CB_OKAY 0")]
    public const int CB_OKAY = 0;
    [NativeTypeName("#define CB_ERR (-1)")]
    public const int CB_ERR = (-1);
    [NativeTypeName("#define CB_ERRSPACE (-2)")]
    public const int CB_ERRSPACE = (-2);
    [NativeTypeName("#define CB_GETEDITSEL 0x0140")]
    public const int CB_GETEDITSEL = 0x0140;
    [NativeTypeName("#define CB_LIMITTEXT 0x0141")]
    public const int CB_LIMITTEXT = 0x0141;
    [NativeTypeName("#define CB_SETEDITSEL 0x0142")]
    public const int CB_SETEDITSEL = 0x0142;
    [NativeTypeName("#define CB_ADDSTRING 0x0143")]
    public const int CB_ADDSTRING = 0x0143;
    [NativeTypeName("#define CB_DELETESTRING 0x0144")]
    public const int CB_DELETESTRING = 0x0144;
    [NativeTypeName("#define CB_DIR 0x0145")]
    public const int CB_DIR = 0x0145;
    [NativeTypeName("#define CB_GETCOUNT 0x0146")]
    public const int CB_GETCOUNT = 0x0146;
    [NativeTypeName("#define CB_GETCURSEL 0x0147")]
    public const int CB_GETCURSEL = 0x0147;
    [NativeTypeName("#define CB_GETLBTEXT 0x0148")]
    public const int CB_GETLBTEXT = 0x0148;
    [NativeTypeName("#define CB_GETLBTEXTLEN 0x0149")]
    public const int CB_GETLBTEXTLEN = 0x0149;
    [NativeTypeName("#define CB_INSERTSTRING 0x014A")]
    public const int CB_INSERTSTRING = 0x014A;
    [NativeTypeName("#define CB_RESETCONTENT 0x014B")]
    public const int CB_RESETCONTENT = 0x014B;
    [NativeTypeName("#define CB_FINDSTRING 0x014C")]
    public const int CB_FINDSTRING = 0x014C;
    [NativeTypeName("#define CB_SELECTSTRING 0x014D")]
    public const int CB_SELECTSTRING = 0x014D;
    [NativeTypeName("#define CB_SETCURSEL 0x014E")]
    public const int CB_SETCURSEL = 0x014E;
    [NativeTypeName("#define CB_SHOWDROPDOWN 0x014F")]
    public const int CB_SHOWDROPDOWN = 0x014F;
    [NativeTypeName("#define CB_GETITEMDATA 0x0150")]
    public const int CB_GETITEMDATA = 0x0150;
    [NativeTypeName("#define CB_SETITEMDATA 0x0151")]
    public const int CB_SETITEMDATA = 0x0151;
    [NativeTypeName("#define CB_GETDROPPEDCONTROLRECT 0x0152")]
    public const int CB_GETDROPPEDCONTROLRECT = 0x0152;
    [NativeTypeName("#define CB_SETITEMHEIGHT 0x0153")]
    public const int CB_SETITEMHEIGHT = 0x0153;
    [NativeTypeName("#define CB_GETITEMHEIGHT 0x0154")]
    public const int CB_GETITEMHEIGHT = 0x0154;
    [NativeTypeName("#define CB_SETEXTENDEDUI 0x0155")]
    public const int CB_SETEXTENDEDUI = 0x0155;
    [NativeTypeName("#define CB_GETEXTENDEDUI 0x0156")]
    public const int CB_GETEXTENDEDUI = 0x0156;
    [NativeTypeName("#define CB_GETDROPPEDSTATE 0x0157")]
    public const int CB_GETDROPPEDSTATE = 0x0157;
    [NativeTypeName("#define CB_FINDSTRINGEXACT 0x0158")]
    public const int CB_FINDSTRINGEXACT = 0x0158;
    [NativeTypeName("#define CB_SETLOCALE 0x0159")]
    public const int CB_SETLOCALE = 0x0159;
    [NativeTypeName("#define CB_GETLOCALE 0x015A")]
    public const int CB_GETLOCALE = 0x015A;
    [NativeTypeName("#define CB_GETTOPINDEX 0x015b")]
    public const int CB_GETTOPINDEX = 0x015b;
    [NativeTypeName("#define CB_SETTOPINDEX 0x015c")]
    public const int CB_SETTOPINDEX = 0x015c;
    [NativeTypeName("#define CB_GETHORIZONTALEXTENT 0x015d")]
    public const int CB_GETHORIZONTALEXTENT = 0x015d;
    [NativeTypeName("#define CB_SETHORIZONTALEXTENT 0x015e")]
    public const int CB_SETHORIZONTALEXTENT = 0x015e;
    [NativeTypeName("#define CB_GETDROPPEDWIDTH 0x015f")]
    public const int CB_GETDROPPEDWIDTH = 0x015f;
    [NativeTypeName("#define CB_SETDROPPEDWIDTH 0x0160")]
    public const int CB_SETDROPPEDWIDTH = 0x0160;
    [NativeTypeName("#define CB_INITSTORAGE 0x0161")]
    public const int CB_INITSTORAGE = 0x0161;
    [NativeTypeName("#define CB_GETCOMBOBOXINFO 0x0164")]
    public const int CB_GETCOMBOBOXINFO = 0x0164;
    [NativeTypeName("#define CB_MSGMAX 0x0165")]
    public const int CB_MSGMAX = 0x0165;
}
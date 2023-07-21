// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class LB
{
    [NativeTypeName("#define LB_CTLCODE 0L")]
    public const int LB_CTLCODE = 0;

    [NativeTypeName("#define LB_OKAY 0")]
    public const int LB_OKAY = 0;

    [NativeTypeName("#define LB_ERR (-1)")]
    public const int LB_ERR = (-1);

    [NativeTypeName("#define LB_ERRSPACE (-2)")]
    public const int LB_ERRSPACE = (-2);

    [NativeTypeName("#define LB_ADDSTRING 0x0180")]
    public const int LB_ADDSTRING = 0x0180;

    [NativeTypeName("#define LB_INSERTSTRING 0x0181")]
    public const int LB_INSERTSTRING = 0x0181;

    [NativeTypeName("#define LB_DELETESTRING 0x0182")]
    public const int LB_DELETESTRING = 0x0182;

    [NativeTypeName("#define LB_SELITEMRANGEEX 0x0183")]
    public const int LB_SELITEMRANGEEX = 0x0183;

    [NativeTypeName("#define LB_RESETCONTENT 0x0184")]
    public const int LB_RESETCONTENT = 0x0184;

    [NativeTypeName("#define LB_SETSEL 0x0185")]
    public const int LB_SETSEL = 0x0185;

    [NativeTypeName("#define LB_SETCURSEL 0x0186")]
    public const int LB_SETCURSEL = 0x0186;

    [NativeTypeName("#define LB_GETSEL 0x0187")]
    public const int LB_GETSEL = 0x0187;

    [NativeTypeName("#define LB_GETCURSEL 0x0188")]
    public const int LB_GETCURSEL = 0x0188;

    [NativeTypeName("#define LB_GETTEXT 0x0189")]
    public const int LB_GETTEXT = 0x0189;

    [NativeTypeName("#define LB_GETTEXTLEN 0x018A")]
    public const int LB_GETTEXTLEN = 0x018A;

    [NativeTypeName("#define LB_GETCOUNT 0x018B")]
    public const int LB_GETCOUNT = 0x018B;

    [NativeTypeName("#define LB_SELECTSTRING 0x018C")]
    public const int LB_SELECTSTRING = 0x018C;

    [NativeTypeName("#define LB_DIR 0x018D")]
    public const int LB_DIR = 0x018D;

    [NativeTypeName("#define LB_GETTOPINDEX 0x018E")]
    public const int LB_GETTOPINDEX = 0x018E;

    [NativeTypeName("#define LB_FINDSTRING 0x018F")]
    public const int LB_FINDSTRING = 0x018F;

    [NativeTypeName("#define LB_GETSELCOUNT 0x0190")]
    public const int LB_GETSELCOUNT = 0x0190;

    [NativeTypeName("#define LB_GETSELITEMS 0x0191")]
    public const int LB_GETSELITEMS = 0x0191;

    [NativeTypeName("#define LB_SETTABSTOPS 0x0192")]
    public const int LB_SETTABSTOPS = 0x0192;

    [NativeTypeName("#define LB_GETHORIZONTALEXTENT 0x0193")]
    public const int LB_GETHORIZONTALEXTENT = 0x0193;

    [NativeTypeName("#define LB_SETHORIZONTALEXTENT 0x0194")]
    public const int LB_SETHORIZONTALEXTENT = 0x0194;

    [NativeTypeName("#define LB_SETCOLUMNWIDTH 0x0195")]
    public const int LB_SETCOLUMNWIDTH = 0x0195;

    [NativeTypeName("#define LB_ADDFILE 0x0196")]
    public const int LB_ADDFILE = 0x0196;

    [NativeTypeName("#define LB_SETTOPINDEX 0x0197")]
    public const int LB_SETTOPINDEX = 0x0197;

    [NativeTypeName("#define LB_GETITEMRECT 0x0198")]
    public const int LB_GETITEMRECT = 0x0198;

    [NativeTypeName("#define LB_GETITEMDATA 0x0199")]
    public const int LB_GETITEMDATA = 0x0199;

    [NativeTypeName("#define LB_SETITEMDATA 0x019A")]
    public const int LB_SETITEMDATA = 0x019A;

    [NativeTypeName("#define LB_SELITEMRANGE 0x019B")]
    public const int LB_SELITEMRANGE = 0x019B;

    [NativeTypeName("#define LB_SETANCHORINDEX 0x019C")]
    public const int LB_SETANCHORINDEX = 0x019C;

    [NativeTypeName("#define LB_GETANCHORINDEX 0x019D")]
    public const int LB_GETANCHORINDEX = 0x019D;

    [NativeTypeName("#define LB_SETCARETINDEX 0x019E")]
    public const int LB_SETCARETINDEX = 0x019E;

    [NativeTypeName("#define LB_GETCARETINDEX 0x019F")]
    public const int LB_GETCARETINDEX = 0x019F;

    [NativeTypeName("#define LB_SETITEMHEIGHT 0x01A0")]
    public const int LB_SETITEMHEIGHT = 0x01A0;

    [NativeTypeName("#define LB_GETITEMHEIGHT 0x01A1")]
    public const int LB_GETITEMHEIGHT = 0x01A1;

    [NativeTypeName("#define LB_FINDSTRINGEXACT 0x01A2")]
    public const int LB_FINDSTRINGEXACT = 0x01A2;

    [NativeTypeName("#define LB_SETLOCALE 0x01A5")]
    public const int LB_SETLOCALE = 0x01A5;

    [NativeTypeName("#define LB_GETLOCALE 0x01A6")]
    public const int LB_GETLOCALE = 0x01A6;

    [NativeTypeName("#define LB_SETCOUNT 0x01A7")]
    public const int LB_SETCOUNT = 0x01A7;

    [NativeTypeName("#define LB_INITSTORAGE 0x01A8")]
    public const int LB_INITSTORAGE = 0x01A8;

    [NativeTypeName("#define LB_ITEMFROMPOINT 0x01A9")]
    public const int LB_ITEMFROMPOINT = 0x01A9;

    [NativeTypeName("#define LB_GETLISTBOXINFO 0x01B2")]
    public const int LB_GETLISTBOXINFO = 0x01B2;

    [NativeTypeName("#define LB_MSGMAX 0x01B3")]
    public const int LB_MSGMAX = 0x01B3;
}

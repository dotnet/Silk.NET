// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TVM
{
    [NativeTypeName("#define TVM_INSERTITEMA (TV_FIRST + 0)")]
    public const int TVM_INSERTITEMA = (0x1100 + 0);

    [NativeTypeName("#define TVM_INSERTITEMW (TV_FIRST + 50)")]
    public const int TVM_INSERTITEMW = (0x1100 + 50);

    [NativeTypeName("#define TVM_INSERTITEM TVM_INSERTITEMW")]
    public const int TVM_INSERTITEM = (0x1100 + 50);

    [NativeTypeName("#define TVM_DELETEITEM (TV_FIRST + 1)")]
    public const int TVM_DELETEITEM = (0x1100 + 1);

    [NativeTypeName("#define TVM_EXPAND (TV_FIRST + 2)")]
    public const int TVM_EXPAND = (0x1100 + 2);

    [NativeTypeName("#define TVM_GETITEMRECT (TV_FIRST + 4)")]
    public const int TVM_GETITEMRECT = (0x1100 + 4);

    [NativeTypeName("#define TVM_GETCOUNT (TV_FIRST + 5)")]
    public const int TVM_GETCOUNT = (0x1100 + 5);

    [NativeTypeName("#define TVM_GETINDENT (TV_FIRST + 6)")]
    public const int TVM_GETINDENT = (0x1100 + 6);

    [NativeTypeName("#define TVM_SETINDENT (TV_FIRST + 7)")]
    public const int TVM_SETINDENT = (0x1100 + 7);

    [NativeTypeName("#define TVM_GETIMAGELIST (TV_FIRST + 8)")]
    public const int TVM_GETIMAGELIST = (0x1100 + 8);

    [NativeTypeName("#define TVM_SETIMAGELIST (TV_FIRST + 9)")]
    public const int TVM_SETIMAGELIST = (0x1100 + 9);

    [NativeTypeName("#define TVM_GETNEXTITEM (TV_FIRST + 10)")]
    public const int TVM_GETNEXTITEM = (0x1100 + 10);

    [NativeTypeName("#define TVM_SELECTITEM (TV_FIRST + 11)")]
    public const int TVM_SELECTITEM = (0x1100 + 11);

    [NativeTypeName("#define TVM_GETITEMA (TV_FIRST + 12)")]
    public const int TVM_GETITEMA = (0x1100 + 12);

    [NativeTypeName("#define TVM_GETITEMW (TV_FIRST + 62)")]
    public const int TVM_GETITEMW = (0x1100 + 62);

    [NativeTypeName("#define TVM_GETITEM TVM_GETITEMW")]
    public const int TVM_GETITEM = (0x1100 + 62);

    [NativeTypeName("#define TVM_SETITEMA (TV_FIRST + 13)")]
    public const int TVM_SETITEMA = (0x1100 + 13);

    [NativeTypeName("#define TVM_SETITEMW (TV_FIRST + 63)")]
    public const int TVM_SETITEMW = (0x1100 + 63);

    [NativeTypeName("#define TVM_SETITEM TVM_SETITEMW")]
    public const int TVM_SETITEM = (0x1100 + 63);

    [NativeTypeName("#define TVM_EDITLABELA (TV_FIRST + 14)")]
    public const int TVM_EDITLABELA = (0x1100 + 14);

    [NativeTypeName("#define TVM_EDITLABELW (TV_FIRST + 65)")]
    public const int TVM_EDITLABELW = (0x1100 + 65);

    [NativeTypeName("#define TVM_EDITLABEL TVM_EDITLABELW")]
    public const int TVM_EDITLABEL = (0x1100 + 65);

    [NativeTypeName("#define TVM_GETEDITCONTROL (TV_FIRST + 15)")]
    public const int TVM_GETEDITCONTROL = (0x1100 + 15);

    [NativeTypeName("#define TVM_GETVISIBLECOUNT (TV_FIRST + 16)")]
    public const int TVM_GETVISIBLECOUNT = (0x1100 + 16);

    [NativeTypeName("#define TVM_HITTEST (TV_FIRST + 17)")]
    public const int TVM_HITTEST = (0x1100 + 17);

    [NativeTypeName("#define TVM_CREATEDRAGIMAGE (TV_FIRST + 18)")]
    public const int TVM_CREATEDRAGIMAGE = (0x1100 + 18);

    [NativeTypeName("#define TVM_SORTCHILDREN (TV_FIRST + 19)")]
    public const int TVM_SORTCHILDREN = (0x1100 + 19);

    [NativeTypeName("#define TVM_ENSUREVISIBLE (TV_FIRST + 20)")]
    public const int TVM_ENSUREVISIBLE = (0x1100 + 20);

    [NativeTypeName("#define TVM_SORTCHILDRENCB (TV_FIRST + 21)")]
    public const int TVM_SORTCHILDRENCB = (0x1100 + 21);

    [NativeTypeName("#define TVM_ENDEDITLABELNOW (TV_FIRST + 22)")]
    public const int TVM_ENDEDITLABELNOW = (0x1100 + 22);

    [NativeTypeName("#define TVM_GETISEARCHSTRINGA (TV_FIRST + 23)")]
    public const int TVM_GETISEARCHSTRINGA = (0x1100 + 23);

    [NativeTypeName("#define TVM_GETISEARCHSTRINGW (TV_FIRST + 64)")]
    public const int TVM_GETISEARCHSTRINGW = (0x1100 + 64);

    [NativeTypeName("#define TVM_GETISEARCHSTRING TVM_GETISEARCHSTRINGW")]
    public const int TVM_GETISEARCHSTRING = (0x1100 + 64);

    [NativeTypeName("#define TVM_SETTOOLTIPS (TV_FIRST + 24)")]
    public const int TVM_SETTOOLTIPS = (0x1100 + 24);

    [NativeTypeName("#define TVM_GETTOOLTIPS (TV_FIRST + 25)")]
    public const int TVM_GETTOOLTIPS = (0x1100 + 25);

    [NativeTypeName("#define TVM_SETINSERTMARK (TV_FIRST + 26)")]
    public const int TVM_SETINSERTMARK = (0x1100 + 26);

    [NativeTypeName("#define TVM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int TVM_SETUNICODEFORMAT = (0x2000 + 5);

    [NativeTypeName("#define TVM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int TVM_GETUNICODEFORMAT = (0x2000 + 6);

    [NativeTypeName("#define TVM_SETITEMHEIGHT (TV_FIRST + 27)")]
    public const int TVM_SETITEMHEIGHT = (0x1100 + 27);

    [NativeTypeName("#define TVM_GETITEMHEIGHT (TV_FIRST + 28)")]
    public const int TVM_GETITEMHEIGHT = (0x1100 + 28);

    [NativeTypeName("#define TVM_SETBKCOLOR (TV_FIRST + 29)")]
    public const int TVM_SETBKCOLOR = (0x1100 + 29);

    [NativeTypeName("#define TVM_SETTEXTCOLOR (TV_FIRST + 30)")]
    public const int TVM_SETTEXTCOLOR = (0x1100 + 30);

    [NativeTypeName("#define TVM_GETBKCOLOR (TV_FIRST + 31)")]
    public const int TVM_GETBKCOLOR = (0x1100 + 31);

    [NativeTypeName("#define TVM_GETTEXTCOLOR (TV_FIRST + 32)")]
    public const int TVM_GETTEXTCOLOR = (0x1100 + 32);

    [NativeTypeName("#define TVM_SETSCROLLTIME (TV_FIRST + 33)")]
    public const int TVM_SETSCROLLTIME = (0x1100 + 33);

    [NativeTypeName("#define TVM_GETSCROLLTIME (TV_FIRST + 34)")]
    public const int TVM_GETSCROLLTIME = (0x1100 + 34);

    [NativeTypeName("#define TVM_SETINSERTMARKCOLOR (TV_FIRST + 37)")]
    public const int TVM_SETINSERTMARKCOLOR = (0x1100 + 37);

    [NativeTypeName("#define TVM_GETINSERTMARKCOLOR (TV_FIRST + 38)")]
    public const int TVM_GETINSERTMARKCOLOR = (0x1100 + 38);

    [NativeTypeName("#define TVM_SETBORDER (TV_FIRST + 35)")]
    public const int TVM_SETBORDER = (0x1100 + 35);

    [NativeTypeName("#define TVM_GETITEMSTATE (TV_FIRST + 39)")]
    public const int TVM_GETITEMSTATE = (0x1100 + 39);

    [NativeTypeName("#define TVM_SETLINECOLOR (TV_FIRST + 40)")]
    public const int TVM_SETLINECOLOR = (0x1100 + 40);

    [NativeTypeName("#define TVM_GETLINECOLOR (TV_FIRST + 41)")]
    public const int TVM_GETLINECOLOR = (0x1100 + 41);

    [NativeTypeName("#define TVM_MAPACCIDTOHTREEITEM (TV_FIRST + 42)")]
    public const int TVM_MAPACCIDTOHTREEITEM = (0x1100 + 42);

    [NativeTypeName("#define TVM_MAPHTREEITEMTOACCID (TV_FIRST + 43)")]
    public const int TVM_MAPHTREEITEMTOACCID = (0x1100 + 43);

    [NativeTypeName("#define TVM_SETEXTENDEDSTYLE (TV_FIRST + 44)")]
    public const int TVM_SETEXTENDEDSTYLE = (0x1100 + 44);

    [NativeTypeName("#define TVM_GETEXTENDEDSTYLE (TV_FIRST + 45)")]
    public const int TVM_GETEXTENDEDSTYLE = (0x1100 + 45);

    [NativeTypeName("#define TVM_SETAUTOSCROLLINFO (TV_FIRST + 59)")]
    public const int TVM_SETAUTOSCROLLINFO = (0x1100 + 59);

    [NativeTypeName("#define TVM_SETHOT (TV_FIRST + 58)")]
    public const int TVM_SETHOT = (0x1100 + 58);

    [NativeTypeName("#define TVM_GETSELECTEDCOUNT (TV_FIRST + 70)")]
    public const int TVM_GETSELECTEDCOUNT = (0x1100 + 70);

    [NativeTypeName("#define TVM_SHOWINFOTIP (TV_FIRST + 71)")]
    public const int TVM_SHOWINFOTIP = (0x1100 + 71);

    [NativeTypeName("#define TVM_GETITEMPARTRECT (TV_FIRST + 72)")]
    public const int TVM_GETITEMPARTRECT = (0x1100 + 72);
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class LVM
{
    [NativeTypeName("#define LVM_FIRST 0x1000")]
    public const int LVM_FIRST = 0x1000;

    [NativeTypeName("#define LVM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int LVM_SETUNICODEFORMAT = (0x2000 + 5);

    [NativeTypeName("#define LVM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int LVM_GETUNICODEFORMAT = (0x2000 + 6);

    [NativeTypeName("#define LVM_GETBKCOLOR (LVM_FIRST + 0)")]
    public const int LVM_GETBKCOLOR = (0x1000 + 0);

    [NativeTypeName("#define LVM_SETBKCOLOR (LVM_FIRST + 1)")]
    public const int LVM_SETBKCOLOR = (0x1000 + 1);

    [NativeTypeName("#define LVM_GETIMAGELIST (LVM_FIRST + 2)")]
    public const int LVM_GETIMAGELIST = (0x1000 + 2);

    [NativeTypeName("#define LVM_SETIMAGELIST (LVM_FIRST + 3)")]
    public const int LVM_SETIMAGELIST = (0x1000 + 3);

    [NativeTypeName("#define LVM_GETITEMCOUNT (LVM_FIRST + 4)")]
    public const int LVM_GETITEMCOUNT = (0x1000 + 4);

    [NativeTypeName("#define LVM_GETITEMA (LVM_FIRST + 5)")]
    public const int LVM_GETITEMA = (0x1000 + 5);

    [NativeTypeName("#define LVM_GETITEMW (LVM_FIRST + 75)")]
    public const int LVM_GETITEMW = (0x1000 + 75);

    [NativeTypeName("#define LVM_GETITEM LVM_GETITEMW")]
    public const int LVM_GETITEM = (0x1000 + 75);

    [NativeTypeName("#define LVM_SETITEMA (LVM_FIRST + 6)")]
    public const int LVM_SETITEMA = (0x1000 + 6);

    [NativeTypeName("#define LVM_SETITEMW (LVM_FIRST + 76)")]
    public const int LVM_SETITEMW = (0x1000 + 76);

    [NativeTypeName("#define LVM_SETITEM LVM_SETITEMW")]
    public const int LVM_SETITEM = (0x1000 + 76);

    [NativeTypeName("#define LVM_INSERTITEMA (LVM_FIRST + 7)")]
    public const int LVM_INSERTITEMA = (0x1000 + 7);

    [NativeTypeName("#define LVM_INSERTITEMW (LVM_FIRST + 77)")]
    public const int LVM_INSERTITEMW = (0x1000 + 77);

    [NativeTypeName("#define LVM_INSERTITEM LVM_INSERTITEMW")]
    public const int LVM_INSERTITEM = (0x1000 + 77);

    [NativeTypeName("#define LVM_DELETEITEM (LVM_FIRST + 8)")]
    public const int LVM_DELETEITEM = (0x1000 + 8);

    [NativeTypeName("#define LVM_DELETEALLITEMS (LVM_FIRST + 9)")]
    public const int LVM_DELETEALLITEMS = (0x1000 + 9);

    [NativeTypeName("#define LVM_GETCALLBACKMASK (LVM_FIRST + 10)")]
    public const int LVM_GETCALLBACKMASK = (0x1000 + 10);

    [NativeTypeName("#define LVM_SETCALLBACKMASK (LVM_FIRST + 11)")]
    public const int LVM_SETCALLBACKMASK = (0x1000 + 11);

    [NativeTypeName("#define LVM_GETNEXTITEM (LVM_FIRST + 12)")]
    public const int LVM_GETNEXTITEM = (0x1000 + 12);

    [NativeTypeName("#define LVM_FINDITEMA (LVM_FIRST + 13)")]
    public const int LVM_FINDITEMA = (0x1000 + 13);

    [NativeTypeName("#define LVM_FINDITEMW (LVM_FIRST + 83)")]
    public const int LVM_FINDITEMW = (0x1000 + 83);

    [NativeTypeName("#define LVM_FINDITEM LVM_FINDITEMW")]
    public const int LVM_FINDITEM = (0x1000 + 83);

    [NativeTypeName("#define LVM_GETITEMRECT (LVM_FIRST + 14)")]
    public const int LVM_GETITEMRECT = (0x1000 + 14);

    [NativeTypeName("#define LVM_SETITEMPOSITION (LVM_FIRST + 15)")]
    public const int LVM_SETITEMPOSITION = (0x1000 + 15);

    [NativeTypeName("#define LVM_GETITEMPOSITION (LVM_FIRST + 16)")]
    public const int LVM_GETITEMPOSITION = (0x1000 + 16);

    [NativeTypeName("#define LVM_GETSTRINGWIDTHA (LVM_FIRST + 17)")]
    public const int LVM_GETSTRINGWIDTHA = (0x1000 + 17);

    [NativeTypeName("#define LVM_GETSTRINGWIDTHW (LVM_FIRST + 87)")]
    public const int LVM_GETSTRINGWIDTHW = (0x1000 + 87);

    [NativeTypeName("#define LVM_GETSTRINGWIDTH LVM_GETSTRINGWIDTHW")]
    public const int LVM_GETSTRINGWIDTH = (0x1000 + 87);

    [NativeTypeName("#define LVM_HITTEST (LVM_FIRST + 18)")]
    public const int LVM_HITTEST = (0x1000 + 18);

    [NativeTypeName("#define LVM_ENSUREVISIBLE (LVM_FIRST + 19)")]
    public const int LVM_ENSUREVISIBLE = (0x1000 + 19);

    [NativeTypeName("#define LVM_SCROLL (LVM_FIRST + 20)")]
    public const int LVM_SCROLL = (0x1000 + 20);

    [NativeTypeName("#define LVM_REDRAWITEMS (LVM_FIRST + 21)")]
    public const int LVM_REDRAWITEMS = (0x1000 + 21);

    [NativeTypeName("#define LVM_ARRANGE (LVM_FIRST + 22)")]
    public const int LVM_ARRANGE = (0x1000 + 22);

    [NativeTypeName("#define LVM_EDITLABELA (LVM_FIRST + 23)")]
    public const int LVM_EDITLABELA = (0x1000 + 23);

    [NativeTypeName("#define LVM_EDITLABELW (LVM_FIRST + 118)")]
    public const int LVM_EDITLABELW = (0x1000 + 118);

    [NativeTypeName("#define LVM_EDITLABEL LVM_EDITLABELW")]
    public const int LVM_EDITLABEL = (0x1000 + 118);

    [NativeTypeName("#define LVM_GETEDITCONTROL (LVM_FIRST + 24)")]
    public const int LVM_GETEDITCONTROL = (0x1000 + 24);

    [NativeTypeName("#define LVM_GETCOLUMNA (LVM_FIRST + 25)")]
    public const int LVM_GETCOLUMNA = (0x1000 + 25);

    [NativeTypeName("#define LVM_GETCOLUMNW (LVM_FIRST + 95)")]
    public const int LVM_GETCOLUMNW = (0x1000 + 95);

    [NativeTypeName("#define LVM_GETCOLUMN LVM_GETCOLUMNW")]
    public const int LVM_GETCOLUMN = (0x1000 + 95);

    [NativeTypeName("#define LVM_SETCOLUMNA (LVM_FIRST + 26)")]
    public const int LVM_SETCOLUMNA = (0x1000 + 26);

    [NativeTypeName("#define LVM_SETCOLUMNW (LVM_FIRST + 96)")]
    public const int LVM_SETCOLUMNW = (0x1000 + 96);

    [NativeTypeName("#define LVM_SETCOLUMN LVM_SETCOLUMNW")]
    public const int LVM_SETCOLUMN = (0x1000 + 96);

    [NativeTypeName("#define LVM_INSERTCOLUMNA (LVM_FIRST + 27)")]
    public const int LVM_INSERTCOLUMNA = (0x1000 + 27);

    [NativeTypeName("#define LVM_INSERTCOLUMNW (LVM_FIRST + 97)")]
    public const int LVM_INSERTCOLUMNW = (0x1000 + 97);

    [NativeTypeName("#define LVM_INSERTCOLUMN LVM_INSERTCOLUMNW")]
    public const int LVM_INSERTCOLUMN = (0x1000 + 97);

    [NativeTypeName("#define LVM_DELETECOLUMN (LVM_FIRST + 28)")]
    public const int LVM_DELETECOLUMN = (0x1000 + 28);

    [NativeTypeName("#define LVM_GETCOLUMNWIDTH (LVM_FIRST + 29)")]
    public const int LVM_GETCOLUMNWIDTH = (0x1000 + 29);

    [NativeTypeName("#define LVM_SETCOLUMNWIDTH (LVM_FIRST + 30)")]
    public const int LVM_SETCOLUMNWIDTH = (0x1000 + 30);

    [NativeTypeName("#define LVM_GETHEADER (LVM_FIRST + 31)")]
    public const int LVM_GETHEADER = (0x1000 + 31);

    [NativeTypeName("#define LVM_CREATEDRAGIMAGE (LVM_FIRST + 33)")]
    public const int LVM_CREATEDRAGIMAGE = (0x1000 + 33);

    [NativeTypeName("#define LVM_GETVIEWRECT (LVM_FIRST + 34)")]
    public const int LVM_GETVIEWRECT = (0x1000 + 34);

    [NativeTypeName("#define LVM_GETTEXTCOLOR (LVM_FIRST + 35)")]
    public const int LVM_GETTEXTCOLOR = (0x1000 + 35);

    [NativeTypeName("#define LVM_SETTEXTCOLOR (LVM_FIRST + 36)")]
    public const int LVM_SETTEXTCOLOR = (0x1000 + 36);

    [NativeTypeName("#define LVM_GETTEXTBKCOLOR (LVM_FIRST + 37)")]
    public const int LVM_GETTEXTBKCOLOR = (0x1000 + 37);

    [NativeTypeName("#define LVM_SETTEXTBKCOLOR (LVM_FIRST + 38)")]
    public const int LVM_SETTEXTBKCOLOR = (0x1000 + 38);

    [NativeTypeName("#define LVM_GETTOPINDEX (LVM_FIRST + 39)")]
    public const int LVM_GETTOPINDEX = (0x1000 + 39);

    [NativeTypeName("#define LVM_GETCOUNTPERPAGE (LVM_FIRST + 40)")]
    public const int LVM_GETCOUNTPERPAGE = (0x1000 + 40);

    [NativeTypeName("#define LVM_GETORIGIN (LVM_FIRST + 41)")]
    public const int LVM_GETORIGIN = (0x1000 + 41);

    [NativeTypeName("#define LVM_UPDATE (LVM_FIRST + 42)")]
    public const int LVM_UPDATE = (0x1000 + 42);

    [NativeTypeName("#define LVM_SETITEMSTATE (LVM_FIRST + 43)")]
    public const int LVM_SETITEMSTATE = (0x1000 + 43);

    [NativeTypeName("#define LVM_GETITEMSTATE (LVM_FIRST + 44)")]
    public const int LVM_GETITEMSTATE = (0x1000 + 44);

    [NativeTypeName("#define LVM_GETITEMTEXTA (LVM_FIRST + 45)")]
    public const int LVM_GETITEMTEXTA = (0x1000 + 45);

    [NativeTypeName("#define LVM_GETITEMTEXTW (LVM_FIRST + 115)")]
    public const int LVM_GETITEMTEXTW = (0x1000 + 115);

    [NativeTypeName("#define LVM_GETITEMTEXT LVM_GETITEMTEXTW")]
    public const int LVM_GETITEMTEXT = (0x1000 + 115);

    [NativeTypeName("#define LVM_SETITEMTEXTA (LVM_FIRST + 46)")]
    public const int LVM_SETITEMTEXTA = (0x1000 + 46);

    [NativeTypeName("#define LVM_SETITEMTEXTW (LVM_FIRST + 116)")]
    public const int LVM_SETITEMTEXTW = (0x1000 + 116);

    [NativeTypeName("#define LVM_SETITEMTEXT LVM_SETITEMTEXTW")]
    public const int LVM_SETITEMTEXT = (0x1000 + 116);

    [NativeTypeName("#define LVM_SETITEMCOUNT (LVM_FIRST + 47)")]
    public const int LVM_SETITEMCOUNT = (0x1000 + 47);

    [NativeTypeName("#define LVM_SORTITEMS (LVM_FIRST + 48)")]
    public const int LVM_SORTITEMS = (0x1000 + 48);

    [NativeTypeName("#define LVM_SETITEMPOSITION32 (LVM_FIRST + 49)")]
    public const int LVM_SETITEMPOSITION32 = (0x1000 + 49);

    [NativeTypeName("#define LVM_GETSELECTEDCOUNT (LVM_FIRST + 50)")]
    public const int LVM_GETSELECTEDCOUNT = (0x1000 + 50);

    [NativeTypeName("#define LVM_GETITEMSPACING (LVM_FIRST + 51)")]
    public const int LVM_GETITEMSPACING = (0x1000 + 51);

    [NativeTypeName("#define LVM_GETISEARCHSTRINGA (LVM_FIRST + 52)")]
    public const int LVM_GETISEARCHSTRINGA = (0x1000 + 52);

    [NativeTypeName("#define LVM_GETISEARCHSTRINGW (LVM_FIRST + 117)")]
    public const int LVM_GETISEARCHSTRINGW = (0x1000 + 117);

    [NativeTypeName("#define LVM_GETISEARCHSTRING LVM_GETISEARCHSTRINGW")]
    public const int LVM_GETISEARCHSTRING = (0x1000 + 117);

    [NativeTypeName("#define LVM_SETICONSPACING (LVM_FIRST + 53)")]
    public const int LVM_SETICONSPACING = (0x1000 + 53);

    [NativeTypeName("#define LVM_SETEXTENDEDLISTVIEWSTYLE (LVM_FIRST + 54)")]
    public const int LVM_SETEXTENDEDLISTVIEWSTYLE = (0x1000 + 54);

    [NativeTypeName("#define LVM_GETEXTENDEDLISTVIEWSTYLE (LVM_FIRST + 55)")]
    public const int LVM_GETEXTENDEDLISTVIEWSTYLE = (0x1000 + 55);

    [NativeTypeName("#define LVM_GETSUBITEMRECT (LVM_FIRST + 56)")]
    public const int LVM_GETSUBITEMRECT = (0x1000 + 56);

    [NativeTypeName("#define LVM_SUBITEMHITTEST (LVM_FIRST + 57)")]
    public const int LVM_SUBITEMHITTEST = (0x1000 + 57);

    [NativeTypeName("#define LVM_SETCOLUMNORDERARRAY (LVM_FIRST + 58)")]
    public const int LVM_SETCOLUMNORDERARRAY = (0x1000 + 58);

    [NativeTypeName("#define LVM_GETCOLUMNORDERARRAY (LVM_FIRST + 59)")]
    public const int LVM_GETCOLUMNORDERARRAY = (0x1000 + 59);

    [NativeTypeName("#define LVM_SETHOTITEM (LVM_FIRST + 60)")]
    public const int LVM_SETHOTITEM = (0x1000 + 60);

    [NativeTypeName("#define LVM_GETHOTITEM (LVM_FIRST + 61)")]
    public const int LVM_GETHOTITEM = (0x1000 + 61);

    [NativeTypeName("#define LVM_SETHOTCURSOR (LVM_FIRST + 62)")]
    public const int LVM_SETHOTCURSOR = (0x1000 + 62);

    [NativeTypeName("#define LVM_GETHOTCURSOR (LVM_FIRST + 63)")]
    public const int LVM_GETHOTCURSOR = (0x1000 + 63);

    [NativeTypeName("#define LVM_APPROXIMATEVIEWRECT (LVM_FIRST + 64)")]
    public const int LVM_APPROXIMATEVIEWRECT = (0x1000 + 64);

    [NativeTypeName("#define LVM_SETWORKAREAS (LVM_FIRST + 65)")]
    public const int LVM_SETWORKAREAS = (0x1000 + 65);

    [NativeTypeName("#define LVM_GETWORKAREAS (LVM_FIRST + 70)")]
    public const int LVM_GETWORKAREAS = (0x1000 + 70);

    [NativeTypeName("#define LVM_GETNUMBEROFWORKAREAS (LVM_FIRST + 73)")]
    public const int LVM_GETNUMBEROFWORKAREAS = (0x1000 + 73);

    [NativeTypeName("#define LVM_GETSELECTIONMARK (LVM_FIRST + 66)")]
    public const int LVM_GETSELECTIONMARK = (0x1000 + 66);

    [NativeTypeName("#define LVM_SETSELECTIONMARK (LVM_FIRST + 67)")]
    public const int LVM_SETSELECTIONMARK = (0x1000 + 67);

    [NativeTypeName("#define LVM_SETHOVERTIME (LVM_FIRST + 71)")]
    public const int LVM_SETHOVERTIME = (0x1000 + 71);

    [NativeTypeName("#define LVM_GETHOVERTIME (LVM_FIRST + 72)")]
    public const int LVM_GETHOVERTIME = (0x1000 + 72);

    [NativeTypeName("#define LVM_SETTOOLTIPS (LVM_FIRST + 74)")]
    public const int LVM_SETTOOLTIPS = (0x1000 + 74);

    [NativeTypeName("#define LVM_GETTOOLTIPS (LVM_FIRST + 78)")]
    public const int LVM_GETTOOLTIPS = (0x1000 + 78);

    [NativeTypeName("#define LVM_SORTITEMSEX (LVM_FIRST + 81)")]
    public const int LVM_SORTITEMSEX = (0x1000 + 81);

    [NativeTypeName("#define LVM_SETBKIMAGEA (LVM_FIRST + 68)")]
    public const int LVM_SETBKIMAGEA = (0x1000 + 68);

    [NativeTypeName("#define LVM_SETBKIMAGEW (LVM_FIRST + 138)")]
    public const int LVM_SETBKIMAGEW = (0x1000 + 138);

    [NativeTypeName("#define LVM_GETBKIMAGEA (LVM_FIRST + 69)")]
    public const int LVM_GETBKIMAGEA = (0x1000 + 69);

    [NativeTypeName("#define LVM_GETBKIMAGEW (LVM_FIRST + 139)")]
    public const int LVM_GETBKIMAGEW = (0x1000 + 139);

    [NativeTypeName("#define LVM_SETSELECTEDCOLUMN (LVM_FIRST + 140)")]
    public const int LVM_SETSELECTEDCOLUMN = (0x1000 + 140);

    [NativeTypeName("#define LVM_SETVIEW (LVM_FIRST + 142)")]
    public const int LVM_SETVIEW = (0x1000 + 142);

    [NativeTypeName("#define LVM_GETVIEW (LVM_FIRST + 143)")]
    public const int LVM_GETVIEW = (0x1000 + 143);

    [NativeTypeName("#define LVM_INSERTGROUP (LVM_FIRST + 145)")]
    public const int LVM_INSERTGROUP = (0x1000 + 145);

    [NativeTypeName("#define LVM_SETGROUPINFO (LVM_FIRST + 147)")]
    public const int LVM_SETGROUPINFO = (0x1000 + 147);

    [NativeTypeName("#define LVM_GETGROUPINFO (LVM_FIRST + 149)")]
    public const int LVM_GETGROUPINFO = (0x1000 + 149);

    [NativeTypeName("#define LVM_REMOVEGROUP (LVM_FIRST + 150)")]
    public const int LVM_REMOVEGROUP = (0x1000 + 150);

    [NativeTypeName("#define LVM_MOVEGROUP (LVM_FIRST + 151)")]
    public const int LVM_MOVEGROUP = (0x1000 + 151);

    [NativeTypeName("#define LVM_GETGROUPCOUNT (LVM_FIRST + 152)")]
    public const int LVM_GETGROUPCOUNT = (0x1000 + 152);

    [NativeTypeName("#define LVM_GETGROUPINFOBYINDEX (LVM_FIRST + 153)")]
    public const int LVM_GETGROUPINFOBYINDEX = (0x1000 + 153);

    [NativeTypeName("#define LVM_MOVEITEMTOGROUP (LVM_FIRST + 154)")]
    public const int LVM_MOVEITEMTOGROUP = (0x1000 + 154);

    [NativeTypeName("#define LVM_GETGROUPRECT (LVM_FIRST + 98)")]
    public const int LVM_GETGROUPRECT = (0x1000 + 98);

    [NativeTypeName("#define LVM_SETGROUPMETRICS (LVM_FIRST + 155)")]
    public const int LVM_SETGROUPMETRICS = (0x1000 + 155);

    [NativeTypeName("#define LVM_GETGROUPMETRICS (LVM_FIRST + 156)")]
    public const int LVM_GETGROUPMETRICS = (0x1000 + 156);

    [NativeTypeName("#define LVM_ENABLEGROUPVIEW (LVM_FIRST + 157)")]
    public const int LVM_ENABLEGROUPVIEW = (0x1000 + 157);

    [NativeTypeName("#define LVM_SORTGROUPS (LVM_FIRST + 158)")]
    public const int LVM_SORTGROUPS = (0x1000 + 158);

    [NativeTypeName("#define LVM_INSERTGROUPSORTED (LVM_FIRST + 159)")]
    public const int LVM_INSERTGROUPSORTED = (0x1000 + 159);

    [NativeTypeName("#define LVM_REMOVEALLGROUPS (LVM_FIRST + 160)")]
    public const int LVM_REMOVEALLGROUPS = (0x1000 + 160);

    [NativeTypeName("#define LVM_HASGROUP (LVM_FIRST + 161)")]
    public const int LVM_HASGROUP = (0x1000 + 161);

    [NativeTypeName("#define LVM_GETGROUPSTATE (LVM_FIRST + 92)")]
    public const int LVM_GETGROUPSTATE = (0x1000 + 92);

    [NativeTypeName("#define LVM_GETFOCUSEDGROUP (LVM_FIRST + 93)")]
    public const int LVM_GETFOCUSEDGROUP = (0x1000 + 93);

    [NativeTypeName("#define LVM_SETTILEVIEWINFO (LVM_FIRST + 162)")]
    public const int LVM_SETTILEVIEWINFO = (0x1000 + 162);

    [NativeTypeName("#define LVM_GETTILEVIEWINFO (LVM_FIRST + 163)")]
    public const int LVM_GETTILEVIEWINFO = (0x1000 + 163);

    [NativeTypeName("#define LVM_SETTILEINFO (LVM_FIRST + 164)")]
    public const int LVM_SETTILEINFO = (0x1000 + 164);

    [NativeTypeName("#define LVM_GETTILEINFO (LVM_FIRST + 165)")]
    public const int LVM_GETTILEINFO = (0x1000 + 165);

    [NativeTypeName("#define LVM_SETINSERTMARK (LVM_FIRST + 166)")]
    public const int LVM_SETINSERTMARK = (0x1000 + 166);

    [NativeTypeName("#define LVM_GETINSERTMARK (LVM_FIRST + 167)")]
    public const int LVM_GETINSERTMARK = (0x1000 + 167);

    [NativeTypeName("#define LVM_INSERTMARKHITTEST (LVM_FIRST + 168)")]
    public const int LVM_INSERTMARKHITTEST = (0x1000 + 168);

    [NativeTypeName("#define LVM_GETINSERTMARKRECT (LVM_FIRST + 169)")]
    public const int LVM_GETINSERTMARKRECT = (0x1000 + 169);

    [NativeTypeName("#define LVM_SETINSERTMARKCOLOR (LVM_FIRST + 170)")]
    public const int LVM_SETINSERTMARKCOLOR = (0x1000 + 170);

    [NativeTypeName("#define LVM_GETINSERTMARKCOLOR (LVM_FIRST + 171)")]
    public const int LVM_GETINSERTMARKCOLOR = (0x1000 + 171);

    [NativeTypeName("#define LVM_SETINFOTIP (LVM_FIRST + 173)")]
    public const int LVM_SETINFOTIP = (0x1000 + 173);

    [NativeTypeName("#define LVM_GETSELECTEDCOLUMN (LVM_FIRST + 174)")]
    public const int LVM_GETSELECTEDCOLUMN = (0x1000 + 174);

    [NativeTypeName("#define LVM_ISGROUPVIEWENABLED (LVM_FIRST + 175)")]
    public const int LVM_ISGROUPVIEWENABLED = (0x1000 + 175);

    [NativeTypeName("#define LVM_GETOUTLINECOLOR (LVM_FIRST + 176)")]
    public const int LVM_GETOUTLINECOLOR = (0x1000 + 176);

    [NativeTypeName("#define LVM_SETOUTLINECOLOR (LVM_FIRST + 177)")]
    public const int LVM_SETOUTLINECOLOR = (0x1000 + 177);

    [NativeTypeName("#define LVM_CANCELEDITLABEL (LVM_FIRST + 179)")]
    public const int LVM_CANCELEDITLABEL = (0x1000 + 179);

    [NativeTypeName("#define LVM_MAPINDEXTOID (LVM_FIRST + 180)")]
    public const int LVM_MAPINDEXTOID = (0x1000 + 180);

    [NativeTypeName("#define LVM_MAPIDTOINDEX (LVM_FIRST + 181)")]
    public const int LVM_MAPIDTOINDEX = (0x1000 + 181);

    [NativeTypeName("#define LVM_ISITEMVISIBLE (LVM_FIRST + 182)")]
    public const int LVM_ISITEMVISIBLE = (0x1000 + 182);

    [NativeTypeName("#define LVM_GETEMPTYTEXT (LVM_FIRST + 204)")]
    public const int LVM_GETEMPTYTEXT = (0x1000 + 204);

    [NativeTypeName("#define LVM_GETFOOTERRECT (LVM_FIRST + 205)")]
    public const int LVM_GETFOOTERRECT = (0x1000 + 205);

    [NativeTypeName("#define LVM_GETFOOTERINFO (LVM_FIRST + 206)")]
    public const int LVM_GETFOOTERINFO = (0x1000 + 206);

    [NativeTypeName("#define LVM_GETFOOTERITEMRECT (LVM_FIRST + 207)")]
    public const int LVM_GETFOOTERITEMRECT = (0x1000 + 207);

    [NativeTypeName("#define LVM_GETFOOTERITEM (LVM_FIRST + 208)")]
    public const int LVM_GETFOOTERITEM = (0x1000 + 208);

    [NativeTypeName("#define LVM_GETITEMINDEXRECT (LVM_FIRST + 209)")]
    public const int LVM_GETITEMINDEXRECT = (0x1000 + 209);

    [NativeTypeName("#define LVM_SETITEMINDEXSTATE (LVM_FIRST + 210)")]
    public const int LVM_SETITEMINDEXSTATE = (0x1000 + 210);

    [NativeTypeName("#define LVM_GETNEXTITEMINDEX (LVM_FIRST + 211)")]
    public const int LVM_GETNEXTITEMINDEX = (0x1000 + 211);

    [NativeTypeName("#define LVM_SETBKIMAGE LVM_SETBKIMAGEW")]
    public const int LVM_SETBKIMAGE = (0x1000 + 138);

    [NativeTypeName("#define LVM_GETBKIMAGE LVM_GETBKIMAGEW")]
    public const int LVM_GETBKIMAGE = (0x1000 + 139);
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TB
{
    [NativeTypeName("#define TB_ENABLEBUTTON (WM_USER + 1)")]
    public const int TB_ENABLEBUTTON = (0x0400 + 1);
    [NativeTypeName("#define TB_CHECKBUTTON (WM_USER + 2)")]
    public const int TB_CHECKBUTTON = (0x0400 + 2);
    [NativeTypeName("#define TB_PRESSBUTTON (WM_USER + 3)")]
    public const int TB_PRESSBUTTON = (0x0400 + 3);
    [NativeTypeName("#define TB_HIDEBUTTON (WM_USER + 4)")]
    public const int TB_HIDEBUTTON = (0x0400 + 4);
    [NativeTypeName("#define TB_INDETERMINATE (WM_USER + 5)")]
    public const int TB_INDETERMINATE = (0x0400 + 5);
    [NativeTypeName("#define TB_MARKBUTTON (WM_USER + 6)")]
    public const int TB_MARKBUTTON = (0x0400 + 6);
    [NativeTypeName("#define TB_ISBUTTONENABLED (WM_USER + 9)")]
    public const int TB_ISBUTTONENABLED = (0x0400 + 9);
    [NativeTypeName("#define TB_ISBUTTONCHECKED (WM_USER + 10)")]
    public const int TB_ISBUTTONCHECKED = (0x0400 + 10);
    [NativeTypeName("#define TB_ISBUTTONPRESSED (WM_USER + 11)")]
    public const int TB_ISBUTTONPRESSED = (0x0400 + 11);
    [NativeTypeName("#define TB_ISBUTTONHIDDEN (WM_USER + 12)")]
    public const int TB_ISBUTTONHIDDEN = (0x0400 + 12);
    [NativeTypeName("#define TB_ISBUTTONINDETERMINATE (WM_USER + 13)")]
    public const int TB_ISBUTTONINDETERMINATE = (0x0400 + 13);
    [NativeTypeName("#define TB_ISBUTTONHIGHLIGHTED (WM_USER + 14)")]
    public const int TB_ISBUTTONHIGHLIGHTED = (0x0400 + 14);
    [NativeTypeName("#define TB_SETSTATE (WM_USER + 17)")]
    public const int TB_SETSTATE = (0x0400 + 17);
    [NativeTypeName("#define TB_GETSTATE (WM_USER + 18)")]
    public const int TB_GETSTATE = (0x0400 + 18);
    [NativeTypeName("#define TB_ADDBITMAP (WM_USER + 19)")]
    public const int TB_ADDBITMAP = (0x0400 + 19);
    [NativeTypeName("#define TB_ADDBUTTONSA (WM_USER + 20)")]
    public const int TB_ADDBUTTONSA = (0x0400 + 20);
    [NativeTypeName("#define TB_INSERTBUTTONA (WM_USER + 21)")]
    public const int TB_INSERTBUTTONA = (0x0400 + 21);
    [NativeTypeName("#define TB_DELETEBUTTON (WM_USER + 22)")]
    public const int TB_DELETEBUTTON = (0x0400 + 22);
    [NativeTypeName("#define TB_GETBUTTON (WM_USER + 23)")]
    public const int TB_GETBUTTON = (0x0400 + 23);
    [NativeTypeName("#define TB_BUTTONCOUNT (WM_USER + 24)")]
    public const int TB_BUTTONCOUNT = (0x0400 + 24);
    [NativeTypeName("#define TB_COMMANDTOINDEX (WM_USER + 25)")]
    public const int TB_COMMANDTOINDEX = (0x0400 + 25);
    [NativeTypeName("#define TB_SAVERESTOREA (WM_USER + 26)")]
    public const int TB_SAVERESTOREA = (0x0400 + 26);
    [NativeTypeName("#define TB_SAVERESTOREW (WM_USER + 76)")]
    public const int TB_SAVERESTOREW = (0x0400 + 76);
    [NativeTypeName("#define TB_CUSTOMIZE (WM_USER + 27)")]
    public const int TB_CUSTOMIZE = (0x0400 + 27);
    [NativeTypeName("#define TB_ADDSTRINGA (WM_USER + 28)")]
    public const int TB_ADDSTRINGA = (0x0400 + 28);
    [NativeTypeName("#define TB_ADDSTRINGW (WM_USER + 77)")]
    public const int TB_ADDSTRINGW = (0x0400 + 77);
    [NativeTypeName("#define TB_GETITEMRECT (WM_USER + 29)")]
    public const int TB_GETITEMRECT = (0x0400 + 29);
    [NativeTypeName("#define TB_BUTTONSTRUCTSIZE (WM_USER + 30)")]
    public const int TB_BUTTONSTRUCTSIZE = (0x0400 + 30);
    [NativeTypeName("#define TB_SETBUTTONSIZE (WM_USER + 31)")]
    public const int TB_SETBUTTONSIZE = (0x0400 + 31);
    [NativeTypeName("#define TB_SETBITMAPSIZE (WM_USER + 32)")]
    public const int TB_SETBITMAPSIZE = (0x0400 + 32);
    [NativeTypeName("#define TB_AUTOSIZE (WM_USER + 33)")]
    public const int TB_AUTOSIZE = (0x0400 + 33);
    [NativeTypeName("#define TB_GETTOOLTIPS (WM_USER + 35)")]
    public const int TB_GETTOOLTIPS = (0x0400 + 35);
    [NativeTypeName("#define TB_SETTOOLTIPS (WM_USER + 36)")]
    public const int TB_SETTOOLTIPS = (0x0400 + 36);
    [NativeTypeName("#define TB_SETPARENT (WM_USER + 37)")]
    public const int TB_SETPARENT = (0x0400 + 37);
    [NativeTypeName("#define TB_SETROWS (WM_USER + 39)")]
    public const int TB_SETROWS = (0x0400 + 39);
    [NativeTypeName("#define TB_GETROWS (WM_USER + 40)")]
    public const int TB_GETROWS = (0x0400 + 40);
    [NativeTypeName("#define TB_SETCMDID (WM_USER + 42)")]
    public const int TB_SETCMDID = (0x0400 + 42);
    [NativeTypeName("#define TB_CHANGEBITMAP (WM_USER + 43)")]
    public const int TB_CHANGEBITMAP = (0x0400 + 43);
    [NativeTypeName("#define TB_GETBITMAP (WM_USER + 44)")]
    public const int TB_GETBITMAP = (0x0400 + 44);
    [NativeTypeName("#define TB_GETBUTTONTEXTA (WM_USER + 45)")]
    public const int TB_GETBUTTONTEXTA = (0x0400 + 45);
    [NativeTypeName("#define TB_GETBUTTONTEXTW (WM_USER + 75)")]
    public const int TB_GETBUTTONTEXTW = (0x0400 + 75);
    [NativeTypeName("#define TB_REPLACEBITMAP (WM_USER + 46)")]
    public const int TB_REPLACEBITMAP = (0x0400 + 46);
    [NativeTypeName("#define TB_SETINDENT (WM_USER + 47)")]
    public const int TB_SETINDENT = (0x0400 + 47);
    [NativeTypeName("#define TB_SETIMAGELIST (WM_USER + 48)")]
    public const int TB_SETIMAGELIST = (0x0400 + 48);
    [NativeTypeName("#define TB_GETIMAGELIST (WM_USER + 49)")]
    public const int TB_GETIMAGELIST = (0x0400 + 49);
    [NativeTypeName("#define TB_LOADIMAGES (WM_USER + 50)")]
    public const int TB_LOADIMAGES = (0x0400 + 50);
    [NativeTypeName("#define TB_GETRECT (WM_USER + 51)")]
    public const int TB_GETRECT = (0x0400 + 51);
    [NativeTypeName("#define TB_SETHOTIMAGELIST (WM_USER + 52)")]
    public const int TB_SETHOTIMAGELIST = (0x0400 + 52);
    [NativeTypeName("#define TB_GETHOTIMAGELIST (WM_USER + 53)")]
    public const int TB_GETHOTIMAGELIST = (0x0400 + 53);
    [NativeTypeName("#define TB_SETDISABLEDIMAGELIST (WM_USER + 54)")]
    public const int TB_SETDISABLEDIMAGELIST = (0x0400 + 54);
    [NativeTypeName("#define TB_GETDISABLEDIMAGELIST (WM_USER + 55)")]
    public const int TB_GETDISABLEDIMAGELIST = (0x0400 + 55);
    [NativeTypeName("#define TB_SETSTYLE (WM_USER + 56)")]
    public const int TB_SETSTYLE = (0x0400 + 56);
    [NativeTypeName("#define TB_GETSTYLE (WM_USER + 57)")]
    public const int TB_GETSTYLE = (0x0400 + 57);
    [NativeTypeName("#define TB_GETBUTTONSIZE (WM_USER + 58)")]
    public const int TB_GETBUTTONSIZE = (0x0400 + 58);
    [NativeTypeName("#define TB_SETBUTTONWIDTH (WM_USER + 59)")]
    public const int TB_SETBUTTONWIDTH = (0x0400 + 59);
    [NativeTypeName("#define TB_SETMAXTEXTROWS (WM_USER + 60)")]
    public const int TB_SETMAXTEXTROWS = (0x0400 + 60);
    [NativeTypeName("#define TB_GETTEXTROWS (WM_USER + 61)")]
    public const int TB_GETTEXTROWS = (0x0400 + 61);
    [NativeTypeName("#define TB_GETBUTTONTEXT TB_GETBUTTONTEXTW")]
    public const int TB_GETBUTTONTEXT = (0x0400 + 75);
    [NativeTypeName("#define TB_SAVERESTORE TB_SAVERESTOREW")]
    public const int TB_SAVERESTORE = (0x0400 + 76);
    [NativeTypeName("#define TB_ADDSTRING TB_ADDSTRINGW")]
    public const int TB_ADDSTRING = (0x0400 + 77);
    [NativeTypeName("#define TB_GETOBJECT (WM_USER + 62)")]
    public const int TB_GETOBJECT = (0x0400 + 62);
    [NativeTypeName("#define TB_GETHOTITEM (WM_USER + 71)")]
    public const int TB_GETHOTITEM = (0x0400 + 71);
    [NativeTypeName("#define TB_SETHOTITEM (WM_USER + 72)")]
    public const int TB_SETHOTITEM = (0x0400 + 72);
    [NativeTypeName("#define TB_SETANCHORHIGHLIGHT (WM_USER + 73)")]
    public const int TB_SETANCHORHIGHLIGHT = (0x0400 + 73);
    [NativeTypeName("#define TB_GETANCHORHIGHLIGHT (WM_USER + 74)")]
    public const int TB_GETANCHORHIGHLIGHT = (0x0400 + 74);
    [NativeTypeName("#define TB_MAPACCELERATORA (WM_USER + 78)")]
    public const int TB_MAPACCELERATORA = (0x0400 + 78);
    [NativeTypeName("#define TB_GETINSERTMARK (WM_USER + 79)")]
    public const int TB_GETINSERTMARK = (0x0400 + 79);
    [NativeTypeName("#define TB_SETINSERTMARK (WM_USER + 80)")]
    public const int TB_SETINSERTMARK = (0x0400 + 80);
    [NativeTypeName("#define TB_INSERTMARKHITTEST (WM_USER + 81)")]
    public const int TB_INSERTMARKHITTEST = (0x0400 + 81);
    [NativeTypeName("#define TB_MOVEBUTTON (WM_USER + 82)")]
    public const int TB_MOVEBUTTON = (0x0400 + 82);
    [NativeTypeName("#define TB_GETMAXSIZE (WM_USER + 83)")]
    public const int TB_GETMAXSIZE = (0x0400 + 83);
    [NativeTypeName("#define TB_SETEXTENDEDSTYLE (WM_USER + 84)")]
    public const int TB_SETEXTENDEDSTYLE = (0x0400 + 84);
    [NativeTypeName("#define TB_GETEXTENDEDSTYLE (WM_USER + 85)")]
    public const int TB_GETEXTENDEDSTYLE = (0x0400 + 85);
    [NativeTypeName("#define TB_GETPADDING (WM_USER + 86)")]
    public const int TB_GETPADDING = (0x0400 + 86);
    [NativeTypeName("#define TB_SETPADDING (WM_USER + 87)")]
    public const int TB_SETPADDING = (0x0400 + 87);
    [NativeTypeName("#define TB_SETINSERTMARKCOLOR (WM_USER + 88)")]
    public const int TB_SETINSERTMARKCOLOR = (0x0400 + 88);
    [NativeTypeName("#define TB_GETINSERTMARKCOLOR (WM_USER + 89)")]
    public const int TB_GETINSERTMARKCOLOR = (0x0400 + 89);
    [NativeTypeName("#define TB_SETCOLORSCHEME CCM_SETCOLORSCHEME")]
    public const int TB_SETCOLORSCHEME = (0x2000 + 2);
    [NativeTypeName("#define TB_GETCOLORSCHEME CCM_GETCOLORSCHEME")]
    public const int TB_GETCOLORSCHEME = (0x2000 + 3);
    [NativeTypeName("#define TB_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int TB_SETUNICODEFORMAT = (0x2000 + 5);
    [NativeTypeName("#define TB_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int TB_GETUNICODEFORMAT = (0x2000 + 6);
    [NativeTypeName("#define TB_MAPACCELERATORW (WM_USER + 90)")]
    public const int TB_MAPACCELERATORW = (0x0400 + 90);
    [NativeTypeName("#define TB_MAPACCELERATOR TB_MAPACCELERATORW")]
    public const int TB_MAPACCELERATOR = (0x0400 + 90);
    [NativeTypeName("#define TB_GETBITMAPFLAGS (WM_USER + 41)")]
    public const int TB_GETBITMAPFLAGS = (0x0400 + 41);
    [NativeTypeName("#define TB_GETBUTTONINFOW (WM_USER + 63)")]
    public const int TB_GETBUTTONINFOW = (0x0400 + 63);
    [NativeTypeName("#define TB_SETBUTTONINFOW (WM_USER + 64)")]
    public const int TB_SETBUTTONINFOW = (0x0400 + 64);
    [NativeTypeName("#define TB_GETBUTTONINFOA (WM_USER + 65)")]
    public const int TB_GETBUTTONINFOA = (0x0400 + 65);
    [NativeTypeName("#define TB_SETBUTTONINFOA (WM_USER + 66)")]
    public const int TB_SETBUTTONINFOA = (0x0400 + 66);
    [NativeTypeName("#define TB_GETBUTTONINFO TB_GETBUTTONINFOW")]
    public const int TB_GETBUTTONINFO = (0x0400 + 63);
    [NativeTypeName("#define TB_SETBUTTONINFO TB_SETBUTTONINFOW")]
    public const int TB_SETBUTTONINFO = (0x0400 + 64);
    [NativeTypeName("#define TB_INSERTBUTTONW (WM_USER + 67)")]
    public const int TB_INSERTBUTTONW = (0x0400 + 67);
    [NativeTypeName("#define TB_ADDBUTTONSW (WM_USER + 68)")]
    public const int TB_ADDBUTTONSW = (0x0400 + 68);
    [NativeTypeName("#define TB_HITTEST (WM_USER + 69)")]
    public const int TB_HITTEST = (0x0400 + 69);
    [NativeTypeName("#define TB_INSERTBUTTON TB_INSERTBUTTONW")]
    public const int TB_INSERTBUTTON = (0x0400 + 67);
    [NativeTypeName("#define TB_ADDBUTTONS TB_ADDBUTTONSW")]
    public const int TB_ADDBUTTONS = (0x0400 + 68);
    [NativeTypeName("#define TB_SETDRAWTEXTFLAGS (WM_USER + 70)")]
    public const int TB_SETDRAWTEXTFLAGS = (0x0400 + 70);
    [NativeTypeName("#define TB_GETSTRINGW (WM_USER + 91)")]
    public const int TB_GETSTRINGW = (0x0400 + 91);
    [NativeTypeName("#define TB_GETSTRINGA (WM_USER + 92)")]
    public const int TB_GETSTRINGA = (0x0400 + 92);
    [NativeTypeName("#define TB_GETSTRING TB_GETSTRINGW")]
    public const int TB_GETSTRING = (0x0400 + 91);
    [NativeTypeName("#define TB_SETBOUNDINGSIZE (WM_USER + 93)")]
    public const int TB_SETBOUNDINGSIZE = (0x0400 + 93);
    [NativeTypeName("#define TB_SETHOTITEM2 (WM_USER + 94)")]
    public const int TB_SETHOTITEM2 = (0x0400 + 94);
    [NativeTypeName("#define TB_HASACCELERATOR (WM_USER + 95)")]
    public const int TB_HASACCELERATOR = (0x0400 + 95);
    [NativeTypeName("#define TB_SETLISTGAP (WM_USER + 96)")]
    public const int TB_SETLISTGAP = (0x0400 + 96);
    [NativeTypeName("#define TB_GETIMAGELISTCOUNT (WM_USER + 98)")]
    public const int TB_GETIMAGELISTCOUNT = (0x0400 + 98);
    [NativeTypeName("#define TB_GETIDEALSIZE (WM_USER + 99)")]
    public const int TB_GETIDEALSIZE = (0x0400 + 99);
    [NativeTypeName("#define TB_GETMETRICS (WM_USER + 101)")]
    public const int TB_GETMETRICS = (0x0400 + 101);
    [NativeTypeName("#define TB_SETMETRICS (WM_USER + 102)")]
    public const int TB_SETMETRICS = (0x0400 + 102);
    [NativeTypeName("#define TB_GETITEMDROPDOWNRECT (WM_USER + 103)")]
    public const int TB_GETITEMDROPDOWNRECT = (0x0400 + 103);
    [NativeTypeName("#define TB_SETPRESSEDIMAGELIST (WM_USER + 104)")]
    public const int TB_SETPRESSEDIMAGELIST = (0x0400 + 104);
    [NativeTypeName("#define TB_GETPRESSEDIMAGELIST (WM_USER + 105)")]
    public const int TB_GETPRESSEDIMAGELIST = (0x0400 + 105);
    [NativeTypeName("#define TB_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
    public const int TB_SETWINDOWTHEME = (0x2000 + 0xb);
    [NativeTypeName("#define TB_LINEUP 0")]
    public const int TB_LINEUP = 0;
    [NativeTypeName("#define TB_LINEDOWN 1")]
    public const int TB_LINEDOWN = 1;
    [NativeTypeName("#define TB_PAGEUP 2")]
    public const int TB_PAGEUP = 2;
    [NativeTypeName("#define TB_PAGEDOWN 3")]
    public const int TB_PAGEDOWN = 3;
    [NativeTypeName("#define TB_THUMBPOSITION 4")]
    public const int TB_THUMBPOSITION = 4;
    [NativeTypeName("#define TB_THUMBTRACK 5")]
    public const int TB_THUMBTRACK = 5;
    [NativeTypeName("#define TB_TOP 6")]
    public const int TB_TOP = 6;
    [NativeTypeName("#define TB_BOTTOM 7")]
    public const int TB_BOTTOM = 7;
    [NativeTypeName("#define TB_ENDTRACK 8")]
    public const int TB_ENDTRACK = 8;
}
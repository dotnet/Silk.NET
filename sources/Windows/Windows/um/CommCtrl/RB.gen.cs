// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class RB
{
    [NativeTypeName("#define RB_INSERTBANDA (WM_USER +  1)")]
    public const int RB_INSERTBANDA = (0x0400 + 1);
    [NativeTypeName("#define RB_DELETEBAND (WM_USER +  2)")]
    public const int RB_DELETEBAND = (0x0400 + 2);
    [NativeTypeName("#define RB_GETBARINFO (WM_USER +  3)")]
    public const int RB_GETBARINFO = (0x0400 + 3);
    [NativeTypeName("#define RB_SETBARINFO (WM_USER +  4)")]
    public const int RB_SETBARINFO = (0x0400 + 4);
    [NativeTypeName("#define RB_SETBANDINFOA (WM_USER +  6)")]
    public const int RB_SETBANDINFOA = (0x0400 + 6);
    [NativeTypeName("#define RB_SETPARENT (WM_USER +  7)")]
    public const int RB_SETPARENT = (0x0400 + 7);
    [NativeTypeName("#define RB_HITTEST (WM_USER +  8)")]
    public const int RB_HITTEST = (0x0400 + 8);
    [NativeTypeName("#define RB_GETRECT (WM_USER +  9)")]
    public const int RB_GETRECT = (0x0400 + 9);
    [NativeTypeName("#define RB_INSERTBANDW (WM_USER +  10)")]
    public const int RB_INSERTBANDW = (0x0400 + 10);
    [NativeTypeName("#define RB_SETBANDINFOW (WM_USER +  11)")]
    public const int RB_SETBANDINFOW = (0x0400 + 11);
    [NativeTypeName("#define RB_GETBANDCOUNT (WM_USER +  12)")]
    public const int RB_GETBANDCOUNT = (0x0400 + 12);
    [NativeTypeName("#define RB_GETROWCOUNT (WM_USER +  13)")]
    public const int RB_GETROWCOUNT = (0x0400 + 13);
    [NativeTypeName("#define RB_GETROWHEIGHT (WM_USER +  14)")]
    public const int RB_GETROWHEIGHT = (0x0400 + 14);
    [NativeTypeName("#define RB_IDTOINDEX (WM_USER +  16)")]
    public const int RB_IDTOINDEX = (0x0400 + 16);
    [NativeTypeName("#define RB_GETTOOLTIPS (WM_USER +  17)")]
    public const int RB_GETTOOLTIPS = (0x0400 + 17);
    [NativeTypeName("#define RB_SETTOOLTIPS (WM_USER +  18)")]
    public const int RB_SETTOOLTIPS = (0x0400 + 18);
    [NativeTypeName("#define RB_SETBKCOLOR (WM_USER +  19)")]
    public const int RB_SETBKCOLOR = (0x0400 + 19);
    [NativeTypeName("#define RB_GETBKCOLOR (WM_USER +  20)")]
    public const int RB_GETBKCOLOR = (0x0400 + 20);
    [NativeTypeName("#define RB_SETTEXTCOLOR (WM_USER +  21)")]
    public const int RB_SETTEXTCOLOR = (0x0400 + 21);
    [NativeTypeName("#define RB_GETTEXTCOLOR (WM_USER +  22)")]
    public const int RB_GETTEXTCOLOR = (0x0400 + 22);
    [NativeTypeName("#define RB_SIZETORECT (WM_USER +  23)")]
    public const int RB_SIZETORECT = (0x0400 + 23);
    [NativeTypeName("#define RB_SETCOLORSCHEME CCM_SETCOLORSCHEME")]
    public const int RB_SETCOLORSCHEME = (0x2000 + 2);
    [NativeTypeName("#define RB_GETCOLORSCHEME CCM_GETCOLORSCHEME")]
    public const int RB_GETCOLORSCHEME = (0x2000 + 3);
    [NativeTypeName("#define RB_INSERTBAND RB_INSERTBANDW")]
    public const int RB_INSERTBAND = (0x0400 + 10);
    [NativeTypeName("#define RB_SETBANDINFO RB_SETBANDINFOW")]
    public const int RB_SETBANDINFO = (0x0400 + 11);
    [NativeTypeName("#define RB_BEGINDRAG (WM_USER + 24)")]
    public const int RB_BEGINDRAG = (0x0400 + 24);
    [NativeTypeName("#define RB_ENDDRAG (WM_USER + 25)")]
    public const int RB_ENDDRAG = (0x0400 + 25);
    [NativeTypeName("#define RB_DRAGMOVE (WM_USER + 26)")]
    public const int RB_DRAGMOVE = (0x0400 + 26);
    [NativeTypeName("#define RB_GETBARHEIGHT (WM_USER + 27)")]
    public const int RB_GETBARHEIGHT = (0x0400 + 27);
    [NativeTypeName("#define RB_GETBANDINFOW (WM_USER + 28)")]
    public const int RB_GETBANDINFOW = (0x0400 + 28);
    [NativeTypeName("#define RB_GETBANDINFOA (WM_USER + 29)")]
    public const int RB_GETBANDINFOA = (0x0400 + 29);
    [NativeTypeName("#define RB_GETBANDINFO RB_GETBANDINFOW")]
    public const int RB_GETBANDINFO = (0x0400 + 28);
    [NativeTypeName("#define RB_MINIMIZEBAND (WM_USER + 30)")]
    public const int RB_MINIMIZEBAND = (0x0400 + 30);
    [NativeTypeName("#define RB_MAXIMIZEBAND (WM_USER + 31)")]
    public const int RB_MAXIMIZEBAND = (0x0400 + 31);
    [NativeTypeName("#define RB_GETDROPTARGET (CCM_GETDROPTARGET)")]
    public const int RB_GETDROPTARGET = ((0x2000 + 4));
    [NativeTypeName("#define RB_GETBANDBORDERS (WM_USER + 34)")]
    public const int RB_GETBANDBORDERS = (0x0400 + 34);
    [NativeTypeName("#define RB_SHOWBAND (WM_USER + 35)")]
    public const int RB_SHOWBAND = (0x0400 + 35);
    [NativeTypeName("#define RB_SETPALETTE (WM_USER + 37)")]
    public const int RB_SETPALETTE = (0x0400 + 37);
    [NativeTypeName("#define RB_GETPALETTE (WM_USER + 38)")]
    public const int RB_GETPALETTE = (0x0400 + 38);
    [NativeTypeName("#define RB_MOVEBAND (WM_USER + 39)")]
    public const int RB_MOVEBAND = (0x0400 + 39);
    [NativeTypeName("#define RB_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int RB_SETUNICODEFORMAT = (0x2000 + 5);
    [NativeTypeName("#define RB_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int RB_GETUNICODEFORMAT = (0x2000 + 6);
    [NativeTypeName("#define RB_GETBANDMARGINS (WM_USER + 40)")]
    public const int RB_GETBANDMARGINS = (0x0400 + 40);
    [NativeTypeName("#define RB_SETWINDOWTHEME CCM_SETWINDOWTHEME")]
    public const int RB_SETWINDOWTHEME = (0x2000 + 0xb);
    [NativeTypeName("#define RB_SETEXTENDEDSTYLE (WM_USER + 41)")]
    public const int RB_SETEXTENDEDSTYLE = (0x0400 + 41);
    [NativeTypeName("#define RB_GETEXTENDEDSTYLE (WM_USER + 42)")]
    public const int RB_GETEXTENDEDSTYLE = (0x0400 + 42);
    [NativeTypeName("#define RB_PUSHCHEVRON (WM_USER + 43)")]
    public const int RB_PUSHCHEVRON = (0x0400 + 43);
    [NativeTypeName("#define RB_SETBANDWIDTH (WM_USER + 44)")]
    public const int RB_SETBANDWIDTH = (0x0400 + 44);
}
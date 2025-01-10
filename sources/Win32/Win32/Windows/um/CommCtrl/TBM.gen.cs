// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TBM
{
    [NativeTypeName("#define TBM_GETPOS (WM_USER)")]
    public const int TBM_GETPOS = (0x0400);

    [NativeTypeName("#define TBM_GETRANGEMIN (WM_USER+1)")]
    public const int TBM_GETRANGEMIN = (0x0400 + 1);

    [NativeTypeName("#define TBM_GETRANGEMAX (WM_USER+2)")]
    public const int TBM_GETRANGEMAX = (0x0400 + 2);

    [NativeTypeName("#define TBM_GETTIC (WM_USER+3)")]
    public const int TBM_GETTIC = (0x0400 + 3);

    [NativeTypeName("#define TBM_SETTIC (WM_USER+4)")]
    public const int TBM_SETTIC = (0x0400 + 4);

    [NativeTypeName("#define TBM_SETPOS (WM_USER+5)")]
    public const int TBM_SETPOS = (0x0400 + 5);

    [NativeTypeName("#define TBM_SETRANGE (WM_USER+6)")]
    public const int TBM_SETRANGE = (0x0400 + 6);

    [NativeTypeName("#define TBM_SETRANGEMIN (WM_USER+7)")]
    public const int TBM_SETRANGEMIN = (0x0400 + 7);

    [NativeTypeName("#define TBM_SETRANGEMAX (WM_USER+8)")]
    public const int TBM_SETRANGEMAX = (0x0400 + 8);

    [NativeTypeName("#define TBM_CLEARTICS (WM_USER+9)")]
    public const int TBM_CLEARTICS = (0x0400 + 9);

    [NativeTypeName("#define TBM_SETSEL (WM_USER+10)")]
    public const int TBM_SETSEL = (0x0400 + 10);

    [NativeTypeName("#define TBM_SETSELSTART (WM_USER+11)")]
    public const int TBM_SETSELSTART = (0x0400 + 11);

    [NativeTypeName("#define TBM_SETSELEND (WM_USER+12)")]
    public const int TBM_SETSELEND = (0x0400 + 12);

    [NativeTypeName("#define TBM_GETPTICS (WM_USER+14)")]
    public const int TBM_GETPTICS = (0x0400 + 14);

    [NativeTypeName("#define TBM_GETTICPOS (WM_USER+15)")]
    public const int TBM_GETTICPOS = (0x0400 + 15);

    [NativeTypeName("#define TBM_GETNUMTICS (WM_USER+16)")]
    public const int TBM_GETNUMTICS = (0x0400 + 16);

    [NativeTypeName("#define TBM_GETSELSTART (WM_USER+17)")]
    public const int TBM_GETSELSTART = (0x0400 + 17);

    [NativeTypeName("#define TBM_GETSELEND (WM_USER+18)")]
    public const int TBM_GETSELEND = (0x0400 + 18);

    [NativeTypeName("#define TBM_CLEARSEL (WM_USER+19)")]
    public const int TBM_CLEARSEL = (0x0400 + 19);

    [NativeTypeName("#define TBM_SETTICFREQ (WM_USER+20)")]
    public const int TBM_SETTICFREQ = (0x0400 + 20);

    [NativeTypeName("#define TBM_SETPAGESIZE (WM_USER+21)")]
    public const int TBM_SETPAGESIZE = (0x0400 + 21);

    [NativeTypeName("#define TBM_GETPAGESIZE (WM_USER+22)")]
    public const int TBM_GETPAGESIZE = (0x0400 + 22);

    [NativeTypeName("#define TBM_SETLINESIZE (WM_USER+23)")]
    public const int TBM_SETLINESIZE = (0x0400 + 23);

    [NativeTypeName("#define TBM_GETLINESIZE (WM_USER+24)")]
    public const int TBM_GETLINESIZE = (0x0400 + 24);

    [NativeTypeName("#define TBM_GETTHUMBRECT (WM_USER+25)")]
    public const int TBM_GETTHUMBRECT = (0x0400 + 25);

    [NativeTypeName("#define TBM_GETCHANNELRECT (WM_USER+26)")]
    public const int TBM_GETCHANNELRECT = (0x0400 + 26);

    [NativeTypeName("#define TBM_SETTHUMBLENGTH (WM_USER+27)")]
    public const int TBM_SETTHUMBLENGTH = (0x0400 + 27);

    [NativeTypeName("#define TBM_GETTHUMBLENGTH (WM_USER+28)")]
    public const int TBM_GETTHUMBLENGTH = (0x0400 + 28);

    [NativeTypeName("#define TBM_SETTOOLTIPS (WM_USER+29)")]
    public const int TBM_SETTOOLTIPS = (0x0400 + 29);

    [NativeTypeName("#define TBM_GETTOOLTIPS (WM_USER+30)")]
    public const int TBM_GETTOOLTIPS = (0x0400 + 30);

    [NativeTypeName("#define TBM_SETTIPSIDE (WM_USER+31)")]
    public const int TBM_SETTIPSIDE = (0x0400 + 31);

    [NativeTypeName("#define TBM_SETBUDDY (WM_USER+32)")]
    public const int TBM_SETBUDDY = (0x0400 + 32);

    [NativeTypeName("#define TBM_GETBUDDY (WM_USER+33)")]
    public const int TBM_GETBUDDY = (0x0400 + 33);

    [NativeTypeName("#define TBM_SETPOSNOTIFY (WM_USER+34)")]
    public const int TBM_SETPOSNOTIFY = (0x0400 + 34);

    [NativeTypeName("#define TBM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int TBM_SETUNICODEFORMAT = (0x2000 + 5);

    [NativeTypeName("#define TBM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int TBM_GETUNICODEFORMAT = (0x2000 + 6);
}

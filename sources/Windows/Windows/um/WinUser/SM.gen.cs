// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SM
{
    [NativeTypeName("#define SM_CXSCREEN 0")]
    public const int SM_CXSCREEN = 0;

    [NativeTypeName("#define SM_CYSCREEN 1")]
    public const int SM_CYSCREEN = 1;

    [NativeTypeName("#define SM_CXVSCROLL 2")]
    public const int SM_CXVSCROLL = 2;

    [NativeTypeName("#define SM_CYHSCROLL 3")]
    public const int SM_CYHSCROLL = 3;

    [NativeTypeName("#define SM_CYCAPTION 4")]
    public const int SM_CYCAPTION = 4;

    [NativeTypeName("#define SM_CXBORDER 5")]
    public const int SM_CXBORDER = 5;

    [NativeTypeName("#define SM_CYBORDER 6")]
    public const int SM_CYBORDER = 6;

    [NativeTypeName("#define SM_CXDLGFRAME 7")]
    public const int SM_CXDLGFRAME = 7;

    [NativeTypeName("#define SM_CYDLGFRAME 8")]
    public const int SM_CYDLGFRAME = 8;

    [NativeTypeName("#define SM_CYVTHUMB 9")]
    public const int SM_CYVTHUMB = 9;

    [NativeTypeName("#define SM_CXHTHUMB 10")]
    public const int SM_CXHTHUMB = 10;

    [NativeTypeName("#define SM_CXICON 11")]
    public const int SM_CXICON = 11;

    [NativeTypeName("#define SM_CYICON 12")]
    public const int SM_CYICON = 12;

    [NativeTypeName("#define SM_CXCURSOR 13")]
    public const int SM_CXCURSOR = 13;

    [NativeTypeName("#define SM_CYCURSOR 14")]
    public const int SM_CYCURSOR = 14;

    [NativeTypeName("#define SM_CYMENU 15")]
    public const int SM_CYMENU = 15;

    [NativeTypeName("#define SM_CXFULLSCREEN 16")]
    public const int SM_CXFULLSCREEN = 16;

    [NativeTypeName("#define SM_CYFULLSCREEN 17")]
    public const int SM_CYFULLSCREEN = 17;

    [NativeTypeName("#define SM_CYKANJIWINDOW 18")]
    public const int SM_CYKANJIWINDOW = 18;

    [NativeTypeName("#define SM_MOUSEPRESENT 19")]
    public const int SM_MOUSEPRESENT = 19;

    [NativeTypeName("#define SM_CYVSCROLL 20")]
    public const int SM_CYVSCROLL = 20;

    [NativeTypeName("#define SM_CXHSCROLL 21")]
    public const int SM_CXHSCROLL = 21;

    [NativeTypeName("#define SM_DEBUG 22")]
    public const int SM_DEBUG = 22;

    [NativeTypeName("#define SM_SWAPBUTTON 23")]
    public const int SM_SWAPBUTTON = 23;

    [NativeTypeName("#define SM_RESERVED1 24")]
    public const int SM_RESERVED1 = 24;

    [NativeTypeName("#define SM_RESERVED2 25")]
    public const int SM_RESERVED2 = 25;

    [NativeTypeName("#define SM_RESERVED3 26")]
    public const int SM_RESERVED3 = 26;

    [NativeTypeName("#define SM_RESERVED4 27")]
    public const int SM_RESERVED4 = 27;

    [NativeTypeName("#define SM_CXMIN 28")]
    public const int SM_CXMIN = 28;

    [NativeTypeName("#define SM_CYMIN 29")]
    public const int SM_CYMIN = 29;

    [NativeTypeName("#define SM_CXSIZE 30")]
    public const int SM_CXSIZE = 30;

    [NativeTypeName("#define SM_CYSIZE 31")]
    public const int SM_CYSIZE = 31;

    [NativeTypeName("#define SM_CXFRAME 32")]
    public const int SM_CXFRAME = 32;

    [NativeTypeName("#define SM_CYFRAME 33")]
    public const int SM_CYFRAME = 33;

    [NativeTypeName("#define SM_CXMINTRACK 34")]
    public const int SM_CXMINTRACK = 34;

    [NativeTypeName("#define SM_CYMINTRACK 35")]
    public const int SM_CYMINTRACK = 35;

    [NativeTypeName("#define SM_CXDOUBLECLK 36")]
    public const int SM_CXDOUBLECLK = 36;

    [NativeTypeName("#define SM_CYDOUBLECLK 37")]
    public const int SM_CYDOUBLECLK = 37;

    [NativeTypeName("#define SM_CXICONSPACING 38")]
    public const int SM_CXICONSPACING = 38;

    [NativeTypeName("#define SM_CYICONSPACING 39")]
    public const int SM_CYICONSPACING = 39;

    [NativeTypeName("#define SM_MENUDROPALIGNMENT 40")]
    public const int SM_MENUDROPALIGNMENT = 40;

    [NativeTypeName("#define SM_PENWINDOWS 41")]
    public const int SM_PENWINDOWS = 41;

    [NativeTypeName("#define SM_DBCSENABLED 42")]
    public const int SM_DBCSENABLED = 42;

    [NativeTypeName("#define SM_CMOUSEBUTTONS 43")]
    public const int SM_CMOUSEBUTTONS = 43;

    [NativeTypeName("#define SM_CXFIXEDFRAME SM_CXDLGFRAME")]
    public const int SM_CXFIXEDFRAME = 7;

    [NativeTypeName("#define SM_CYFIXEDFRAME SM_CYDLGFRAME")]
    public const int SM_CYFIXEDFRAME = 8;

    [NativeTypeName("#define SM_CXSIZEFRAME SM_CXFRAME")]
    public const int SM_CXSIZEFRAME = 32;

    [NativeTypeName("#define SM_CYSIZEFRAME SM_CYFRAME")]
    public const int SM_CYSIZEFRAME = 33;

    [NativeTypeName("#define SM_SECURE 44")]
    public const int SM_SECURE = 44;

    [NativeTypeName("#define SM_CXEDGE 45")]
    public const int SM_CXEDGE = 45;

    [NativeTypeName("#define SM_CYEDGE 46")]
    public const int SM_CYEDGE = 46;

    [NativeTypeName("#define SM_CXMINSPACING 47")]
    public const int SM_CXMINSPACING = 47;

    [NativeTypeName("#define SM_CYMINSPACING 48")]
    public const int SM_CYMINSPACING = 48;

    [NativeTypeName("#define SM_CXSMICON 49")]
    public const int SM_CXSMICON = 49;

    [NativeTypeName("#define SM_CYSMICON 50")]
    public const int SM_CYSMICON = 50;

    [NativeTypeName("#define SM_CYSMCAPTION 51")]
    public const int SM_CYSMCAPTION = 51;

    [NativeTypeName("#define SM_CXSMSIZE 52")]
    public const int SM_CXSMSIZE = 52;

    [NativeTypeName("#define SM_CYSMSIZE 53")]
    public const int SM_CYSMSIZE = 53;

    [NativeTypeName("#define SM_CXMENUSIZE 54")]
    public const int SM_CXMENUSIZE = 54;

    [NativeTypeName("#define SM_CYMENUSIZE 55")]
    public const int SM_CYMENUSIZE = 55;

    [NativeTypeName("#define SM_ARRANGE 56")]
    public const int SM_ARRANGE = 56;

    [NativeTypeName("#define SM_CXMINIMIZED 57")]
    public const int SM_CXMINIMIZED = 57;

    [NativeTypeName("#define SM_CYMINIMIZED 58")]
    public const int SM_CYMINIMIZED = 58;

    [NativeTypeName("#define SM_CXMAXTRACK 59")]
    public const int SM_CXMAXTRACK = 59;

    [NativeTypeName("#define SM_CYMAXTRACK 60")]
    public const int SM_CYMAXTRACK = 60;

    [NativeTypeName("#define SM_CXMAXIMIZED 61")]
    public const int SM_CXMAXIMIZED = 61;

    [NativeTypeName("#define SM_CYMAXIMIZED 62")]
    public const int SM_CYMAXIMIZED = 62;

    [NativeTypeName("#define SM_NETWORK 63")]
    public const int SM_NETWORK = 63;

    [NativeTypeName("#define SM_CLEANBOOT 67")]
    public const int SM_CLEANBOOT = 67;

    [NativeTypeName("#define SM_CXDRAG 68")]
    public const int SM_CXDRAG = 68;

    [NativeTypeName("#define SM_CYDRAG 69")]
    public const int SM_CYDRAG = 69;

    [NativeTypeName("#define SM_SHOWSOUNDS 70")]
    public const int SM_SHOWSOUNDS = 70;

    [NativeTypeName("#define SM_CXMENUCHECK 71")]
    public const int SM_CXMENUCHECK = 71;

    [NativeTypeName("#define SM_CYMENUCHECK 72")]
    public const int SM_CYMENUCHECK = 72;

    [NativeTypeName("#define SM_SLOWMACHINE 73")]
    public const int SM_SLOWMACHINE = 73;

    [NativeTypeName("#define SM_MIDEASTENABLED 74")]
    public const int SM_MIDEASTENABLED = 74;

    [NativeTypeName("#define SM_MOUSEWHEELPRESENT 75")]
    public const int SM_MOUSEWHEELPRESENT = 75;

    [NativeTypeName("#define SM_XVIRTUALSCREEN 76")]
    public const int SM_XVIRTUALSCREEN = 76;

    [NativeTypeName("#define SM_YVIRTUALSCREEN 77")]
    public const int SM_YVIRTUALSCREEN = 77;

    [NativeTypeName("#define SM_CXVIRTUALSCREEN 78")]
    public const int SM_CXVIRTUALSCREEN = 78;

    [NativeTypeName("#define SM_CYVIRTUALSCREEN 79")]
    public const int SM_CYVIRTUALSCREEN = 79;

    [NativeTypeName("#define SM_CMONITORS 80")]
    public const int SM_CMONITORS = 80;

    [NativeTypeName("#define SM_SAMEDISPLAYFORMAT 81")]
    public const int SM_SAMEDISPLAYFORMAT = 81;

    [NativeTypeName("#define SM_IMMENABLED 82")]
    public const int SM_IMMENABLED = 82;

    [NativeTypeName("#define SM_CXFOCUSBORDER 83")]
    public const int SM_CXFOCUSBORDER = 83;

    [NativeTypeName("#define SM_CYFOCUSBORDER 84")]
    public const int SM_CYFOCUSBORDER = 84;

    [NativeTypeName("#define SM_TABLETPC 86")]
    public const int SM_TABLETPC = 86;

    [NativeTypeName("#define SM_MEDIACENTER 87")]
    public const int SM_MEDIACENTER = 87;

    [NativeTypeName("#define SM_STARTER 88")]
    public const int SM_STARTER = 88;

    [NativeTypeName("#define SM_SERVERR2 89")]
    public const int SM_SERVERR2 = 89;

    [NativeTypeName("#define SM_MOUSEHORIZONTALWHEELPRESENT 91")]
    public const int SM_MOUSEHORIZONTALWHEELPRESENT = 91;

    [NativeTypeName("#define SM_CXPADDEDBORDER 92")]
    public const int SM_CXPADDEDBORDER = 92;

    [NativeTypeName("#define SM_DIGITIZER 94")]
    public const int SM_DIGITIZER = 94;

    [NativeTypeName("#define SM_MAXIMUMTOUCHES 95")]
    public const int SM_MAXIMUMTOUCHES = 95;

    [NativeTypeName("#define SM_CMETRICS 97")]
    public const int SM_CMETRICS = 97;

    [NativeTypeName("#define SM_REMOTESESSION 0x1000")]
    public const int SM_REMOTESESSION = 0x1000;

    [NativeTypeName("#define SM_SHUTTINGDOWN 0x2000")]
    public const int SM_SHUTTINGDOWN = 0x2000;

    [NativeTypeName("#define SM_REMOTECONTROL 0x2001")]
    public const int SM_REMOTECONTROL = 0x2001;

    [NativeTypeName("#define SM_CARETBLINKINGENABLED 0x2002")]
    public const int SM_CARETBLINKINGENABLED = 0x2002;

    [NativeTypeName("#define SM_CONVERTIBLESLATEMODE 0x2003")]
    public const int SM_CONVERTIBLESLATEMODE = 0x2003;

    [NativeTypeName("#define SM_SYSTEMDOCKED 0x2004")]
    public const int SM_SYSTEMDOCKED = 0x2004;
}

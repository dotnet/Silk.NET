// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class EM
{
    [NativeTypeName("#define EM_GETSEL 0x00B0")]
    public const int EM_GETSEL = 0x00B0;

    [NativeTypeName("#define EM_SETSEL 0x00B1")]
    public const int EM_SETSEL = 0x00B1;

    [NativeTypeName("#define EM_GETRECT 0x00B2")]
    public const int EM_GETRECT = 0x00B2;

    [NativeTypeName("#define EM_SETRECT 0x00B3")]
    public const int EM_SETRECT = 0x00B3;

    [NativeTypeName("#define EM_SETRECTNP 0x00B4")]
    public const int EM_SETRECTNP = 0x00B4;

    [NativeTypeName("#define EM_SCROLL 0x00B5")]
    public const int EM_SCROLL = 0x00B5;

    [NativeTypeName("#define EM_LINESCROLL 0x00B6")]
    public const int EM_LINESCROLL = 0x00B6;

    [NativeTypeName("#define EM_SCROLLCARET 0x00B7")]
    public const int EM_SCROLLCARET = 0x00B7;

    [NativeTypeName("#define EM_GETMODIFY 0x00B8")]
    public const int EM_GETMODIFY = 0x00B8;

    [NativeTypeName("#define EM_SETMODIFY 0x00B9")]
    public const int EM_SETMODIFY = 0x00B9;

    [NativeTypeName("#define EM_GETLINECOUNT 0x00BA")]
    public const int EM_GETLINECOUNT = 0x00BA;

    [NativeTypeName("#define EM_LINEINDEX 0x00BB")]
    public const int EM_LINEINDEX = 0x00BB;

    [NativeTypeName("#define EM_SETHANDLE 0x00BC")]
    public const int EM_SETHANDLE = 0x00BC;

    [NativeTypeName("#define EM_GETHANDLE 0x00BD")]
    public const int EM_GETHANDLE = 0x00BD;

    [NativeTypeName("#define EM_GETTHUMB 0x00BE")]
    public const int EM_GETTHUMB = 0x00BE;

    [NativeTypeName("#define EM_LINELENGTH 0x00C1")]
    public const int EM_LINELENGTH = 0x00C1;

    [NativeTypeName("#define EM_REPLACESEL 0x00C2")]
    public const int EM_REPLACESEL = 0x00C2;

    [NativeTypeName("#define EM_GETLINE 0x00C4")]
    public const int EM_GETLINE = 0x00C4;

    [NativeTypeName("#define EM_LIMITTEXT 0x00C5")]
    public const int EM_LIMITTEXT = 0x00C5;

    [NativeTypeName("#define EM_CANUNDO 0x00C6")]
    public const int EM_CANUNDO = 0x00C6;

    [NativeTypeName("#define EM_UNDO 0x00C7")]
    public const int EM_UNDO = 0x00C7;

    [NativeTypeName("#define EM_FMTLINES 0x00C8")]
    public const int EM_FMTLINES = 0x00C8;

    [NativeTypeName("#define EM_LINEFROMCHAR 0x00C9")]
    public const int EM_LINEFROMCHAR = 0x00C9;

    [NativeTypeName("#define EM_SETTABSTOPS 0x00CB")]
    public const int EM_SETTABSTOPS = 0x00CB;

    [NativeTypeName("#define EM_SETPASSWORDCHAR 0x00CC")]
    public const int EM_SETPASSWORDCHAR = 0x00CC;

    [NativeTypeName("#define EM_EMPTYUNDOBUFFER 0x00CD")]
    public const int EM_EMPTYUNDOBUFFER = 0x00CD;

    [NativeTypeName("#define EM_GETFIRSTVISIBLELINE 0x00CE")]
    public const int EM_GETFIRSTVISIBLELINE = 0x00CE;

    [NativeTypeName("#define EM_SETREADONLY 0x00CF")]
    public const int EM_SETREADONLY = 0x00CF;

    [NativeTypeName("#define EM_SETWORDBREAKPROC 0x00D0")]
    public const int EM_SETWORDBREAKPROC = 0x00D0;

    [NativeTypeName("#define EM_GETWORDBREAKPROC 0x00D1")]
    public const int EM_GETWORDBREAKPROC = 0x00D1;

    [NativeTypeName("#define EM_GETPASSWORDCHAR 0x00D2")]
    public const int EM_GETPASSWORDCHAR = 0x00D2;

    [NativeTypeName("#define EM_SETMARGINS 0x00D3")]
    public const int EM_SETMARGINS = 0x00D3;

    [NativeTypeName("#define EM_GETMARGINS 0x00D4")]
    public const int EM_GETMARGINS = 0x00D4;

    [NativeTypeName("#define EM_SETLIMITTEXT EM_LIMITTEXT")]
    public const int EM_SETLIMITTEXT = 0x00C5;

    [NativeTypeName("#define EM_GETLIMITTEXT 0x00D5")]
    public const int EM_GETLIMITTEXT = 0x00D5;

    [NativeTypeName("#define EM_POSFROMCHAR 0x00D6")]
    public const int EM_POSFROMCHAR = 0x00D6;

    [NativeTypeName("#define EM_CHARFROMPOS 0x00D7")]
    public const int EM_CHARFROMPOS = 0x00D7;

    [NativeTypeName("#define EM_SETIMESTATUS 0x00D8")]
    public const int EM_SETIMESTATUS = 0x00D8;

    [NativeTypeName("#define EM_GETIMESTATUS 0x00D9")]
    public const int EM_GETIMESTATUS = 0x00D9;

    [NativeTypeName("#define EM_ENABLEFEATURE 0x00DA")]
    public const int EM_ENABLEFEATURE = 0x00DA;
}

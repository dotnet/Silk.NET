// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class EM
{
    [NativeTypeName("#define EM_SETCUEBANNER (ECM_FIRST + 1)")]
    public const int EM_SETCUEBANNER = (0x1500 + 1);
    [NativeTypeName("#define EM_GETCUEBANNER (ECM_FIRST + 2)")]
    public const int EM_GETCUEBANNER = (0x1500 + 2);
    [NativeTypeName("#define EM_SHOWBALLOONTIP (ECM_FIRST + 3)")]
    public const int EM_SHOWBALLOONTIP = (0x1500 + 3);
    [NativeTypeName("#define EM_HIDEBALLOONTIP (ECM_FIRST + 4)")]
    public const int EM_HIDEBALLOONTIP = (0x1500 + 4);
    [NativeTypeName("#define EM_SETHILITE (ECM_FIRST + 5)")]
    public const int EM_SETHILITE = (0x1500 + 5);
    [NativeTypeName("#define EM_GETHILITE (ECM_FIRST + 6)")]
    public const int EM_GETHILITE = (0x1500 + 6);
    [NativeTypeName("#define EM_NOSETFOCUS (ECM_FIRST + 7)")]
    public const int EM_NOSETFOCUS = (0x1500 + 7);
    [NativeTypeName("#define EM_TAKEFOCUS (ECM_FIRST + 8)")]
    public const int EM_TAKEFOCUS = (0x1500 + 8);
    [NativeTypeName("#define EM_SETEXTENDEDSTYLE (ECM_FIRST + 10)")]
    public const int EM_SETEXTENDEDSTYLE = (0x1500 + 10);
    [NativeTypeName("#define EM_GETEXTENDEDSTYLE (ECM_FIRST + 11)")]
    public const int EM_GETEXTENDEDSTYLE = (0x1500 + 11);
    [NativeTypeName("#define EM_SETENDOFLINE (ECM_FIRST + 12)")]
    public const int EM_SETENDOFLINE = (0x1500 + 12);
    [NativeTypeName("#define EM_GETENDOFLINE (ECM_FIRST + 13)")]
    public const int EM_GETENDOFLINE = (0x1500 + 13);
    [NativeTypeName("#define EM_ENABLESEARCHWEB (ECM_FIRST + 14)")]
    public const int EM_ENABLESEARCHWEB = (0x1500 + 14);
    [NativeTypeName("#define EM_SEARCHWEB (ECM_FIRST + 15)")]
    public const int EM_SEARCHWEB = (0x1500 + 15);
    [NativeTypeName("#define EM_SETCARETINDEX (ECM_FIRST + 17)")]
    public const int EM_SETCARETINDEX = (0x1500 + 17);
    [NativeTypeName("#define EM_GETCARETINDEX (ECM_FIRST + 18)")]
    public const int EM_GETCARETINDEX = (0x1500 + 18);
    [NativeTypeName("#define EM_GETZOOM (WM_USER + 224)")]
    public const int EM_GETZOOM = (0x0400 + 224);
    [NativeTypeName("#define EM_SETZOOM (WM_USER + 225)")]
    public const int EM_SETZOOM = (0x0400 + 225);
    [NativeTypeName("#define EM_FILELINEFROMCHAR (ECM_FIRST + 19)")]
    public const int EM_FILELINEFROMCHAR = (0x1500 + 19);
    [NativeTypeName("#define EM_FILELINEINDEX (ECM_FIRST + 20)")]
    public const int EM_FILELINEINDEX = (0x1500 + 20);
    [NativeTypeName("#define EM_FILELINELENGTH (ECM_FIRST + 21)")]
    public const int EM_FILELINELENGTH = (0x1500 + 21);
    [NativeTypeName("#define EM_GETFILELINE (ECM_FIRST + 22)")]
    public const int EM_GETFILELINE = (0x1500 + 22);
    [NativeTypeName("#define EM_GETFILELINECOUNT (ECM_FIRST + 23)")]
    public const int EM_GETFILELINECOUNT = (0x1500 + 23);
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class CBN
{
    [NativeTypeName("#define CBN_ERRSPACE (-1)")]
    public const int CBN_ERRSPACE = (-1);

    [NativeTypeName("#define CBN_SELCHANGE 1")]
    public const int CBN_SELCHANGE = 1;

    [NativeTypeName("#define CBN_DBLCLK 2")]
    public const int CBN_DBLCLK = 2;

    [NativeTypeName("#define CBN_SETFOCUS 3")]
    public const int CBN_SETFOCUS = 3;

    [NativeTypeName("#define CBN_KILLFOCUS 4")]
    public const int CBN_KILLFOCUS = 4;

    [NativeTypeName("#define CBN_EDITCHANGE 5")]
    public const int CBN_EDITCHANGE = 5;

    [NativeTypeName("#define CBN_EDITUPDATE 6")]
    public const int CBN_EDITUPDATE = 6;

    [NativeTypeName("#define CBN_DROPDOWN 7")]
    public const int CBN_DROPDOWN = 7;

    [NativeTypeName("#define CBN_CLOSEUP 8")]
    public const int CBN_CLOSEUP = 8;

    [NativeTypeName("#define CBN_SELENDOK 9")]
    public const int CBN_SELENDOK = 9;

    [NativeTypeName("#define CBN_SELENDCANCEL 10")]
    public const int CBN_SELENDCANCEL = 10;
}

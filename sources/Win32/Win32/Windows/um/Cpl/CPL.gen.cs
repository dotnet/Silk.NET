// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CPL
{
    [NativeTypeName("#define CPL_DYNAMIC_RES 0")]
    public const int CPL_DYNAMIC_RES = 0;

    [NativeTypeName("#define CPL_INIT 1")]
    public const int CPL_INIT = 1;

    [NativeTypeName("#define CPL_GETCOUNT 2")]
    public const int CPL_GETCOUNT = 2;

    [NativeTypeName("#define CPL_INQUIRE 3")]
    public const int CPL_INQUIRE = 3;

    [NativeTypeName("#define CPL_SELECT 4")]
    public const int CPL_SELECT = 4;

    [NativeTypeName("#define CPL_DBLCLK 5")]
    public const int CPL_DBLCLK = 5;

    [NativeTypeName("#define CPL_STOP 6")]
    public const int CPL_STOP = 6;

    [NativeTypeName("#define CPL_EXIT 7")]
    public const int CPL_EXIT = 7;

    [NativeTypeName("#define CPL_NEWINQUIRE 8")]
    public const int CPL_NEWINQUIRE = 8;

    [NativeTypeName("#define CPL_STARTWPARMSA 9")]
    public const int CPL_STARTWPARMSA = 9;

    [NativeTypeName("#define CPL_STARTWPARMSW 10")]
    public const int CPL_STARTWPARMSW = 10;

    [NativeTypeName("#define CPL_STARTWPARMS CPL_STARTWPARMSW")]
    public const int CPL_STARTWPARMS = 10;

    [NativeTypeName("#define CPL_SETUP 200")]
    public const int CPL_SETUP = 200;
}

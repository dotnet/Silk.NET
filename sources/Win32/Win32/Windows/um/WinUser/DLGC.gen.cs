// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DLGC
{
    [NativeTypeName("#define DLGC_WANTARROWS 0x0001")]
    public const int DLGC_WANTARROWS = 0x0001;

    [NativeTypeName("#define DLGC_WANTTAB 0x0002")]
    public const int DLGC_WANTTAB = 0x0002;

    [NativeTypeName("#define DLGC_WANTALLKEYS 0x0004")]
    public const int DLGC_WANTALLKEYS = 0x0004;

    [NativeTypeName("#define DLGC_WANTMESSAGE 0x0004")]
    public const int DLGC_WANTMESSAGE = 0x0004;

    [NativeTypeName("#define DLGC_HASSETSEL 0x0008")]
    public const int DLGC_HASSETSEL = 0x0008;

    [NativeTypeName("#define DLGC_DEFPUSHBUTTON 0x0010")]
    public const int DLGC_DEFPUSHBUTTON = 0x0010;

    [NativeTypeName("#define DLGC_UNDEFPUSHBUTTON 0x0020")]
    public const int DLGC_UNDEFPUSHBUTTON = 0x0020;

    [NativeTypeName("#define DLGC_RADIOBUTTON 0x0040")]
    public const int DLGC_RADIOBUTTON = 0x0040;

    [NativeTypeName("#define DLGC_WANTCHARS 0x0080")]
    public const int DLGC_WANTCHARS = 0x0080;

    [NativeTypeName("#define DLGC_STATIC 0x0100")]
    public const int DLGC_STATIC = 0x0100;

    [NativeTypeName("#define DLGC_BUTTON 0x2000")]
    public const int DLGC_BUTTON = 0x2000;
}

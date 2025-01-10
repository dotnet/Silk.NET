// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BS
{
    [NativeTypeName("#define BS_PUSHBUTTON 0x00000000L")]
    public const int BS_PUSHBUTTON = 0x00000000;

    [NativeTypeName("#define BS_DEFPUSHBUTTON 0x00000001L")]
    public const int BS_DEFPUSHBUTTON = 0x00000001;

    [NativeTypeName("#define BS_CHECKBOX 0x00000002L")]
    public const int BS_CHECKBOX = 0x00000002;

    [NativeTypeName("#define BS_AUTOCHECKBOX 0x00000003L")]
    public const int BS_AUTOCHECKBOX = 0x00000003;

    [NativeTypeName("#define BS_RADIOBUTTON 0x00000004L")]
    public const int BS_RADIOBUTTON = 0x00000004;

    [NativeTypeName("#define BS_3STATE 0x00000005L")]
    public const int BS_3STATE = 0x00000005;

    [NativeTypeName("#define BS_AUTO3STATE 0x00000006L")]
    public const int BS_AUTO3STATE = 0x00000006;

    [NativeTypeName("#define BS_GROUPBOX 0x00000007L")]
    public const int BS_GROUPBOX = 0x00000007;

    [NativeTypeName("#define BS_USERBUTTON 0x00000008L")]
    public const int BS_USERBUTTON = 0x00000008;

    [NativeTypeName("#define BS_AUTORADIOBUTTON 0x00000009L")]
    public const int BS_AUTORADIOBUTTON = 0x00000009;

    [NativeTypeName("#define BS_PUSHBOX 0x0000000AL")]
    public const int BS_PUSHBOX = 0x0000000A;

    [NativeTypeName("#define BS_OWNERDRAW 0x0000000BL")]
    public const int BS_OWNERDRAW = 0x0000000B;

    [NativeTypeName("#define BS_TYPEMASK 0x0000000FL")]
    public const int BS_TYPEMASK = 0x0000000F;

    [NativeTypeName("#define BS_LEFTTEXT 0x00000020L")]
    public const int BS_LEFTTEXT = 0x00000020;

    [NativeTypeName("#define BS_TEXT 0x00000000L")]
    public const int BS_TEXT = 0x00000000;

    [NativeTypeName("#define BS_ICON 0x00000040L")]
    public const int BS_ICON = 0x00000040;

    [NativeTypeName("#define BS_BITMAP 0x00000080L")]
    public const int BS_BITMAP = 0x00000080;

    [NativeTypeName("#define BS_LEFT 0x00000100L")]
    public const int BS_LEFT = 0x00000100;

    [NativeTypeName("#define BS_RIGHT 0x00000200L")]
    public const int BS_RIGHT = 0x00000200;

    [NativeTypeName("#define BS_CENTER 0x00000300L")]
    public const int BS_CENTER = 0x00000300;

    [NativeTypeName("#define BS_TOP 0x00000400L")]
    public const int BS_TOP = 0x00000400;

    [NativeTypeName("#define BS_BOTTOM 0x00000800L")]
    public const int BS_BOTTOM = 0x00000800;

    [NativeTypeName("#define BS_VCENTER 0x00000C00L")]
    public const int BS_VCENTER = 0x00000C00;

    [NativeTypeName("#define BS_PUSHLIKE 0x00001000L")]
    public const int BS_PUSHLIKE = 0x00001000;

    [NativeTypeName("#define BS_MULTILINE 0x00002000L")]
    public const int BS_MULTILINE = 0x00002000;

    [NativeTypeName("#define BS_NOTIFY 0x00004000L")]
    public const int BS_NOTIFY = 0x00004000;

    [NativeTypeName("#define BS_FLAT 0x00008000L")]
    public const int BS_FLAT = 0x00008000;

    [NativeTypeName("#define BS_RIGHTBUTTON BS_LEFTTEXT")]
    public const int BS_RIGHTBUTTON = 0x00000020;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class QS
{
    [NativeTypeName("#define QS_KEY 0x0001")]
    public const int QS_KEY = 0x0001;

    [NativeTypeName("#define QS_MOUSEMOVE 0x0002")]
    public const int QS_MOUSEMOVE = 0x0002;

    [NativeTypeName("#define QS_MOUSEBUTTON 0x0004")]
    public const int QS_MOUSEBUTTON = 0x0004;

    [NativeTypeName("#define QS_POSTMESSAGE 0x0008")]
    public const int QS_POSTMESSAGE = 0x0008;

    [NativeTypeName("#define QS_TIMER 0x0010")]
    public const int QS_TIMER = 0x0010;

    [NativeTypeName("#define QS_PAINT 0x0020")]
    public const int QS_PAINT = 0x0020;

    [NativeTypeName("#define QS_SENDMESSAGE 0x0040")]
    public const int QS_SENDMESSAGE = 0x0040;

    [NativeTypeName("#define QS_HOTKEY 0x0080")]
    public const int QS_HOTKEY = 0x0080;

    [NativeTypeName("#define QS_ALLPOSTMESSAGE 0x0100")]
    public const int QS_ALLPOSTMESSAGE = 0x0100;

    [NativeTypeName("#define QS_RAWINPUT 0x0400")]
    public const int QS_RAWINPUT = 0x0400;

    [NativeTypeName("#define QS_TOUCH 0x0800")]
    public const int QS_TOUCH = 0x0800;

    [NativeTypeName("#define QS_POINTER 0x1000")]
    public const int QS_POINTER = 0x1000;

    [NativeTypeName(
        "#define QS_MOUSE (QS_MOUSEMOVE     | \\\r\n                            QS_MOUSEBUTTON)"
    )]
    public const int QS_MOUSE = (0x0002 | 0x0004);

    [NativeTypeName(
        "#define QS_INPUT (QS_MOUSE         | \\\r\n                            QS_KEY           | \\\r\n                            QS_RAWINPUT      | \\\r\n                            QS_TOUCH         | \\\r\n                            QS_POINTER)"
    )]
    public const int QS_INPUT = ((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000);

    [NativeTypeName(
        "#define QS_ALLEVENTS (QS_INPUT         | \\\r\n                            QS_POSTMESSAGE   | \\\r\n                            QS_TIMER         | \\\r\n                            QS_PAINT         | \\\r\n                            QS_HOTKEY)"
    )]
    public const int QS_ALLEVENTS = (
        ((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000) | 0x0008 | 0x0010 | 0x0020 | 0x0080
    );

    [NativeTypeName(
        "#define QS_ALLINPUT (QS_INPUT         | \\\r\n                            QS_POSTMESSAGE   | \\\r\n                            QS_TIMER         | \\\r\n                            QS_PAINT         | \\\r\n                            QS_HOTKEY        | \\\r\n                            QS_SENDMESSAGE)"
    )]
    public const int QS_ALLINPUT = (
        ((0x0002 | 0x0004) | 0x0001 | 0x0400 | 0x0800 | 0x1000)
        | 0x0008
        | 0x0010
        | 0x0020
        | 0x0080
        | 0x0040
    );
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DC
{
    [NativeTypeName("#define DC_ACTIVE 0x0001")]
    public const int DC_ACTIVE = 0x0001;

    [NativeTypeName("#define DC_SMALLCAP 0x0002")]
    public const int DC_SMALLCAP = 0x0002;

    [NativeTypeName("#define DC_ICON 0x0004")]
    public const int DC_ICON = 0x0004;

    [NativeTypeName("#define DC_TEXT 0x0008")]
    public const int DC_TEXT = 0x0008;

    [NativeTypeName("#define DC_INBUTTON 0x0010")]
    public const int DC_INBUTTON = 0x0010;

    [NativeTypeName("#define DC_GRADIENT 0x0020")]
    public const int DC_GRADIENT = 0x0020;

    [NativeTypeName("#define DC_BUTTONS 0x1000")]
    public const int DC_BUTTONS = 0x1000;

    [NativeTypeName("#define DC_HASDEFID 0x534B")]
    public const int DC_HASDEFID = 0x534B;
}

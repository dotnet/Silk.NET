// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class RI
{
    [NativeTypeName("#define RI_MOUSE_LEFT_BUTTON_DOWN 0x0001")]
    public const int RI_MOUSE_LEFT_BUTTON_DOWN = 0x0001;
    [NativeTypeName("#define RI_MOUSE_LEFT_BUTTON_UP 0x0002")]
    public const int RI_MOUSE_LEFT_BUTTON_UP = 0x0002;
    [NativeTypeName("#define RI_MOUSE_RIGHT_BUTTON_DOWN 0x0004")]
    public const int RI_MOUSE_RIGHT_BUTTON_DOWN = 0x0004;
    [NativeTypeName("#define RI_MOUSE_RIGHT_BUTTON_UP 0x0008")]
    public const int RI_MOUSE_RIGHT_BUTTON_UP = 0x0008;
    [NativeTypeName("#define RI_MOUSE_MIDDLE_BUTTON_DOWN 0x0010")]
    public const int RI_MOUSE_MIDDLE_BUTTON_DOWN = 0x0010;
    [NativeTypeName("#define RI_MOUSE_MIDDLE_BUTTON_UP 0x0020")]
    public const int RI_MOUSE_MIDDLE_BUTTON_UP = 0x0020;
    [NativeTypeName("#define RI_MOUSE_BUTTON_1_DOWN RI_MOUSE_LEFT_BUTTON_DOWN")]
    public const int RI_MOUSE_BUTTON_1_DOWN = 0x0001;
    [NativeTypeName("#define RI_MOUSE_BUTTON_1_UP RI_MOUSE_LEFT_BUTTON_UP")]
    public const int RI_MOUSE_BUTTON_1_UP = 0x0002;
    [NativeTypeName("#define RI_MOUSE_BUTTON_2_DOWN RI_MOUSE_RIGHT_BUTTON_DOWN")]
    public const int RI_MOUSE_BUTTON_2_DOWN = 0x0004;
    [NativeTypeName("#define RI_MOUSE_BUTTON_2_UP RI_MOUSE_RIGHT_BUTTON_UP")]
    public const int RI_MOUSE_BUTTON_2_UP = 0x0008;
    [NativeTypeName("#define RI_MOUSE_BUTTON_3_DOWN RI_MOUSE_MIDDLE_BUTTON_DOWN")]
    public const int RI_MOUSE_BUTTON_3_DOWN = 0x0010;
    [NativeTypeName("#define RI_MOUSE_BUTTON_3_UP RI_MOUSE_MIDDLE_BUTTON_UP")]
    public const int RI_MOUSE_BUTTON_3_UP = 0x0020;
    [NativeTypeName("#define RI_MOUSE_BUTTON_4_DOWN 0x0040")]
    public const int RI_MOUSE_BUTTON_4_DOWN = 0x0040;
    [NativeTypeName("#define RI_MOUSE_BUTTON_4_UP 0x0080")]
    public const int RI_MOUSE_BUTTON_4_UP = 0x0080;
    [NativeTypeName("#define RI_MOUSE_BUTTON_5_DOWN 0x0100")]
    public const int RI_MOUSE_BUTTON_5_DOWN = 0x0100;
    [NativeTypeName("#define RI_MOUSE_BUTTON_5_UP 0x0200")]
    public const int RI_MOUSE_BUTTON_5_UP = 0x0200;
    [NativeTypeName("#define RI_MOUSE_WHEEL 0x0400")]
    public const int RI_MOUSE_WHEEL = 0x0400;
    [NativeTypeName("#define RI_MOUSE_HWHEEL 0x0800")]
    public const int RI_MOUSE_HWHEEL = 0x0800;
    [NativeTypeName("#define RI_KEY_MAKE 0")]
    public const int RI_KEY_MAKE = 0;
    [NativeTypeName("#define RI_KEY_BREAK 1")]
    public const int RI_KEY_BREAK = 1;
    [NativeTypeName("#define RI_KEY_E0 2")]
    public const int RI_KEY_E0 = 2;
    [NativeTypeName("#define RI_KEY_E1 4")]
    public const int RI_KEY_E1 = 4;
    [NativeTypeName("#define RI_KEY_TERMSRV_SET_LED 8")]
    public const int RI_KEY_TERMSRV_SET_LED = 8;
    [NativeTypeName("#define RI_KEY_TERMSRV_SHADOW 0x10")]
    public const int RI_KEY_TERMSRV_SHADOW = 0x10;
}
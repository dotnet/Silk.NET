// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static partial class DIJOFS
{
    [NativeTypeName("#define DIJOFS_X FIELD_OFFSET(DIJOYSTATE, lX)")]
    public static int DIJOFS_X => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lX")));

    [NativeTypeName("#define DIJOFS_Y FIELD_OFFSET(DIJOYSTATE, lY)")]
    public static int DIJOFS_Y => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lY")));

    [NativeTypeName("#define DIJOFS_Z FIELD_OFFSET(DIJOYSTATE, lZ)")]
    public static int DIJOFS_Z => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lZ")));

    [NativeTypeName("#define DIJOFS_RX FIELD_OFFSET(DIJOYSTATE, lRx)")]
    public static int DIJOFS_RX => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lRx")));

    [NativeTypeName("#define DIJOFS_RY FIELD_OFFSET(DIJOYSTATE, lRy)")]
    public static int DIJOFS_RY => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lRy")));

    [NativeTypeName("#define DIJOFS_RZ FIELD_OFFSET(DIJOYSTATE, lRz)")]
    public static int DIJOFS_RZ => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lRz")));

    [NativeTypeName("#define DIJOFS_BUTTON0 DIJOFS_BUTTON(0)")]
    public static int DIJOFS_BUTTON0 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (0));

    [NativeTypeName("#define DIJOFS_BUTTON1 DIJOFS_BUTTON(1)")]
    public static int DIJOFS_BUTTON1 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (1));

    [NativeTypeName("#define DIJOFS_BUTTON2 DIJOFS_BUTTON(2)")]
    public static int DIJOFS_BUTTON2 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (2));

    [NativeTypeName("#define DIJOFS_BUTTON3 DIJOFS_BUTTON(3)")]
    public static int DIJOFS_BUTTON3 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (3));

    [NativeTypeName("#define DIJOFS_BUTTON4 DIJOFS_BUTTON(4)")]
    public static int DIJOFS_BUTTON4 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (4));

    [NativeTypeName("#define DIJOFS_BUTTON5 DIJOFS_BUTTON(5)")]
    public static int DIJOFS_BUTTON5 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (5));

    [NativeTypeName("#define DIJOFS_BUTTON6 DIJOFS_BUTTON(6)")]
    public static int DIJOFS_BUTTON6 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (6));

    [NativeTypeName("#define DIJOFS_BUTTON7 DIJOFS_BUTTON(7)")]
    public static int DIJOFS_BUTTON7 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (7));

    [NativeTypeName("#define DIJOFS_BUTTON8 DIJOFS_BUTTON(8)")]
    public static int DIJOFS_BUTTON8 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (8));

    [NativeTypeName("#define DIJOFS_BUTTON9 DIJOFS_BUTTON(9)")]
    public static int DIJOFS_BUTTON9 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (9));

    [NativeTypeName("#define DIJOFS_BUTTON10 DIJOFS_BUTTON(10)")]
    public static int DIJOFS_BUTTON10 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (10));

    [NativeTypeName("#define DIJOFS_BUTTON11 DIJOFS_BUTTON(11)")]
    public static int DIJOFS_BUTTON11 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (11));

    [NativeTypeName("#define DIJOFS_BUTTON12 DIJOFS_BUTTON(12)")]
    public static int DIJOFS_BUTTON12 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (12));

    [NativeTypeName("#define DIJOFS_BUTTON13 DIJOFS_BUTTON(13)")]
    public static int DIJOFS_BUTTON13 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (13));

    [NativeTypeName("#define DIJOFS_BUTTON14 DIJOFS_BUTTON(14)")]
    public static int DIJOFS_BUTTON14 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (14));

    [NativeTypeName("#define DIJOFS_BUTTON15 DIJOFS_BUTTON(15)")]
    public static int DIJOFS_BUTTON15 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (15));

    [NativeTypeName("#define DIJOFS_BUTTON16 DIJOFS_BUTTON(16)")]
    public static int DIJOFS_BUTTON16 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (16));

    [NativeTypeName("#define DIJOFS_BUTTON17 DIJOFS_BUTTON(17)")]
    public static int DIJOFS_BUTTON17 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (17));

    [NativeTypeName("#define DIJOFS_BUTTON18 DIJOFS_BUTTON(18)")]
    public static int DIJOFS_BUTTON18 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (18));

    [NativeTypeName("#define DIJOFS_BUTTON19 DIJOFS_BUTTON(19)")]
    public static int DIJOFS_BUTTON19 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (19));

    [NativeTypeName("#define DIJOFS_BUTTON20 DIJOFS_BUTTON(20)")]
    public static int DIJOFS_BUTTON20 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (20));

    [NativeTypeName("#define DIJOFS_BUTTON21 DIJOFS_BUTTON(21)")]
    public static int DIJOFS_BUTTON21 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (21));

    [NativeTypeName("#define DIJOFS_BUTTON22 DIJOFS_BUTTON(22)")]
    public static int DIJOFS_BUTTON22 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (22));

    [NativeTypeName("#define DIJOFS_BUTTON23 DIJOFS_BUTTON(23)")]
    public static int DIJOFS_BUTTON23 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (23));

    [NativeTypeName("#define DIJOFS_BUTTON24 DIJOFS_BUTTON(24)")]
    public static int DIJOFS_BUTTON24 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (24));

    [NativeTypeName("#define DIJOFS_BUTTON25 DIJOFS_BUTTON(25)")]
    public static int DIJOFS_BUTTON25 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (25));

    [NativeTypeName("#define DIJOFS_BUTTON26 DIJOFS_BUTTON(26)")]
    public static int DIJOFS_BUTTON26 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (26));

    [NativeTypeName("#define DIJOFS_BUTTON27 DIJOFS_BUTTON(27)")]
    public static int DIJOFS_BUTTON27 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (27));

    [NativeTypeName("#define DIJOFS_BUTTON28 DIJOFS_BUTTON(28)")]
    public static int DIJOFS_BUTTON28 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (28));

    [NativeTypeName("#define DIJOFS_BUTTON29 DIJOFS_BUTTON(29)")]
    public static int DIJOFS_BUTTON29 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (29));

    [NativeTypeName("#define DIJOFS_BUTTON30 DIJOFS_BUTTON(30)")]
    public static int DIJOFS_BUTTON30 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (30));

    [NativeTypeName("#define DIJOFS_BUTTON31 DIJOFS_BUTTON(31)")]
    public static int DIJOFS_BUTTON31 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (31));
}
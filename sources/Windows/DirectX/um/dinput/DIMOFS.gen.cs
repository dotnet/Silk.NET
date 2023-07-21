// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static partial class DIMOFS
{
    [NativeTypeName("#define DIMOFS_X FIELD_OFFSET(DIMOUSESTATE, lX)")]
    public static int DIMOFS_X => ((int)(Marshal.OffsetOf<DIMOUSESTATE>("lX")));

    [NativeTypeName("#define DIMOFS_Y FIELD_OFFSET(DIMOUSESTATE, lY)")]
    public static int DIMOFS_Y => ((int)(Marshal.OffsetOf<DIMOUSESTATE>("lY")));

    [NativeTypeName("#define DIMOFS_Z FIELD_OFFSET(DIMOUSESTATE, lZ)")]
    public static int DIMOFS_Z => ((int)(Marshal.OffsetOf<DIMOUSESTATE>("lZ")));

    [NativeTypeName("#define DIMOFS_BUTTON0 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 0)")]
    public static int DIMOFS_BUTTON0 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 0);

    [NativeTypeName("#define DIMOFS_BUTTON1 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 1)")]
    public static int DIMOFS_BUTTON1 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 1);

    [NativeTypeName("#define DIMOFS_BUTTON2 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 2)")]
    public static int DIMOFS_BUTTON2 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 2);

    [NativeTypeName("#define DIMOFS_BUTTON3 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 3)")]
    public static int DIMOFS_BUTTON3 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 3);

    [NativeTypeName("#define DIMOFS_BUTTON4 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 4)")]
    public static int DIMOFS_BUTTON4 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 4);

    [NativeTypeName("#define DIMOFS_BUTTON5 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 5)")]
    public static int DIMOFS_BUTTON5 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 5);

    [NativeTypeName("#define DIMOFS_BUTTON6 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 6)")]
    public static int DIMOFS_BUTTON6 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 6);

    [NativeTypeName("#define DIMOFS_BUTTON7 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 7)")]
    public static int DIMOFS_BUTTON7 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 7);
}

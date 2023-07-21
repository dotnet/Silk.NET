// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SKF
{
    [NativeTypeName("#define SKF_STICKYKEYSON 0x00000001")]
    public const int SKF_STICKYKEYSON = 0x00000001;

    [NativeTypeName("#define SKF_AVAILABLE 0x00000002")]
    public const int SKF_AVAILABLE = 0x00000002;

    [NativeTypeName("#define SKF_HOTKEYACTIVE 0x00000004")]
    public const int SKF_HOTKEYACTIVE = 0x00000004;

    [NativeTypeName("#define SKF_CONFIRMHOTKEY 0x00000008")]
    public const int SKF_CONFIRMHOTKEY = 0x00000008;

    [NativeTypeName("#define SKF_HOTKEYSOUND 0x00000010")]
    public const int SKF_HOTKEYSOUND = 0x00000010;

    [NativeTypeName("#define SKF_INDICATOR 0x00000020")]
    public const int SKF_INDICATOR = 0x00000020;

    [NativeTypeName("#define SKF_AUDIBLEFEEDBACK 0x00000040")]
    public const int SKF_AUDIBLEFEEDBACK = 0x00000040;

    [NativeTypeName("#define SKF_TRISTATE 0x00000080")]
    public const int SKF_TRISTATE = 0x00000080;

    [NativeTypeName("#define SKF_TWOKEYSOFF 0x00000100")]
    public const int SKF_TWOKEYSOFF = 0x00000100;

    [NativeTypeName("#define SKF_LALTLATCHED 0x10000000")]
    public const int SKF_LALTLATCHED = 0x10000000;

    [NativeTypeName("#define SKF_LCTLLATCHED 0x04000000")]
    public const int SKF_LCTLLATCHED = 0x04000000;

    [NativeTypeName("#define SKF_LSHIFTLATCHED 0x01000000")]
    public const int SKF_LSHIFTLATCHED = 0x01000000;

    [NativeTypeName("#define SKF_RALTLATCHED 0x20000000")]
    public const int SKF_RALTLATCHED = 0x20000000;

    [NativeTypeName("#define SKF_RCTLLATCHED 0x08000000")]
    public const int SKF_RCTLLATCHED = 0x08000000;

    [NativeTypeName("#define SKF_RSHIFTLATCHED 0x02000000")]
    public const int SKF_RSHIFTLATCHED = 0x02000000;

    [NativeTypeName("#define SKF_LWINLATCHED 0x40000000")]
    public const int SKF_LWINLATCHED = 0x40000000;

    [NativeTypeName("#define SKF_RWINLATCHED 0x80000000")]
    public const uint SKF_RWINLATCHED = 0x80000000;

    [NativeTypeName("#define SKF_LALTLOCKED 0x00100000")]
    public const int SKF_LALTLOCKED = 0x00100000;

    [NativeTypeName("#define SKF_LCTLLOCKED 0x00040000")]
    public const int SKF_LCTLLOCKED = 0x00040000;

    [NativeTypeName("#define SKF_LSHIFTLOCKED 0x00010000")]
    public const int SKF_LSHIFTLOCKED = 0x00010000;

    [NativeTypeName("#define SKF_RALTLOCKED 0x00200000")]
    public const int SKF_RALTLOCKED = 0x00200000;

    [NativeTypeName("#define SKF_RCTLLOCKED 0x00080000")]
    public const int SKF_RCTLLOCKED = 0x00080000;

    [NativeTypeName("#define SKF_RSHIFTLOCKED 0x00020000")]
    public const int SKF_RSHIFTLOCKED = 0x00020000;

    [NativeTypeName("#define SKF_LWINLOCKED 0x00400000")]
    public const int SKF_LWINLOCKED = 0x00400000;

    [NativeTypeName("#define SKF_RWINLOCKED 0x00800000")]
    public const int SKF_RWINLOCKED = 0x00800000;
}

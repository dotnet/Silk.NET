// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class CCM
{
    [NativeTypeName("#define CCM_FIRST 0x2000")]
    public const int CCM_FIRST = 0x2000;

    [NativeTypeName("#define CCM_LAST (CCM_FIRST + 0x200)")]
    public const int CCM_LAST = (0x2000 + 0x200);

    [NativeTypeName("#define CCM_SETBKCOLOR (CCM_FIRST + 1)")]
    public const int CCM_SETBKCOLOR = (0x2000 + 1);

    [NativeTypeName("#define CCM_SETCOLORSCHEME (CCM_FIRST + 2)")]
    public const int CCM_SETCOLORSCHEME = (0x2000 + 2);

    [NativeTypeName("#define CCM_GETCOLORSCHEME (CCM_FIRST + 3)")]
    public const int CCM_GETCOLORSCHEME = (0x2000 + 3);

    [NativeTypeName("#define CCM_GETDROPTARGET (CCM_FIRST + 4)")]
    public const int CCM_GETDROPTARGET = (0x2000 + 4);

    [NativeTypeName("#define CCM_SETUNICODEFORMAT (CCM_FIRST + 5)")]
    public const int CCM_SETUNICODEFORMAT = (0x2000 + 5);

    [NativeTypeName("#define CCM_GETUNICODEFORMAT (CCM_FIRST + 6)")]
    public const int CCM_GETUNICODEFORMAT = (0x2000 + 6);

    [NativeTypeName("#define CCM_SETVERSION (CCM_FIRST + 0x7)")]
    public const int CCM_SETVERSION = (0x2000 + 0x7);

    [NativeTypeName("#define CCM_GETVERSION (CCM_FIRST + 0x8)")]
    public const int CCM_GETVERSION = (0x2000 + 0x8);

    [NativeTypeName("#define CCM_SETNOTIFYWINDOW (CCM_FIRST + 0x9)")]
    public const int CCM_SETNOTIFYWINDOW = (0x2000 + 0x9);

    [NativeTypeName("#define CCM_SETWINDOWTHEME (CCM_FIRST + 0xb)")]
    public const int CCM_SETWINDOWTHEME = (0x2000 + 0xb);

    [NativeTypeName("#define CCM_DPISCALE (CCM_FIRST + 0xc)")]
    public const int CCM_DPISCALE = (0x2000 + 0xc);
}

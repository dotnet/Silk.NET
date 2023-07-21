// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SB
{
    [NativeTypeName("#define SB_HORZ 0")]
    public const int SB_HORZ = 0;

    [NativeTypeName("#define SB_VERT 1")]
    public const int SB_VERT = 1;

    [NativeTypeName("#define SB_CTL 2")]
    public const int SB_CTL = 2;

    [NativeTypeName("#define SB_BOTH 3")]
    public const int SB_BOTH = 3;

    [NativeTypeName("#define SB_LINEUP 0")]
    public const int SB_LINEUP = 0;

    [NativeTypeName("#define SB_LINELEFT 0")]
    public const int SB_LINELEFT = 0;

    [NativeTypeName("#define SB_LINEDOWN 1")]
    public const int SB_LINEDOWN = 1;

    [NativeTypeName("#define SB_LINERIGHT 1")]
    public const int SB_LINERIGHT = 1;

    [NativeTypeName("#define SB_PAGEUP 2")]
    public const int SB_PAGEUP = 2;

    [NativeTypeName("#define SB_PAGELEFT 2")]
    public const int SB_PAGELEFT = 2;

    [NativeTypeName("#define SB_PAGEDOWN 3")]
    public const int SB_PAGEDOWN = 3;

    [NativeTypeName("#define SB_PAGERIGHT 3")]
    public const int SB_PAGERIGHT = 3;

    [NativeTypeName("#define SB_THUMBPOSITION 4")]
    public const int SB_THUMBPOSITION = 4;

    [NativeTypeName("#define SB_THUMBTRACK 5")]
    public const int SB_THUMBTRACK = 5;

    [NativeTypeName("#define SB_TOP 6")]
    public const int SB_TOP = 6;

    [NativeTypeName("#define SB_LEFT 6")]
    public const int SB_LEFT = 6;

    [NativeTypeName("#define SB_BOTTOM 7")]
    public const int SB_BOTTOM = 7;

    [NativeTypeName("#define SB_RIGHT 7")]
    public const int SB_RIGHT = 7;

    [NativeTypeName("#define SB_ENDSCROLL 8")]
    public const int SB_ENDSCROLL = 8;
}

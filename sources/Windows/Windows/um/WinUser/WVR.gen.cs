// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WVR
{
    [NativeTypeName("#define WVR_ALIGNTOP 0x0010")]
    public const int WVR_ALIGNTOP = 0x0010;

    [NativeTypeName("#define WVR_ALIGNLEFT 0x0020")]
    public const int WVR_ALIGNLEFT = 0x0020;

    [NativeTypeName("#define WVR_ALIGNBOTTOM 0x0040")]
    public const int WVR_ALIGNBOTTOM = 0x0040;

    [NativeTypeName("#define WVR_ALIGNRIGHT 0x0080")]
    public const int WVR_ALIGNRIGHT = 0x0080;

    [NativeTypeName("#define WVR_HREDRAW 0x0100")]
    public const int WVR_HREDRAW = 0x0100;

    [NativeTypeName("#define WVR_VREDRAW 0x0200")]
    public const int WVR_VREDRAW = 0x0200;

    [NativeTypeName("#define WVR_REDRAW (WVR_HREDRAW | \\\r\n                            WVR_VREDRAW)")]
    public const int WVR_REDRAW = (0x0100 | 0x0200);

    [NativeTypeName("#define WVR_VALIDRECTS 0x0400")]
    public const int WVR_VALIDRECTS = 0x0400;
}

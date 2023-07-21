// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class HTTB
{
    [NativeTypeName("#define HTTB_BACKGROUNDSEG 0x00000000")]
    public const int HTTB_BACKGROUNDSEG = 0x00000000;

    [NativeTypeName("#define HTTB_FIXEDBORDER 0x00000002")]
    public const int HTTB_FIXEDBORDER = 0x00000002;

    [NativeTypeName("#define HTTB_CAPTION 0x00000004")]
    public const int HTTB_CAPTION = 0x00000004;

    [NativeTypeName("#define HTTB_RESIZINGBORDER_LEFT 0x00000010")]
    public const int HTTB_RESIZINGBORDER_LEFT = 0x00000010;

    [NativeTypeName("#define HTTB_RESIZINGBORDER_TOP 0x00000020")]
    public const int HTTB_RESIZINGBORDER_TOP = 0x00000020;

    [NativeTypeName("#define HTTB_RESIZINGBORDER_RIGHT 0x00000040")]
    public const int HTTB_RESIZINGBORDER_RIGHT = 0x00000040;

    [NativeTypeName("#define HTTB_RESIZINGBORDER_BOTTOM 0x00000080")]
    public const int HTTB_RESIZINGBORDER_BOTTOM = 0x00000080;

    [NativeTypeName("#define HTTB_RESIZINGBORDER (HTTB_RESIZINGBORDER_LEFT | \\\r\n                                     HTTB_RESIZINGBORDER_TOP | \\\r\n                                     HTTB_RESIZINGBORDER_RIGHT | \\\r\n                                     HTTB_RESIZINGBORDER_BOTTOM)")]
    public const int HTTB_RESIZINGBORDER = (0x00000010 | 0x00000020 | 0x00000040 | 0x00000080);

    [NativeTypeName("#define HTTB_SIZINGTEMPLATE 0x00000100")]
    public const int HTTB_SIZINGTEMPLATE = 0x00000100;

    [NativeTypeName("#define HTTB_SYSTEMSIZINGMARGINS 0x00000200")]
    public const int HTTB_SYSTEMSIZINGMARGINS = 0x00000200;
}

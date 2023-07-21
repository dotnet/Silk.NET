// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class HDI
{
    [NativeTypeName("#define HDI_WIDTH 0x0001")]
    public const int HDI_WIDTH = 0x0001;

    [NativeTypeName("#define HDI_HEIGHT HDI_WIDTH")]
    public const int HDI_HEIGHT = 0x0001;

    [NativeTypeName("#define HDI_TEXT 0x0002")]
    public const int HDI_TEXT = 0x0002;

    [NativeTypeName("#define HDI_FORMAT 0x0004")]
    public const int HDI_FORMAT = 0x0004;

    [NativeTypeName("#define HDI_LPARAM 0x0008")]
    public const int HDI_LPARAM = 0x0008;

    [NativeTypeName("#define HDI_BITMAP 0x0010")]
    public const int HDI_BITMAP = 0x0010;

    [NativeTypeName("#define HDI_IMAGE 0x0020")]
    public const int HDI_IMAGE = 0x0020;

    [NativeTypeName("#define HDI_DI_SETITEM 0x0040")]
    public const int HDI_DI_SETITEM = 0x0040;

    [NativeTypeName("#define HDI_ORDER 0x0080")]
    public const int HDI_ORDER = 0x0080;

    [NativeTypeName("#define HDI_FILTER 0x0100")]
    public const int HDI_FILTER = 0x0100;

    [NativeTypeName("#define HDI_STATE 0x0200")]
    public const int HDI_STATE = 0x0200;
}

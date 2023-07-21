// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class HDF
{
    [NativeTypeName("#define HDF_LEFT 0x0000")]
    public const int HDF_LEFT = 0x0000;

    [NativeTypeName("#define HDF_RIGHT 0x0001")]
    public const int HDF_RIGHT = 0x0001;

    [NativeTypeName("#define HDF_CENTER 0x0002")]
    public const int HDF_CENTER = 0x0002;

    [NativeTypeName("#define HDF_JUSTIFYMASK 0x0003")]
    public const int HDF_JUSTIFYMASK = 0x0003;

    [NativeTypeName("#define HDF_RTLREADING 0x0004")]
    public const int HDF_RTLREADING = 0x0004;

    [NativeTypeName("#define HDF_BITMAP 0x2000")]
    public const int HDF_BITMAP = 0x2000;

    [NativeTypeName("#define HDF_STRING 0x4000")]
    public const int HDF_STRING = 0x4000;

    [NativeTypeName("#define HDF_OWNERDRAW 0x8000")]
    public const int HDF_OWNERDRAW = 0x8000;

    [NativeTypeName("#define HDF_IMAGE 0x0800")]
    public const int HDF_IMAGE = 0x0800;

    [NativeTypeName("#define HDF_BITMAP_ON_RIGHT 0x1000")]
    public const int HDF_BITMAP_ON_RIGHT = 0x1000;

    [NativeTypeName("#define HDF_SORTUP 0x0400")]
    public const int HDF_SORTUP = 0x0400;

    [NativeTypeName("#define HDF_SORTDOWN 0x0200")]
    public const int HDF_SORTDOWN = 0x0200;

    [NativeTypeName("#define HDF_CHECKBOX 0x0040")]
    public const int HDF_CHECKBOX = 0x0040;

    [NativeTypeName("#define HDF_CHECKED 0x0080")]
    public const int HDF_CHECKED = 0x0080;

    [NativeTypeName("#define HDF_FIXEDWIDTH 0x0100")]
    public const int HDF_FIXEDWIDTH = 0x0100;

    [NativeTypeName("#define HDF_SPLITBUTTON 0x1000000")]
    public const int HDF_SPLITBUTTON = 0x1000000;
}

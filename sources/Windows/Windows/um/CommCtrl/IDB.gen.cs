// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class IDB
{
    [NativeTypeName("#define IDB_STD_SMALL_COLOR 0")]
    public const int IDB_STD_SMALL_COLOR = 0;
    [NativeTypeName("#define IDB_STD_LARGE_COLOR 1")]
    public const int IDB_STD_LARGE_COLOR = 1;
    [NativeTypeName("#define IDB_VIEW_SMALL_COLOR 4")]
    public const int IDB_VIEW_SMALL_COLOR = 4;
    [NativeTypeName("#define IDB_VIEW_LARGE_COLOR 5")]
    public const int IDB_VIEW_LARGE_COLOR = 5;
    [NativeTypeName("#define IDB_HIST_SMALL_COLOR 8")]
    public const int IDB_HIST_SMALL_COLOR = 8;
    [NativeTypeName("#define IDB_HIST_LARGE_COLOR 9")]
    public const int IDB_HIST_LARGE_COLOR = 9;
    [NativeTypeName("#define IDB_HIST_NORMAL 12")]
    public const int IDB_HIST_NORMAL = 12;
    [NativeTypeName("#define IDB_HIST_HOT 13")]
    public const int IDB_HIST_HOT = 13;
    [NativeTypeName("#define IDB_HIST_DISABLED 14")]
    public const int IDB_HIST_DISABLED = 14;
    [NativeTypeName("#define IDB_HIST_PRESSED 15")]
    public const int IDB_HIST_PRESSED = 15;
}
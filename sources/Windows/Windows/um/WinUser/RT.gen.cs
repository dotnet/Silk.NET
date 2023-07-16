// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static unsafe partial class RT
{
    [NativeTypeName("#define RT_CURSOR MAKEINTRESOURCE(1)")]
    public static ushort* RT_CURSOR => ((ushort*)((nuint)((ushort)(1))));

    [NativeTypeName("#define RT_BITMAP MAKEINTRESOURCE(2)")]
    public static ushort* RT_BITMAP => ((ushort*)((nuint)((ushort)(2))));

    [NativeTypeName("#define RT_ICON MAKEINTRESOURCE(3)")]
    public static ushort* RT_ICON => ((ushort*)((nuint)((ushort)(3))));

    [NativeTypeName("#define RT_MENU MAKEINTRESOURCE(4)")]
    public static ushort* RT_MENU => ((ushort*)((nuint)((ushort)(4))));

    [NativeTypeName("#define RT_DIALOG MAKEINTRESOURCE(5)")]
    public static ushort* RT_DIALOG => ((ushort*)((nuint)((ushort)(5))));

    [NativeTypeName("#define RT_STRING MAKEINTRESOURCE(6)")]
    public static ushort* RT_STRING => ((ushort*)((nuint)((ushort)(6))));

    [NativeTypeName("#define RT_FONTDIR MAKEINTRESOURCE(7)")]
    public static ushort* RT_FONTDIR => ((ushort*)((nuint)((ushort)(7))));

    [NativeTypeName("#define RT_FONT MAKEINTRESOURCE(8)")]
    public static ushort* RT_FONT => ((ushort*)((nuint)((ushort)(8))));

    [NativeTypeName("#define RT_ACCELERATOR MAKEINTRESOURCE(9)")]
    public static ushort* RT_ACCELERATOR => ((ushort*)((nuint)((ushort)(9))));

    [NativeTypeName("#define RT_RCDATA MAKEINTRESOURCE(10)")]
    public static ushort* RT_RCDATA => ((ushort*)((nuint)((ushort)(10))));

    [NativeTypeName("#define RT_MESSAGETABLE MAKEINTRESOURCE(11)")]
    public static ushort* RT_MESSAGETABLE => ((ushort*)((nuint)((ushort)(11))));

    [NativeTypeName("#define RT_GROUP_CURSOR MAKEINTRESOURCE((ULONG_PTR)(RT_CURSOR) + DIFFERENCE)")]
    public static ushort* RT_GROUP_CURSOR => ((ushort*)((nuint)((ushort)((nuint)(((ushort*)((nuint)((ushort)(1))))) + 11))));

    [NativeTypeName("#define RT_GROUP_ICON MAKEINTRESOURCE((ULONG_PTR)(RT_ICON) + DIFFERENCE)")]
    public static ushort* RT_GROUP_ICON => ((ushort*)((nuint)((ushort)((nuint)(((ushort*)((nuint)((ushort)(3))))) + 11))));

    [NativeTypeName("#define RT_VERSION MAKEINTRESOURCE(16)")]
    public static ushort* RT_VERSION => ((ushort*)((nuint)((ushort)(16))));

    [NativeTypeName("#define RT_DLGINCLUDE MAKEINTRESOURCE(17)")]
    public static ushort* RT_DLGINCLUDE => ((ushort*)((nuint)((ushort)(17))));

    [NativeTypeName("#define RT_PLUGPLAY MAKEINTRESOURCE(19)")]
    public static ushort* RT_PLUGPLAY => ((ushort*)((nuint)((ushort)(19))));

    [NativeTypeName("#define RT_VXD MAKEINTRESOURCE(20)")]
    public static ushort* RT_VXD => ((ushort*)((nuint)((ushort)(20))));

    [NativeTypeName("#define RT_ANICURSOR MAKEINTRESOURCE(21)")]
    public static ushort* RT_ANICURSOR => ((ushort*)((nuint)((ushort)(21))));

    [NativeTypeName("#define RT_ANIICON MAKEINTRESOURCE(22)")]
    public static ushort* RT_ANIICON => ((ushort*)((nuint)((ushort)(22))));

    [NativeTypeName("#define RT_HTML MAKEINTRESOURCE(23)")]
    public static ushort* RT_HTML => ((ushort*)((nuint)((ushort)(23))));

    [NativeTypeName("#define RT_MANIFEST MAKEINTRESOURCE(24)")]
    public static ushort* RT_MANIFEST => ((ushort*)((nuint)((ushort)(24))));
}
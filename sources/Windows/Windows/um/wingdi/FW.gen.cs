// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class FW
{
    [NativeTypeName("#define FW_DONTCARE 0")]
    public const int FW_DONTCARE = 0;
    [NativeTypeName("#define FW_THIN 100")]
    public const int FW_THIN = 100;
    [NativeTypeName("#define FW_EXTRALIGHT 200")]
    public const int FW_EXTRALIGHT = 200;
    [NativeTypeName("#define FW_LIGHT 300")]
    public const int FW_LIGHT = 300;
    [NativeTypeName("#define FW_NORMAL 400")]
    public const int FW_NORMAL = 400;
    [NativeTypeName("#define FW_MEDIUM 500")]
    public const int FW_MEDIUM = 500;
    [NativeTypeName("#define FW_SEMIBOLD 600")]
    public const int FW_SEMIBOLD = 600;
    [NativeTypeName("#define FW_BOLD 700")]
    public const int FW_BOLD = 700;
    [NativeTypeName("#define FW_EXTRABOLD 800")]
    public const int FW_EXTRABOLD = 800;
    [NativeTypeName("#define FW_HEAVY 900")]
    public const int FW_HEAVY = 900;
    [NativeTypeName("#define FW_ULTRALIGHT FW_EXTRALIGHT")]
    public const int FW_ULTRALIGHT = 200;
    [NativeTypeName("#define FW_REGULAR FW_NORMAL")]
    public const int FW_REGULAR = 400;
    [NativeTypeName("#define FW_DEMIBOLD FW_SEMIBOLD")]
    public const int FW_DEMIBOLD = 600;
    [NativeTypeName("#define FW_ULTRABOLD FW_EXTRABOLD")]
    public const int FW_ULTRABOLD = 800;
    [NativeTypeName("#define FW_BLACK FW_HEAVY")]
    public const int FW_BLACK = 900;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PDC
{
    [NativeTypeName("#define PDC_ARRIVAL 0x001")]
    public const int PDC_ARRIVAL = 0x001;

    [NativeTypeName("#define PDC_REMOVAL 0x002")]
    public const int PDC_REMOVAL = 0x002;

    [NativeTypeName("#define PDC_ORIENTATION_0 0x004")]
    public const int PDC_ORIENTATION_0 = 0x004;

    [NativeTypeName("#define PDC_ORIENTATION_90 0x008")]
    public const int PDC_ORIENTATION_90 = 0x008;

    [NativeTypeName("#define PDC_ORIENTATION_180 0x010")]
    public const int PDC_ORIENTATION_180 = 0x010;

    [NativeTypeName("#define PDC_ORIENTATION_270 0x020")]
    public const int PDC_ORIENTATION_270 = 0x020;

    [NativeTypeName("#define PDC_MODE_DEFAULT 0x040")]
    public const int PDC_MODE_DEFAULT = 0x040;

    [NativeTypeName("#define PDC_MODE_CENTERED 0x080")]
    public const int PDC_MODE_CENTERED = 0x080;

    [NativeTypeName("#define PDC_MAPPING_CHANGE 0x100")]
    public const int PDC_MAPPING_CHANGE = 0x100;

    [NativeTypeName("#define PDC_RESOLUTION 0x200")]
    public const int PDC_RESOLUTION = 0x200;

    [NativeTypeName("#define PDC_ORIGIN 0x400")]
    public const int PDC_ORIGIN = 0x400;

    [NativeTypeName("#define PDC_MODE_ASPECTRATIOPRESERVED 0x800")]
    public const int PDC_MODE_ASPECTRATIOPRESERVED = 0x800;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PC
{
    [NativeTypeName("#define PC_RESERVED 0x01")]
    public const int PC_RESERVED = 0x01;

    [NativeTypeName("#define PC_EXPLICIT 0x02")]
    public const int PC_EXPLICIT = 0x02;

    [NativeTypeName("#define PC_NOCOLLAPSE 0x04")]
    public const int PC_NOCOLLAPSE = 0x04;

    [NativeTypeName("#define PC_NONE 0")]
    public const int PC_NONE = 0;

    [NativeTypeName("#define PC_POLYGON 1")]
    public const int PC_POLYGON = 1;

    [NativeTypeName("#define PC_RECTANGLE 2")]
    public const int PC_RECTANGLE = 2;

    [NativeTypeName("#define PC_WINDPOLYGON 4")]
    public const int PC_WINDPOLYGON = 4;

    [NativeTypeName("#define PC_TRAPEZOID 4")]
    public const int PC_TRAPEZOID = 4;

    [NativeTypeName("#define PC_SCANLINE 8")]
    public const int PC_SCANLINE = 8;

    [NativeTypeName("#define PC_WIDE 16")]
    public const int PC_WIDE = 16;

    [NativeTypeName("#define PC_STYLED 32")]
    public const int PC_STYLED = 32;

    [NativeTypeName("#define PC_WIDESTYLED 64")]
    public const int PC_WIDESTYLED = 64;

    [NativeTypeName("#define PC_INTERIORS 128")]
    public const int PC_INTERIORS = 128;

    [NativeTypeName("#define PC_POLYPOLYGON 256")]
    public const int PC_POLYPOLYGON = 256;

    [NativeTypeName("#define PC_PATHS 512")]
    public const int PC_PATHS = 512;
}

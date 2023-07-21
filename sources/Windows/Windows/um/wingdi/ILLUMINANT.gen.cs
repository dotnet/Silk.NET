// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ILLUMINANT
{
    [NativeTypeName("#define ILLUMINANT_DEVICE_DEFAULT 0")]
    public const int ILLUMINANT_DEVICE_DEFAULT = 0;

    [NativeTypeName("#define ILLUMINANT_A 1")]
    public const int ILLUMINANT_A = 1;

    [NativeTypeName("#define ILLUMINANT_B 2")]
    public const int ILLUMINANT_B = 2;

    [NativeTypeName("#define ILLUMINANT_C 3")]
    public const int ILLUMINANT_C = 3;

    [NativeTypeName("#define ILLUMINANT_D50 4")]
    public const int ILLUMINANT_D50 = 4;

    [NativeTypeName("#define ILLUMINANT_D55 5")]
    public const int ILLUMINANT_D55 = 5;

    [NativeTypeName("#define ILLUMINANT_D65 6")]
    public const int ILLUMINANT_D65 = 6;

    [NativeTypeName("#define ILLUMINANT_D75 7")]
    public const int ILLUMINANT_D75 = 7;

    [NativeTypeName("#define ILLUMINANT_F2 8")]
    public const int ILLUMINANT_F2 = 8;

    [NativeTypeName("#define ILLUMINANT_MAX_INDEX ILLUMINANT_F2")]
    public const int ILLUMINANT_MAX_INDEX = 8;

    [NativeTypeName("#define ILLUMINANT_TUNGSTEN ILLUMINANT_A")]
    public const int ILLUMINANT_TUNGSTEN = 1;

    [NativeTypeName("#define ILLUMINANT_DAYLIGHT ILLUMINANT_C")]
    public const int ILLUMINANT_DAYLIGHT = 3;

    [NativeTypeName("#define ILLUMINANT_FLUORESCENT ILLUMINANT_F2")]
    public const int ILLUMINANT_FLUORESCENT = 8;

    [NativeTypeName("#define ILLUMINANT_NTSC ILLUMINANT_C")]
    public const int ILLUMINANT_NTSC = 3;
}

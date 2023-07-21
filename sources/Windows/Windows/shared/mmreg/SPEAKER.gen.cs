// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SPEAKER
{
    [NativeTypeName("#define SPEAKER_FRONT_LEFT 0x1")]
    public const int SPEAKER_FRONT_LEFT = 0x1;

    [NativeTypeName("#define SPEAKER_FRONT_RIGHT 0x2")]
    public const int SPEAKER_FRONT_RIGHT = 0x2;

    [NativeTypeName("#define SPEAKER_FRONT_CENTER 0x4")]
    public const int SPEAKER_FRONT_CENTER = 0x4;

    [NativeTypeName("#define SPEAKER_LOW_FREQUENCY 0x8")]
    public const int SPEAKER_LOW_FREQUENCY = 0x8;

    [NativeTypeName("#define SPEAKER_BACK_LEFT 0x10")]
    public const int SPEAKER_BACK_LEFT = 0x10;

    [NativeTypeName("#define SPEAKER_BACK_RIGHT 0x20")]
    public const int SPEAKER_BACK_RIGHT = 0x20;

    [NativeTypeName("#define SPEAKER_FRONT_LEFT_OF_CENTER 0x40")]
    public const int SPEAKER_FRONT_LEFT_OF_CENTER = 0x40;

    [NativeTypeName("#define SPEAKER_FRONT_RIGHT_OF_CENTER 0x80")]
    public const int SPEAKER_FRONT_RIGHT_OF_CENTER = 0x80;

    [NativeTypeName("#define SPEAKER_BACK_CENTER 0x100")]
    public const int SPEAKER_BACK_CENTER = 0x100;

    [NativeTypeName("#define SPEAKER_SIDE_LEFT 0x200")]
    public const int SPEAKER_SIDE_LEFT = 0x200;

    [NativeTypeName("#define SPEAKER_SIDE_RIGHT 0x400")]
    public const int SPEAKER_SIDE_RIGHT = 0x400;

    [NativeTypeName("#define SPEAKER_TOP_CENTER 0x800")]
    public const int SPEAKER_TOP_CENTER = 0x800;

    [NativeTypeName("#define SPEAKER_TOP_FRONT_LEFT 0x1000")]
    public const int SPEAKER_TOP_FRONT_LEFT = 0x1000;

    [NativeTypeName("#define SPEAKER_TOP_FRONT_CENTER 0x2000")]
    public const int SPEAKER_TOP_FRONT_CENTER = 0x2000;

    [NativeTypeName("#define SPEAKER_TOP_FRONT_RIGHT 0x4000")]
    public const int SPEAKER_TOP_FRONT_RIGHT = 0x4000;

    [NativeTypeName("#define SPEAKER_TOP_BACK_LEFT 0x8000")]
    public const int SPEAKER_TOP_BACK_LEFT = 0x8000;

    [NativeTypeName("#define SPEAKER_TOP_BACK_CENTER 0x10000")]
    public const int SPEAKER_TOP_BACK_CENTER = 0x10000;

    [NativeTypeName("#define SPEAKER_TOP_BACK_RIGHT 0x20000")]
    public const int SPEAKER_TOP_BACK_RIGHT = 0x20000;

    [NativeTypeName("#define SPEAKER_RESERVED 0x7FFC0000")]
    public const int SPEAKER_RESERVED = 0x7FFC0000;

    [NativeTypeName("#define SPEAKER_ALL 0x80000000")]
    public const uint SPEAKER_ALL = 0x80000000;
}

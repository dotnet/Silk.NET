// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class BATTERY
{
    [NativeTypeName("#define BATTERY_FLAG_HIGH 0x01")]
    public const int BATTERY_FLAG_HIGH = 0x01;

    [NativeTypeName("#define BATTERY_FLAG_LOW 0x02")]
    public const int BATTERY_FLAG_LOW = 0x02;

    [NativeTypeName("#define BATTERY_FLAG_CRITICAL 0x04")]
    public const int BATTERY_FLAG_CRITICAL = 0x04;

    [NativeTypeName("#define BATTERY_FLAG_CHARGING 0x08")]
    public const int BATTERY_FLAG_CHARGING = 0x08;

    [NativeTypeName("#define BATTERY_FLAG_NO_BATTERY 0x80")]
    public const int BATTERY_FLAG_NO_BATTERY = 0x80;

    [NativeTypeName("#define BATTERY_FLAG_UNKNOWN 0xFF")]
    public const int BATTERY_FLAG_UNKNOWN = 0xFF;

    [NativeTypeName("#define BATTERY_PERCENTAGE_UNKNOWN 0xFF")]
    public const int BATTERY_PERCENTAGE_UNKNOWN = 0xFF;

    [NativeTypeName("#define BATTERY_LIFE_UNKNOWN 0xFFFFFFFF")]
    public const uint BATTERY_LIFE_UNKNOWN = 0xFFFFFFFF;
}

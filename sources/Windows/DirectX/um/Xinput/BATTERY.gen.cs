// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;
public static partial class BATTERY
{
    [NativeTypeName("#define BATTERY_DEVTYPE_GAMEPAD 0x00")]
    public const int BATTERY_DEVTYPE_GAMEPAD = 0x00;
    [NativeTypeName("#define BATTERY_DEVTYPE_HEADSET 0x01")]
    public const int BATTERY_DEVTYPE_HEADSET = 0x01;
    [NativeTypeName("#define BATTERY_TYPE_DISCONNECTED 0x00")]
    public const int BATTERY_TYPE_DISCONNECTED = 0x00;
    [NativeTypeName("#define BATTERY_TYPE_WIRED 0x01")]
    public const int BATTERY_TYPE_WIRED = 0x01;
    [NativeTypeName("#define BATTERY_TYPE_ALKALINE 0x02")]
    public const int BATTERY_TYPE_ALKALINE = 0x02;
    [NativeTypeName("#define BATTERY_TYPE_NIMH 0x03")]
    public const int BATTERY_TYPE_NIMH = 0x03;
    [NativeTypeName("#define BATTERY_TYPE_UNKNOWN 0xFF")]
    public const int BATTERY_TYPE_UNKNOWN = 0xFF;
    [NativeTypeName("#define BATTERY_LEVEL_EMPTY 0x00")]
    public const int BATTERY_LEVEL_EMPTY = 0x00;
    [NativeTypeName("#define BATTERY_LEVEL_LOW 0x01")]
    public const int BATTERY_LEVEL_LOW = 0x01;
    [NativeTypeName("#define BATTERY_LEVEL_MEDIUM 0x02")]
    public const int BATTERY_LEVEL_MEDIUM = 0x02;
    [NativeTypeName("#define BATTERY_LEVEL_FULL 0x03")]
    public const int BATTERY_LEVEL_FULL = 0x03;
}
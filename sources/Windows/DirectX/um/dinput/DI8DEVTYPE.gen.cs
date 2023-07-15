// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DI8DEVTYPE
{
    [NativeTypeName("#define DI8DEVTYPE_DEVICE 0x11")]
    public const int DI8DEVTYPE_DEVICE = 0x11;
    [NativeTypeName("#define DI8DEVTYPE_MOUSE 0x12")]
    public const int DI8DEVTYPE_MOUSE = 0x12;
    [NativeTypeName("#define DI8DEVTYPE_KEYBOARD 0x13")]
    public const int DI8DEVTYPE_KEYBOARD = 0x13;
    [NativeTypeName("#define DI8DEVTYPE_JOYSTICK 0x14")]
    public const int DI8DEVTYPE_JOYSTICK = 0x14;
    [NativeTypeName("#define DI8DEVTYPE_GAMEPAD 0x15")]
    public const int DI8DEVTYPE_GAMEPAD = 0x15;
    [NativeTypeName("#define DI8DEVTYPE_DRIVING 0x16")]
    public const int DI8DEVTYPE_DRIVING = 0x16;
    [NativeTypeName("#define DI8DEVTYPE_FLIGHT 0x17")]
    public const int DI8DEVTYPE_FLIGHT = 0x17;
    [NativeTypeName("#define DI8DEVTYPE_1STPERSON 0x18")]
    public const int DI8DEVTYPE_1STPERSON = 0x18;
    [NativeTypeName("#define DI8DEVTYPE_DEVICECTRL 0x19")]
    public const int DI8DEVTYPE_DEVICECTRL = 0x19;
    [NativeTypeName("#define DI8DEVTYPE_SCREENPOINTER 0x1A")]
    public const int DI8DEVTYPE_SCREENPOINTER = 0x1A;
    [NativeTypeName("#define DI8DEVTYPE_REMOTE 0x1B")]
    public const int DI8DEVTYPE_REMOTE = 0x1B;
    [NativeTypeName("#define DI8DEVTYPE_SUPPLEMENTAL 0x1C")]
    public const int DI8DEVTYPE_SUPPLEMENTAL = 0x1C;
    [NativeTypeName("#define DI8DEVTYPE_LIMITEDGAMESUBTYPE 1")]
    public const int DI8DEVTYPE_LIMITEDGAMESUBTYPE = 1;
}
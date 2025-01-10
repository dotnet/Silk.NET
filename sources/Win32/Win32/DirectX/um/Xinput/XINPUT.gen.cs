// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class XINPUT
{
    [NativeTypeName("#define XINPUT_DLL_A \"xinput1_4.dll\"")]
    public static ReadOnlySpan<byte> XINPUT_DLL_A => "xinput1_4.dll"u8;

    [NativeTypeName("#define XINPUT_DLL_W L\"xinput1_4.dll\"")]
    public const string XINPUT_DLL_W = "xinput1_4.dll";

    [NativeTypeName("#define XINPUT_DLL XINPUT_DLL_W")]
    public const string XINPUT_DLL = "xinput1_4.dll";

    [NativeTypeName("#define XINPUT_DEVTYPE_GAMEPAD 0x01")]
    public const int XINPUT_DEVTYPE_GAMEPAD = 0x01;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GAMEPAD 0x01")]
    public const int XINPUT_DEVSUBTYPE_GAMEPAD = 0x01;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_UNKNOWN 0x00")]
    public const int XINPUT_DEVSUBTYPE_UNKNOWN = 0x00;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_WHEEL 0x02")]
    public const int XINPUT_DEVSUBTYPE_WHEEL = 0x02;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_ARCADE_STICK 0x03")]
    public const int XINPUT_DEVSUBTYPE_ARCADE_STICK = 0x03;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_FLIGHT_STICK 0x04")]
    public const int XINPUT_DEVSUBTYPE_FLIGHT_STICK = 0x04;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_DANCE_PAD 0x05")]
    public const int XINPUT_DEVSUBTYPE_DANCE_PAD = 0x05;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR 0x06")]
    public const int XINPUT_DEVSUBTYPE_GUITAR = 0x06;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE 0x07")]
    public const int XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE = 0x07;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_DRUM_KIT 0x08")]
    public const int XINPUT_DEVSUBTYPE_DRUM_KIT = 0x08;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR_BASS 0x0B")]
    public const int XINPUT_DEVSUBTYPE_GUITAR_BASS = 0x0B;

    [NativeTypeName("#define XINPUT_DEVSUBTYPE_ARCADE_PAD 0x13")]
    public const int XINPUT_DEVSUBTYPE_ARCADE_PAD = 0x13;

    [NativeTypeName("#define XINPUT_CAPS_VOICE_SUPPORTED 0x0004")]
    public const int XINPUT_CAPS_VOICE_SUPPORTED = 0x0004;

    [NativeTypeName("#define XINPUT_CAPS_FFB_SUPPORTED 0x0001")]
    public const int XINPUT_CAPS_FFB_SUPPORTED = 0x0001;

    [NativeTypeName("#define XINPUT_CAPS_WIRELESS 0x0002")]
    public const int XINPUT_CAPS_WIRELESS = 0x0002;

    [NativeTypeName("#define XINPUT_CAPS_PMD_SUPPORTED 0x0008")]
    public const int XINPUT_CAPS_PMD_SUPPORTED = 0x0008;

    [NativeTypeName("#define XINPUT_CAPS_NO_NAVIGATION 0x0010")]
    public const int XINPUT_CAPS_NO_NAVIGATION = 0x0010;

    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_UP 0x0001")]
    public const int XINPUT_GAMEPAD_DPAD_UP = 0x0001;

    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_DOWN 0x0002")]
    public const int XINPUT_GAMEPAD_DPAD_DOWN = 0x0002;

    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_LEFT 0x0004")]
    public const int XINPUT_GAMEPAD_DPAD_LEFT = 0x0004;

    [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_RIGHT 0x0008")]
    public const int XINPUT_GAMEPAD_DPAD_RIGHT = 0x0008;

    [NativeTypeName("#define XINPUT_GAMEPAD_START 0x0010")]
    public const int XINPUT_GAMEPAD_START = 0x0010;

    [NativeTypeName("#define XINPUT_GAMEPAD_BACK 0x0020")]
    public const int XINPUT_GAMEPAD_BACK = 0x0020;

    [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_THUMB 0x0040")]
    public const int XINPUT_GAMEPAD_LEFT_THUMB = 0x0040;

    [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_THUMB 0x0080")]
    public const int XINPUT_GAMEPAD_RIGHT_THUMB = 0x0080;

    [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_SHOULDER 0x0100")]
    public const int XINPUT_GAMEPAD_LEFT_SHOULDER = 0x0100;

    [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_SHOULDER 0x0200")]
    public const int XINPUT_GAMEPAD_RIGHT_SHOULDER = 0x0200;

    [NativeTypeName("#define XINPUT_GAMEPAD_A 0x1000")]
    public const int XINPUT_GAMEPAD_A = 0x1000;

    [NativeTypeName("#define XINPUT_GAMEPAD_B 0x2000")]
    public const int XINPUT_GAMEPAD_B = 0x2000;

    [NativeTypeName("#define XINPUT_GAMEPAD_X 0x4000")]
    public const int XINPUT_GAMEPAD_X = 0x4000;

    [NativeTypeName("#define XINPUT_GAMEPAD_Y 0x8000")]
    public const int XINPUT_GAMEPAD_Y = 0x8000;

    [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE 7849")]
    public const int XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE = 7849;

    [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE 8689")]
    public const int XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE = 8689;

    [NativeTypeName("#define XINPUT_GAMEPAD_TRIGGER_THRESHOLD 30")]
    public const int XINPUT_GAMEPAD_TRIGGER_THRESHOLD = 30;

    [NativeTypeName("#define XINPUT_FLAG_GAMEPAD 0x00000001")]
    public const int XINPUT_FLAG_GAMEPAD = 0x00000001;

    [NativeTypeName("#define XINPUT_KEYSTROKE_KEYDOWN 0x0001")]
    public const int XINPUT_KEYSTROKE_KEYDOWN = 0x0001;

    [NativeTypeName("#define XINPUT_KEYSTROKE_KEYUP 0x0002")]
    public const int XINPUT_KEYSTROKE_KEYUP = 0x0002;

    [NativeTypeName("#define XINPUT_KEYSTROKE_REPEAT 0x0004")]
    public const int XINPUT_KEYSTROKE_REPEAT = 0x0004;
}

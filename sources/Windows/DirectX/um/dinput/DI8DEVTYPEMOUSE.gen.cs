// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DI8DEVTYPEMOUSE
{
    [NativeTypeName("#define DI8DEVTYPEMOUSE_UNKNOWN 1")]
    public const int DI8DEVTYPEMOUSE_UNKNOWN = 1;
    [NativeTypeName("#define DI8DEVTYPEMOUSE_TRADITIONAL 2")]
    public const int DI8DEVTYPEMOUSE_TRADITIONAL = 2;
    [NativeTypeName("#define DI8DEVTYPEMOUSE_FINGERSTICK 3")]
    public const int DI8DEVTYPEMOUSE_FINGERSTICK = 3;
    [NativeTypeName("#define DI8DEVTYPEMOUSE_TOUCHPAD 4")]
    public const int DI8DEVTYPEMOUSE_TOUCHPAD = 4;
    [NativeTypeName("#define DI8DEVTYPEMOUSE_TRACKBALL 5")]
    public const int DI8DEVTYPEMOUSE_TRACKBALL = 5;
    [NativeTypeName("#define DI8DEVTYPEMOUSE_ABSOLUTE 6")]
    public const int DI8DEVTYPEMOUSE_ABSOLUTE = 6;
}
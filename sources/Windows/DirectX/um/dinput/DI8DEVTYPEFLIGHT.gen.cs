// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DI8DEVTYPEFLIGHT
{
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEFLIGHT_LIMITED = 1;
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_STICK 2")]
    public const int DI8DEVTYPEFLIGHT_STICK = 2;
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_YOKE 3")]
    public const int DI8DEVTYPEFLIGHT_YOKE = 3;
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_RC 4")]
    public const int DI8DEVTYPEFLIGHT_RC = 4;
}
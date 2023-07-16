// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DI8DEVCLASS
{
    [NativeTypeName("#define DI8DEVCLASS_ALL 0")]
    public const int DI8DEVCLASS_ALL = 0;
    [NativeTypeName("#define DI8DEVCLASS_DEVICE 1")]
    public const int DI8DEVCLASS_DEVICE = 1;
    [NativeTypeName("#define DI8DEVCLASS_POINTER 2")]
    public const int DI8DEVCLASS_POINTER = 2;
    [NativeTypeName("#define DI8DEVCLASS_KEYBOARD 3")]
    public const int DI8DEVCLASS_KEYBOARD = 3;
    [NativeTypeName("#define DI8DEVCLASS_GAMECTRL 4")]
    public const int DI8DEVCLASS_GAMECTRL = 4;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DI8DEVTYPESCREENPTR
{
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_UNKNOWN 2")]
    public const int DI8DEVTYPESCREENPTR_UNKNOWN = 2;
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_LIGHTGUN 3")]
    public const int DI8DEVTYPESCREENPTR_LIGHTGUN = 3;
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_LIGHTPEN 4")]
    public const int DI8DEVTYPESCREENPTR_LIGHTPEN = 4;
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_TOUCH 5")]
    public const int DI8DEVTYPESCREENPTR_TOUCH = 5;
}
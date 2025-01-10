// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DISCL
{
    [NativeTypeName("#define DISCL_EXCLUSIVE 0x00000001")]
    public const int DISCL_EXCLUSIVE = 0x00000001;

    [NativeTypeName("#define DISCL_NONEXCLUSIVE 0x00000002")]
    public const int DISCL_NONEXCLUSIVE = 0x00000002;

    [NativeTypeName("#define DISCL_FOREGROUND 0x00000004")]
    public const int DISCL_FOREGROUND = 0x00000004;

    [NativeTypeName("#define DISCL_BACKGROUND 0x00000008")]
    public const int DISCL_BACKGROUND = 0x00000008;

    [NativeTypeName("#define DISCL_NOWINKEY 0x00000010")]
    public const int DISCL_NOWINKEY = 0x00000010;
}

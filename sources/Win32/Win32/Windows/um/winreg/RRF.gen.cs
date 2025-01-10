// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class RRF
{
    [NativeTypeName("#define RRF_RT_REG_NONE 0x00000001")]
    public const int RRF_RT_REG_NONE = 0x00000001;

    [NativeTypeName("#define RRF_RT_REG_SZ 0x00000002")]
    public const int RRF_RT_REG_SZ = 0x00000002;

    [NativeTypeName("#define RRF_RT_REG_EXPAND_SZ 0x00000004")]
    public const int RRF_RT_REG_EXPAND_SZ = 0x00000004;

    [NativeTypeName("#define RRF_RT_REG_BINARY 0x00000008")]
    public const int RRF_RT_REG_BINARY = 0x00000008;

    [NativeTypeName("#define RRF_RT_REG_DWORD 0x00000010")]
    public const int RRF_RT_REG_DWORD = 0x00000010;

    [NativeTypeName("#define RRF_RT_REG_MULTI_SZ 0x00000020")]
    public const int RRF_RT_REG_MULTI_SZ = 0x00000020;

    [NativeTypeName("#define RRF_RT_REG_QWORD 0x00000040")]
    public const int RRF_RT_REG_QWORD = 0x00000040;

    [NativeTypeName("#define RRF_RT_DWORD (RRF_RT_REG_BINARY | RRF_RT_REG_DWORD)")]
    public const int RRF_RT_DWORD = (0x00000008 | 0x00000010);

    [NativeTypeName("#define RRF_RT_QWORD (RRF_RT_REG_BINARY | RRF_RT_REG_QWORD)")]
    public const int RRF_RT_QWORD = (0x00000008 | 0x00000040);

    [NativeTypeName("#define RRF_RT_ANY 0x0000ffff")]
    public const int RRF_RT_ANY = 0x0000ffff;

    [NativeTypeName("#define RRF_SUBKEY_WOW6464KEY 0x00010000")]
    public const int RRF_SUBKEY_WOW6464KEY = 0x00010000;

    [NativeTypeName("#define RRF_SUBKEY_WOW6432KEY 0x00020000")]
    public const int RRF_SUBKEY_WOW6432KEY = 0x00020000;

    [NativeTypeName("#define RRF_WOW64_MASK 0x00030000")]
    public const int RRF_WOW64_MASK = 0x00030000;

    [NativeTypeName("#define RRF_NOEXPAND 0x10000000")]
    public const int RRF_NOEXPAND = 0x10000000;

    [NativeTypeName("#define RRF_ZEROONFAILURE 0x20000000")]
    public const int RRF_ZEROONFAILURE = 0x20000000;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SRRF
{
    [NativeTypeName("#define SRRF_RT_REG_NONE 0x00000001")]
    public const int SRRF_RT_REG_NONE = 0x00000001;

    [NativeTypeName("#define SRRF_RT_REG_SZ 0x00000002")]
    public const int SRRF_RT_REG_SZ = 0x00000002;

    [NativeTypeName("#define SRRF_RT_REG_EXPAND_SZ 0x00000004")]
    public const int SRRF_RT_REG_EXPAND_SZ = 0x00000004;

    [NativeTypeName("#define SRRF_RT_REG_BINARY 0x00000008")]
    public const int SRRF_RT_REG_BINARY = 0x00000008;

    [NativeTypeName("#define SRRF_RT_REG_DWORD 0x00000010")]
    public const int SRRF_RT_REG_DWORD = 0x00000010;

    [NativeTypeName("#define SRRF_RT_REG_MULTI_SZ 0x00000020")]
    public const int SRRF_RT_REG_MULTI_SZ = 0x00000020;

    [NativeTypeName("#define SRRF_RT_REG_QWORD 0x00000040")]
    public const int SRRF_RT_REG_QWORD = 0x00000040;

    [NativeTypeName("#define SRRF_RT_DWORD (SRRF_RT_REG_BINARY | SRRF_RT_REG_DWORD)")]
    public const int SRRF_RT_DWORD = (0x00000008 | 0x00000010);

    [NativeTypeName("#define SRRF_RT_QWORD (SRRF_RT_REG_BINARY | SRRF_RT_REG_QWORD)")]
    public const int SRRF_RT_QWORD = (0x00000008 | 0x00000040);

    [NativeTypeName("#define SRRF_RT_ANY 0x0000ffff")]
    public const int SRRF_RT_ANY = 0x0000ffff;

    [NativeTypeName("#define SRRF_RM_ANY 0x00000000")]
    public const int SRRF_RM_ANY = 0x00000000;

    [NativeTypeName("#define SRRF_RM_NORMAL 0x00010000")]
    public const int SRRF_RM_NORMAL = 0x00010000;

    [NativeTypeName("#define SRRF_RM_SAFE 0x00020000")]
    public const int SRRF_RM_SAFE = 0x00020000;

    [NativeTypeName("#define SRRF_RM_SAFENETWORK 0x00040000")]
    public const int SRRF_RM_SAFENETWORK = 0x00040000;

    [NativeTypeName("#define SRRF_NOEXPAND 0x10000000")]
    public const int SRRF_NOEXPAND = 0x10000000;

    [NativeTypeName("#define SRRF_ZEROONFAILURE 0x20000000")]
    public const int SRRF_ZEROONFAILURE = 0x20000000;

    [NativeTypeName("#define SRRF_NOVIRT 0x40000000")]
    public const int SRRF_NOVIRT = 0x40000000;
}

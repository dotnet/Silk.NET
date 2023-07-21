// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class CREATE
{
    [NativeTypeName("#define CREATE_SUSPENDED 0x00000004")]
    public const int CREATE_SUSPENDED = 0x00000004;

    [NativeTypeName("#define CREATE_NEW_CONSOLE 0x00000010")]
    public const int CREATE_NEW_CONSOLE = 0x00000010;

    [NativeTypeName("#define CREATE_NEW_PROCESS_GROUP 0x00000200")]
    public const int CREATE_NEW_PROCESS_GROUP = 0x00000200;

    [NativeTypeName("#define CREATE_UNICODE_ENVIRONMENT 0x00000400")]
    public const int CREATE_UNICODE_ENVIRONMENT = 0x00000400;

    [NativeTypeName("#define CREATE_SEPARATE_WOW_VDM 0x00000800")]
    public const int CREATE_SEPARATE_WOW_VDM = 0x00000800;

    [NativeTypeName("#define CREATE_SHARED_WOW_VDM 0x00001000")]
    public const int CREATE_SHARED_WOW_VDM = 0x00001000;

    [NativeTypeName("#define CREATE_FORCEDOS 0x00002000")]
    public const int CREATE_FORCEDOS = 0x00002000;

    [NativeTypeName("#define CREATE_PROTECTED_PROCESS 0x00040000")]
    public const int CREATE_PROTECTED_PROCESS = 0x00040000;

    [NativeTypeName("#define CREATE_SECURE_PROCESS 0x00400000")]
    public const int CREATE_SECURE_PROCESS = 0x00400000;

    [NativeTypeName("#define CREATE_BREAKAWAY_FROM_JOB 0x01000000")]
    public const int CREATE_BREAKAWAY_FROM_JOB = 0x01000000;

    [NativeTypeName("#define CREATE_PRESERVE_CODE_AUTHZ_LEVEL 0x02000000")]
    public const int CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000;

    [NativeTypeName("#define CREATE_DEFAULT_ERROR_MODE 0x04000000")]
    public const int CREATE_DEFAULT_ERROR_MODE = 0x04000000;

    [NativeTypeName("#define CREATE_NO_WINDOW 0x08000000")]
    public const int CREATE_NO_WINDOW = 0x08000000;

    [NativeTypeName("#define CREATE_IGNORE_SYSTEM_DEFAULT 0x80000000")]
    public const uint CREATE_IGNORE_SYSTEM_DEFAULT = 0x80000000;

    [NativeTypeName("#define CREATE_FOR_IMPORT (1)")]
    public const int CREATE_FOR_IMPORT = (1);

    [NativeTypeName("#define CREATE_FOR_DIR (2)")]
    public const int CREATE_FOR_DIR = (2);
}

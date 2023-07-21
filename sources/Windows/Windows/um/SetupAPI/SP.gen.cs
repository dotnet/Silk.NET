// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SP
{
    [NativeTypeName("#define SP_MAX_MACHINENAME_LENGTH (MAX_PATH + 3)")]
    public const int SP_MAX_MACHINENAME_LENGTH = (260 + 3);

    [NativeTypeName("#define SP_ALTPLATFORM_FLAGS_VERSION_RANGE (0x0001)")]
    public const int SP_ALTPLATFORM_FLAGS_VERSION_RANGE = (0x0001);

    [NativeTypeName("#define SP_ALTPLATFORM_FLAGS_SUITE_MASK (0x0002)")]
    public const int SP_ALTPLATFORM_FLAGS_SUITE_MASK = (0x0002);

    [NativeTypeName("#define SP_COPY_DELETESOURCE 0x0000001")]
    public const int SP_COPY_DELETESOURCE = 0x0000001;

    [NativeTypeName("#define SP_COPY_REPLACEONLY 0x0000002")]
    public const int SP_COPY_REPLACEONLY = 0x0000002;

    [NativeTypeName("#define SP_COPY_NEWER 0x0000004")]
    public const int SP_COPY_NEWER = 0x0000004;

    [NativeTypeName("#define SP_COPY_NEWER_OR_SAME SP_COPY_NEWER")]
    public const int SP_COPY_NEWER_OR_SAME = 0x0000004;

    [NativeTypeName("#define SP_COPY_NOOVERWRITE 0x0000008")]
    public const int SP_COPY_NOOVERWRITE = 0x0000008;

    [NativeTypeName("#define SP_COPY_NODECOMP 0x0000010")]
    public const int SP_COPY_NODECOMP = 0x0000010;

    [NativeTypeName("#define SP_COPY_LANGUAGEAWARE 0x0000020")]
    public const int SP_COPY_LANGUAGEAWARE = 0x0000020;

    [NativeTypeName("#define SP_COPY_SOURCE_ABSOLUTE 0x0000040")]
    public const int SP_COPY_SOURCE_ABSOLUTE = 0x0000040;

    [NativeTypeName("#define SP_COPY_SOURCEPATH_ABSOLUTE 0x0000080")]
    public const int SP_COPY_SOURCEPATH_ABSOLUTE = 0x0000080;

    [NativeTypeName("#define SP_COPY_IN_USE_NEEDS_REBOOT 0x0000100")]
    public const int SP_COPY_IN_USE_NEEDS_REBOOT = 0x0000100;

    [NativeTypeName("#define SP_COPY_FORCE_IN_USE 0x0000200")]
    public const int SP_COPY_FORCE_IN_USE = 0x0000200;

    [NativeTypeName("#define SP_COPY_NOSKIP 0x0000400")]
    public const int SP_COPY_NOSKIP = 0x0000400;

    [NativeTypeName("#define SP_FLAG_CABINETCONTINUATION 0x0000800")]
    public const int SP_FLAG_CABINETCONTINUATION = 0x0000800;

    [NativeTypeName("#define SP_COPY_FORCE_NOOVERWRITE 0x0001000")]
    public const int SP_COPY_FORCE_NOOVERWRITE = 0x0001000;

    [NativeTypeName("#define SP_COPY_FORCE_NEWER 0x0002000")]
    public const int SP_COPY_FORCE_NEWER = 0x0002000;

    [NativeTypeName("#define SP_COPY_WARNIFSKIP 0x0004000")]
    public const int SP_COPY_WARNIFSKIP = 0x0004000;

    [NativeTypeName("#define SP_COPY_NOBROWSE 0x0008000")]
    public const int SP_COPY_NOBROWSE = 0x0008000;

    [NativeTypeName("#define SP_COPY_NEWER_ONLY 0x0010000")]
    public const int SP_COPY_NEWER_ONLY = 0x0010000;

    [NativeTypeName("#define SP_COPY_RESERVED 0x0020000")]
    public const int SP_COPY_RESERVED = 0x0020000;

    [NativeTypeName("#define SP_COPY_OEMINF_CATALOG_ONLY 0x0040000")]
    public const int SP_COPY_OEMINF_CATALOG_ONLY = 0x0040000;

    [NativeTypeName("#define SP_COPY_REPLACE_BOOT_FILE 0x0080000")]
    public const int SP_COPY_REPLACE_BOOT_FILE = 0x0080000;

    [NativeTypeName("#define SP_COPY_NOPRUNE 0x0100000")]
    public const int SP_COPY_NOPRUNE = 0x0100000;

    [NativeTypeName("#define SP_COPY_OEM_F6_INF 0x0200000")]
    public const int SP_COPY_OEM_F6_INF = 0x0200000;

    [NativeTypeName("#define SP_COPY_ALREADYDECOMP 0x0400000")]
    public const int SP_COPY_ALREADYDECOMP = 0x0400000;

    [NativeTypeName("#define SP_COPY_WINDOWS_SIGNED 0x1000000")]
    public const int SP_COPY_WINDOWS_SIGNED = 0x1000000;

    [NativeTypeName("#define SP_COPY_PNPLOCKED 0x2000000")]
    public const int SP_COPY_PNPLOCKED = 0x2000000;

    [NativeTypeName("#define SP_COPY_IN_USE_TRY_RENAME 0x4000000")]
    public const int SP_COPY_IN_USE_TRY_RENAME = 0x4000000;

    [NativeTypeName("#define SP_COPY_INBOX_INF 0x8000000")]
    public const int SP_COPY_INBOX_INF = 0x8000000;

    [NativeTypeName("#define SP_COPY_HARDLINK 0x10000000")]
    public const int SP_COPY_HARDLINK = 0x10000000;

    [NativeTypeName("#define SP_BACKUP_BACKUPPASS 0x00000001")]
    public const int SP_BACKUP_BACKUPPASS = 0x00000001;

    [NativeTypeName("#define SP_BACKUP_DEMANDPASS 0x00000002")]
    public const int SP_BACKUP_DEMANDPASS = 0x00000002;

    [NativeTypeName("#define SP_BACKUP_SPECIAL 0x00000004")]
    public const int SP_BACKUP_SPECIAL = 0x00000004;

    [NativeTypeName("#define SP_BACKUP_BOOTFILE 0x00000008")]
    public const int SP_BACKUP_BOOTFILE = 0x00000008;
}

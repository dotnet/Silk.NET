// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class REG
{
    [NativeTypeName("#define REG_OPTION_RESERVED (0x00000000L)")]
    public const int REG_OPTION_RESERVED = (0x00000000);

    [NativeTypeName("#define REG_OPTION_NON_VOLATILE (0x00000000L)")]
    public const int REG_OPTION_NON_VOLATILE = (0x00000000);

    [NativeTypeName("#define REG_OPTION_VOLATILE (0x00000001L)")]
    public const int REG_OPTION_VOLATILE = (0x00000001);

    [NativeTypeName("#define REG_OPTION_CREATE_LINK (0x00000002L)")]
    public const int REG_OPTION_CREATE_LINK = (0x00000002);

    [NativeTypeName("#define REG_OPTION_BACKUP_RESTORE (0x00000004L)")]
    public const int REG_OPTION_BACKUP_RESTORE = (0x00000004);

    [NativeTypeName("#define REG_OPTION_OPEN_LINK (0x00000008L)")]
    public const int REG_OPTION_OPEN_LINK = (0x00000008);

    [NativeTypeName("#define REG_OPTION_DONT_VIRTUALIZE (0x00000010L)")]
    public const int REG_OPTION_DONT_VIRTUALIZE = (0x00000010);

    [NativeTypeName(
        "#define REG_LEGAL_OPTION (REG_OPTION_RESERVED            |\\\r\n                 REG_OPTION_NON_VOLATILE        |\\\r\n                 REG_OPTION_VOLATILE            |\\\r\n                 REG_OPTION_CREATE_LINK         |\\\r\n                 REG_OPTION_BACKUP_RESTORE      |\\\r\n                 REG_OPTION_OPEN_LINK           |\\\r\n                 REG_OPTION_DONT_VIRTUALIZE)"
    )]
    public const int REG_LEGAL_OPTION = (
        (0x00000000)
        | (0x00000000)
        | (0x00000001)
        | (0x00000002)
        | (0x00000004)
        | (0x00000008)
        | (0x00000010)
    );

    [NativeTypeName(
        "#define REG_OPEN_LEGAL_OPTION (REG_OPTION_RESERVED            |\\\r\n                 REG_OPTION_BACKUP_RESTORE      |\\\r\n                 REG_OPTION_OPEN_LINK           |\\\r\n                 REG_OPTION_DONT_VIRTUALIZE)"
    )]
    public const int REG_OPEN_LEGAL_OPTION = (
        (0x00000000) | (0x00000004) | (0x00000008) | (0x00000010)
    );

    [NativeTypeName("#define REG_CREATED_NEW_KEY (0x00000001L)")]
    public const int REG_CREATED_NEW_KEY = (0x00000001);

    [NativeTypeName("#define REG_OPENED_EXISTING_KEY (0x00000002L)")]
    public const int REG_OPENED_EXISTING_KEY = (0x00000002);

    [NativeTypeName("#define REG_STANDARD_FORMAT 1")]
    public const int REG_STANDARD_FORMAT = 1;

    [NativeTypeName("#define REG_LATEST_FORMAT 2")]
    public const int REG_LATEST_FORMAT = 2;

    [NativeTypeName("#define REG_NO_COMPRESSION 4")]
    public const int REG_NO_COMPRESSION = 4;

    [NativeTypeName("#define REG_WHOLE_HIVE_VOLATILE (0x00000001L)")]
    public const int REG_WHOLE_HIVE_VOLATILE = (0x00000001);

    [NativeTypeName("#define REG_REFRESH_HIVE (0x00000002L)")]
    public const int REG_REFRESH_HIVE = (0x00000002);

    [NativeTypeName("#define REG_NO_LAZY_FLUSH (0x00000004L)")]
    public const int REG_NO_LAZY_FLUSH = (0x00000004);

    [NativeTypeName("#define REG_FORCE_RESTORE (0x00000008L)")]
    public const int REG_FORCE_RESTORE = (0x00000008);

    [NativeTypeName("#define REG_APP_HIVE (0x00000010L)")]
    public const int REG_APP_HIVE = (0x00000010);

    [NativeTypeName("#define REG_PROCESS_PRIVATE (0x00000020L)")]
    public const int REG_PROCESS_PRIVATE = (0x00000020);

    [NativeTypeName("#define REG_START_JOURNAL (0x00000040L)")]
    public const int REG_START_JOURNAL = (0x00000040);

    [NativeTypeName("#define REG_HIVE_EXACT_FILE_GROWTH (0x00000080L)")]
    public const int REG_HIVE_EXACT_FILE_GROWTH = (0x00000080);

    [NativeTypeName("#define REG_HIVE_NO_RM (0x00000100L)")]
    public const int REG_HIVE_NO_RM = (0x00000100);

    [NativeTypeName("#define REG_HIVE_SINGLE_LOG (0x00000200L)")]
    public const int REG_HIVE_SINGLE_LOG = (0x00000200);

    [NativeTypeName("#define REG_BOOT_HIVE (0x00000400L)")]
    public const int REG_BOOT_HIVE = (0x00000400);

    [NativeTypeName("#define REG_LOAD_HIVE_OPEN_HANDLE (0x00000800L)")]
    public const int REG_LOAD_HIVE_OPEN_HANDLE = (0x00000800);

    [NativeTypeName("#define REG_FLUSH_HIVE_FILE_GROWTH (0x00001000L)")]
    public const int REG_FLUSH_HIVE_FILE_GROWTH = (0x00001000);

    [NativeTypeName("#define REG_OPEN_READ_ONLY (0x00002000L)")]
    public const int REG_OPEN_READ_ONLY = (0x00002000);

    [NativeTypeName("#define REG_IMMUTABLE (0x00004000L)")]
    public const int REG_IMMUTABLE = (0x00004000);

    [NativeTypeName("#define REG_NO_IMPERSONATION_FALLBACK (0x00008000L)")]
    public const int REG_NO_IMPERSONATION_FALLBACK = (0x00008000);

    [NativeTypeName("#define REG_APP_HIVE_OPEN_READ_ONLY (REG_OPEN_READ_ONLY)")]
    public const int REG_APP_HIVE_OPEN_READ_ONLY = ((0x00002000));

    [NativeTypeName("#define REG_FORCE_UNLOAD 1")]
    public const int REG_FORCE_UNLOAD = 1;

    [NativeTypeName("#define REG_UNLOAD_LEGAL_FLAGS (REG_FORCE_UNLOAD)")]
    public const int REG_UNLOAD_LEGAL_FLAGS = (1);

    [NativeTypeName("#define REG_NOTIFY_CHANGE_NAME (0x00000001L)")]
    public const int REG_NOTIFY_CHANGE_NAME = (0x00000001);

    [NativeTypeName("#define REG_NOTIFY_CHANGE_ATTRIBUTES (0x00000002L)")]
    public const int REG_NOTIFY_CHANGE_ATTRIBUTES = (0x00000002);

    [NativeTypeName("#define REG_NOTIFY_CHANGE_LAST_SET (0x00000004L)")]
    public const int REG_NOTIFY_CHANGE_LAST_SET = (0x00000004);

    [NativeTypeName("#define REG_NOTIFY_CHANGE_SECURITY (0x00000008L)")]
    public const int REG_NOTIFY_CHANGE_SECURITY = (0x00000008);

    [NativeTypeName("#define REG_NOTIFY_THREAD_AGNOSTIC (0x10000000L)")]
    public const int REG_NOTIFY_THREAD_AGNOSTIC = (0x10000000);

    [NativeTypeName(
        "#define REG_LEGAL_CHANGE_FILTER (REG_NOTIFY_CHANGE_NAME          |\\\r\n                 REG_NOTIFY_CHANGE_ATTRIBUTES    |\\\r\n                 REG_NOTIFY_CHANGE_LAST_SET      |\\\r\n                 REG_NOTIFY_CHANGE_SECURITY      |\\\r\n                 REG_NOTIFY_THREAD_AGNOSTIC)"
    )]
    public const int REG_LEGAL_CHANGE_FILTER = (
        (0x00000001) | (0x00000002) | (0x00000004) | (0x00000008) | (0x10000000)
    );

    [NativeTypeName("#define REG_NONE ( 0ul )")]
    public const uint REG_NONE = (0U);

    [NativeTypeName("#define REG_SZ ( 1ul )")]
    public const uint REG_SZ = (1U);

    [NativeTypeName("#define REG_EXPAND_SZ ( 2ul )")]
    public const uint REG_EXPAND_SZ = (2U);

    [NativeTypeName("#define REG_BINARY ( 3ul )")]
    public const uint REG_BINARY = (3U);

    [NativeTypeName("#define REG_DWORD ( 4ul )")]
    public const uint REG_DWORD = (4U);

    [NativeTypeName("#define REG_DWORD_LITTLE_ENDIAN ( 4ul )")]
    public const uint REG_DWORD_LITTLE_ENDIAN = (4U);

    [NativeTypeName("#define REG_DWORD_BIG_ENDIAN ( 5ul )")]
    public const uint REG_DWORD_BIG_ENDIAN = (5U);

    [NativeTypeName("#define REG_LINK ( 6ul )")]
    public const uint REG_LINK = (6U);

    [NativeTypeName("#define REG_MULTI_SZ ( 7ul )")]
    public const uint REG_MULTI_SZ = (7U);

    [NativeTypeName("#define REG_RESOURCE_LIST ( 8ul )")]
    public const uint REG_RESOURCE_LIST = (8U);

    [NativeTypeName("#define REG_FULL_RESOURCE_DESCRIPTOR ( 9ul )")]
    public const uint REG_FULL_RESOURCE_DESCRIPTOR = (9U);

    [NativeTypeName("#define REG_RESOURCE_REQUIREMENTS_LIST ( 10ul )")]
    public const uint REG_RESOURCE_REQUIREMENTS_LIST = (10U);

    [NativeTypeName("#define REG_QWORD ( 11ul )")]
    public const uint REG_QWORD = (11U);

    [NativeTypeName("#define REG_QWORD_LITTLE_ENDIAN ( 11ul )")]
    public const uint REG_QWORD_LITTLE_ENDIAN = (11U);
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class USN
{
    [NativeTypeName("#define USN_PAGE_SIZE (0x1000)")]
    public const int USN_PAGE_SIZE = (0x1000);

    [NativeTypeName("#define USN_REASON_DATA_OVERWRITE (0x00000001)")]
    public const int USN_REASON_DATA_OVERWRITE = (0x00000001);

    [NativeTypeName("#define USN_REASON_DATA_EXTEND (0x00000002)")]
    public const int USN_REASON_DATA_EXTEND = (0x00000002);

    [NativeTypeName("#define USN_REASON_DATA_TRUNCATION (0x00000004)")]
    public const int USN_REASON_DATA_TRUNCATION = (0x00000004);

    [NativeTypeName("#define USN_REASON_NAMED_DATA_OVERWRITE (0x00000010)")]
    public const int USN_REASON_NAMED_DATA_OVERWRITE = (0x00000010);

    [NativeTypeName("#define USN_REASON_NAMED_DATA_EXTEND (0x00000020)")]
    public const int USN_REASON_NAMED_DATA_EXTEND = (0x00000020);

    [NativeTypeName("#define USN_REASON_NAMED_DATA_TRUNCATION (0x00000040)")]
    public const int USN_REASON_NAMED_DATA_TRUNCATION = (0x00000040);

    [NativeTypeName("#define USN_REASON_FILE_CREATE (0x00000100)")]
    public const int USN_REASON_FILE_CREATE = (0x00000100);

    [NativeTypeName("#define USN_REASON_FILE_DELETE (0x00000200)")]
    public const int USN_REASON_FILE_DELETE = (0x00000200);

    [NativeTypeName("#define USN_REASON_EA_CHANGE (0x00000400)")]
    public const int USN_REASON_EA_CHANGE = (0x00000400);

    [NativeTypeName("#define USN_REASON_SECURITY_CHANGE (0x00000800)")]
    public const int USN_REASON_SECURITY_CHANGE = (0x00000800);

    [NativeTypeName("#define USN_REASON_RENAME_OLD_NAME (0x00001000)")]
    public const int USN_REASON_RENAME_OLD_NAME = (0x00001000);

    [NativeTypeName("#define USN_REASON_RENAME_NEW_NAME (0x00002000)")]
    public const int USN_REASON_RENAME_NEW_NAME = (0x00002000);

    [NativeTypeName("#define USN_REASON_INDEXABLE_CHANGE (0x00004000)")]
    public const int USN_REASON_INDEXABLE_CHANGE = (0x00004000);

    [NativeTypeName("#define USN_REASON_BASIC_INFO_CHANGE (0x00008000)")]
    public const int USN_REASON_BASIC_INFO_CHANGE = (0x00008000);

    [NativeTypeName("#define USN_REASON_HARD_LINK_CHANGE (0x00010000)")]
    public const int USN_REASON_HARD_LINK_CHANGE = (0x00010000);

    [NativeTypeName("#define USN_REASON_COMPRESSION_CHANGE (0x00020000)")]
    public const int USN_REASON_COMPRESSION_CHANGE = (0x00020000);

    [NativeTypeName("#define USN_REASON_ENCRYPTION_CHANGE (0x00040000)")]
    public const int USN_REASON_ENCRYPTION_CHANGE = (0x00040000);

    [NativeTypeName("#define USN_REASON_OBJECT_ID_CHANGE (0x00080000)")]
    public const int USN_REASON_OBJECT_ID_CHANGE = (0x00080000);

    [NativeTypeName("#define USN_REASON_REPARSE_POINT_CHANGE (0x00100000)")]
    public const int USN_REASON_REPARSE_POINT_CHANGE = (0x00100000);

    [NativeTypeName("#define USN_REASON_STREAM_CHANGE (0x00200000)")]
    public const int USN_REASON_STREAM_CHANGE = (0x00200000);

    [NativeTypeName("#define USN_REASON_TRANSACTED_CHANGE (0x00400000)")]
    public const int USN_REASON_TRANSACTED_CHANGE = (0x00400000);

    [NativeTypeName("#define USN_REASON_INTEGRITY_CHANGE (0x00800000)")]
    public const int USN_REASON_INTEGRITY_CHANGE = (0x00800000);

    [NativeTypeName("#define USN_REASON_DESIRED_STORAGE_CLASS_CHANGE (0x01000000)")]
    public const int USN_REASON_DESIRED_STORAGE_CLASS_CHANGE = (0x01000000);

    [NativeTypeName("#define USN_REASON_CLOSE (0x80000000)")]
    public const uint USN_REASON_CLOSE = (0x80000000);

    [NativeTypeName("#define USN_DELETE_FLAG_DELETE (0x00000001)")]
    public const int USN_DELETE_FLAG_DELETE = (0x00000001);

    [NativeTypeName("#define USN_DELETE_FLAG_NOTIFY (0x00000002)")]
    public const int USN_DELETE_FLAG_NOTIFY = (0x00000002);

    [NativeTypeName("#define USN_DELETE_VALID_FLAGS (0x00000003)")]
    public const int USN_DELETE_VALID_FLAGS = (0x00000003);

    [NativeTypeName("#define USN_SOURCE_DATA_MANAGEMENT (0x00000001)")]
    public const int USN_SOURCE_DATA_MANAGEMENT = (0x00000001);

    [NativeTypeName("#define USN_SOURCE_AUXILIARY_DATA (0x00000002)")]
    public const int USN_SOURCE_AUXILIARY_DATA = (0x00000002);

    [NativeTypeName("#define USN_SOURCE_REPLICATION_MANAGEMENT (0x00000004)")]
    public const int USN_SOURCE_REPLICATION_MANAGEMENT = (0x00000004);

    [NativeTypeName("#define USN_SOURCE_CLIENT_REPLICATION_MANAGEMENT (0x00000008)")]
    public const int USN_SOURCE_CLIENT_REPLICATION_MANAGEMENT = (0x00000008);

    [NativeTypeName("#define USN_SOURCE_VALID_FLAGS (USN_SOURCE_DATA_MANAGEMENT |               \\\r\n                                     USN_SOURCE_AUXILIARY_DATA |                \\\r\n                                     USN_SOURCE_REPLICATION_MANAGEMENT |        \\\r\n                                     USN_SOURCE_CLIENT_REPLICATION_MANAGEMENT)")]
    public const int USN_SOURCE_VALID_FLAGS = ((0x00000001) | (0x00000002) | (0x00000004) | (0x00000008));
}

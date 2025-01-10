// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FSCTL
{
    [NativeTypeName(
        "#define FSCTL_REQUEST_OPLOCK_LEVEL_1 CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  0, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REQUEST_OPLOCK_LEVEL_1 = (
        ((0x00000009) << 16) | ((0) << 14) | ((0) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REQUEST_OPLOCK_LEVEL_2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  1, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REQUEST_OPLOCK_LEVEL_2 = (
        ((0x00000009) << 16) | ((0) << 14) | ((1) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REQUEST_BATCH_OPLOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  2, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REQUEST_BATCH_OPLOCK = (
        ((0x00000009) << 16) | ((0) << 14) | ((2) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_OPLOCK_BREAK_ACKNOWLEDGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  3, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_OPLOCK_BREAK_ACKNOWLEDGE = (
        ((0x00000009) << 16) | ((0) << 14) | ((3) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_OPBATCH_ACK_CLOSE_PENDING CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  4, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_OPBATCH_ACK_CLOSE_PENDING = (
        ((0x00000009) << 16) | ((0) << 14) | ((4) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_OPLOCK_BREAK_NOTIFY CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  5, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_OPLOCK_BREAK_NOTIFY = (
        ((0x00000009) << 16) | ((0) << 14) | ((5) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_LOCK_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  6, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_LOCK_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((6) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_UNLOCK_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  7, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_UNLOCK_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((7) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_DISMOUNT_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  8, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_DISMOUNT_VOLUME = (
        ((0x00000009) << 16) | ((0) << 14) | ((8) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_IS_VOLUME_MOUNTED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 10, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_IS_VOLUME_MOUNTED = (
        ((0x00000009) << 16) | ((0) << 14) | ((10) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_IS_PATHNAME_VALID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 11, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_IS_PATHNAME_VALID = (
        ((0x00000009) << 16) | ((0) << 14) | ((11) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_MARK_VOLUME_DIRTY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 12, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_MARK_VOLUME_DIRTY = (
        ((0x00000009) << 16) | ((0) << 14) | ((12) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_RETRIEVAL_POINTERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 14,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_RETRIEVAL_POINTERS = (
        ((0x00000009) << 16) | ((0) << 14) | ((14) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_GET_COMPRESSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 15, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_COMPRESSION = (
        ((0x00000009) << 16) | ((0) << 14) | ((15) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_COMPRESSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 16, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)"
    )]
    public const int FSCTL_SET_COMPRESSION = (
        ((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((16) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_BOOTLOADER_ACCESSED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 19,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_BOOTLOADER_ACCESSED = (
        ((0x00000009) << 16) | ((0) << 14) | ((19) << 2) | (3)
    );

    [NativeTypeName("#define FSCTL_MARK_AS_SYSTEM_HIVE FSCTL_SET_BOOTLOADER_ACCESSED")]
    public const int FSCTL_MARK_AS_SYSTEM_HIVE = (
        ((0x00000009) << 16) | ((0) << 14) | ((19) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_OPLOCK_BREAK_ACK_NO_2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 20, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_OPLOCK_BREAK_ACK_NO_2 = (
        ((0x00000009) << 16) | ((0) << 14) | ((20) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_INVALIDATE_VOLUMES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 21, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_INVALIDATE_VOLUMES = (
        ((0x00000009) << 16) | ((0) << 14) | ((21) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_FAT_BPB CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 22, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_FAT_BPB = (((0x00000009) << 16) | ((0) << 14) | ((22) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_REQUEST_FILTER_OPLOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 23, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REQUEST_FILTER_OPLOCK = (
        ((0x00000009) << 16) | ((0) << 14) | ((23) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_FILESYSTEM_GET_STATISTICS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 24, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_FILESYSTEM_GET_STATISTICS = (
        ((0x00000009) << 16) | ((0) << 14) | ((24) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_NTFS_VOLUME_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 25, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_NTFS_VOLUME_DATA = (
        ((0x00000009) << 16) | ((0) << 14) | ((25) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_NTFS_FILE_RECORD CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 26, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_NTFS_FILE_RECORD = (
        ((0x00000009) << 16) | ((0) << 14) | ((26) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_VOLUME_BITMAP CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 27,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_VOLUME_BITMAP = (
        ((0x00000009) << 16) | ((0) << 14) | ((27) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_GET_RETRIEVAL_POINTERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 28,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_RETRIEVAL_POINTERS = (
        ((0x00000009) << 16) | ((0) << 14) | ((28) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_MOVE_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 29, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_MOVE_FILE = (((0x00000009) << 16) | (((0)) << 14) | ((29) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_IS_VOLUME_DIRTY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 30, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_IS_VOLUME_DIRTY = (
        ((0x00000009) << 16) | ((0) << 14) | ((30) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_ALLOW_EXTENDED_DASD_IO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 32, METHOD_NEITHER,  FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_ALLOW_EXTENDED_DASD_IO = (
        ((0x00000009) << 16) | ((0) << 14) | ((32) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_FIND_FILES_BY_SID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 35, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_FIND_FILES_BY_SID = (
        ((0x00000009) << 16) | ((0) << 14) | ((35) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_SET_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 38, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_OBJECT_ID = (
        ((0x00000009) << 16) | (((0)) << 14) | ((38) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 39, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_OBJECT_ID = (((0x00000009) << 16) | ((0) << 14) | ((39) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_DELETE_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 40, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_DELETE_OBJECT_ID = (
        ((0x00000009) << 16) | (((0)) << 14) | ((40) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_REPARSE_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 41, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_REPARSE_POINT = (
        ((0x00000009) << 16) | (((0)) << 14) | ((41) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_REPARSE_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 42, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_REPARSE_POINT = (
        ((0x00000009) << 16) | ((0) << 14) | ((42) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DELETE_REPARSE_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 43, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_DELETE_REPARSE_POINT = (
        ((0x00000009) << 16) | (((0)) << 14) | ((43) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_ENUM_USN_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 44,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_ENUM_USN_DATA = (((0x00000009) << 16) | ((0) << 14) | ((44) << 2) | (3));

    [NativeTypeName(
        "#define FSCTL_SECURITY_ID_CHECK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 45,  METHOD_NEITHER, FILE_READ_DATA)"
    )]
    public const int FSCTL_SECURITY_ID_CHECK = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((45) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_READ_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 46,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_READ_USN_JOURNAL = (
        ((0x00000009) << 16) | ((0) << 14) | ((46) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_SET_OBJECT_ID_EXTENDED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 47, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_OBJECT_ID_EXTENDED = (
        ((0x00000009) << 16) | (((0)) << 14) | ((47) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CREATE_OR_GET_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 48, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CREATE_OR_GET_OBJECT_ID = (
        ((0x00000009) << 16) | ((0) << 14) | ((48) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_SPARSE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 49, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_SPARSE = (((0x00000009) << 16) | (((0)) << 14) | ((49) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_SET_ZERO_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 50, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_SET_ZERO_DATA = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((50) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_ALLOCATED_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 51,  METHOD_NEITHER, FILE_READ_DATA)"
    )]
    public const int FSCTL_QUERY_ALLOCATED_RANGES = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((51) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_ENABLE_UPGRADE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 52, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_ENABLE_UPGRADE = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((52) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_ENCRYPTION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 53,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_ENCRYPTION = (
        ((0x00000009) << 16) | ((0) << 14) | ((53) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_ENCRYPTION_FSCTL_IO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 54,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_ENCRYPTION_FSCTL_IO = (
        ((0x00000009) << 16) | ((0) << 14) | ((54) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_WRITE_RAW_ENCRYPTED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 55,  METHOD_NEITHER, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_WRITE_RAW_ENCRYPTED = (
        ((0x00000009) << 16) | (((0)) << 14) | ((55) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_READ_RAW_ENCRYPTED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 56,  METHOD_NEITHER, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_READ_RAW_ENCRYPTED = (
        ((0x00000009) << 16) | (((0)) << 14) | ((56) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_CREATE_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 57,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CREATE_USN_JOURNAL = (
        ((0x00000009) << 16) | ((0) << 14) | ((57) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_READ_FILE_USN_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 58,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_READ_FILE_USN_DATA = (
        ((0x00000009) << 16) | ((0) << 14) | ((58) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_WRITE_USN_CLOSE_RECORD CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 59,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_WRITE_USN_CLOSE_RECORD = (
        ((0x00000009) << 16) | ((0) << 14) | ((59) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_EXTEND_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 60, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_EXTEND_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((60) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_QUERY_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 61, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_USN_JOURNAL = (
        ((0x00000009) << 16) | ((0) << 14) | ((61) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DELETE_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 62, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_DELETE_USN_JOURNAL = (
        ((0x00000009) << 16) | ((0) << 14) | ((62) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_MARK_HANDLE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 63, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_MARK_HANDLE = (((0x00000009) << 16) | ((0) << 14) | ((63) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_SIS_COPYFILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 64, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SIS_COPYFILE = (((0x00000009) << 16) | ((0) << 14) | ((64) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_SIS_LINK_FILES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 65, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)"
    )]
    public const int FSCTL_SIS_LINK_FILES = (
        ((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((65) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_RECALL_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 69, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_RECALL_FILE = (((0x00000009) << 16) | ((0) << 14) | ((69) << 2) | (3));

    [NativeTypeName(
        "#define FSCTL_READ_FROM_PLEX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 71, METHOD_OUT_DIRECT, FILE_READ_DATA)"
    )]
    public const int FSCTL_READ_FROM_PLEX = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((71) << 2) | (2)
    );

    [NativeTypeName(
        "#define FSCTL_FILE_PREFETCH CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 72, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_FILE_PREFETCH = (
        ((0x00000009) << 16) | (((0)) << 14) | ((72) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_MAKE_MEDIA_COMPATIBLE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 76, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_MAKE_MEDIA_COMPATIBLE = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((76) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_DEFECT_MANAGEMENT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 77, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_SET_DEFECT_MANAGEMENT = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((77) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_SPARING_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 78, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_SPARING_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((78) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_ON_DISK_VOLUME_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 79, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_ON_DISK_VOLUME_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((79) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_VOLUME_COMPRESSION_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 80, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_VOLUME_COMPRESSION_STATE = (
        ((0x00000009) << 16) | (((0)) << 14) | ((80) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_MODIFY_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 81, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_MODIFY_RM = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((81) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_QUERY_RM_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 82, METHOD_BUFFERED, FILE_READ_DATA)"
    )]
    public const int FSCTL_TXFS_QUERY_RM_INFORMATION = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((82) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_ROLLFORWARD_REDO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 84, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_ROLLFORWARD_REDO = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((84) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_ROLLFORWARD_UNDO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 85, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_ROLLFORWARD_UNDO = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((85) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_START_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 86, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_START_RM = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((86) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_SHUTDOWN_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 87, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_SHUTDOWN_RM = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((87) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_READ_BACKUP_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 88, METHOD_BUFFERED, FILE_READ_DATA)"
    )]
    public const int FSCTL_TXFS_READ_BACKUP_INFORMATION = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((88) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_WRITE_BACKUP_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 89, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_WRITE_BACKUP_INFORMATION = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((89) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_CREATE_SECONDARY_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 90, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_CREATE_SECONDARY_RM = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((90) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_GET_METADATA_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 91, METHOD_BUFFERED, FILE_READ_DATA)"
    )]
    public const int FSCTL_TXFS_GET_METADATA_INFO = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((91) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_GET_TRANSACTED_VERSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 92, METHOD_BUFFERED, FILE_READ_DATA)"
    )]
    public const int FSCTL_TXFS_GET_TRANSACTED_VERSION = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((92) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_SAVEPOINT_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 94, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_SAVEPOINT_INFORMATION = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((94) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_CREATE_MINIVERSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 95, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_TXFS_CREATE_MINIVERSION = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((95) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_TRANSACTION_ACTIVE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 99, METHOD_BUFFERED, FILE_READ_DATA)"
    )]
    public const int FSCTL_TXFS_TRANSACTION_ACTIVE = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((99) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_ZERO_ON_DEALLOCATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 101, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_ZERO_ON_DEALLOCATION = (
        ((0x00000009) << 16) | (((0)) << 14) | ((101) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 102, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_REPAIR = (((0x00000009) << 16) | ((0) << 14) | ((102) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_GET_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 103, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_REPAIR = (((0x00000009) << 16) | ((0) << 14) | ((103) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_WAIT_FOR_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 104, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_WAIT_FOR_REPAIR = (
        ((0x00000009) << 16) | ((0) << 14) | ((104) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_INITIATE_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 106, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_INITIATE_REPAIR = (
        ((0x00000009) << 16) | ((0) << 14) | ((106) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSC_INTERNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 107, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSC_INTERNAL = (((0x00000009) << 16) | ((0) << 14) | ((107) << 2) | (3));

    [NativeTypeName(
        "#define FSCTL_SHRINK_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 108, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SHRINK_VOLUME = (
        ((0x00000009) << 16) | (((0)) << 14) | ((108) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_SHORT_NAME_BEHAVIOR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 109, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_SHORT_NAME_BEHAVIOR = (
        ((0x00000009) << 16) | ((0) << 14) | ((109) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DFSR_SET_GHOST_HANDLE_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 110, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_DFSR_SET_GHOST_HANDLE_STATE = (
        ((0x00000009) << 16) | ((0) << 14) | ((110) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_LIST_TRANSACTION_LOCKED_FILES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 120, METHOD_BUFFERED, FILE_READ_DATA)"
    )]
    public const int FSCTL_TXFS_LIST_TRANSACTION_LOCKED_FILES = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((120) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_LIST_TRANSACTIONS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 121, METHOD_BUFFERED, FILE_READ_DATA)"
    )]
    public const int FSCTL_TXFS_LIST_TRANSACTIONS = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((121) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_PAGEFILE_ENCRYPTION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 122, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_PAGEFILE_ENCRYPTION = (
        ((0x00000009) << 16) | ((0) << 14) | ((122) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_RESET_VOLUME_ALLOCATION_HINTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 123, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_RESET_VOLUME_ALLOCATION_HINTS = (
        ((0x00000009) << 16) | ((0) << 14) | ((123) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_DEPENDENT_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 124, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_DEPENDENT_VOLUME = (
        ((0x00000009) << 16) | ((0) << 14) | ((124) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SD_GLOBAL_CHANGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 125, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SD_GLOBAL_CHANGE = (
        ((0x00000009) << 16) | ((0) << 14) | ((125) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_READ_BACKUP_INFORMATION2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 126, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_TXFS_READ_BACKUP_INFORMATION2 = (
        ((0x00000009) << 16) | ((0) << 14) | ((126) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_LOOKUP_STREAM_FROM_CLUSTER CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 127, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_LOOKUP_STREAM_FROM_CLUSTER = (
        ((0x00000009) << 16) | ((0) << 14) | ((127) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_TXFS_WRITE_BACKUP_INFORMATION2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 128, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_TXFS_WRITE_BACKUP_INFORMATION2 = (
        ((0x00000009) << 16) | ((0) << 14) | ((128) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_FILE_TYPE_NOTIFICATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 129, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_FILE_TYPE_NOTIFICATION = (
        ((0x00000009) << 16) | ((0) << 14) | ((129) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_FILE_LEVEL_TRIM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 130, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    [SupportedOSPlatform("windows6.2")]
    public const int FSCTL_FILE_LEVEL_TRIM = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((130) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_BOOT_AREA_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 140, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_BOOT_AREA_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((140) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_RETRIEVAL_POINTER_BASE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 141, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_RETRIEVAL_POINTER_BASE = (
        ((0x00000009) << 16) | ((0) << 14) | ((141) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_PERSISTENT_VOLUME_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 142, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_PERSISTENT_VOLUME_STATE = (
        ((0x00000009) << 16) | ((0) << 14) | ((142) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_PERSISTENT_VOLUME_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 143, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_PERSISTENT_VOLUME_STATE = (
        ((0x00000009) << 16) | ((0) << 14) | ((143) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REQUEST_OPLOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 144, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REQUEST_OPLOCK = (
        ((0x00000009) << 16) | ((0) << 14) | ((144) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 145, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((145) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_IS_CSV_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 146, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_IS_CSV_FILE = (((0x00000009) << 16) | ((0) << 14) | ((146) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_QUERY_FILE_SYSTEM_RECOGNITION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 147, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_FILE_SYSTEM_RECOGNITION = (
        ((0x00000009) << 16) | ((0) << 14) | ((147) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_GET_VOLUME_PATH_NAME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 148, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_GET_VOLUME_PATH_NAME = (
        ((0x00000009) << 16) | ((0) << 14) | ((148) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_GET_VOLUME_NAME_FOR_VOLUME_MOUNT_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 149, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_GET_VOLUME_NAME_FOR_VOLUME_MOUNT_POINT = (
        ((0x00000009) << 16) | ((0) << 14) | ((149) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_GET_VOLUME_PATH_NAMES_FOR_VOLUME_NAME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 150,  METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_GET_VOLUME_PATH_NAMES_FOR_VOLUME_NAME = (
        ((0x00000009) << 16) | ((0) << 14) | ((150) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_IS_FILE_ON_CSV_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 151,  METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_IS_FILE_ON_CSV_VOLUME = (
        ((0x00000009) << 16) | ((0) << 14) | ((151) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CORRUPTION_HANDLING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 152, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CORRUPTION_HANDLING = (
        ((0x00000009) << 16) | ((0) << 14) | ((152) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_OFFLOAD_READ CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 153, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int FSCTL_OFFLOAD_READ = (
        ((0x00000009) << 16) | (((0x0001)) << 14) | ((153) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_OFFLOAD_WRITE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 154, METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int FSCTL_OFFLOAD_WRITE = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((154) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_INTERNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 155,  METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_INTERNAL = (((0x00000009) << 16) | ((0) << 14) | ((155) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_SET_PURGE_FAILURE_MODE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 156, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_PURGE_FAILURE_MODE = (
        ((0x00000009) << 16) | ((0) << 14) | ((156) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_FILE_LAYOUT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 157, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_FILE_LAYOUT = (
        ((0x00000009) << 16) | ((0) << 14) | ((157) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_IS_VOLUME_OWNED_BYCSVFS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 158,  METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_IS_VOLUME_OWNED_BYCSVFS = (
        ((0x00000009) << 16) | ((0) << 14) | ((158) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_INTEGRITY_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 159, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_INTEGRITY_INFORMATION = (
        ((0x00000009) << 16) | ((0) << 14) | ((159) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_INTEGRITY_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 160, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)"
    )]
    public const int FSCTL_SET_INTEGRITY_INFORMATION = (
        ((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((160) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_FILE_REGIONS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 161, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_FILE_REGIONS = (
        ((0x00000009) << 16) | ((0) << 14) | ((161) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_RKF_INTERNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 171, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_RKF_INTERNAL = (((0x00000009) << 16) | ((0) << 14) | ((171) << 2) | (3));

    [NativeTypeName(
        "#define FSCTL_SCRUB_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 172, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SCRUB_DATA = (((0x00000009) << 16) | ((0) << 14) | ((172) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_REPAIR_COPIES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 173, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)"
    )]
    public const int FSCTL_REPAIR_COPIES = (
        ((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((173) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DISABLE_LOCAL_BUFFERING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 174, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_DISABLE_LOCAL_BUFFERING = (
        ((0x00000009) << 16) | ((0) << 14) | ((174) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_MGMT_LOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 175, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_MGMT_LOCK = (
        ((0x00000009) << 16) | ((0) << 14) | ((175) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_QUERY_DOWN_LEVEL_FILE_SYSTEM_CHARACTERISTICS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 176, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_QUERY_DOWN_LEVEL_FILE_SYSTEM_CHARACTERISTICS = (
        ((0x00000009) << 16) | ((0) << 14) | ((176) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_ADVANCE_FILE_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 177, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_ADVANCE_FILE_ID = (
        ((0x00000009) << 16) | ((0) << 14) | ((177) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 178, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_SYNC_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((178) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_QUERY_VETO_FILE_DIRECT_IO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 179, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_QUERY_VETO_FILE_DIRECT_IO = (
        ((0x00000009) << 16) | ((0) << 14) | ((179) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_WRITE_USN_REASON CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 180, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_WRITE_USN_REASON = (
        ((0x00000009) << 16) | ((0) << 14) | ((180) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_CONTROL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 181, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_CONTROL = (((0x00000009) << 16) | ((0) << 14) | ((181) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_GET_REFS_VOLUME_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 182, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_REFS_VOLUME_DATA = (
        ((0x00000009) << 16) | ((0) << 14) | ((182) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CSV_H_BREAKING_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 185, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CSV_H_BREAKING_SYNC_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((185) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_STORAGE_CLASSES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 187, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_STORAGE_CLASSES = (
        ((0x00000009) << 16) | ((0) << 14) | ((187) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_REGION_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 188, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_REGION_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((188) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_USN_TRACK_MODIFIED_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 189, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    [SupportedOSPlatform("windows6.3")]
    public const int FSCTL_USN_TRACK_MODIFIED_RANGES = (
        ((0x00000009) << 16) | ((0) << 14) | ((189) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_SHARED_VIRTUAL_DISK_SUPPORT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 192, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_SHARED_VIRTUAL_DISK_SUPPORT = (
        ((0x00000009) << 16) | ((0) << 14) | ((192) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SVHDX_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 193, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SVHDX_SYNC_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((193) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SVHDX_SET_INITIATOR_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 194, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SVHDX_SET_INITIATOR_INFORMATION = (
        ((0x00000009) << 16) | ((0) << 14) | ((194) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 195, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_EXTERNAL_BACKING = (
        ((0x00000009) << 16) | (((0)) << 14) | ((195) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 196, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_EXTERNAL_BACKING = (
        ((0x00000009) << 16) | ((0) << 14) | ((196) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DELETE_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 197, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_DELETE_EXTERNAL_BACKING = (
        ((0x00000009) << 16) | (((0)) << 14) | ((197) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_ENUM_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 198, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_ENUM_EXTERNAL_BACKING = (
        ((0x00000009) << 16) | ((0) << 14) | ((198) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_ENUM_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 199, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_ENUM_OVERLAY = (((0x00000009) << 16) | ((0) << 14) | ((199) << 2) | (3));

    [NativeTypeName(
        "#define FSCTL_ADD_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 204, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_ADD_OVERLAY = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((204) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REMOVE_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 205, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_REMOVE_OVERLAY = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((205) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_UPDATE_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 206, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_UPDATE_OVERLAY = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((206) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SHUFFLE_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 208, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int FSCTL_SHUFFLE_FILE = (
        ((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((208) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DUPLICATE_EXTENTS_TO_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 209, METHOD_BUFFERED, FILE_WRITE_DATA )"
    )]
    public const int FSCTL_DUPLICATE_EXTENTS_TO_FILE = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((209) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SPARSE_OVERALLOCATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 211, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SPARSE_OVERALLOCATE = (
        ((0x00000009) << 16) | (((0)) << 14) | ((211) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_STORAGE_QOS_CONTROL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 212, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_STORAGE_QOS_CONTROL = (
        ((0x00000009) << 16) | ((0) << 14) | ((212) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_INITIATE_FILE_METADATA_OPTIMIZATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 215, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_INITIATE_FILE_METADATA_OPTIMIZATION = (
        ((0x00000009) << 16) | (((0)) << 14) | ((215) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_FILE_METADATA_OPTIMIZATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 216, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_QUERY_FILE_METADATA_OPTIMIZATION = (
        ((0x00000009) << 16) | (((0)) << 14) | ((216) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SVHDX_ASYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 217, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SVHDX_ASYNC_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((217) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_WOF_VERSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 218, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_WOF_VERSION = (
        ((0x00000009) << 16) | ((0) << 14) | ((218) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_HCS_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 219, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_HCS_SYNC_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((219) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_HCS_ASYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 220, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_HCS_ASYNC_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((220) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_EXTENT_READ_CACHE_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 221, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_EXTENT_READ_CACHE_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((221) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_REFS_VOLUME_COUNTER_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 222, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_REFS_VOLUME_COUNTER_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((222) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_CLEAN_VOLUME_METADATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 223, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CLEAN_VOLUME_METADATA = (
        ((0x00000009) << 16) | ((0) << 14) | ((223) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_INTEGRITY_INFORMATION_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 224, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_INTEGRITY_INFORMATION_EX = (
        ((0x00000009) << 16) | ((0) << 14) | ((224) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SUSPEND_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 225, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SUSPEND_OVERLAY = (
        ((0x00000009) << 16) | ((0) << 14) | ((225) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_VIRTUAL_STORAGE_QUERY_PROPERTY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 226, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_VIRTUAL_STORAGE_QUERY_PROPERTY = (
        ((0x00000009) << 16) | ((0) << 14) | ((226) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_FILESYSTEM_GET_STATISTICS_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 227, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    [SupportedOSPlatform("windows10.0")]
    public const int FSCTL_FILESYSTEM_GET_STATISTICS_EX = (
        ((0x00000009) << 16) | ((0) << 14) | ((227) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_VOLUME_CONTAINER_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 228, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_VOLUME_CONTAINER_STATE = (
        ((0x00000009) << 16) | ((0) << 14) | ((228) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_LAYER_ROOT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 229, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_LAYER_ROOT = (
        ((0x00000009) << 16) | ((0) << 14) | ((229) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_DIRECT_ACCESS_EXTENTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 230, METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_DIRECT_ACCESS_EXTENTS = (
        ((0x00000009) << 16) | ((0) << 14) | ((230) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_NOTIFY_STORAGE_SPACE_ALLOCATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 231, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_NOTIFY_STORAGE_SPACE_ALLOCATION = (
        ((0x00000009) << 16) | ((0) << 14) | ((231) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SSDI_STORAGE_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 232, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SSDI_STORAGE_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((232) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_DIRECT_IMAGE_ORIGINAL_BASE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 233, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_DIRECT_IMAGE_ORIGINAL_BASE = (
        ((0x00000009) << 16) | ((0) << 14) | ((233) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_READ_UNPRIVILEGED_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 234,  METHOD_NEITHER, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_READ_UNPRIVILEGED_USN_JOURNAL = (
        ((0x00000009) << 16) | ((0) << 14) | ((234) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_GHOST_FILE_EXTENTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 235, METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int FSCTL_GHOST_FILE_EXTENTS = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((235) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_GHOSTED_FILE_EXTENTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 236, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_GHOSTED_FILE_EXTENTS = (
        ((0x00000009) << 16) | ((0) << 14) | ((236) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_UNMAP_SPACE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 237, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_UNMAP_SPACE = (((0x00000009) << 16) | ((0) << 14) | ((237) << 2) | (0));

    [NativeTypeName(
        "#define FSCTL_HCS_SYNC_NO_WRITE_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 238, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_HCS_SYNC_NO_WRITE_TUNNEL_REQUEST = (
        ((0x00000009) << 16) | ((0) << 14) | ((238) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_START_VIRTUALIZATION_INSTANCE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 240, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_START_VIRTUALIZATION_INSTANCE = (
        ((0x00000009) << 16) | ((0) << 14) | ((240) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_FILTER_FILE_IDENTIFIER CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 241, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_FILTER_FILE_IDENTIFIER = (
        ((0x00000009) << 16) | ((0) << 14) | ((241) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_STREAMS_QUERY_PARAMETERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 241, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_STREAMS_QUERY_PARAMETERS = (
        ((0x00000009) << 16) | ((0) << 14) | ((241) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_STREAMS_ASSOCIATE_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 242, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_STREAMS_ASSOCIATE_ID = (
        ((0x00000009) << 16) | ((0) << 14) | ((242) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_STREAMS_QUERY_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 243, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_STREAMS_QUERY_ID = (
        ((0x00000009) << 16) | ((0) << 14) | ((243) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_RETRIEVAL_POINTERS_AND_REFCOUNT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 244, METHOD_NEITHER,  FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_RETRIEVAL_POINTERS_AND_REFCOUNT = (
        ((0x00000009) << 16) | ((0) << 14) | ((244) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_VOLUME_NUMA_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 245, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_VOLUME_NUMA_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((245) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_DEALLOCATE_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 246, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_DEALLOCATE_RANGES = (
        ((0x00000009) << 16) | ((0) << 14) | ((246) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_REFS_SMR_VOLUME_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 247, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_REFS_SMR_VOLUME_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((247) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_REFS_SMR_VOLUME_GC_PARAMETERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 248, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_REFS_SMR_VOLUME_GC_PARAMETERS = (
        ((0x00000009) << 16) | ((0) << 14) | ((248) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_REFS_FILE_STRICTLY_SEQUENTIAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 249, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_REFS_FILE_STRICTLY_SEQUENTIAL = (
        ((0x00000009) << 16) | ((0) << 14) | ((249) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DUPLICATE_EXTENTS_TO_FILE_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 250, METHOD_BUFFERED, FILE_WRITE_DATA)"
    )]
    public const int FSCTL_DUPLICATE_EXTENTS_TO_FILE_EX = (
        ((0x00000009) << 16) | (((0x0002)) << 14) | ((250) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_BAD_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 251, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_BAD_RANGES = (
        ((0x00000009) << 16) | ((0) << 14) | ((251) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_DAX_ALLOC_ALIGNMENT_HINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 252, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_DAX_ALLOC_ALIGNMENT_HINT = (
        ((0x00000009) << 16) | ((0) << 14) | ((252) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DELETE_CORRUPTED_REFS_CONTAINER CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 253, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_DELETE_CORRUPTED_REFS_CONTAINER = (
        ((0x00000009) << 16) | ((0) << 14) | ((253) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SCRUB_UNDISCOVERABLE_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 254, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SCRUB_UNDISCOVERABLE_ID = (
        ((0x00000009) << 16) | ((0) << 14) | ((254) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_NOTIFY_DATA_CHANGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 255, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_NOTIFY_DATA_CHANGE = (
        ((0x00000009) << 16) | ((0) << 14) | ((255) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_START_VIRTUALIZATION_INSTANCE_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 256, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_START_VIRTUALIZATION_INSTANCE_EX = (
        ((0x00000009) << 16) | ((0) << 14) | ((256) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_ENCRYPTION_KEY_CONTROL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 257, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_ENCRYPTION_KEY_CONTROL = (
        ((0x00000009) << 16) | ((0) << 14) | ((257) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_VIRTUAL_STORAGE_SET_BEHAVIOR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 258, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_VIRTUAL_STORAGE_SET_BEHAVIOR = (
        ((0x00000009) << 16) | ((0) << 14) | ((258) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_REPARSE_POINT_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 259, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)"
    )]
    public const int FSCTL_SET_REPARSE_POINT_EX = (
        ((0x00000009) << 16) | (((0)) << 14) | ((259) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REARRANGE_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 264, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int FSCTL_REARRANGE_FILE = (
        ((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((264) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_VIRTUAL_STORAGE_PASSTHROUGH CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 265, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_VIRTUAL_STORAGE_PASSTHROUGH = (
        ((0x00000009) << 16) | ((0) << 14) | ((265) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_GET_RETRIEVAL_POINTER_COUNT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 266, METHOD_NEITHER,  FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_GET_RETRIEVAL_POINTER_COUNT = (
        ((0x00000009) << 16) | ((0) << 14) | ((266) << 2) | (3)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_ASYNC_DUPLICATE_EXTENTS_STATUS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 268, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_ASYNC_DUPLICATE_EXTENTS_STATUS = (
        ((0x00000009) << 16) | ((0) << 14) | ((268) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SMB_SHARE_FLUSH_AND_PURGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 271, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SMB_SHARE_FLUSH_AND_PURGE = (
        ((0x00000009) << 16) | ((0) << 14) | ((271) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_STREAM_SNAPSHOT_MANAGEMENT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 272, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_STREAM_SNAPSHOT_MANAGEMENT = (
        ((0x00000009) << 16) | ((0) << 14) | ((272) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_MANAGE_BYPASS_IO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 274, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_MANAGE_BYPASS_IO = (
        ((0x00000009) << 16) | ((0) << 14) | ((274) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_DEALLOCATE_RANGES_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 275, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_DEALLOCATE_RANGES_EX = (
        ((0x00000009) << 16) | ((0) << 14) | ((275) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_SET_CACHED_RUNS_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 276, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_SET_CACHED_RUNS_STATE = (
        ((0x00000009) << 16) | ((0) << 14) | ((276) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_SET_VOLUME_COMPRESSION_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 277, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_SET_VOLUME_COMPRESSION_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((277) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_QUERY_VOLUME_COMPRESSION_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 278, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_QUERY_VOLUME_COMPRESSION_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((278) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_DUPLICATE_CLUSTER CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 279, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_DUPLICATE_CLUSTER = (
        ((0x00000009) << 16) | ((0) << 14) | ((279) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CREATE_LCN_WEAK_REFERENCE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 280, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CREATE_LCN_WEAK_REFERENCE = (
        ((0x00000009) << 16) | ((0) << 14) | ((280) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CLEAR_LCN_WEAK_REFERENCE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 281, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CLEAR_LCN_WEAK_REFERENCE = (
        ((0x00000009) << 16) | ((0) << 14) | ((281) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_QUERY_LCN_WEAK_REFERENCE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 282, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_QUERY_LCN_WEAK_REFERENCE = (
        ((0x00000009) << 16) | ((0) << 14) | ((282) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CLEAR_ALL_LCN_WEAK_REFERENCES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 283, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CLEAR_ALL_LCN_WEAK_REFERENCES = (
        ((0x00000009) << 16) | ((0) << 14) | ((283) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_SET_VOLUME_DEDUP_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 284, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_SET_VOLUME_DEDUP_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((284) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_QUERY_VOLUME_DEDUP_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 285, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_QUERY_VOLUME_DEDUP_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((285) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_LMR_QUERY_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 286, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_LMR_QUERY_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((286) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_CHECKPOINT_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 287, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_CHECKPOINT_VOLUME = (
        ((0x00000009) << 16) | ((0) << 14) | ((287) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_QUERY_VOLUME_TOTAL_SHARED_LCNS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 288, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_QUERY_VOLUME_TOTAL_SHARED_LCNS = (
        ((0x00000009) << 16) | ((0) << 14) | ((288) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_UPGRADE_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 289, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_UPGRADE_VOLUME = (
        ((0x00000009) << 16) | ((0) << 14) | ((289) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_SET_VOLUME_IO_METRICS_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 290, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_SET_VOLUME_IO_METRICS_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((290) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_QUERY_VOLUME_IO_METRICS_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 291, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_QUERY_VOLUME_IO_METRICS_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((291) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_SET_ROLLBACK_PROTECTION_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 292, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_SET_ROLLBACK_PROTECTION_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((292) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_REFS_QUERY_ROLLBACK_PROTECTION_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 293, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_REFS_QUERY_ROLLBACK_PROTECTION_INFO = (
        ((0x00000009) << 16) | ((0) << 14) | ((293) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_FILE_SOV_CHECK_RANGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 294, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_FILE_SOV_CHECK_RANGE = (
        ((0x00000009) << 16) | ((0) << 14) | ((294) << 2) | (0)
    );

    [NativeTypeName(
        "#define FSCTL_CASCADES_REFS_SET_FILE_REMOTE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 295, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int FSCTL_CASCADES_REFS_SET_FILE_REMOTE = (
        ((0x00000009) << 16) | ((0) << 14) | ((295) << 2) | (0)
    );

    [NativeTypeName("#define FSCTL_INTEGRITY_FLAG_CHECKSUM_ENFORCEMENT_OFF (1)")]
    public const int FSCTL_INTEGRITY_FLAG_CHECKSUM_ENFORCEMENT_OFF = (1);

    [NativeTypeName(
        "#define FSCTL_QUERY_STORAGE_CLASSES_OUTPUT_VERSION sizeof(FSCTL_QUERY_STORAGE_CLASSES_OUTPUT)"
    )]
    public const uint FSCTL_QUERY_STORAGE_CLASSES_OUTPUT_VERSION = 1088;

    [NativeTypeName(
        "#define FSCTL_QUERY_REGION_INFO_INPUT_VERSION sizeof(FSCTL_QUERY_REGION_INFO_INPUT)"
    )]
    public const uint FSCTL_QUERY_REGION_INFO_INPUT_VERSION = 32;

    [NativeTypeName(
        "#define FSCTL_QUERY_REGION_INFO_OUTPUT_VERSION sizeof(FSCTL_QUERY_REGION_INFO_OUTPUT)"
    )]
    public const uint FSCTL_QUERY_REGION_INFO_OUTPUT_VERSION = 64;
}

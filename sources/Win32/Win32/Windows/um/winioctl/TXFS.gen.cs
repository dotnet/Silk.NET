// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TXFS
{
    [NativeTypeName("#define TXFS_RM_FLAG_LOGGING_MODE 0x00000001")]
    public const int TXFS_RM_FLAG_LOGGING_MODE = 0x00000001;

    [NativeTypeName("#define TXFS_RM_FLAG_RENAME_RM 0x00000002")]
    public const int TXFS_RM_FLAG_RENAME_RM = 0x00000002;

    [NativeTypeName("#define TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MAX 0x00000004")]
    public const int TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MAX = 0x00000004;

    [NativeTypeName("#define TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MIN 0x00000008")]
    public const int TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MIN = 0x00000008;

    [NativeTypeName("#define TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS 0x00000010")]
    public const int TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS = 0x00000010;

    [NativeTypeName("#define TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT 0x00000020")]
    public const int TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT = 0x00000020;

    [NativeTypeName("#define TXFS_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE 0x00000040")]
    public const int TXFS_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE = 0x00000040;

    [NativeTypeName("#define TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX 0x00000080")]
    public const int TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX = 0x00000080;

    [NativeTypeName("#define TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN 0x00000100")]
    public const int TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN = 0x00000100;

    [NativeTypeName("#define TXFS_RM_FLAG_GROW_LOG 0x00000400")]
    public const int TXFS_RM_FLAG_GROW_LOG = 0x00000400;

    [NativeTypeName("#define TXFS_RM_FLAG_SHRINK_LOG 0x00000800")]
    public const int TXFS_RM_FLAG_SHRINK_LOG = 0x00000800;

    [NativeTypeName("#define TXFS_RM_FLAG_ENFORCE_MINIMUM_SIZE 0x00001000")]
    public const int TXFS_RM_FLAG_ENFORCE_MINIMUM_SIZE = 0x00001000;

    [NativeTypeName("#define TXFS_RM_FLAG_PRESERVE_CHANGES 0x00002000")]
    public const int TXFS_RM_FLAG_PRESERVE_CHANGES = 0x00002000;

    [NativeTypeName("#define TXFS_RM_FLAG_RESET_RM_AT_NEXT_START 0x00004000")]
    public const int TXFS_RM_FLAG_RESET_RM_AT_NEXT_START = 0x00004000;

    [NativeTypeName("#define TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START 0x00008000")]
    public const int TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START = 0x00008000;

    [NativeTypeName("#define TXFS_RM_FLAG_PREFER_CONSISTENCY 0x00010000")]
    public const int TXFS_RM_FLAG_PREFER_CONSISTENCY = 0x00010000;

    [NativeTypeName("#define TXFS_RM_FLAG_PREFER_AVAILABILITY 0x00020000")]
    public const int TXFS_RM_FLAG_PREFER_AVAILABILITY = 0x00020000;

    [NativeTypeName("#define TXFS_LOGGING_MODE_SIMPLE (0x0001)")]
    public const int TXFS_LOGGING_MODE_SIMPLE = (0x0001);

    [NativeTypeName("#define TXFS_LOGGING_MODE_FULL (0x0002)")]
    public const int TXFS_LOGGING_MODE_FULL = (0x0002);

    [NativeTypeName("#define TXFS_TRANSACTION_STATE_NONE 0x00")]
    public const int TXFS_TRANSACTION_STATE_NONE = 0x00;

    [NativeTypeName("#define TXFS_TRANSACTION_STATE_ACTIVE 0x01")]
    public const int TXFS_TRANSACTION_STATE_ACTIVE = 0x01;

    [NativeTypeName("#define TXFS_TRANSACTION_STATE_PREPARED 0x02")]
    public const int TXFS_TRANSACTION_STATE_PREPARED = 0x02;

    [NativeTypeName("#define TXFS_TRANSACTION_STATE_NOTACTIVE 0x03")]
    public const int TXFS_TRANSACTION_STATE_NOTACTIVE = 0x03;

    [NativeTypeName(
        "#define TXFS_MODIFY_RM_VALID_FLAGS (TXFS_RM_FLAG_LOGGING_MODE                          |   \\\r\n                 TXFS_RM_FLAG_RENAME_RM                             |   \\\r\n                 TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MAX               |   \\\r\n                 TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MIN               |   \\\r\n                 TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS   |   \\\r\n                 TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT          |   \\\r\n                 TXFS_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE            |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX            |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN            |   \\\r\n                 TXFS_RM_FLAG_SHRINK_LOG                            |   \\\r\n                 TXFS_RM_FLAG_GROW_LOG                              |   \\\r\n                 TXFS_RM_FLAG_ENFORCE_MINIMUM_SIZE                  |   \\\r\n                 TXFS_RM_FLAG_PRESERVE_CHANGES                      |   \\\r\n                 TXFS_RM_FLAG_RESET_RM_AT_NEXT_START                |   \\\r\n                 TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START         |   \\\r\n                 TXFS_RM_FLAG_PREFER_CONSISTENCY                    |   \\\r\n                 TXFS_RM_FLAG_PREFER_AVAILABILITY)"
    )]
    public const int TXFS_MODIFY_RM_VALID_FLAGS = (
        0x00000001
        | 0x00000002
        | 0x00000004
        | 0x00000008
        | 0x00000010
        | 0x00000020
        | 0x00000040
        | 0x00000080
        | 0x00000100
        | 0x00000800
        | 0x00000400
        | 0x00001000
        | 0x00002000
        | 0x00004000
        | 0x00008000
        | 0x00010000
        | 0x00020000
    );

    [NativeTypeName("#define TXFS_RM_STATE_NOT_STARTED 0")]
    public const int TXFS_RM_STATE_NOT_STARTED = 0;

    [NativeTypeName("#define TXFS_RM_STATE_STARTING 1")]
    public const int TXFS_RM_STATE_STARTING = 1;

    [NativeTypeName("#define TXFS_RM_STATE_ACTIVE 2")]
    public const int TXFS_RM_STATE_ACTIVE = 2;

    [NativeTypeName("#define TXFS_RM_STATE_SHUTTING_DOWN 3")]
    public const int TXFS_RM_STATE_SHUTTING_DOWN = 3;

    [NativeTypeName(
        "#define TXFS_QUERY_RM_INFORMATION_VALID_FLAGS (TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS   |   \\\r\n                 TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT          |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX            |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN            |   \\\r\n                 TXFS_RM_FLAG_RESET_RM_AT_NEXT_START                |   \\\r\n                 TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START         |   \\\r\n                 TXFS_RM_FLAG_PREFER_CONSISTENCY                    |   \\\r\n                 TXFS_RM_FLAG_PREFER_AVAILABILITY)"
    )]
    public const int TXFS_QUERY_RM_INFORMATION_VALID_FLAGS = (
        0x00000010
        | 0x00000020
        | 0x00000080
        | 0x00000100
        | 0x00004000
        | 0x00008000
        | 0x00010000
        | 0x00020000
    );

    [NativeTypeName("#define TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_REDO_LSN 0x01")]
    public const int TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_REDO_LSN = 0x01;

    [NativeTypeName("#define TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_VIRTUAL_CLOCK 0x02")]
    public const int TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_VIRTUAL_CLOCK = 0x02;

    [NativeTypeName(
        "#define TXFS_ROLLFORWARD_REDO_VALID_FLAGS (TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_REDO_LSN |         \\\r\n                 TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_VIRTUAL_CLOCK)"
    )]
    public const int TXFS_ROLLFORWARD_REDO_VALID_FLAGS = (0x01 | 0x02);

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MAX 0x00000001")]
    public const int TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MAX = 0x00000001;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MIN 0x00000002")]
    public const int TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MIN = 0x00000002;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_CONTAINER_SIZE 0x00000004")]
    public const int TXFS_START_RM_FLAG_LOG_CONTAINER_SIZE = 0x00000004;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS 0x00000008")]
    public const int TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS = 0x00000008;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT 0x00000010")]
    public const int TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT = 0x00000010;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE 0x00000020")]
    public const int TXFS_START_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE = 0x00000020;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX 0x00000040")]
    public const int TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX = 0x00000040;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN 0x00000080")]
    public const int TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN = 0x00000080;

    [NativeTypeName("#define TXFS_START_RM_FLAG_RECOVER_BEST_EFFORT 0x00000200")]
    public const int TXFS_START_RM_FLAG_RECOVER_BEST_EFFORT = 0x00000200;

    [NativeTypeName("#define TXFS_START_RM_FLAG_LOGGING_MODE 0x00000400")]
    public const int TXFS_START_RM_FLAG_LOGGING_MODE = 0x00000400;

    [NativeTypeName("#define TXFS_START_RM_FLAG_PRESERVE_CHANGES 0x00000800")]
    public const int TXFS_START_RM_FLAG_PRESERVE_CHANGES = 0x00000800;

    [NativeTypeName("#define TXFS_START_RM_FLAG_PREFER_CONSISTENCY 0x00001000")]
    public const int TXFS_START_RM_FLAG_PREFER_CONSISTENCY = 0x00001000;

    [NativeTypeName("#define TXFS_START_RM_FLAG_PREFER_AVAILABILITY 0x00002000")]
    public const int TXFS_START_RM_FLAG_PREFER_AVAILABILITY = 0x00002000;

    [NativeTypeName(
        "#define TXFS_START_RM_VALID_FLAGS (TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MAX             |   \\\r\n                 TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MIN             |   \\\r\n                 TXFS_START_RM_FLAG_LOG_CONTAINER_SIZE                  |   \\\r\n                 TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS |   \\\r\n                 TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT        |   \\\r\n                 TXFS_START_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE          |   \\\r\n                 TXFS_START_RM_FLAG_RECOVER_BEST_EFFORT                 |   \\\r\n                 TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX          |   \\\r\n                 TXFS_START_RM_FLAG_LOGGING_MODE                        |   \\\r\n                 TXFS_START_RM_FLAG_PRESERVE_CHANGES                    |   \\\r\n                 TXFS_START_RM_FLAG_PREFER_CONSISTENCY                  |   \\\r\n                 TXFS_START_RM_FLAG_PREFER_AVAILABILITY)"
    )]
    public const int TXFS_START_RM_VALID_FLAGS = (
        0x00000001
        | 0x00000002
        | 0x00000004
        | 0x00000008
        | 0x00000010
        | 0x00000020
        | 0x00000200
        | 0x00000040
        | 0x00000400
        | 0x00000800
        | 0x00001000
        | 0x00002000
    );

    [NativeTypeName("#define TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_CREATED 0x00000001")]
    public const int TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_CREATED = 0x00000001;

    [NativeTypeName("#define TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_DELETED 0x00000002")]
    public const int TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_DELETED = 0x00000002;

    [NativeTypeName("#define TXFS_TRANSACTED_VERSION_NONTRANSACTED 0xFFFFFFFE")]
    public const uint TXFS_TRANSACTED_VERSION_NONTRANSACTED = 0xFFFFFFFE;

    [NativeTypeName("#define TXFS_TRANSACTED_VERSION_UNCOMMITTED 0xFFFFFFFF")]
    public const uint TXFS_TRANSACTED_VERSION_UNCOMMITTED = 0xFFFFFFFF;

    [NativeTypeName("#define TXFS_SAVEPOINT_SET 0x00000001")]
    public const int TXFS_SAVEPOINT_SET = 0x00000001;

    [NativeTypeName("#define TXFS_SAVEPOINT_ROLLBACK 0x00000002")]
    public const int TXFS_SAVEPOINT_ROLLBACK = 0x00000002;

    [NativeTypeName("#define TXFS_SAVEPOINT_CLEAR 0x00000004")]
    public const int TXFS_SAVEPOINT_CLEAR = 0x00000004;

    [NativeTypeName("#define TXFS_SAVEPOINT_CLEAR_ALL 0x00000010")]
    public const int TXFS_SAVEPOINT_CLEAR_ALL = 0x00000010;
}

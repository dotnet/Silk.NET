// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FILE
{
    [NativeTypeName("#define FILE_BEGIN 0")]
    public const int FILE_BEGIN = 0;

    [NativeTypeName("#define FILE_CURRENT 1")]
    public const int FILE_CURRENT = 1;

    [NativeTypeName("#define FILE_END 2")]
    public const int FILE_END = 2;

    [NativeTypeName("#define FILE_FLAG_WRITE_THROUGH 0x80000000")]
    public const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;

    [NativeTypeName("#define FILE_FLAG_OVERLAPPED 0x40000000")]
    public const int FILE_FLAG_OVERLAPPED = 0x40000000;

    [NativeTypeName("#define FILE_FLAG_NO_BUFFERING 0x20000000")]
    public const int FILE_FLAG_NO_BUFFERING = 0x20000000;

    [NativeTypeName("#define FILE_FLAG_RANDOM_ACCESS 0x10000000")]
    public const int FILE_FLAG_RANDOM_ACCESS = 0x10000000;

    [NativeTypeName("#define FILE_FLAG_SEQUENTIAL_SCAN 0x08000000")]
    public const int FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000;

    [NativeTypeName("#define FILE_FLAG_DELETE_ON_CLOSE 0x04000000")]
    public const int FILE_FLAG_DELETE_ON_CLOSE = 0x04000000;

    [NativeTypeName("#define FILE_FLAG_BACKUP_SEMANTICS 0x02000000")]
    public const int FILE_FLAG_BACKUP_SEMANTICS = 0x02000000;

    [NativeTypeName("#define FILE_FLAG_POSIX_SEMANTICS 0x01000000")]
    public const int FILE_FLAG_POSIX_SEMANTICS = 0x01000000;

    [NativeTypeName("#define FILE_FLAG_SESSION_AWARE 0x00800000")]
    public const int FILE_FLAG_SESSION_AWARE = 0x00800000;

    [NativeTypeName("#define FILE_FLAG_OPEN_REPARSE_POINT 0x00200000")]
    public const int FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000;

    [NativeTypeName("#define FILE_FLAG_OPEN_NO_RECALL 0x00100000")]
    public const int FILE_FLAG_OPEN_NO_RECALL = 0x00100000;

    [NativeTypeName("#define FILE_FLAG_FIRST_PIPE_INSTANCE 0x00080000")]
    public const int FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000;

    [NativeTypeName("#define FILE_FLAG_OPEN_REQUIRING_OPLOCK 0x00040000")]
    public const int FILE_FLAG_OPEN_REQUIRING_OPLOCK = 0x00040000;

    [NativeTypeName("#define FILE_FLAG_IGNORE_IMPERSONATED_DEVICEMAP 0x00020000")]
    public const int FILE_FLAG_IGNORE_IMPERSONATED_DEVICEMAP = 0x00020000;

    [NativeTypeName("#define FILE_NAME_NORMALIZED 0x0")]
    public const int FILE_NAME_NORMALIZED = 0x0;

    [NativeTypeName("#define FILE_NAME_OPENED 0x8")]
    public const int FILE_NAME_OPENED = 0x8;

    [NativeTypeName("#define FILE_TYPE_UNKNOWN 0x0000")]
    public const int FILE_TYPE_UNKNOWN = 0x0000;

    [NativeTypeName("#define FILE_TYPE_DISK 0x0001")]
    public const int FILE_TYPE_DISK = 0x0001;

    [NativeTypeName("#define FILE_TYPE_CHAR 0x0002")]
    public const int FILE_TYPE_CHAR = 0x0002;

    [NativeTypeName("#define FILE_TYPE_PIPE 0x0003")]
    public const int FILE_TYPE_PIPE = 0x0003;

    [NativeTypeName("#define FILE_TYPE_REMOTE 0x8000")]
    public const int FILE_TYPE_REMOTE = 0x8000;

    [NativeTypeName("#define FILE_SKIP_COMPLETION_PORT_ON_SUCCESS 0x1")]
    public const int FILE_SKIP_COMPLETION_PORT_ON_SUCCESS = 0x1;

    [NativeTypeName("#define FILE_SKIP_SET_EVENT_ON_HANDLE 0x2")]
    public const int FILE_SKIP_SET_EVENT_ON_HANDLE = 0x2;

    [NativeTypeName("#define FILE_ENCRYPTABLE 0")]
    public const int FILE_ENCRYPTABLE = 0;

    [NativeTypeName("#define FILE_IS_ENCRYPTED 1")]
    public const int FILE_IS_ENCRYPTED = 1;

    [NativeTypeName("#define FILE_SYSTEM_ATTR 2")]
    public const int FILE_SYSTEM_ATTR = 2;

    [NativeTypeName("#define FILE_ROOT_DIR 3")]
    public const int FILE_ROOT_DIR = 3;

    [NativeTypeName("#define FILE_SYSTEM_DIR 4")]
    public const int FILE_SYSTEM_DIR = 4;

    [NativeTypeName("#define FILE_UNKNOWN 5")]
    public const int FILE_UNKNOWN = 5;

    [NativeTypeName("#define FILE_SYSTEM_NOT_SUPPORT 6")]
    public const int FILE_SYSTEM_NOT_SUPPORT = 6;

    [NativeTypeName("#define FILE_USER_DISALLOWED 7")]
    public const int FILE_USER_DISALLOWED = 7;

    [NativeTypeName("#define FILE_READ_ONLY 8")]
    public const int FILE_READ_ONLY = 8;

    [NativeTypeName("#define FILE_DIR_DISALLOWED 9")]
    public const int FILE_DIR_DISALLOWED = 9;

    [NativeTypeName("#define FILE_RENAME_FLAG_REPLACE_IF_EXISTS 0x00000001")]
    public const int FILE_RENAME_FLAG_REPLACE_IF_EXISTS = 0x00000001;

    [NativeTypeName("#define FILE_RENAME_FLAG_POSIX_SEMANTICS 0x00000002")]
    public const int FILE_RENAME_FLAG_POSIX_SEMANTICS = 0x00000002;

    [NativeTypeName("#define FILE_RENAME_FLAG_SUPPRESS_PIN_STATE_INHERITANCE 0x00000004")]
    public const int FILE_RENAME_FLAG_SUPPRESS_PIN_STATE_INHERITANCE = 0x00000004;

    [NativeTypeName("#define FILE_DISPOSITION_FLAG_DO_NOT_DELETE 0x00000000")]
    public const int FILE_DISPOSITION_FLAG_DO_NOT_DELETE = 0x00000000;

    [NativeTypeName("#define FILE_DISPOSITION_FLAG_DELETE 0x00000001")]
    public const int FILE_DISPOSITION_FLAG_DELETE = 0x00000001;

    [NativeTypeName("#define FILE_DISPOSITION_FLAG_POSIX_SEMANTICS 0x00000002")]
    public const int FILE_DISPOSITION_FLAG_POSIX_SEMANTICS = 0x00000002;

    [NativeTypeName("#define FILE_DISPOSITION_FLAG_FORCE_IMAGE_SECTION_CHECK 0x00000004")]
    public const int FILE_DISPOSITION_FLAG_FORCE_IMAGE_SECTION_CHECK = 0x00000004;

    [NativeTypeName("#define FILE_DISPOSITION_FLAG_ON_CLOSE 0x00000008")]
    public const int FILE_DISPOSITION_FLAG_ON_CLOSE = 0x00000008;

    [NativeTypeName("#define FILE_DISPOSITION_FLAG_IGNORE_READONLY_ATTRIBUTE 0x00000010")]
    public const int FILE_DISPOSITION_FLAG_IGNORE_READONLY_ATTRIBUTE = 0x00000010;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FILE
{
    [NativeTypeName("#define FILE_READ_DATA ( 0x0001 )")]
    public const int FILE_READ_DATA = (0x0001);

    [NativeTypeName("#define FILE_LIST_DIRECTORY ( 0x0001 )")]
    public const int FILE_LIST_DIRECTORY = (0x0001);

    [NativeTypeName("#define FILE_WRITE_DATA ( 0x0002 )")]
    public const int FILE_WRITE_DATA = (0x0002);

    [NativeTypeName("#define FILE_ADD_FILE ( 0x0002 )")]
    public const int FILE_ADD_FILE = (0x0002);

    [NativeTypeName("#define FILE_APPEND_DATA ( 0x0004 )")]
    public const int FILE_APPEND_DATA = (0x0004);

    [NativeTypeName("#define FILE_ADD_SUBDIRECTORY ( 0x0004 )")]
    public const int FILE_ADD_SUBDIRECTORY = (0x0004);

    [NativeTypeName("#define FILE_CREATE_PIPE_INSTANCE ( 0x0004 )")]
    public const int FILE_CREATE_PIPE_INSTANCE = (0x0004);

    [NativeTypeName("#define FILE_READ_EA ( 0x0008 )")]
    public const int FILE_READ_EA = (0x0008);

    [NativeTypeName("#define FILE_WRITE_EA ( 0x0010 )")]
    public const int FILE_WRITE_EA = (0x0010);

    [NativeTypeName("#define FILE_EXECUTE ( 0x0020 )")]
    public const int FILE_EXECUTE = (0x0020);

    [NativeTypeName("#define FILE_TRAVERSE ( 0x0020 )")]
    public const int FILE_TRAVERSE = (0x0020);

    [NativeTypeName("#define FILE_DELETE_CHILD ( 0x0040 )")]
    public const int FILE_DELETE_CHILD = (0x0040);

    [NativeTypeName("#define FILE_READ_ATTRIBUTES ( 0x0080 )")]
    public const int FILE_READ_ATTRIBUTES = (0x0080);

    [NativeTypeName("#define FILE_WRITE_ATTRIBUTES ( 0x0100 )")]
    public const int FILE_WRITE_ATTRIBUTES = (0x0100);

    [NativeTypeName("#define FILE_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF)")]
    public const int FILE_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x1FF);

    [NativeTypeName(
        "#define FILE_GENERIC_READ (STANDARD_RIGHTS_READ     |\\\r\n                                   FILE_READ_DATA           |\\\r\n                                   FILE_READ_ATTRIBUTES     |\\\r\n                                   FILE_READ_EA             |\\\r\n                                   SYNCHRONIZE)"
    )]
    public const int FILE_GENERIC_READ = (
        ((0x00020000)) | (0x0001) | (0x0080) | (0x0008) | (0x00100000)
    );

    [NativeTypeName(
        "#define FILE_GENERIC_WRITE (STANDARD_RIGHTS_WRITE    |\\\r\n                                   FILE_WRITE_DATA          |\\\r\n                                   FILE_WRITE_ATTRIBUTES    |\\\r\n                                   FILE_WRITE_EA            |\\\r\n                                   FILE_APPEND_DATA         |\\\r\n                                   SYNCHRONIZE)"
    )]
    public const int FILE_GENERIC_WRITE = (
        ((0x00020000)) | (0x0002) | (0x0100) | (0x0010) | (0x0004) | (0x00100000)
    );

    [NativeTypeName(
        "#define FILE_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE  |\\\r\n                                   FILE_READ_ATTRIBUTES     |\\\r\n                                   FILE_EXECUTE             |\\\r\n                                   SYNCHRONIZE)"
    )]
    public const int FILE_GENERIC_EXECUTE = (((0x00020000)) | (0x0080) | (0x0020) | (0x00100000));

    [NativeTypeName("#define FILE_SHARE_READ 0x00000001")]
    public const int FILE_SHARE_READ = 0x00000001;

    [NativeTypeName("#define FILE_SHARE_WRITE 0x00000002")]
    public const int FILE_SHARE_WRITE = 0x00000002;

    [NativeTypeName("#define FILE_SHARE_DELETE 0x00000004")]
    public const int FILE_SHARE_DELETE = 0x00000004;

    [NativeTypeName("#define FILE_ATTRIBUTE_READONLY 0x00000001")]
    public const int FILE_ATTRIBUTE_READONLY = 0x00000001;

    [NativeTypeName("#define FILE_ATTRIBUTE_HIDDEN 0x00000002")]
    public const int FILE_ATTRIBUTE_HIDDEN = 0x00000002;

    [NativeTypeName("#define FILE_ATTRIBUTE_SYSTEM 0x00000004")]
    public const int FILE_ATTRIBUTE_SYSTEM = 0x00000004;

    [NativeTypeName("#define FILE_ATTRIBUTE_DIRECTORY 0x00000010")]
    public const int FILE_ATTRIBUTE_DIRECTORY = 0x00000010;

    [NativeTypeName("#define FILE_ATTRIBUTE_ARCHIVE 0x00000020")]
    public const int FILE_ATTRIBUTE_ARCHIVE = 0x00000020;

    [NativeTypeName("#define FILE_ATTRIBUTE_DEVICE 0x00000040")]
    public const int FILE_ATTRIBUTE_DEVICE = 0x00000040;

    [NativeTypeName("#define FILE_ATTRIBUTE_NORMAL 0x00000080")]
    public const int FILE_ATTRIBUTE_NORMAL = 0x00000080;

    [NativeTypeName("#define FILE_ATTRIBUTE_TEMPORARY 0x00000100")]
    public const int FILE_ATTRIBUTE_TEMPORARY = 0x00000100;

    [NativeTypeName("#define FILE_ATTRIBUTE_SPARSE_FILE 0x00000200")]
    public const int FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200;

    [NativeTypeName("#define FILE_ATTRIBUTE_REPARSE_POINT 0x00000400")]
    public const int FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400;

    [NativeTypeName("#define FILE_ATTRIBUTE_COMPRESSED 0x00000800")]
    public const int FILE_ATTRIBUTE_COMPRESSED = 0x00000800;

    [NativeTypeName("#define FILE_ATTRIBUTE_OFFLINE 0x00001000")]
    public const int FILE_ATTRIBUTE_OFFLINE = 0x00001000;

    [NativeTypeName("#define FILE_ATTRIBUTE_NOT_CONTENT_INDEXED 0x00002000")]
    public const int FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000;

    [NativeTypeName("#define FILE_ATTRIBUTE_ENCRYPTED 0x00004000")]
    public const int FILE_ATTRIBUTE_ENCRYPTED = 0x00004000;

    [NativeTypeName("#define FILE_ATTRIBUTE_INTEGRITY_STREAM 0x00008000")]
    public const int FILE_ATTRIBUTE_INTEGRITY_STREAM = 0x00008000;

    [NativeTypeName("#define FILE_ATTRIBUTE_VIRTUAL 0x00010000")]
    public const int FILE_ATTRIBUTE_VIRTUAL = 0x00010000;

    [NativeTypeName("#define FILE_ATTRIBUTE_NO_SCRUB_DATA 0x00020000")]
    public const int FILE_ATTRIBUTE_NO_SCRUB_DATA = 0x00020000;

    [NativeTypeName("#define FILE_ATTRIBUTE_EA 0x00040000")]
    public const int FILE_ATTRIBUTE_EA = 0x00040000;

    [NativeTypeName("#define FILE_ATTRIBUTE_PINNED 0x00080000")]
    public const int FILE_ATTRIBUTE_PINNED = 0x00080000;

    [NativeTypeName("#define FILE_ATTRIBUTE_UNPINNED 0x00100000")]
    public const int FILE_ATTRIBUTE_UNPINNED = 0x00100000;

    [NativeTypeName("#define FILE_ATTRIBUTE_RECALL_ON_OPEN 0x00040000")]
    public const int FILE_ATTRIBUTE_RECALL_ON_OPEN = 0x00040000;

    [NativeTypeName("#define FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS 0x00400000")]
    public const int FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = 0x00400000;

    [NativeTypeName("#define FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL 0x20000000")]
    public const int FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL = 0x20000000;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_FILE_NAME 0x00000001")]
    public const int FILE_NOTIFY_CHANGE_FILE_NAME = 0x00000001;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_DIR_NAME 0x00000002")]
    public const int FILE_NOTIFY_CHANGE_DIR_NAME = 0x00000002;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_ATTRIBUTES 0x00000004")]
    public const int FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x00000004;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_SIZE 0x00000008")]
    public const int FILE_NOTIFY_CHANGE_SIZE = 0x00000008;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_LAST_WRITE 0x00000010")]
    public const int FILE_NOTIFY_CHANGE_LAST_WRITE = 0x00000010;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_LAST_ACCESS 0x00000020")]
    public const int FILE_NOTIFY_CHANGE_LAST_ACCESS = 0x00000020;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_CREATION 0x00000040")]
    public const int FILE_NOTIFY_CHANGE_CREATION = 0x00000040;

    [NativeTypeName("#define FILE_NOTIFY_CHANGE_SECURITY 0x00000100")]
    public const int FILE_NOTIFY_CHANGE_SECURITY = 0x00000100;

    [NativeTypeName("#define FILE_ACTION_ADDED 0x00000001")]
    public const int FILE_ACTION_ADDED = 0x00000001;

    [NativeTypeName("#define FILE_ACTION_REMOVED 0x00000002")]
    public const int FILE_ACTION_REMOVED = 0x00000002;

    [NativeTypeName("#define FILE_ACTION_MODIFIED 0x00000003")]
    public const int FILE_ACTION_MODIFIED = 0x00000003;

    [NativeTypeName("#define FILE_ACTION_RENAMED_OLD_NAME 0x00000004")]
    public const int FILE_ACTION_RENAMED_OLD_NAME = 0x00000004;

    [NativeTypeName("#define FILE_ACTION_RENAMED_NEW_NAME 0x00000005")]
    public const int FILE_ACTION_RENAMED_NEW_NAME = 0x00000005;

    [NativeTypeName("#define FILE_CASE_SENSITIVE_SEARCH 0x00000001")]
    public const int FILE_CASE_SENSITIVE_SEARCH = 0x00000001;

    [NativeTypeName("#define FILE_CASE_PRESERVED_NAMES 0x00000002")]
    public const int FILE_CASE_PRESERVED_NAMES = 0x00000002;

    [NativeTypeName("#define FILE_UNICODE_ON_DISK 0x00000004")]
    public const int FILE_UNICODE_ON_DISK = 0x00000004;

    [NativeTypeName("#define FILE_PERSISTENT_ACLS 0x00000008")]
    public const int FILE_PERSISTENT_ACLS = 0x00000008;

    [NativeTypeName("#define FILE_FILE_COMPRESSION 0x00000010")]
    public const int FILE_FILE_COMPRESSION = 0x00000010;

    [NativeTypeName("#define FILE_VOLUME_QUOTAS 0x00000020")]
    public const int FILE_VOLUME_QUOTAS = 0x00000020;

    [NativeTypeName("#define FILE_SUPPORTS_SPARSE_FILES 0x00000040")]
    public const int FILE_SUPPORTS_SPARSE_FILES = 0x00000040;

    [NativeTypeName("#define FILE_SUPPORTS_REPARSE_POINTS 0x00000080")]
    public const int FILE_SUPPORTS_REPARSE_POINTS = 0x00000080;

    [NativeTypeName("#define FILE_SUPPORTS_REMOTE_STORAGE 0x00000100")]
    public const int FILE_SUPPORTS_REMOTE_STORAGE = 0x00000100;

    [NativeTypeName("#define FILE_RETURNS_CLEANUP_RESULT_INFO 0x00000200")]
    public const int FILE_RETURNS_CLEANUP_RESULT_INFO = 0x00000200;

    [NativeTypeName("#define FILE_SUPPORTS_POSIX_UNLINK_RENAME 0x00000400")]
    public const int FILE_SUPPORTS_POSIX_UNLINK_RENAME = 0x00000400;

    [NativeTypeName("#define FILE_SUPPORTS_BYPASS_IO 0x00000800")]
    public const int FILE_SUPPORTS_BYPASS_IO = 0x00000800;

    [NativeTypeName("#define FILE_SUPPORTS_STREAM_SNAPSHOTS 0x00001000")]
    public const int FILE_SUPPORTS_STREAM_SNAPSHOTS = 0x00001000;

    [NativeTypeName("#define FILE_SUPPORTS_CASE_SENSITIVE_DIRS 0x00002000")]
    public const int FILE_SUPPORTS_CASE_SENSITIVE_DIRS = 0x00002000;

    [NativeTypeName("#define FILE_VOLUME_IS_COMPRESSED 0x00008000")]
    public const int FILE_VOLUME_IS_COMPRESSED = 0x00008000;

    [NativeTypeName("#define FILE_SUPPORTS_OBJECT_IDS 0x00010000")]
    public const int FILE_SUPPORTS_OBJECT_IDS = 0x00010000;

    [NativeTypeName("#define FILE_SUPPORTS_ENCRYPTION 0x00020000")]
    public const int FILE_SUPPORTS_ENCRYPTION = 0x00020000;

    [NativeTypeName("#define FILE_NAMED_STREAMS 0x00040000")]
    public const int FILE_NAMED_STREAMS = 0x00040000;

    [NativeTypeName("#define FILE_READ_ONLY_VOLUME 0x00080000")]
    public const int FILE_READ_ONLY_VOLUME = 0x00080000;

    [NativeTypeName("#define FILE_SEQUENTIAL_WRITE_ONCE 0x00100000")]
    public const int FILE_SEQUENTIAL_WRITE_ONCE = 0x00100000;

    [NativeTypeName("#define FILE_SUPPORTS_TRANSACTIONS 0x00200000")]
    public const int FILE_SUPPORTS_TRANSACTIONS = 0x00200000;

    [NativeTypeName("#define FILE_SUPPORTS_HARD_LINKS 0x00400000")]
    public const int FILE_SUPPORTS_HARD_LINKS = 0x00400000;

    [NativeTypeName("#define FILE_SUPPORTS_EXTENDED_ATTRIBUTES 0x00800000")]
    public const int FILE_SUPPORTS_EXTENDED_ATTRIBUTES = 0x00800000;

    [NativeTypeName("#define FILE_SUPPORTS_OPEN_BY_FILE_ID 0x01000000")]
    public const int FILE_SUPPORTS_OPEN_BY_FILE_ID = 0x01000000;

    [NativeTypeName("#define FILE_SUPPORTS_USN_JOURNAL 0x02000000")]
    public const int FILE_SUPPORTS_USN_JOURNAL = 0x02000000;

    [NativeTypeName("#define FILE_SUPPORTS_INTEGRITY_STREAMS 0x04000000")]
    public const int FILE_SUPPORTS_INTEGRITY_STREAMS = 0x04000000;

    [NativeTypeName("#define FILE_SUPPORTS_BLOCK_REFCOUNTING 0x08000000")]
    public const int FILE_SUPPORTS_BLOCK_REFCOUNTING = 0x08000000;

    [NativeTypeName("#define FILE_SUPPORTS_SPARSE_VDL 0x10000000")]
    public const int FILE_SUPPORTS_SPARSE_VDL = 0x10000000;

    [NativeTypeName("#define FILE_DAX_VOLUME 0x20000000")]
    public const int FILE_DAX_VOLUME = 0x20000000;

    [NativeTypeName("#define FILE_SUPPORTS_GHOSTING 0x40000000")]
    public const int FILE_SUPPORTS_GHOSTING = 0x40000000;

    [NativeTypeName("#define FILE_INVALID_FILE_ID ((LONGLONG)-1LL)")]
    public const long FILE_INVALID_FILE_ID = ((long)(-1L));

    [NativeTypeName("#define FILE_NAME_FLAG_HARDLINK 0")]
    public const int FILE_NAME_FLAG_HARDLINK = 0;

    [NativeTypeName("#define FILE_NAME_FLAG_NTFS 0x01")]
    public const int FILE_NAME_FLAG_NTFS = 0x01;

    [NativeTypeName("#define FILE_NAME_FLAG_DOS 0x02")]
    public const int FILE_NAME_FLAG_DOS = 0x02;

    [NativeTypeName("#define FILE_NAME_FLAG_BOTH 0x03")]
    public const int FILE_NAME_FLAG_BOTH = 0x03;

    [NativeTypeName("#define FILE_NAME_FLAGS_UNSPECIFIED 0x80")]
    public const int FILE_NAME_FLAGS_UNSPECIFIED = 0x80;

    [NativeTypeName("#define FILE_CS_FLAG_CASE_SENSITIVE_DIR 0x00000001")]
    public const int FILE_CS_FLAG_CASE_SENSITIVE_DIR = 0x00000001;
}

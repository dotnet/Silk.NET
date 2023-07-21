// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class FILE
{
    [NativeTypeName("#define FILE_SUPERSEDE 0x00000000")]
    public const int FILE_SUPERSEDE = 0x00000000;

    [NativeTypeName("#define FILE_OPEN 0x00000001")]
    public const int FILE_OPEN = 0x00000001;

    [NativeTypeName("#define FILE_CREATE 0x00000002")]
    public const int FILE_CREATE = 0x00000002;

    [NativeTypeName("#define FILE_OPEN_IF 0x00000003")]
    public const int FILE_OPEN_IF = 0x00000003;

    [NativeTypeName("#define FILE_OVERWRITE 0x00000004")]
    public const int FILE_OVERWRITE = 0x00000004;

    [NativeTypeName("#define FILE_OVERWRITE_IF 0x00000005")]
    public const int FILE_OVERWRITE_IF = 0x00000005;

    [NativeTypeName("#define FILE_MAXIMUM_DISPOSITION 0x00000005")]
    public const int FILE_MAXIMUM_DISPOSITION = 0x00000005;

    [NativeTypeName("#define FILE_DIRECTORY_FILE 0x00000001")]
    public const int FILE_DIRECTORY_FILE = 0x00000001;

    [NativeTypeName("#define FILE_WRITE_THROUGH 0x00000002")]
    public const int FILE_WRITE_THROUGH = 0x00000002;

    [NativeTypeName("#define FILE_SEQUENTIAL_ONLY 0x00000004")]
    public const int FILE_SEQUENTIAL_ONLY = 0x00000004;

    [NativeTypeName("#define FILE_NO_INTERMEDIATE_BUFFERING 0x00000008")]
    public const int FILE_NO_INTERMEDIATE_BUFFERING = 0x00000008;

    [NativeTypeName("#define FILE_SYNCHRONOUS_IO_ALERT 0x00000010")]
    public const int FILE_SYNCHRONOUS_IO_ALERT = 0x00000010;

    [NativeTypeName("#define FILE_SYNCHRONOUS_IO_NONALERT 0x00000020")]
    public const int FILE_SYNCHRONOUS_IO_NONALERT = 0x00000020;

    [NativeTypeName("#define FILE_NON_DIRECTORY_FILE 0x00000040")]
    public const int FILE_NON_DIRECTORY_FILE = 0x00000040;

    [NativeTypeName("#define FILE_CREATE_TREE_CONNECTION 0x00000080")]
    public const int FILE_CREATE_TREE_CONNECTION = 0x00000080;

    [NativeTypeName("#define FILE_COMPLETE_IF_OPLOCKED 0x00000100")]
    public const int FILE_COMPLETE_IF_OPLOCKED = 0x00000100;

    [NativeTypeName("#define FILE_NO_EA_KNOWLEDGE 0x00000200")]
    public const int FILE_NO_EA_KNOWLEDGE = 0x00000200;

    [NativeTypeName("#define FILE_OPEN_REMOTE_INSTANCE 0x00000400")]
    public const int FILE_OPEN_REMOTE_INSTANCE = 0x00000400;

    [NativeTypeName("#define FILE_RANDOM_ACCESS 0x00000800")]
    public const int FILE_RANDOM_ACCESS = 0x00000800;

    [NativeTypeName("#define FILE_DELETE_ON_CLOSE 0x00001000")]
    public const int FILE_DELETE_ON_CLOSE = 0x00001000;

    [NativeTypeName("#define FILE_OPEN_BY_FILE_ID 0x00002000")]
    public const int FILE_OPEN_BY_FILE_ID = 0x00002000;

    [NativeTypeName("#define FILE_OPEN_FOR_BACKUP_INTENT 0x00004000")]
    public const int FILE_OPEN_FOR_BACKUP_INTENT = 0x00004000;

    [NativeTypeName("#define FILE_NO_COMPRESSION 0x00008000")]
    public const int FILE_NO_COMPRESSION = 0x00008000;

    [NativeTypeName("#define FILE_OPEN_REQUIRING_OPLOCK 0x00010000")]
    public const int FILE_OPEN_REQUIRING_OPLOCK = 0x00010000;

    [NativeTypeName("#define FILE_RESERVE_OPFILTER 0x00100000")]
    public const int FILE_RESERVE_OPFILTER = 0x00100000;

    [NativeTypeName("#define FILE_OPEN_REPARSE_POINT 0x00200000")]
    public const int FILE_OPEN_REPARSE_POINT = 0x00200000;

    [NativeTypeName("#define FILE_OPEN_NO_RECALL 0x00400000")]
    public const int FILE_OPEN_NO_RECALL = 0x00400000;

    [NativeTypeName("#define FILE_OPEN_FOR_FREE_SPACE_QUERY 0x00800000")]
    public const int FILE_OPEN_FOR_FREE_SPACE_QUERY = 0x00800000;

    [NativeTypeName("#define FILE_VALID_OPTION_FLAGS 0x00ffffff")]
    public const int FILE_VALID_OPTION_FLAGS = 0x00ffffff;

    [NativeTypeName("#define FILE_VALID_PIPE_OPTION_FLAGS 0x00000032")]
    public const int FILE_VALID_PIPE_OPTION_FLAGS = 0x00000032;

    [NativeTypeName("#define FILE_VALID_MAILSLOT_OPTION_FLAGS 0x00000032")]
    public const int FILE_VALID_MAILSLOT_OPTION_FLAGS = 0x00000032;

    [NativeTypeName("#define FILE_VALID_SET_FLAGS 0x00000036")]
    public const int FILE_VALID_SET_FLAGS = 0x00000036;

    [NativeTypeName("#define FILE_SUPERSEDED 0x00000000")]
    public const int FILE_SUPERSEDED = 0x00000000;

    [NativeTypeName("#define FILE_OPENED 0x00000001")]
    public const int FILE_OPENED = 0x00000001;

    [NativeTypeName("#define FILE_CREATED 0x00000002")]
    public const int FILE_CREATED = 0x00000002;

    [NativeTypeName("#define FILE_OVERWRITTEN 0x00000003")]
    public const int FILE_OVERWRITTEN = 0x00000003;

    [NativeTypeName("#define FILE_EXISTS 0x00000004")]
    public const int FILE_EXISTS = 0x00000004;

    [NativeTypeName("#define FILE_DOES_NOT_EXIST 0x00000005")]
    public const int FILE_DOES_NOT_EXIST = 0x00000005;
}

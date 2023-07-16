// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TAPE
{
    [NativeTypeName("#define TAPE_ERASE_SHORT 0L")]
    public const int TAPE_ERASE_SHORT = 0;
    [NativeTypeName("#define TAPE_ERASE_LONG 1L")]
    public const int TAPE_ERASE_LONG = 1;
    [NativeTypeName("#define TAPE_LOAD 0L")]
    public const int TAPE_LOAD = 0;
    [NativeTypeName("#define TAPE_UNLOAD 1L")]
    public const int TAPE_UNLOAD = 1;
    [NativeTypeName("#define TAPE_TENSION 2L")]
    public const int TAPE_TENSION = 2;
    [NativeTypeName("#define TAPE_LOCK 3L")]
    public const int TAPE_LOCK = 3;
    [NativeTypeName("#define TAPE_UNLOCK 4L")]
    public const int TAPE_UNLOCK = 4;
    [NativeTypeName("#define TAPE_FORMAT 5L")]
    public const int TAPE_FORMAT = 5;
    [NativeTypeName("#define TAPE_SETMARKS 0L")]
    public const int TAPE_SETMARKS = 0;
    [NativeTypeName("#define TAPE_FILEMARKS 1L")]
    public const int TAPE_FILEMARKS = 1;
    [NativeTypeName("#define TAPE_SHORT_FILEMARKS 2L")]
    public const int TAPE_SHORT_FILEMARKS = 2;
    [NativeTypeName("#define TAPE_LONG_FILEMARKS 3L")]
    public const int TAPE_LONG_FILEMARKS = 3;
    [NativeTypeName("#define TAPE_ABSOLUTE_POSITION 0L")]
    public const int TAPE_ABSOLUTE_POSITION = 0;
    [NativeTypeName("#define TAPE_LOGICAL_POSITION 1L")]
    public const int TAPE_LOGICAL_POSITION = 1;
    [NativeTypeName("#define TAPE_PSEUDO_LOGICAL_POSITION 2L")]
    public const int TAPE_PSEUDO_LOGICAL_POSITION = 2;
    [NativeTypeName("#define TAPE_REWIND 0L")]
    public const int TAPE_REWIND = 0;
    [NativeTypeName("#define TAPE_ABSOLUTE_BLOCK 1L")]
    public const int TAPE_ABSOLUTE_BLOCK = 1;
    [NativeTypeName("#define TAPE_LOGICAL_BLOCK 2L")]
    public const int TAPE_LOGICAL_BLOCK = 2;
    [NativeTypeName("#define TAPE_PSEUDO_LOGICAL_BLOCK 3L")]
    public const int TAPE_PSEUDO_LOGICAL_BLOCK = 3;
    [NativeTypeName("#define TAPE_SPACE_END_OF_DATA 4L")]
    public const int TAPE_SPACE_END_OF_DATA = 4;
    [NativeTypeName("#define TAPE_SPACE_RELATIVE_BLOCKS 5L")]
    public const int TAPE_SPACE_RELATIVE_BLOCKS = 5;
    [NativeTypeName("#define TAPE_SPACE_FILEMARKS 6L")]
    public const int TAPE_SPACE_FILEMARKS = 6;
    [NativeTypeName("#define TAPE_SPACE_SEQUENTIAL_FMKS 7L")]
    public const int TAPE_SPACE_SEQUENTIAL_FMKS = 7;
    [NativeTypeName("#define TAPE_SPACE_SETMARKS 8L")]
    public const int TAPE_SPACE_SETMARKS = 8;
    [NativeTypeName("#define TAPE_SPACE_SEQUENTIAL_SMKS 9L")]
    public const int TAPE_SPACE_SEQUENTIAL_SMKS = 9;
    [NativeTypeName("#define TAPE_DRIVE_FIXED 0x00000001")]
    public const int TAPE_DRIVE_FIXED = 0x00000001;
    [NativeTypeName("#define TAPE_DRIVE_SELECT 0x00000002")]
    public const int TAPE_DRIVE_SELECT = 0x00000002;
    [NativeTypeName("#define TAPE_DRIVE_INITIATOR 0x00000004")]
    public const int TAPE_DRIVE_INITIATOR = 0x00000004;
    [NativeTypeName("#define TAPE_DRIVE_ERASE_SHORT 0x00000010")]
    public const int TAPE_DRIVE_ERASE_SHORT = 0x00000010;
    [NativeTypeName("#define TAPE_DRIVE_ERASE_LONG 0x00000020")]
    public const int TAPE_DRIVE_ERASE_LONG = 0x00000020;
    [NativeTypeName("#define TAPE_DRIVE_ERASE_BOP_ONLY 0x00000040")]
    public const int TAPE_DRIVE_ERASE_BOP_ONLY = 0x00000040;
    [NativeTypeName("#define TAPE_DRIVE_ERASE_IMMEDIATE 0x00000080")]
    public const int TAPE_DRIVE_ERASE_IMMEDIATE = 0x00000080;
    [NativeTypeName("#define TAPE_DRIVE_TAPE_CAPACITY 0x00000100")]
    public const int TAPE_DRIVE_TAPE_CAPACITY = 0x00000100;
    [NativeTypeName("#define TAPE_DRIVE_TAPE_REMAINING 0x00000200")]
    public const int TAPE_DRIVE_TAPE_REMAINING = 0x00000200;
    [NativeTypeName("#define TAPE_DRIVE_FIXED_BLOCK 0x00000400")]
    public const int TAPE_DRIVE_FIXED_BLOCK = 0x00000400;
    [NativeTypeName("#define TAPE_DRIVE_VARIABLE_BLOCK 0x00000800")]
    public const int TAPE_DRIVE_VARIABLE_BLOCK = 0x00000800;
    [NativeTypeName("#define TAPE_DRIVE_WRITE_PROTECT 0x00001000")]
    public const int TAPE_DRIVE_WRITE_PROTECT = 0x00001000;
    [NativeTypeName("#define TAPE_DRIVE_EOT_WZ_SIZE 0x00002000")]
    public const int TAPE_DRIVE_EOT_WZ_SIZE = 0x00002000;
    [NativeTypeName("#define TAPE_DRIVE_ECC 0x00010000")]
    public const int TAPE_DRIVE_ECC = 0x00010000;
    [NativeTypeName("#define TAPE_DRIVE_COMPRESSION 0x00020000")]
    public const int TAPE_DRIVE_COMPRESSION = 0x00020000;
    [NativeTypeName("#define TAPE_DRIVE_PADDING 0x00040000")]
    public const int TAPE_DRIVE_PADDING = 0x00040000;
    [NativeTypeName("#define TAPE_DRIVE_REPORT_SMKS 0x00080000")]
    public const int TAPE_DRIVE_REPORT_SMKS = 0x00080000;
    [NativeTypeName("#define TAPE_DRIVE_GET_ABSOLUTE_BLK 0x00100000")]
    public const int TAPE_DRIVE_GET_ABSOLUTE_BLK = 0x00100000;
    [NativeTypeName("#define TAPE_DRIVE_GET_LOGICAL_BLK 0x00200000")]
    public const int TAPE_DRIVE_GET_LOGICAL_BLK = 0x00200000;
    [NativeTypeName("#define TAPE_DRIVE_SET_EOT_WZ_SIZE 0x00400000")]
    public const int TAPE_DRIVE_SET_EOT_WZ_SIZE = 0x00400000;
    [NativeTypeName("#define TAPE_DRIVE_EJECT_MEDIA 0x01000000")]
    public const int TAPE_DRIVE_EJECT_MEDIA = 0x01000000;
    [NativeTypeName("#define TAPE_DRIVE_CLEAN_REQUESTS 0x02000000")]
    public const int TAPE_DRIVE_CLEAN_REQUESTS = 0x02000000;
    [NativeTypeName("#define TAPE_DRIVE_SET_CMP_BOP_ONLY 0x04000000")]
    public const int TAPE_DRIVE_SET_CMP_BOP_ONLY = 0x04000000;
    [NativeTypeName("#define TAPE_DRIVE_RESERVED_BIT 0x80000000")]
    public const uint TAPE_DRIVE_RESERVED_BIT = 0x80000000;
    [NativeTypeName("#define TAPE_DRIVE_LOAD_UNLOAD 0x80000001")]
    public const uint TAPE_DRIVE_LOAD_UNLOAD = 0x80000001;
    [NativeTypeName("#define TAPE_DRIVE_TENSION 0x80000002")]
    public const uint TAPE_DRIVE_TENSION = 0x80000002;
    [NativeTypeName("#define TAPE_DRIVE_LOCK_UNLOCK 0x80000004")]
    public const uint TAPE_DRIVE_LOCK_UNLOCK = 0x80000004;
    [NativeTypeName("#define TAPE_DRIVE_REWIND_IMMEDIATE 0x80000008")]
    public const uint TAPE_DRIVE_REWIND_IMMEDIATE = 0x80000008;
    [NativeTypeName("#define TAPE_DRIVE_SET_BLOCK_SIZE 0x80000010")]
    public const uint TAPE_DRIVE_SET_BLOCK_SIZE = 0x80000010;
    [NativeTypeName("#define TAPE_DRIVE_LOAD_UNLD_IMMED 0x80000020")]
    public const uint TAPE_DRIVE_LOAD_UNLD_IMMED = 0x80000020;
    [NativeTypeName("#define TAPE_DRIVE_TENSION_IMMED 0x80000040")]
    public const uint TAPE_DRIVE_TENSION_IMMED = 0x80000040;
    [NativeTypeName("#define TAPE_DRIVE_LOCK_UNLK_IMMED 0x80000080")]
    public const uint TAPE_DRIVE_LOCK_UNLK_IMMED = 0x80000080;
    [NativeTypeName("#define TAPE_DRIVE_SET_ECC 0x80000100")]
    public const uint TAPE_DRIVE_SET_ECC = 0x80000100;
    [NativeTypeName("#define TAPE_DRIVE_SET_COMPRESSION 0x80000200")]
    public const uint TAPE_DRIVE_SET_COMPRESSION = 0x80000200;
    [NativeTypeName("#define TAPE_DRIVE_SET_PADDING 0x80000400")]
    public const uint TAPE_DRIVE_SET_PADDING = 0x80000400;
    [NativeTypeName("#define TAPE_DRIVE_SET_REPORT_SMKS 0x80000800")]
    public const uint TAPE_DRIVE_SET_REPORT_SMKS = 0x80000800;
    [NativeTypeName("#define TAPE_DRIVE_ABSOLUTE_BLK 0x80001000")]
    public const uint TAPE_DRIVE_ABSOLUTE_BLK = 0x80001000;
    [NativeTypeName("#define TAPE_DRIVE_ABS_BLK_IMMED 0x80002000")]
    public const uint TAPE_DRIVE_ABS_BLK_IMMED = 0x80002000;
    [NativeTypeName("#define TAPE_DRIVE_LOGICAL_BLK 0x80004000")]
    public const uint TAPE_DRIVE_LOGICAL_BLK = 0x80004000;
    [NativeTypeName("#define TAPE_DRIVE_LOG_BLK_IMMED 0x80008000")]
    public const uint TAPE_DRIVE_LOG_BLK_IMMED = 0x80008000;
    [NativeTypeName("#define TAPE_DRIVE_END_OF_DATA 0x80010000")]
    public const uint TAPE_DRIVE_END_OF_DATA = 0x80010000;
    [NativeTypeName("#define TAPE_DRIVE_RELATIVE_BLKS 0x80020000")]
    public const uint TAPE_DRIVE_RELATIVE_BLKS = 0x80020000;
    [NativeTypeName("#define TAPE_DRIVE_FILEMARKS 0x80040000")]
    public const uint TAPE_DRIVE_FILEMARKS = 0x80040000;
    [NativeTypeName("#define TAPE_DRIVE_SEQUENTIAL_FMKS 0x80080000")]
    public const uint TAPE_DRIVE_SEQUENTIAL_FMKS = 0x80080000;
    [NativeTypeName("#define TAPE_DRIVE_SETMARKS 0x80100000")]
    public const uint TAPE_DRIVE_SETMARKS = 0x80100000;
    [NativeTypeName("#define TAPE_DRIVE_SEQUENTIAL_SMKS 0x80200000")]
    public const uint TAPE_DRIVE_SEQUENTIAL_SMKS = 0x80200000;
    [NativeTypeName("#define TAPE_DRIVE_REVERSE_POSITION 0x80400000")]
    public const uint TAPE_DRIVE_REVERSE_POSITION = 0x80400000;
    [NativeTypeName("#define TAPE_DRIVE_SPACE_IMMEDIATE 0x80800000")]
    public const uint TAPE_DRIVE_SPACE_IMMEDIATE = 0x80800000;
    [NativeTypeName("#define TAPE_DRIVE_WRITE_SETMARKS 0x81000000")]
    public const uint TAPE_DRIVE_WRITE_SETMARKS = 0x81000000;
    [NativeTypeName("#define TAPE_DRIVE_WRITE_FILEMARKS 0x82000000")]
    public const uint TAPE_DRIVE_WRITE_FILEMARKS = 0x82000000;
    [NativeTypeName("#define TAPE_DRIVE_WRITE_SHORT_FMKS 0x84000000")]
    public const uint TAPE_DRIVE_WRITE_SHORT_FMKS = 0x84000000;
    [NativeTypeName("#define TAPE_DRIVE_WRITE_LONG_FMKS 0x88000000")]
    public const uint TAPE_DRIVE_WRITE_LONG_FMKS = 0x88000000;
    [NativeTypeName("#define TAPE_DRIVE_WRITE_MARK_IMMED 0x90000000")]
    public const uint TAPE_DRIVE_WRITE_MARK_IMMED = 0x90000000;
    [NativeTypeName("#define TAPE_DRIVE_FORMAT 0xA0000000")]
    public const uint TAPE_DRIVE_FORMAT = 0xA0000000;
    [NativeTypeName("#define TAPE_DRIVE_FORMAT_IMMEDIATE 0xC0000000")]
    public const uint TAPE_DRIVE_FORMAT_IMMEDIATE = 0xC0000000;
    [NativeTypeName("#define TAPE_DRIVE_HIGH_FEATURES 0x80000000")]
    public const uint TAPE_DRIVE_HIGH_FEATURES = 0x80000000;
    [NativeTypeName("#define TAPE_FIXED_PARTITIONS 0L")]
    public const int TAPE_FIXED_PARTITIONS = 0;
    [NativeTypeName("#define TAPE_SELECT_PARTITIONS 1L")]
    public const int TAPE_SELECT_PARTITIONS = 1;
    [NativeTypeName("#define TAPE_INITIATOR_PARTITIONS 2L")]
    public const int TAPE_INITIATOR_PARTITIONS = 2;
    [NativeTypeName("#define TAPE_QUERY_DRIVE_PARAMETERS 0L")]
    public const int TAPE_QUERY_DRIVE_PARAMETERS = 0;
    [NativeTypeName("#define TAPE_QUERY_MEDIA_CAPACITY 1L")]
    public const int TAPE_QUERY_MEDIA_CAPACITY = 1;
    [NativeTypeName("#define TAPE_CHECK_FOR_DRIVE_PROBLEM 2L")]
    public const int TAPE_CHECK_FOR_DRIVE_PROBLEM = 2;
    [NativeTypeName("#define TAPE_QUERY_IO_ERROR_DATA 3L")]
    public const int TAPE_QUERY_IO_ERROR_DATA = 3;
    [NativeTypeName("#define TAPE_QUERY_DEVICE_ERROR_DATA 4L")]
    public const int TAPE_QUERY_DEVICE_ERROR_DATA = 4;
}
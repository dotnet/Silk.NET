// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IO
{
    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_ZERO (0)")]
    public const int IO_REPARSE_TAG_RESERVED_ZERO = (0);

    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_ONE (1)")]
    public const int IO_REPARSE_TAG_RESERVED_ONE = (1);

    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_TWO (2)")]
    public const int IO_REPARSE_TAG_RESERVED_TWO = (2);

    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_RANGE IO_REPARSE_TAG_RESERVED_TWO")]
    public const int IO_REPARSE_TAG_RESERVED_RANGE = (2);

    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_INVALID (0xC0008000L)")]
    public const uint IO_REPARSE_TAG_RESERVED_INVALID = (0xC0008000);

    [NativeTypeName("#define IO_REPARSE_TAG_MOUNT_POINT (0xA0000003L)")]
    public const uint IO_REPARSE_TAG_MOUNT_POINT = (0xA0000003);

    [NativeTypeName("#define IO_REPARSE_TAG_HSM (0xC0000004L)")]
    public const uint IO_REPARSE_TAG_HSM = (0xC0000004);

    [NativeTypeName("#define IO_REPARSE_TAG_HSM2 (0x80000006L)")]
    public const uint IO_REPARSE_TAG_HSM2 = (0x80000006);

    [NativeTypeName("#define IO_REPARSE_TAG_SIS (0x80000007L)")]
    public const uint IO_REPARSE_TAG_SIS = (0x80000007);

    [NativeTypeName("#define IO_REPARSE_TAG_WIM (0x80000008L)")]
    public const uint IO_REPARSE_TAG_WIM = (0x80000008);

    [NativeTypeName("#define IO_REPARSE_TAG_CSV (0x80000009L)")]
    public const uint IO_REPARSE_TAG_CSV = (0x80000009);

    [NativeTypeName("#define IO_REPARSE_TAG_DFS (0x8000000AL)")]
    public const uint IO_REPARSE_TAG_DFS = (0x8000000A);

    [NativeTypeName("#define IO_REPARSE_TAG_SYMLINK (0xA000000CL)")]
    public const uint IO_REPARSE_TAG_SYMLINK = (0xA000000C);

    [NativeTypeName("#define IO_REPARSE_TAG_DFSR (0x80000012L)")]
    public const uint IO_REPARSE_TAG_DFSR = (0x80000012);

    [NativeTypeName("#define IO_REPARSE_TAG_DEDUP (0x80000013L)")]
    public const uint IO_REPARSE_TAG_DEDUP = (0x80000013);

    [NativeTypeName("#define IO_REPARSE_TAG_NFS (0x80000014L)")]
    public const uint IO_REPARSE_TAG_NFS = (0x80000014);

    [NativeTypeName("#define IO_REPARSE_TAG_FILE_PLACEHOLDER (0x80000015L)")]
    public const uint IO_REPARSE_TAG_FILE_PLACEHOLDER = (0x80000015);

    [NativeTypeName("#define IO_REPARSE_TAG_WOF (0x80000017L)")]
    public const uint IO_REPARSE_TAG_WOF = (0x80000017);

    [NativeTypeName("#define IO_REPARSE_TAG_WCI (0x80000018L)")]
    public const uint IO_REPARSE_TAG_WCI = (0x80000018);

    [NativeTypeName("#define IO_REPARSE_TAG_WCI_1 (0x90001018L)")]
    public const uint IO_REPARSE_TAG_WCI_1 = (0x90001018);

    [NativeTypeName("#define IO_REPARSE_TAG_GLOBAL_REPARSE (0xA0000019L)")]
    public const uint IO_REPARSE_TAG_GLOBAL_REPARSE = (0xA0000019);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD (0x9000001AL)")]
    public const uint IO_REPARSE_TAG_CLOUD = (0x9000001A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_1 (0x9000101AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_1 = (0x9000101A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_2 (0x9000201AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_2 = (0x9000201A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_3 (0x9000301AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_3 = (0x9000301A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_4 (0x9000401AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_4 = (0x9000401A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_5 (0x9000501AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_5 = (0x9000501A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_6 (0x9000601AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_6 = (0x9000601A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_7 (0x9000701AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_7 = (0x9000701A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_8 (0x9000801AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_8 = (0x9000801A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_9 (0x9000901AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_9 = (0x9000901A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_A (0x9000A01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_A = (0x9000A01A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_B (0x9000B01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_B = (0x9000B01A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_C (0x9000C01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_C = (0x9000C01A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_D (0x9000D01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_D = (0x9000D01A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_E (0x9000E01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_E = (0x9000E01A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_F (0x9000F01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_F = (0x9000F01A);

    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_MASK (0x0000F000L)")]
    public const int IO_REPARSE_TAG_CLOUD_MASK = (0x0000F000);

    [NativeTypeName("#define IO_REPARSE_TAG_APPEXECLINK (0x8000001BL)")]
    public const uint IO_REPARSE_TAG_APPEXECLINK = (0x8000001B);

    [NativeTypeName("#define IO_REPARSE_TAG_PROJFS (0x9000001CL)")]
    public const uint IO_REPARSE_TAG_PROJFS = (0x9000001C);

    [NativeTypeName("#define IO_REPARSE_TAG_STORAGE_SYNC (0x8000001EL)")]
    public const uint IO_REPARSE_TAG_STORAGE_SYNC = (0x8000001E);

    [NativeTypeName("#define IO_REPARSE_TAG_WCI_TOMBSTONE (0xA000001FL)")]
    public const uint IO_REPARSE_TAG_WCI_TOMBSTONE = (0xA000001F);

    [NativeTypeName("#define IO_REPARSE_TAG_UNHANDLED (0x80000020L)")]
    public const uint IO_REPARSE_TAG_UNHANDLED = (0x80000020);

    [NativeTypeName("#define IO_REPARSE_TAG_ONEDRIVE (0x80000021L)")]
    public const uint IO_REPARSE_TAG_ONEDRIVE = (0x80000021);

    [NativeTypeName("#define IO_REPARSE_TAG_PROJFS_TOMBSTONE (0xA0000022L)")]
    public const uint IO_REPARSE_TAG_PROJFS_TOMBSTONE = (0xA0000022);

    [NativeTypeName("#define IO_REPARSE_TAG_AF_UNIX (0x80000023L)")]
    public const uint IO_REPARSE_TAG_AF_UNIX = (0x80000023);

    [NativeTypeName("#define IO_REPARSE_TAG_WCI_LINK (0xA0000027L)")]
    public const uint IO_REPARSE_TAG_WCI_LINK = (0xA0000027);

    [NativeTypeName("#define IO_REPARSE_TAG_WCI_LINK_1 (0xA0001027L)")]
    public const uint IO_REPARSE_TAG_WCI_LINK_1 = (0xA0001027);

    [NativeTypeName("#define IO_REPARSE_TAG_DATALESS_CIM (0xA0000028L)")]
    public const uint IO_REPARSE_TAG_DATALESS_CIM = (0xA0000028);

    [NativeTypeName("#define IO_COMPLETION_MODIFY_STATE 0x0002")]
    public const int IO_COMPLETION_MODIFY_STATE = 0x0002;

    [NativeTypeName("#define IO_COMPLETION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
    public const int IO_COMPLETION_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

    [NativeTypeName("#define IO_QOS_MAX_RESERVATION 1000000000ULL")]
    public const ulong IO_QOS_MAX_RESERVATION = 1000000000UL;
}

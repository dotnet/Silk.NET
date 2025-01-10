// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BACKUP
{
    [NativeTypeName("#define BACKUP_INVALID 0x00000000")]
    public const int BACKUP_INVALID = 0x00000000;

    [NativeTypeName("#define BACKUP_DATA 0x00000001")]
    public const int BACKUP_DATA = 0x00000001;

    [NativeTypeName("#define BACKUP_EA_DATA 0x00000002")]
    public const int BACKUP_EA_DATA = 0x00000002;

    [NativeTypeName("#define BACKUP_SECURITY_DATA 0x00000003")]
    public const int BACKUP_SECURITY_DATA = 0x00000003;

    [NativeTypeName("#define BACKUP_ALTERNATE_DATA 0x00000004")]
    public const int BACKUP_ALTERNATE_DATA = 0x00000004;

    [NativeTypeName("#define BACKUP_LINK 0x00000005")]
    public const int BACKUP_LINK = 0x00000005;

    [NativeTypeName("#define BACKUP_PROPERTY_DATA 0x00000006")]
    public const int BACKUP_PROPERTY_DATA = 0x00000006;

    [NativeTypeName("#define BACKUP_OBJECT_ID 0x00000007")]
    public const int BACKUP_OBJECT_ID = 0x00000007;

    [NativeTypeName("#define BACKUP_REPARSE_DATA 0x00000008")]
    public const int BACKUP_REPARSE_DATA = 0x00000008;

    [NativeTypeName("#define BACKUP_SPARSE_BLOCK 0x00000009")]
    public const int BACKUP_SPARSE_BLOCK = 0x00000009;

    [NativeTypeName("#define BACKUP_TXFS_DATA 0x0000000a")]
    public const int BACKUP_TXFS_DATA = 0x0000000a;

    [NativeTypeName("#define BACKUP_GHOSTED_FILE_EXTENTS 0x0000000b")]
    public const int BACKUP_GHOSTED_FILE_EXTENTS = 0x0000000b;
}

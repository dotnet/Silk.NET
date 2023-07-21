// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class FS
{
    [NativeTypeName("#define FS_CASE_IS_PRESERVED FILE_CASE_PRESERVED_NAMES")]
    public const int FS_CASE_IS_PRESERVED = 0x00000002;

    [NativeTypeName("#define FS_CASE_SENSITIVE FILE_CASE_SENSITIVE_SEARCH")]
    public const int FS_CASE_SENSITIVE = 0x00000001;

    [NativeTypeName("#define FS_UNICODE_STORED_ON_DISK FILE_UNICODE_ON_DISK")]
    public const int FS_UNICODE_STORED_ON_DISK = 0x00000004;

    [NativeTypeName("#define FS_PERSISTENT_ACLS FILE_PERSISTENT_ACLS")]
    public const int FS_PERSISTENT_ACLS = 0x00000008;

    [NativeTypeName("#define FS_VOL_IS_COMPRESSED FILE_VOLUME_IS_COMPRESSED")]
    public const int FS_VOL_IS_COMPRESSED = 0x00008000;

    [NativeTypeName("#define FS_FILE_COMPRESSION FILE_FILE_COMPRESSION")]
    public const int FS_FILE_COMPRESSION = 0x00000010;

    [NativeTypeName("#define FS_FILE_ENCRYPTION FILE_SUPPORTS_ENCRYPTION")]
    public const int FS_FILE_ENCRYPTION = 0x00020000;
}

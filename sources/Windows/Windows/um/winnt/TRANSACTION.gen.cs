// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TRANSACTION
{
    [NativeTypeName("#define TRANSACTION_QUERY_INFORMATION ( 0x0001 )")]
    public const int TRANSACTION_QUERY_INFORMATION = (0x0001);
    [NativeTypeName("#define TRANSACTION_SET_INFORMATION ( 0x0002 )")]
    public const int TRANSACTION_SET_INFORMATION = (0x0002);
    [NativeTypeName("#define TRANSACTION_ENLIST ( 0x0004 )")]
    public const int TRANSACTION_ENLIST = (0x0004);
    [NativeTypeName("#define TRANSACTION_COMMIT ( 0x0008 )")]
    public const int TRANSACTION_COMMIT = (0x0008);
    [NativeTypeName("#define TRANSACTION_ROLLBACK ( 0x0010 )")]
    public const int TRANSACTION_ROLLBACK = (0x0010);
    [NativeTypeName("#define TRANSACTION_PROPAGATE ( 0x0020 )")]
    public const int TRANSACTION_PROPAGATE = (0x0020);
    [NativeTypeName("#define TRANSACTION_RIGHT_RESERVED1 ( 0x0040 )")]
    public const int TRANSACTION_RIGHT_RESERVED1 = (0x0040);
    [NativeTypeName("#define TRANSACTION_GENERIC_READ (STANDARD_RIGHTS_READ            |\\\r\n                                             TRANSACTION_QUERY_INFORMATION   |\\\r\n                                             SYNCHRONIZE)")]
    public const int TRANSACTION_GENERIC_READ = (((0x00020000)) | (0x0001) | (0x00100000));
    [NativeTypeName("#define TRANSACTION_GENERIC_WRITE (STANDARD_RIGHTS_WRITE           |\\\r\n                                             TRANSACTION_SET_INFORMATION     |\\\r\n                                             TRANSACTION_COMMIT              |\\\r\n                                             TRANSACTION_ENLIST              |\\\r\n                                             TRANSACTION_ROLLBACK            |\\\r\n                                             TRANSACTION_PROPAGATE           |\\\r\n                                             SYNCHRONIZE)")]
    public const int TRANSACTION_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0008) | (0x0004) | (0x0010) | (0x0020) | (0x00100000));
    [NativeTypeName("#define TRANSACTION_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE         |\\\r\n                                             TRANSACTION_COMMIT              |\\\r\n                                             TRANSACTION_ROLLBACK            |\\\r\n                                             SYNCHRONIZE)")]
    public const int TRANSACTION_GENERIC_EXECUTE = (((0x00020000)) | (0x0008) | (0x0010) | (0x00100000));
    [NativeTypeName("#define TRANSACTION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED        |\\\r\n                                             TRANSACTION_GENERIC_READ        |\\\r\n                                             TRANSACTION_GENERIC_WRITE       |\\\r\n                                             TRANSACTION_GENERIC_EXECUTE)")]
    public const int TRANSACTION_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001) | (0x00100000)) | (((0x00020000)) | (0x0002) | (0x0008) | (0x0004) | (0x0010) | (0x0020) | (0x00100000)) | (((0x00020000)) | (0x0008) | (0x0010) | (0x00100000)));
    [NativeTypeName("#define TRANSACTION_RESOURCE_MANAGER_RIGHTS (TRANSACTION_GENERIC_READ        |\\\r\n                                             STANDARD_RIGHTS_WRITE           |\\\r\n                                             TRANSACTION_SET_INFORMATION     |\\\r\n                                             TRANSACTION_ENLIST              |\\\r\n                                             TRANSACTION_ROLLBACK            |\\\r\n                                             TRANSACTION_PROPAGATE           |\\\r\n                                             SYNCHRONIZE)")]
    public const int TRANSACTION_RESOURCE_MANAGER_RIGHTS = ((((0x00020000)) | (0x0001) | (0x00100000)) | ((0x00020000)) | (0x0002) | (0x0004) | (0x0010) | (0x0020) | (0x00100000));
}
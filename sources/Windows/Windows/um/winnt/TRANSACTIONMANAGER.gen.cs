// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TRANSACTIONMANAGER
{
    [NativeTypeName("#define TRANSACTIONMANAGER_QUERY_INFORMATION ( 0x0001 )")]
    public const int TRANSACTIONMANAGER_QUERY_INFORMATION = (0x0001);
    [NativeTypeName("#define TRANSACTIONMANAGER_SET_INFORMATION ( 0x0002 )")]
    public const int TRANSACTIONMANAGER_SET_INFORMATION = (0x0002);
    [NativeTypeName("#define TRANSACTIONMANAGER_RECOVER ( 0x0004 )")]
    public const int TRANSACTIONMANAGER_RECOVER = (0x0004);
    [NativeTypeName("#define TRANSACTIONMANAGER_RENAME ( 0x0008 )")]
    public const int TRANSACTIONMANAGER_RENAME = (0x0008);
    [NativeTypeName("#define TRANSACTIONMANAGER_CREATE_RM ( 0x0010 )")]
    public const int TRANSACTIONMANAGER_CREATE_RM = (0x0010);
    [NativeTypeName("#define TRANSACTIONMANAGER_BIND_TRANSACTION ( 0x0020 )")]
    public const int TRANSACTIONMANAGER_BIND_TRANSACTION = (0x0020);
    [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_READ (STANDARD_RIGHTS_READ            |\\\r\n                                                    TRANSACTIONMANAGER_QUERY_INFORMATION)")]
    public const int TRANSACTIONMANAGER_GENERIC_READ = (((0x00020000)) | (0x0001));
    [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_WRITE (STANDARD_RIGHTS_WRITE           |\\\r\n                                                    TRANSACTIONMANAGER_SET_INFORMATION     |\\\r\n                                                    TRANSACTIONMANAGER_RECOVER             |\\\r\n                                                    TRANSACTIONMANAGER_RENAME              |\\\r\n                                                    TRANSACTIONMANAGER_CREATE_RM)")]
    public const int TRANSACTIONMANAGER_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010));
    [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE)")]
    public const int TRANSACTIONMANAGER_GENERIC_EXECUTE = (((0x00020000)));
    [NativeTypeName("#define TRANSACTIONMANAGER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED        |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_READ        |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_WRITE       |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_EXECUTE     |\\\r\n                                                    TRANSACTIONMANAGER_BIND_TRANSACTION)")]
    public const int TRANSACTIONMANAGER_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010)) | (((0x00020000))) | (0x0020));
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ENLISTMENT
{
    [NativeTypeName("#define ENLISTMENT_QUERY_INFORMATION ( 0x0001 )")]
    public const int ENLISTMENT_QUERY_INFORMATION = (0x0001);

    [NativeTypeName("#define ENLISTMENT_SET_INFORMATION ( 0x0002 )")]
    public const int ENLISTMENT_SET_INFORMATION = (0x0002);

    [NativeTypeName("#define ENLISTMENT_RECOVER ( 0x0004 )")]
    public const int ENLISTMENT_RECOVER = (0x0004);

    [NativeTypeName("#define ENLISTMENT_SUBORDINATE_RIGHTS ( 0x0008 )")]
    public const int ENLISTMENT_SUBORDINATE_RIGHTS = (0x0008);

    [NativeTypeName("#define ENLISTMENT_SUPERIOR_RIGHTS ( 0x0010 )")]
    public const int ENLISTMENT_SUPERIOR_RIGHTS = (0x0010);

    [NativeTypeName("#define ENLISTMENT_GENERIC_READ (STANDARD_RIGHTS_READ           |\\\r\n                                        ENLISTMENT_QUERY_INFORMATION)")]
    public const int ENLISTMENT_GENERIC_READ = (((0x00020000)) | (0x0001));

    [NativeTypeName("#define ENLISTMENT_GENERIC_WRITE (STANDARD_RIGHTS_WRITE          |\\\r\n                                        ENLISTMENT_SET_INFORMATION     |\\\r\n                                        ENLISTMENT_RECOVER             |\\\r\n                                        ENLISTMENT_SUBORDINATE_RIGHTS  |\\\r\n                                        ENLISTMENT_SUPERIOR_RIGHTS)")]
    public const int ENLISTMENT_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010));

    [NativeTypeName("#define ENLISTMENT_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE        |\\\r\n                                        ENLISTMENT_RECOVER             |\\\r\n                                        ENLISTMENT_SUBORDINATE_RIGHTS  |\\\r\n                                        ENLISTMENT_SUPERIOR_RIGHTS)")]
    public const int ENLISTMENT_GENERIC_EXECUTE = (((0x00020000)) | (0x0004) | (0x0008) | (0x0010));

    [NativeTypeName("#define ENLISTMENT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED       |\\\r\n                                        ENLISTMENT_GENERIC_READ        |\\\r\n                                        ENLISTMENT_GENERIC_WRITE       |\\\r\n                                        ENLISTMENT_GENERIC_EXECUTE)")]
    public const int ENLISTMENT_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010)) | (((0x00020000)) | (0x0004) | (0x0008) | (0x0010)));
}

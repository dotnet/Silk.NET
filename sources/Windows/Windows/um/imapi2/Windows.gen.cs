// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define IMAPI_SECTOR_SIZE ( 2048 )")]
    public const int IMAPI_SECTOR_SIZE = (2048);

    [NativeTypeName("#define IMAPI2_DEFAULT_COMMAND_TIMEOUT 10")]
    public const int IMAPI2_DEFAULT_COMMAND_TIMEOUT = 10;

    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_CD 75")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_CD = 75;

    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_DVD 680")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_DVD = 680;

    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_BD 2195")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_BD = 2195;

    [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD 4568")]
    public const int IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD = 4568;

    [NativeTypeName("#define IMAPILib2_MajorVersion 1")]
    public const int IMAPILib2_MajorVersion = 1;

    [NativeTypeName("#define IMAPILib2_MinorVersion 0")]
    public const int IMAPILib2_MinorVersion = 0;
}

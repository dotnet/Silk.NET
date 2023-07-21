// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SECURITY
{
    [NativeTypeName("#define SECURITY_FLAG_IGNORE_UNKNOWN_CA 0x00000100")]
    public const int SECURITY_FLAG_IGNORE_UNKNOWN_CA = 0x00000100;

    [NativeTypeName("#define SECURITY_FLAG_IGNORE_CERT_WRONG_USAGE 0x00000200")]
    public const int SECURITY_FLAG_IGNORE_CERT_WRONG_USAGE = 0x00000200;

    [NativeTypeName("#define SECURITY_FLAG_IGNORE_CERT_CN_INVALID 0x00001000")]
    public const int SECURITY_FLAG_IGNORE_CERT_CN_INVALID = 0x00001000;

    [NativeTypeName("#define SECURITY_FLAG_IGNORE_CERT_DATE_INVALID 0x00002000")]
    public const int SECURITY_FLAG_IGNORE_CERT_DATE_INVALID = 0x00002000;

    [NativeTypeName("#define SECURITY_FLAG_IGNORE_ALL_CERT_ERRORS (SECURITY_FLAG_IGNORE_UNKNOWN_CA        | \\\r\n                                                 SECURITY_FLAG_IGNORE_CERT_WRONG_USAGE  | \\\r\n                                                 SECURITY_FLAG_IGNORE_CERT_CN_INVALID   | \\\r\n                                                 SECURITY_FLAG_IGNORE_CERT_DATE_INVALID)")]
    public const int SECURITY_FLAG_IGNORE_ALL_CERT_ERRORS = (0x00000100 | 0x00000200 | 0x00001000 | 0x00002000);

    [NativeTypeName("#define SECURITY_FLAG_SECURE 0x00000001")]
    public const int SECURITY_FLAG_SECURE = 0x00000001;

    [NativeTypeName("#define SECURITY_FLAG_STRENGTH_WEAK 0x10000000")]
    public const int SECURITY_FLAG_STRENGTH_WEAK = 0x10000000;

    [NativeTypeName("#define SECURITY_FLAG_STRENGTH_MEDIUM 0x40000000")]
    public const int SECURITY_FLAG_STRENGTH_MEDIUM = 0x40000000;

    [NativeTypeName("#define SECURITY_FLAG_STRENGTH_STRONG 0x20000000")]
    public const int SECURITY_FLAG_STRENGTH_STRONG = 0x20000000;
}

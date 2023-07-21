// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static unsafe partial class TIMESTAMP
{
    [NativeTypeName("#define TIMESTAMP_REQUEST ((LPCSTR) 78)")]
    public static sbyte* TIMESTAMP_REQUEST => ((sbyte*)(78));

    [NativeTypeName("#define TIMESTAMP_RESPONSE ((LPCSTR) 79)")]
    public static sbyte* TIMESTAMP_RESPONSE => ((sbyte*)(79));

    [NativeTypeName("#define TIMESTAMP_INFO ((LPCSTR) 80)")]
    public static sbyte* TIMESTAMP_INFO => ((sbyte*)(80));

    [NativeTypeName("#define TIMESTAMP_VERSION 1")]
    public const int TIMESTAMP_VERSION = 1;

    [NativeTypeName("#define TIMESTAMP_STATUS_GRANTED 0")]
    public const int TIMESTAMP_STATUS_GRANTED = 0;

    [NativeTypeName("#define TIMESTAMP_STATUS_GRANTED_WITH_MODS 1")]
    public const int TIMESTAMP_STATUS_GRANTED_WITH_MODS = 1;

    [NativeTypeName("#define TIMESTAMP_STATUS_REJECTED 2")]
    public const int TIMESTAMP_STATUS_REJECTED = 2;

    [NativeTypeName("#define TIMESTAMP_STATUS_WAITING 3")]
    public const int TIMESTAMP_STATUS_WAITING = 3;

    [NativeTypeName("#define TIMESTAMP_STATUS_REVOCATION_WARNING 4")]
    public const int TIMESTAMP_STATUS_REVOCATION_WARNING = 4;

    [NativeTypeName("#define TIMESTAMP_STATUS_REVOKED 5")]
    public const int TIMESTAMP_STATUS_REVOKED = 5;

    [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_ALG 0")]
    public const int TIMESTAMP_FAILURE_BAD_ALG = 0;

    [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_REQUEST 2")]
    public const int TIMESTAMP_FAILURE_BAD_REQUEST = 2;

    [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_FORMAT 5")]
    public const int TIMESTAMP_FAILURE_BAD_FORMAT = 5;

    [NativeTypeName("#define TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE 14")]
    public const int TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE = 14;

    [NativeTypeName("#define TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED 15")]
    public const int TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED = 15;

    [NativeTypeName("#define TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED 16")]
    public const int TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED = 16;

    [NativeTypeName("#define TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE 17")]
    public const int TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE = 17;

    [NativeTypeName("#define TIMESTAMP_FAILURE_SYSTEM_FAILURE 25")]
    public const int TIMESTAMP_FAILURE_SYSTEM_FAILURE = 25;

    [NativeTypeName("#define TIMESTAMP_DONT_HASH_DATA 0x00000001")]
    public const int TIMESTAMP_DONT_HASH_DATA = 0x00000001;

    [NativeTypeName("#define TIMESTAMP_VERIFY_CONTEXT_SIGNATURE 0x00000020")]
    public const int TIMESTAMP_VERIFY_CONTEXT_SIGNATURE = 0x00000020;

    [NativeTypeName("#define TIMESTAMP_NO_AUTH_RETRIEVAL 0x00020000")]
    public const int TIMESTAMP_NO_AUTH_RETRIEVAL = 0x00020000;
}

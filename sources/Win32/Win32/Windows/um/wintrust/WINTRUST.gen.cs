// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WINTRUST
{
    [NativeTypeName(
        "#define WINTRUST_CONFIG_REGPATH L\"Software\\Microsoft\\Cryptography\\Wintrust\\Config\""
    )]
    public const string WINTRUST_CONFIG_REGPATH =
        "Software\\Microsoft\\Cryptography\\Wintrust\\Config";

    [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME L\"MaxHeaderBytesToMap\"")]
    public const string WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME = "MaxHeaderBytesToMap";

    [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT 0x00A00000")]
    public const int WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT = 0x00A00000;

    [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME L\"MaxHashBytesToMap\"")]
    public const string WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME = "MaxHashBytesToMap";

    [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT 0x00100000")]
    public const int WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT = 0x00100000;

    [NativeTypeName("#define WINTRUST_DETACHED_SIG_CHOICE_HANDLE 1")]
    public const int WINTRUST_DETACHED_SIG_CHOICE_HANDLE = 1;

    [NativeTypeName("#define WINTRUST_DETACHED_SIG_CHOICE_BLOB 2")]
    public const int WINTRUST_DETACHED_SIG_CHOICE_BLOB = 2;
}

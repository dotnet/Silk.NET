// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WINTRUST
{
    [NativeTypeName("#define WINTRUST_CONFIG_REGPATH L\"Software\\\\Microsoft\\\\Cryptography\\\\Wintrust\\\\Config\"")]
    public const string WINTRUST_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\Wintrust\\Config";
    [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME L\"MaxHeaderBytesToMap\"")]
    public const string WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME = "MaxHeaderBytesToMap";
    [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT 0x00A00000")]
    public const int WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT = 0x00A00000;
    [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME L\"MaxHashBytesToMap\"")]
    public const string WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME = "MaxHashBytesToMap";
    [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT 0x00100000")]
    public const int WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT = 0x00100000;
}
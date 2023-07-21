// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class INTERNET
{
    [NativeTypeName("#define INTERNET_MAX_PATH_LENGTH 2048")]
    public const int INTERNET_MAX_PATH_LENGTH = 2048;

    [NativeTypeName("#define INTERNET_MAX_SCHEME_LENGTH 32")]
    public const int INTERNET_MAX_SCHEME_LENGTH = 32;

    [NativeTypeName("#define INTERNET_MAX_URL_LENGTH (INTERNET_MAX_SCHEME_LENGTH \\\r\n                                        + sizeof(\"://\") \\\r\n                                        + INTERNET_MAX_PATH_LENGTH)")]
    public const uint INTERNET_MAX_URL_LENGTH = (32 + 4 + 2048);
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class URL
{
    [NativeTypeName("#define URL_MK_LEGACY 0")]
    public const int URL_MK_LEGACY = 0;

    [NativeTypeName("#define URL_MK_UNIFORM 1")]
    public const int URL_MK_UNIFORM = 1;

    [NativeTypeName("#define URL_MK_NO_CANONICALIZE 2")]
    public const int URL_MK_NO_CANONICALIZE = 2;
}

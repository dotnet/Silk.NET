// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class URL
{
    [NativeTypeName("#define URL_UNESCAPE 0x10000000")]
    public const int URL_UNESCAPE = 0x10000000;

    [NativeTypeName("#define URL_ESCAPE_UNSAFE 0x20000000")]
    public const int URL_ESCAPE_UNSAFE = 0x20000000;

    [NativeTypeName("#define URL_PLUGGABLE_PROTOCOL 0x40000000")]
    public const int URL_PLUGGABLE_PROTOCOL = 0x40000000;

    [NativeTypeName("#define URL_WININET_COMPATIBILITY 0x80000000")]
    public const uint URL_WININET_COMPATIBILITY = 0x80000000;

    [NativeTypeName("#define URL_DONT_ESCAPE_EXTRA_INFO 0x02000000")]
    public const int URL_DONT_ESCAPE_EXTRA_INFO = 0x02000000;

    [NativeTypeName("#define URL_DONT_UNESCAPE_EXTRA_INFO URL_DONT_ESCAPE_EXTRA_INFO")]
    public const int URL_DONT_UNESCAPE_EXTRA_INFO = 0x02000000;

    [NativeTypeName("#define URL_BROWSER_MODE URL_DONT_ESCAPE_EXTRA_INFO")]
    public const int URL_BROWSER_MODE = 0x02000000;

    [NativeTypeName("#define URL_ESCAPE_SPACES_ONLY 0x04000000")]
    public const int URL_ESCAPE_SPACES_ONLY = 0x04000000;

    [NativeTypeName("#define URL_DONT_SIMPLIFY 0x08000000")]
    public const int URL_DONT_SIMPLIFY = 0x08000000;

    [NativeTypeName("#define URL_NO_META URL_DONT_SIMPLIFY")]
    public const int URL_NO_META = 0x08000000;

    [NativeTypeName("#define URL_UNESCAPE_INPLACE 0x00100000")]
    public const int URL_UNESCAPE_INPLACE = 0x00100000;

    [NativeTypeName("#define URL_CONVERT_IF_DOSPATH 0x00200000")]
    public const int URL_CONVERT_IF_DOSPATH = 0x00200000;

    [NativeTypeName("#define URL_UNESCAPE_HIGH_ANSI_ONLY 0x00400000")]
    public const int URL_UNESCAPE_HIGH_ANSI_ONLY = 0x00400000;

    [NativeTypeName("#define URL_INTERNAL_PATH 0x00800000")]
    public const int URL_INTERNAL_PATH = 0x00800000;

    [NativeTypeName("#define URL_FILE_USE_PATHURL 0x00010000")]
    public const int URL_FILE_USE_PATHURL = 0x00010000;

    [NativeTypeName("#define URL_DONT_UNESCAPE 0x00020000")]
    public const int URL_DONT_UNESCAPE = 0x00020000;

    [NativeTypeName("#define URL_ESCAPE_AS_UTF8 0x00040000")]
    public const int URL_ESCAPE_AS_UTF8 = 0x00040000;

    [NativeTypeName("#define URL_UNESCAPE_AS_UTF8 URL_ESCAPE_AS_UTF8")]
    public const int URL_UNESCAPE_AS_UTF8 = 0x00040000;

    [NativeTypeName("#define URL_ESCAPE_ASCII_URI_COMPONENT 0x00080000")]
    public const int URL_ESCAPE_ASCII_URI_COMPONENT = 0x00080000;

    [NativeTypeName(
        "#define URL_ESCAPE_URI_COMPONENT (URL_ESCAPE_ASCII_URI_COMPONENT | URL_ESCAPE_AS_UTF8)"
    )]
    public const int URL_ESCAPE_URI_COMPONENT = (0x00080000 | 0x00040000);

    [NativeTypeName("#define URL_UNESCAPE_URI_COMPONENT URL_UNESCAPE_AS_UTF8")]
    public const int URL_UNESCAPE_URI_COMPONENT = 0x00040000;

    [NativeTypeName("#define URL_ESCAPE_PERCENT 0x00001000")]
    public const int URL_ESCAPE_PERCENT = 0x00001000;

    [NativeTypeName("#define URL_ESCAPE_SEGMENT_ONLY 0x00002000")]
    public const int URL_ESCAPE_SEGMENT_ONLY = 0x00002000;

    [NativeTypeName("#define URL_PARTFLAG_KEEPSCHEME 0x00000001")]
    public const int URL_PARTFLAG_KEEPSCHEME = 0x00000001;

    [NativeTypeName("#define URL_APPLY_DEFAULT 0x00000001")]
    public const int URL_APPLY_DEFAULT = 0x00000001;

    [NativeTypeName("#define URL_APPLY_GUESSSCHEME 0x00000002")]
    public const int URL_APPLY_GUESSSCHEME = 0x00000002;

    [NativeTypeName("#define URL_APPLY_GUESSFILE 0x00000004")]
    public const int URL_APPLY_GUESSFILE = 0x00000004;

    [NativeTypeName("#define URL_APPLY_FORCEAPPLY 0x00000008")]
    public const int URL_APPLY_FORCEAPPLY = 0x00000008;
}

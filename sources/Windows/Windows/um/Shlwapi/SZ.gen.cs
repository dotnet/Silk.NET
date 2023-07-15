// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
public static partial class SZ
{
    [NativeTypeName("#define SZ_CONTENTTYPE_HTMLA \"text/html\"")]
    public static ReadOnlySpan<byte> SZ_CONTENTTYPE_HTMLA => "text/html"u8;

    [NativeTypeName("#define SZ_CONTENTTYPE_HTMLW L\"text/html\"")]
    public const string SZ_CONTENTTYPE_HTMLW = "text/html";
    [NativeTypeName("#define SZ_CONTENTTYPE_CDFA \"application/x-cdf\"")]
    public static ReadOnlySpan<byte> SZ_CONTENTTYPE_CDFA => "application/x-cdf"u8;

    [NativeTypeName("#define SZ_CONTENTTYPE_CDFW L\"application/x-cdf\"")]
    public const string SZ_CONTENTTYPE_CDFW = "application/x-cdf";
    [NativeTypeName("#define SZ_CONTENTTYPE_HTML SZ_CONTENTTYPE_HTMLW")]
    public const string SZ_CONTENTTYPE_HTML = "text/html";
    [NativeTypeName("#define SZ_CONTENTTYPE_CDF SZ_CONTENTTYPE_CDFW")]
    public const string SZ_CONTENTTYPE_CDF = "application/x-cdf";
}
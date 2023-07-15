// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class INTERNET
{
    [NativeTypeName("#define INTERNET_DEFAULT_PORT 0")]
    public const int INTERNET_DEFAULT_PORT = 0;
    [NativeTypeName("#define INTERNET_DEFAULT_HTTP_PORT 80")]
    public const int INTERNET_DEFAULT_HTTP_PORT = 80;
    [NativeTypeName("#define INTERNET_DEFAULT_HTTPS_PORT 443")]
    public const int INTERNET_DEFAULT_HTTPS_PORT = 443;
    [NativeTypeName("#define INTERNET_SCHEME_HTTP (1)")]
    public const int INTERNET_SCHEME_HTTP = (1);
    [NativeTypeName("#define INTERNET_SCHEME_HTTPS (2)")]
    public const int INTERNET_SCHEME_HTTPS = (2);
    [NativeTypeName("#define INTERNET_SCHEME_FTP (3)")]
    public const int INTERNET_SCHEME_FTP = (3);
    [NativeTypeName("#define INTERNET_SCHEME_SOCKS (4)")]
    public const int INTERNET_SCHEME_SOCKS = (4);
}
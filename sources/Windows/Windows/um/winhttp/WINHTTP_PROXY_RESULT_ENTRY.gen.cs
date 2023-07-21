// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WINHTTP_PROXY_RESULT_ENTRY.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_ENTRY"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct WINHTTP_PROXY_RESULT_ENTRY
{
    /// <include file='WINHTTP_PROXY_RESULT_ENTRY.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_ENTRY.fProxy"]/*' />
    public BOOL fProxy;

    /// <include file='WINHTTP_PROXY_RESULT_ENTRY.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_ENTRY.fBypass"]/*' />
    public BOOL fBypass;

    /// <include file='WINHTTP_PROXY_RESULT_ENTRY.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_ENTRY.ProxyScheme"]/*' />
    [NativeTypeName("INTERNET_SCHEME")]
    public int ProxyScheme;

    /// <include file='WINHTTP_PROXY_RESULT_ENTRY.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_ENTRY.pwszProxy"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* pwszProxy;

    /// <include file='WINHTTP_PROXY_RESULT_ENTRY.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_ENTRY.ProxyPort"]/*' />
    [NativeTypeName("INTERNET_PORT")]
    public ushort ProxyPort;
}

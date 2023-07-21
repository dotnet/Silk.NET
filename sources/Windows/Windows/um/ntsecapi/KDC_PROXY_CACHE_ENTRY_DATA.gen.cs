// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA"]/*' />
public partial struct KDC_PROXY_CACHE_ENTRY_DATA
{
    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.SinceLastUsed"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SinceLastUsed;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.DomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.ProxyServerName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ProxyServerName;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.ProxyServerVdir"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ProxyServerVdir;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.ProxyServerPort"]/*' />
    public ushort ProxyServerPort;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.LogonId"]/*' />
    public LUID LogonId;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.CredUserName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING CredUserName;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.CredDomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING CredDomainName;

    /// <include file='KDC_PROXY_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KDC_PROXY_CACHE_ENTRY_DATA.GlobalCache"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte GlobalCache;
}

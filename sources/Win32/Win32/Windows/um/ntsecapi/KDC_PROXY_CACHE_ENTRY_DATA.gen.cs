// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KDC_PROXY_CACHE_ENTRY_DATA
{
    [NativeTypeName("ULONG64")]
    public ulong SinceLastUsed;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ProxyServerName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ProxyServerVdir;
    public ushort ProxyServerPort;
    public LUID LogonId;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING CredUserName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING CredDomainName;

    [NativeTypeName("BOOLEAN")]
    public byte GlobalCache;
}

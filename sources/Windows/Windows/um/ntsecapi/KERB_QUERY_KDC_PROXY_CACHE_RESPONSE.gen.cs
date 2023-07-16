// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_QUERY_KDC_PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_KDC_PROXY_CACHE_RESPONSE"]/*'/>
public unsafe partial struct KERB_QUERY_KDC_PROXY_CACHE_RESPONSE
{
    /// <include file='KERB_QUERY_KDC_PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_KDC_PROXY_CACHE_RESPONSE.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_QUERY_KDC_PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_KDC_PROXY_CACHE_RESPONSE.CountOfEntries"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CountOfEntries;
    /// <include file='KERB_QUERY_KDC_PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_KDC_PROXY_CACHE_RESPONSE.Entries"]/*'/>
    [NativeTypeName("PKDC_PROXY_CACHE_ENTRY_DATA")]
    public KDC_PROXY_CACHE_ENTRY_DATA* Entries;
}
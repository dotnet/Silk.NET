// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_PURGE_KDC_PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_PURGE_KDC_PROXY_CACHE_RESPONSE"]/*'/>
public partial struct KERB_PURGE_KDC_PROXY_CACHE_RESPONSE
{
    /// <include file='KERB_PURGE_KDC_PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_PURGE_KDC_PROXY_CACHE_RESPONSE.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_PURGE_KDC_PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_PURGE_KDC_PROXY_CACHE_RESPONSE.CountOfPurged"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CountOfPurged;
}
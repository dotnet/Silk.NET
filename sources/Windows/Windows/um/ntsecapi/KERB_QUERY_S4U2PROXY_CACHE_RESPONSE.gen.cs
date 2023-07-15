// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_QUERY_S4U2PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE"]/*'/>
public unsafe partial struct KERB_QUERY_S4U2PROXY_CACHE_RESPONSE
{
    /// <include file='KERB_QUERY_S4U2PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_QUERY_S4U2PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE.CountOfCreds"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CountOfCreds;
    /// <include file='KERB_QUERY_S4U2PROXY_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE.Creds"]/*'/>
    [NativeTypeName("PKERB_S4U2PROXY_CRED")]
    public KERB_S4U2PROXY_CRED* Creds;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX"]/*'/>
public partial struct KERB_TICKET_CACHE_INFO_EX
{
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.ClientName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientName;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.ClientRealm"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientRealm;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.ServerName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerName;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.ServerRealm"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerRealm;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.StartTime"]/*'/>
    public LARGE_INTEGER StartTime;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.EndTime"]/*'/>
    public LARGE_INTEGER EndTime;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.RenewTime"]/*'/>
    public LARGE_INTEGER RenewTime;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.EncryptionType"]/*'/>
    [NativeTypeName("LONG")]
    public int EncryptionType;
    /// <include file='KERB_TICKET_CACHE_INFO_EX.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX.TicketFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TicketFlags;
}
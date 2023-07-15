// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3"]/*'/>
public partial struct KERB_TICKET_CACHE_INFO_EX3
{
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.ClientName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientName;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.ClientRealm"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ClientRealm;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.ServerName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerName;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.ServerRealm"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerRealm;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.StartTime"]/*'/>
    public LARGE_INTEGER StartTime;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.EndTime"]/*'/>
    public LARGE_INTEGER EndTime;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.RenewTime"]/*'/>
    public LARGE_INTEGER RenewTime;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.EncryptionType"]/*'/>
    [NativeTypeName("LONG")]
    public int EncryptionType;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.TicketFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TicketFlags;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.SessionKeyType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SessionKeyType;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.BranchId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BranchId;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.CacheFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CacheFlags;
    /// <include file='KERB_TICKET_CACHE_INFO_EX3.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO_EX3.KdcCalled"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING KdcCalled;
}
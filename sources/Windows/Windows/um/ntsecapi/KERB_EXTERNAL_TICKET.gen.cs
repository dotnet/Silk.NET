// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET"]/*'/>
public unsafe partial struct KERB_EXTERNAL_TICKET
{
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.ServiceName"]/*'/>
    [NativeTypeName("PKERB_EXTERNAL_NAME")]
    public KERB_EXTERNAL_NAME* ServiceName;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.TargetName"]/*'/>
    [NativeTypeName("PKERB_EXTERNAL_NAME")]
    public KERB_EXTERNAL_NAME* TargetName;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.ClientName"]/*'/>
    [NativeTypeName("PKERB_EXTERNAL_NAME")]
    public KERB_EXTERNAL_NAME* ClientName;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.DomainName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.TargetDomainName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING TargetDomainName;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.AltTargetDomainName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING AltTargetDomainName;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.SessionKey"]/*'/>
    public KERB_CRYPTO_KEY SessionKey;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.TicketFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TicketFlags;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.KeyExpirationTime"]/*'/>
    public LARGE_INTEGER KeyExpirationTime;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.StartTime"]/*'/>
    public LARGE_INTEGER StartTime;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.EndTime"]/*'/>
    public LARGE_INTEGER EndTime;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.RenewUntil"]/*'/>
    public LARGE_INTEGER RenewUntil;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.TimeSkew"]/*'/>
    public LARGE_INTEGER TimeSkew;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.EncodedTicketSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint EncodedTicketSize;
    /// <include file='KERB_EXTERNAL_TICKET.xml' path='doc/member[@name="KERB_EXTERNAL_TICKET.EncodedTicket"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* EncodedTicket;
}
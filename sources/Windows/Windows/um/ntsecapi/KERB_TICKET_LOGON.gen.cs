// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_TICKET_LOGON.xml' path='doc/member[@name="KERB_TICKET_LOGON"]/*'/>
public unsafe partial struct KERB_TICKET_LOGON
{
    /// <include file='KERB_TICKET_LOGON.xml' path='doc/member[@name="KERB_TICKET_LOGON.MessageType"]/*'/>
    public KERB_LOGON_SUBMIT_TYPE MessageType;
    /// <include file='KERB_TICKET_LOGON.xml' path='doc/member[@name="KERB_TICKET_LOGON.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_TICKET_LOGON.xml' path='doc/member[@name="KERB_TICKET_LOGON.ServiceTicketLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ServiceTicketLength;
    /// <include file='KERB_TICKET_LOGON.xml' path='doc/member[@name="KERB_TICKET_LOGON.TicketGrantingTicketLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TicketGrantingTicketLength;
    /// <include file='KERB_TICKET_LOGON.xml' path='doc/member[@name="KERB_TICKET_LOGON.ServiceTicket"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* ServiceTicket;
    /// <include file='KERB_TICKET_LOGON.xml' path='doc/member[@name="KERB_TICKET_LOGON.TicketGrantingTicket"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* TicketGrantingTicket;
}
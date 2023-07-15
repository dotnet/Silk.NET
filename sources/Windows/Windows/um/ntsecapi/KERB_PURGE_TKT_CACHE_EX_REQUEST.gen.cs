// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_PURGE_TKT_CACHE_EX_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_EX_REQUEST"]/*'/>
public partial struct KERB_PURGE_TKT_CACHE_EX_REQUEST
{
    /// <include file='KERB_PURGE_TKT_CACHE_EX_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_EX_REQUEST.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_PURGE_TKT_CACHE_EX_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_EX_REQUEST.LogonId"]/*'/>
    public LUID LogonId;
    /// <include file='KERB_PURGE_TKT_CACHE_EX_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_EX_REQUEST.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_PURGE_TKT_CACHE_EX_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_EX_REQUEST.TicketTemplate"]/*'/>
    public KERB_TICKET_CACHE_INFO_EX TicketTemplate;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_TRANSFER_CRED_REQUEST.xml' path='doc/member[@name="KERB_TRANSFER_CRED_REQUEST"]/*'/>
public partial struct KERB_TRANSFER_CRED_REQUEST
{
    /// <include file='KERB_TRANSFER_CRED_REQUEST.xml' path='doc/member[@name="KERB_TRANSFER_CRED_REQUEST.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_TRANSFER_CRED_REQUEST.xml' path='doc/member[@name="KERB_TRANSFER_CRED_REQUEST.OriginLogonId"]/*'/>
    public LUID OriginLogonId;
    /// <include file='KERB_TRANSFER_CRED_REQUEST.xml' path='doc/member[@name="KERB_TRANSFER_CRED_REQUEST.DestinationLogonId"]/*'/>
    public LUID DestinationLogonId;
    /// <include file='KERB_TRANSFER_CRED_REQUEST.xml' path='doc/member[@name="KERB_TRANSFER_CRED_REQUEST.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
}